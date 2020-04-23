namespace Server
{
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using Fleck;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json;
    class Program
    {
        private static WebSocketServer server = new WebSocketServer($"ws://127.0.0.1:8181");
        private static MySqlConnection cnn = new MySqlConnection("server=192.168.1.108;database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
        private static List<WebsocketUsers> usersConnected = new List<WebsocketUsers>();
        private static List<Messages> MessagesInAttesa = new List<Messages>();

        static void Main()
        {
            server.RestartAfterListenError = true;

            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    foreach (var i in usersConnected)
                    {
                        if (i.socketId == socket)
                        {
                            i.SocketConnected = true;
                            if (i.user != "none")
                            {
                                Console.WriteLine($"<{DateTime.Now}> Connect: {i.user}");
                            }
                            else
                            {
                                Console.WriteLine($"<{DateTime.Now}> Connect: Client");
                            }
                            return;
                        }
                    }

                    WebsocketUsers user = new WebsocketUsers
                    {
                        socketId = socket,
                        user = "none",
                        SocketConnected = true
                    };
                    usersConnected.Add(user);
                    Console.WriteLine($"<{DateTime.Now}> Connect: Client");
                };

                socket.OnClose = () =>
                {
                    foreach (var i in usersConnected)
                    {
                        if (i.socketId == socket)
                        {
                            i.SocketConnected = false;
                            if (i.user != "none")
                            {
                                Console.WriteLine($"<{DateTime.Now}> Disconect: {i.user}");
                                string query = $"UPDATE account SET state = '{DateTime.Now}' WHERE user = '{i.user}';"; // Per ora funziona solo su orario italiano.
                                MySqlCommand cmd = new MySqlCommand(query, cnn);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                Console.WriteLine($"<{DateTime.Now}> Disconect: empty");
                            }
                            return;
                        }
                    }
                };

                socket.OnMessage = message =>
                {
                    Json json0 = JsonConvert.DeserializeObject<Json>(message);

                    switch (json0.id)
                    {
                        case 1: // Si occupa del login è fa tutti i controlli riguardanti l'esistenza dell'utente e il controllo della password.
                            {
                                string query;
                                MySqlCommand cmd;
                                List<Friend> Friends = new List<Friend>();
                                MySqlDataReader reader;
                                string ToClient;

                                // L'utente esiste.

                                query = $"SELECT (EXISTS(SELECT user from account where user = '{json0.username}')) LIMIT 1;";
                                cmd = new MySqlCommand(query, cnn);
                                string dbUser = cmd.ExecuteScalar().ToString();

                                if (dbUser != "0")
                                {
                                    query = $"SELECT password FROM account WHERE user= '{json0.username}' limit 1;";
                                    cmd = new MySqlCommand(query, cnn);

                                    if (json0.password == cmd.ExecuteScalar().ToString()) // Password corretta.
                                    {
                                        foreach (var i in usersConnected)
                                        {
                                            if (i.socketId == socket)
                                            {
                                                i.user = json0.username;
                                                query = $"UPDATE account SET state = 'online' WHERE user = '{json0.username}' limit 1;";
                                                cmd = new MySqlCommand(query, cnn);
                                                cmd.ExecuteNonQuery();
                                            }
                                        }

                                        // Aggiunta alla lista degli amici già presenti.
                                        query = $"SELECT friend from friends where user= '{json0.username}';";
                                        cmd = new MySqlCommand(query, cnn);
                                        reader = cmd.ExecuteReader();
                                        while (reader.Read())
                                        {
                                            Friend friend = new Friend
                                            {
                                                user = reader[0].ToString(),
                                                // Da aggiungere l'immagine.
                                            };
                                            Friends.Add(friend);
                                        }
                                        reader.Close();


                                        foreach (var i in Friends) // Aggiunta delle foto profilo degli amici già presenti.
                                        {
                                            query = $"SELECT image from account where user= '{i.user}';";
                                            cmd = new MySqlCommand(query, cnn);
                                            i.image = cmd.ExecuteScalar().ToString();
                                        }

                                        query = $"select image from account where user='{json0.username}'"; // Aggiunge la foto profilo dell'utente
                                        cmd = new MySqlCommand(query, cnn);
                                        string Image = cmd.ExecuteScalar().ToString();

                                        Json json1 = new Json // Invio del pacchetto.
                                        {
                                            id = 1,
                                            uok = true,
                                            pok = true,
                                            friends = Friends,
                                            image = Image
                                        };

                                        ToClient = JsonConvert.SerializeObject(json1);
                                        if (socket.IsAvailable == true)
                                        {
                                            socket.Send(ToClient);
                                        }
                                    }
                                    else // Password non corretta.
                                    {
                                        Json json = new Json
                                        {
                                            id = 2,
                                            uok = true,
                                            pok = false
                                        };
                                        ToClient = JsonConvert.SerializeObject(json);
                                        socket.Send(ToClient);
                                    }
                                }
                                else // L'utente non esiste.
                                {
                                    Json json = new Json
                                    {
                                        id = 2,
                                        uok = false,
                                        pok = false
                                    };
                                    ToClient = JsonConvert.SerializeObject(json);
                                    socket.Send(ToClient);
                                }
                                break;
                            }
                        case 2: // Reindirizza i messaggi agli utenti conessi e mette i messaggi in attesa per gli utenti che non sono connessi (thread1).
                            {
                                bool ok = false;
                                foreach (var i in usersConnected)
                                {
                                    if (json0.to == i.user && i.SocketConnected)
                                    {
                                        Json json = new Json
                                        {
                                            id = 3,
                                            from = json0.from,
                                            message = json0.message,
                                            messageType = json0.messageType,
                                            date = json0.date
                                        };
                                        ok = true;
                                        string ToClient = JsonConvert.SerializeObject(json);
                                        i.socketId.Send(ToClient);
                                    }
                                }

                                if (!ok)
                                {
                                    Messages message1 = new Messages
                                    {
                                        to = json0.to,
                                        from = json0.from,
                                        date = json0.date,
                                        message = json0.message,
                                        messageType = json0.messageType
                                    };
                                    MessagesInAttesa.Add(message1);
                                }

                                string query;
                                MySqlCommand cmd;
                                MySqlDataReader reader;

                                // Archivia i messaggi nel db.

                                query = "SHOW TABLES;";
                                cmd = new MySqlCommand(query, cnn);
                                reader = cmd.ExecuteReader();

                                while (reader.Read())
                                {
                                    if (reader[0].ToString() == $"{json0.from}_messagges")
                                    {
                                        query = $"insert into {json0.from}_messagges (user,messagges,type,date) values ('{json0.to}','{json0.message}','{json0.messageType}','{json0.date.ToString("yyyy/MM/dd HH:mm:ss")}');";
                                        cmd = new MySqlCommand(query, cnn);
                                        cmd.ExecuteNonQuery();
                                        return;
                                    }
                                }

                                query = $"CREATE TABLE `{json0.from}_messages` ( `id` int(11) NOT NULL, `user` varchar(20) NOT NULL, `messages` varchar(1000) NOT NULL, `type` varchar(10) NOT NULL, `date` datetime NOT NULL ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4; ALTER TABLE `{json0.from}_messages` ADD PRIMARY KEY (`id`); ALTER TABLE `{json0.from}_messages` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT; ALTER TABLE `{json0.from}_messages` ADD FOREIGN KEY (`user`) REFERENCES `account`(`user`) ON DELETE CASCADE ON UPDATE CASCADE;";
                                cmd = new MySqlCommand();
                                cmd.ExecuteNonQuery();

                                query = $"insert into {json0.from}_messages (user,messages,type,date) values ('{json0.to}','{json0.message}','{json0.messageType}','{json0.date.ToString("yyyy/MM/dd HH:mm:ss")}');";
                                cmd = new MySqlCommand(query, cnn);
                                cmd.ExecuteNonQuery();

                                break;
                            }
                    }
                };
            });

            Console.Clear();
            Console.WriteLine($"<{DateTime.Now}> Server status: Open.");

            Thread thread = new Thread(() => // Apre la conessione al db
            {
                bool ok = false;
                while (!ok)
                {
                    if (cnn.State != System.Data.ConnectionState.Open)
                    {
                        try
                        {
                            cnn.Open();
                            Console.WriteLine($"<{DateTime.Now}> MySql Connection attemp: Successful.");
                            ok = true;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"<{DateTime.Now}> MySql Connection attemp: Failed.");
                        }
                    }
                    Thread.Sleep(5000);
                }
            });

            Thread thread1 = new Thread(() => // Controlla se gli utenti tornano online per mandargli i messaggi
            {
                while (true)
                {
                    foreach (var i in MessagesInAttesa)
                    {
                        foreach (var x in usersConnected)
                        {
                            if (x.SocketConnected && x.user == i.to)
                            {
                                Json json = new Json
                                {
                                    id = 3,
                                    from = i.from,
                                    date = i.date,
                                    message = i.message,
                                    messageType = i.messageType
                                };

                                string ToClient = JsonConvert.SerializeObject(json);
                                x.socketId.Send(ToClient);
                                MessagesInAttesa.Remove(i);
                            }
                        }
                    }
                }
            });

            thread.Start();
            thread1.Start();
        }

        private class Json
        {
            public int id { get; set; } // Identifica la funzione.
            public string username { get; set; } // Identifica L'utente che sta provando ad eseguire l'accesso.
            public bool uok { get; set; } // Identifica se il nome utente è presente nel db.
            public string password { get; set; } // Password che è stata immessa nel client.
            public bool pok { get; set; } // Identifica se la password è corretta nel db.
            public int age { get; set; } // Identifica l'età dell'utente.
            public string image { get; set; } // Immagine profilo dell'utente.
            public List<Friend> friends { get; set; } // Lista di amici dell'utente.
            public string from { get; set; } // Da chi viene il messaggio.
            public string to { get; set; } // Verso che deve andare il messaggio.
            public DateTime date { get; set; } // Orario di invio del messaggio.
            public string message { get; set; } // Stringa della messaggio.
            public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
        }
        private class Messages
        {
            public string from { get; set; } // Da chi viene il messaggio.
            public string to { get; set; } // Verso che deve andare il messaggio.
            public DateTime date { get; set; } // Orario di invio del messaggio.
            public string message { get; set; } // Stringa della messaggio.
            public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
        }
        private class Friend
        {
            public string image { get; set; } // Immagine dell'amico.
            public string user { get; set; } // Nome utente dell'amico.
        }
        private class WebsocketUsers
        {
            public bool SocketConnected { get; set; } // Identifica se il socket è connesso.
            public IWebSocketConnection socketId { get; set; } // Identifica il socket.
            public string user { get; set; } // Identifica che utente si è conesso da quel socket.
        }
    }
}