namespace Server
{
    using Fleck;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using Lib;
    using System.Drawing.Text;
    using System.Linq;

    public class Program
    {
        public static List<Obj.WebsocketUsers> usersConnected = new List<Obj.WebsocketUsers>();
        public static List<Obj.Messages> MessaggiInAttesa = new List<Obj.Messages>();
        private static string ip = "80.182.17.185";
        static void Main()
        {
            MySqlConnection mainCnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
            mainCnn.Open();
            Console.WriteLine(mainCnn.State);
            Start.OnServerOpen(mainCnn);

            #region Server
            WebSocketServer server = new WebSocketServer($"ws://0.0.0.0:8181");
            server.RestartAfterListenError = true;
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    socketOnOpen(socket);
                };
                socket.OnClose = () =>
                {
                    socketOnClose(socket);
                };
                socket.OnMessage = message =>
                {
                    Obj.Json json0 = JsonConvert.DeserializeObject<Obj.Json>(message);

                    switch (json0.id)
                    {
                        case 1:
                            {
                                Primo(json0, socket);
                                break;
                            }
                        case 2:
                            {
                                Secondo(json0, socket);
                                break;
                            }
                        case 3:
                            {
                                Terzo(json0, socket);
                                break;
                            }
                        case 4:
                            {
                                Quarto(json0, socket);
                                break;
                            }
                        case 5:
                            {
                                Quinto(json0, socket);
                                break;
                            }
                        case 6:
                            {
                                Sesto(json0, socket);
                                break;
                            }
                        case 7:
                            {
                                Settimo(json0, socket);
                                break;
                            }
                        case 8:
                            {
                                Ottavo(json0, socket);
                                break;
                            }
                        case 9:
                            {
                                Nono(json0, socket);
                                break;
                            }
                        case 10:
                            {
                                Decimo(json0, socket);
                                break;
                            }
                    }
                };
            });

            void socketOnClose(IWebSocketConnection e)
            {

            }
            void socketOnOpen(IWebSocketConnection e)
            {
                
            }
            void Primo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();

                string query;
                MySqlCommand cmd;
                string ToClient;
                MySqlDataReader reader;
                string img;

                query = $"SELECT (EXISTS(SELECT user from account where user = '{json0.username}')) LIMIT 1;";
                cmd = new MySqlCommand(query, cnn);
                string dbUser = cmd.ExecuteScalar().ToString();

                if (dbUser != "0")
                {
                    query = $"SELECT password FROM account WHERE user= '{json0.username}' limit 1;";
                    cmd = new MySqlCommand(query, cnn);

                    if (json0.password == cmd.ExecuteScalar().ToString())
                    {
                        foreach (var i in usersConnected)
                        {
                            if (i.user == json0.username)
                            {
                                i.socketId = socket;
                                i.SocketConnected = true;
                            }
                        }
                        query = $"UPDATE account SET state = 'online' WHERE user = '{json0.username}' limit 1;";
                        cmd = new MySqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();

                        List<Obj.Friend> friends = new List<Obj.Friend>();
                        query = $"SELECT friend from friends where user= '{json0.username}';";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Obj.Friend friend = new Obj.Friend
                            {
                                user = reader[0].ToString()
                            };
                            friends.Add(friend);
                        }
                        reader.Close();

                        foreach (var x in friends)
                        {
                            query = $"SELECT image from account where user= '{x.user}';";
                            cmd = new MySqlCommand(query, cnn);
                            img = cmd.ExecuteScalar().ToString();
                            if (string.IsNullOrEmpty(img))
                                img = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAABmJLR0QA/wD/AP+gvaeTAAABmElEQVRoge3Yv05UQRiG8Z8al0QTjaG1sRIFLgC9CTvopTdciAYi0U5q1FIbUTuvANBQkWALyQakg6zFOZsY2HPcnRmY1cyTvNXuzPd8J1/m/KFQKBT+N2axgi38qrOFZcxk9PorE3iFU/QacoJVdDI5NjKBr5rFz+aLMWviteHl+3mZxXQAs9rHpm2cpmOLX43dAIuB+1zD0wT1o9k2+tXvZzOD7zmOhDdwGFs8xQj1Mq1FmgZ+Rqzdiy2eooGNiLWfEtSPZkZ1JIYcow8z+A5k1egNrGQxbaCDz4aX38D1LKYtdFSPB23jdKK68mMn/yfTeKG6SR3V2cRzYzTzhUKhkIYrifZ4gMeqY/I+7mESt+r/HOIAu9jBd3zDDwmeSEO4iXm8x77w94F9vKv3unEZ4lNYw3GEdFOO8aaukZy7eCvs5X3UnGK9rpmEJ+LGJDRdLMTKL2UQP5tnofKPXM7IDDNScyENfBwD+X4+NEm23Qe6uD1i0xdFF3cG/dDWQO9iXIIZ6Jriq0RWSgO5+ecbKBQKhbz8BlwQZA0cAiNhAAAAAElFTkSuQmCC";
                            x.image = img;
                        }

                        query = $"select image,mail from account where user= '{json0.username}' limit 1";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();

                        reader.Read();

                        Obj.Json json1 = new Obj.Json
                        {
                            id = 1,
                            uok = true,
                            pok = true,
                            friends = friends,
                            image = reader[0].ToString(),
                            username = json0.username,
                            mail = reader[1].ToString()
                        };
                        reader.Close();

                        ToClient = JsonConvert.SerializeObject(json1);
                        socket.Send(ToClient);

                        List<Obj.Messages> messages = new List<Obj.Messages>();
                        bool ok = false;
                        foreach (var k in MessaggiInAttesa)
                        {
                            if (k.to == json0.username)
                            {
                                messages.Add(k);
                                ok = true;
                            }
                        }
                        if (ok)
                        {
                            Obj.Json json = new Obj.Json
                            {
                                id = 5,
                                ms = messages
                            };
                            string to1 = JsonConvert.SerializeObject(json);
                            socket.Send(to1);
                            foreach (var i in messages)
                                MessaggiInAttesa.Remove(i);
                        }

                        MySqlConnection cnn1 = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                        cnn1.Open();

                        List<Obj.Friend> items = new List<Obj.Friend>();

                        query = $"select user from newFriendsRequest where friend = '{json0.username}';";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            query = $"select user,image from account where user = '{reader[0]}' limit 1;";
                            cmd = new MySqlCommand(query, cnn1);
                            MySqlDataReader rd = cmd.ExecuteReader();
                            rd.Read();
                            Obj.Friend item = new Obj.Friend
                            {
                                user = rd[0].ToString(),
                                image = rd[1].ToString()
                            };
                            items.Add(item);
                            rd.Close();
                        }
                        reader.Close();

                        Obj.Json json2 = new Obj.Json
                        {
                            id = 8,
                            friends = items
                        };
                        string to = JsonConvert.SerializeObject(json2);
                        socket.Send(to);

                        cnn.Close();
                        cnn1.Close();
                    }
                    else
                    {
                        Obj.Json json = new Obj.Json
                        {
                            id = 2,
                            uok = true,
                            pok = false
                        };
                        ToClient = JsonConvert.SerializeObject(json);
                        socket.Send(ToClient);
                        cnn.Close();
                    }
                }
                else
                {
                    Obj.Json json = new Obj.Json
                    {
                        id = 2,
                        uok = false,
                        pok = false
                    };
                    ToClient = JsonConvert.SerializeObject(json);
                    socket.Send(ToClient);
                    cnn.Close();
                }
            }
            void Secondo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();

                string query;
                MySqlCommand cmd;
                MySqlDataReader reader;
                List<Obj.Friend> Friends = new List<Obj.Friend>();
                string ToClient;
                bool ok;

                ok = false;
                foreach (var i in usersConnected)
                {
                    if (json0.to == i.user && i.SocketConnected)
                    {
                        Obj.Json json = new Obj.Json
                        {
                            id = 3,
                            from = json0.from,
                            message = json0.message,
                            messageType = json0.messageType,
                            date = json0.date
                        };
                        ok = true;
                        ToClient = JsonConvert.SerializeObject(json);
                        i.socketId.Send(ToClient);
                    }
                }

                if (!ok)
                {
                    Obj.Messages message1 = new Obj.Messages
                    {
                        to = json0.to,
                        from = json0.from,
                        date = json0.date,
                        message = json0.message,
                        messageType = json0.messageType
                    };
                    MessaggiInAttesa.Add(message1);
                }

                query = "SHOW TABLES;";
                cmd = new MySqlCommand(query, cnn);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if (reader[0].ToString() == $"{json0.from}_messages")
                    {
                        reader.Close();
                        query = $"insert into {json0.from}_messages (user,messages,type,date) values ('{json0.to}','{json0.message}','{json0.messageType}','{json0.date.ToString("yyyy/MM/dd HH:mm:ss")}');";
                        cmd = new MySqlCommand(query, cnn);
                        cmd.ExecuteNonQuery();
                        return;
                    }
                }
                reader.Close();

                query = $"CREATE TABLE `{json0.from}_messages` ( `id` int(11) NOT NULL, `user` varchar(20) NOT NULL, `messages` varchar(1000) NOT NULL, `type` varchar(10) NOT NULL, `date` datetime NOT NULL ) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4; ALTER TABLE `{json0.from}_messages` ADD PRIMARY KEY (`id`); ALTER TABLE `{json0.from}_messages` MODIFY `id` int(11) NOT NULL AUTO_INCREMENT; ALTER TABLE `{json0.from}_messages` ADD FOREIGN KEY (`user`) REFERENCES `account`(`user`) ON DELETE CASCADE ON UPDATE CASCADE;";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                query = $"insert into {json0.from}_messages (user,messages,type,date) values ('{json0.to}','{json0.message}','{json0.messageType}','{json0.date.ToString("yyyy/MM/dd HH:mm:ss")}');";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            void Terzo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();

                string query;
                MySqlCommand cmd;
                MySqlDataReader reader;
                string toClient;

                bool mailOk = false;

                query = "select user from account";
                cmd = new MySqlCommand(query, cnn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (json0.username == reader[0].ToString())
                    {
                        reader.Close();
                        query = "select mail from account";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                            if (reader[0].ToString() == json0.mail)
                            {
                                Obj.Json json2 = new Obj.Json
                                {
                                    id = 4,
                                    uok = false,
                                    mok = false
                                };
                                toClient = JsonConvert.SerializeObject(json2);
                                socket.Send(toClient);
                                reader.Close();
                                cnn.Close();
                                return;
                            }
                        reader.Close();

                        Obj.Json json = new Obj.Json
                        {
                            id = 4,
                            uok = false,
                            mok = true
                        };
                        mailOk = true;
                        toClient = JsonConvert.SerializeObject(json);
                        socket.Send(toClient);
                        cnn.Close();
                        return;
                    }
                }
                reader.Close();

                if (!mailOk)
                {
                    Obj.Json json2 = new Obj.Json
                    {
                        id = 4,
                        uok = true,
                        mok = false
                    };
                    toClient = JsonConvert.SerializeObject(json2);
                    socket.Send(toClient);
                    return;
                }

                Obj.Json json1 = new Obj.Json
                {
                    id = 4,
                    uok = true,
                    mok = true
                };
                toClient = JsonConvert.SerializeObject(json1);
                socket.Send(toClient);

                query = $"INSERT INTO account (user,password,mail,age,image) VALUES ('{json0.username}', '{json0.password}', '{json0.mail}', '{json0.age}', '{json0.image}');";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                Obj.WebsocketUsers newUser = new Obj.WebsocketUsers
                {
                    SocketConnected = false,
                    user = json0.username
                };
                usersConnected.Add(newUser);
            }
            void Quarto(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();
                MySqlConnection cnn1 = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn1.Open();
                MySqlCommand cmd;
                string query;
                MySqlDataReader reader;

                List<Obj.Friend> userToAdd = new List<Obj.Friend>();

                query = $"select user,image from account where user not in ('{json0.username}') and user REGEXP '^[{json0.message}]' limit 4";
                cmd = new MySqlCommand(query, cnn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    query = $"SELECT (EXISTS(SELECT user from friends where user = '{json0.username}' and friend = '{reader[0]}')) LIMIT 1 ";
                    cmd = new MySqlCommand(query, cnn1);
                    string k = cmd.ExecuteScalar().ToString();
                    if (k != "1")
                    {
                        query = $"SELECT (EXISTS(SELECT friend from newFriendsRequest where user = '{json0.username}' and friend = '{reader[0]}')) LIMIT 1 ";
                        cmd = new MySqlCommand(query, cnn1);
                        k = cmd.ExecuteScalar().ToString();
                        if (k != "1")
                        {
                            Obj.Friend item = new Obj.Friend
                            {
                                user = reader[0].ToString(),
                                image = reader[1].ToString()
                            };
                            userToAdd.Add(item);
                        }
                    }
                }
                reader.Close();
                Obj.Json json = new Obj.Json
                {
                    id = 6,
                    friends = userToAdd
                };
                string to = JsonConvert.SerializeObject(json);
                cnn.Close();
                cnn1.Close();
                socket.Send(to);
            }
            void Quinto(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();

                MySqlCommand cmd;
                string query;
                foreach (var i in json0.friends)
                {
                    query = $"select image from account where user = '{i.user}'";
                    cmd = new MySqlCommand(query, cnn);
                    string img = cmd.ExecuteScalar().ToString();

                    query = $"Insert into newFriendsRequest (user,friend,image) values ('{json0.username}','{i.user}','{img}')";
                    cmd = new MySqlCommand(query, cnn);
                    cmd.ExecuteNonQuery();

                    Obj.Json json = new Obj.Json
                    {
                        id = 8,
                        from = json0.username,
                        image = img
                    };
                    string to = JsonConvert.SerializeObject(json);
                    foreach (var k in usersConnected)
                        if (k.user == i.user && k.SocketConnected)
                            k.socketId.Send(to);
                }
                cnn.Close();
            }
            void Sesto(Obj.Json json0, IWebSocketConnection socekt)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();

                string query;
                MySqlCommand cmd;

                query = $"select mail,password from account where user = '{json0.username}'";
                cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string mail = reader[0].ToString();
                string password = reader[1].ToString();
                reader.Close();

                if (string.IsNullOrEmpty(json0.mail))
                    json0.mail = mail;
                if (string.IsNullOrEmpty(json0.password))
                    json0.password = password;

                query = $"update account set mail = '{json0.mail}', password = '{json0.password}' where user = '{json0.username}'";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                Obj.Json json = new Obj.Json
                {
                    id = 7,
                };
                string to = JsonConvert.SerializeObject(json);
                socekt.Send(to);
            }
            void Settimo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();
                string query = $"update account set image = '{json0.image}' where user = '{json0.username}'";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();

                Obj.Json json = new Obj.Json
                {
                    id = 7,
                };
                string to = JsonConvert.SerializeObject(json);
                socket.Send(to);
            }
            void Ottavo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();
                string query;
                MySqlCommand cmd;

                query = $"delete from newFriendsRequest where user = '{json0.to}' and friend = '{json0.username}' limit 1;";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO friends (user,friend) VALUES ('{json0.to}','{json0.username}');";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                query = $"INSERT INTO friends (user,friend) VALUES ('{json0.username}','{json0.to}');";
                cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();

                query = $"select user,image from account where user = '{json0.to}' limit 1;";
                cmd = new MySqlCommand(query, cnn);
                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                foreach (var i in usersConnected)
                {
                    if (i.user == json0.username && i.SocketConnected)
                    {
                        Obj.Json json = new Obj.Json
                        {
                            id = 9,
                            username = reader[0].ToString(),
                            image = reader[1].ToString()
                        };
                        string to = JsonConvert.SerializeObject(json);
                        i.socketId.Send(to);
                    }
                }
                reader.Close();

                query = $"select user,image from account where user = '{json0.username}' limit 1;";
                cmd = new MySqlCommand(query, cnn);
                reader = cmd.ExecuteReader();
                reader.Read();
                foreach (var i in usersConnected)
                {
                    if (i.user == json0.to && i.SocketConnected)
                    {
                        Obj.Json json = new Obj.Json
                        {
                            id = 9,
                            username = reader[0].ToString(),
                            image = reader[1].ToString()
                        };
                        string to = JsonConvert.SerializeObject(json);
                        i.socketId.Send(to);
                    }
                }
                reader.Close();
                cnn.Close();
            }
            void Nono(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();
                string query = $"DELETE from newFriendsRequest where user = '{json0.to}' and friend = '{json0.username}' ";
                MySqlCommand cmd = new MySqlCommand(query, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
            }
            void Decimo(Obj.Json json0, IWebSocketConnection socket)
            {
                MySqlConnection cnn = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn.Open();
                MySqlConnection cnn1 = new MySqlConnection($"server={ip};database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
                cnn1.Open();
                string query;
                MySqlCommand cmd;
                MySqlDataReader reader;

                foreach (var i in usersConnected)
                {
                    if (i.user == json0.username)
                    {
                        query = $"select friend from friends where user = '{json0.username}';";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            Obj.Json json = new Obj.Json
                            {
                                id = 10,
                                username = json0.username,
                                date = DateTime.Now
                            };
                            string to = JsonConvert.SerializeObject(json);
                            foreach (var k in usersConnected)
                            {
                                if (k.user == reader[0].ToString() && k.SocketConnected)
                                    k.socketId.Send(to);
                            }
                        }

                        i.SocketConnected = false;

                        i.user = "none";
                        query = $"UPDATE account SET state = '{DateTime.Now}' WHERE user = '{i.user}';";
                        cmd = new MySqlCommand(query, mainCnn);
                        cmd.ExecuteNonQuery();
                    }
                }
                cnn.Close();
                cnn1.Close();
            }
            while (true)
            {
            }
            #endregion
        }
    }
    public class Obj
    {
        public class Json
        {
            public int id { get; set; } // Identifica la funzione.
            public string username { get; set; } // Identifica L'utente che sta provando ad eseguire l'accesso.
            public bool uok { get; set; } // Identifica se il nome utente è presente nel db.
            public string password { get; set; } // Password che è stata immessa nel client.
            public bool pok { get; set; } // Identifica se la password è corretta nel db.
            public int age { get; set; } // Identifica l'età dell'utente.
            public string mail { get; set; }
            public bool mok { get; set; }
            public string image { get; set; } // Immagine profilo dell'utente.
            public List<Friend> friends { get; set; } // Lista di amici dell'utente.
            public List<Messages> ms { get; set; }
            public string from { get; set; } // Da chi viene il messaggio.
            public string to { get; set; } // Verso che deve andare il messaggio.
            public DateTime date { get; set; } // Orario di invio del messaggio.
            public string message { get; set; } // Stringa della messaggio.
            public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
        }
        public class Messages
        {
            public string from { get; set; } // Da chi viene il messaggio.
            public string to { get; set; } // Verso che deve andare il messaggio.
            public DateTime date { get; set; } // Orario di invio del messaggio.
            public string message { get; set; } // Stringa della messaggio.
            public string messageType { get; set; } // Che tipo di messaggio è (testo, audio, video, immagine).
        }
        public class Friend
        {
            public string image { get; set; } // Immagine dell'amico.
            public string user { get; set; } // Nome utente dell'amico.
        }
        public class WebsocketUsers
        {
            public bool SocketConnected { get; set; } // Identifica se il socket è connesso.
            public IWebSocketConnection socketId { get; set; } // Identifica il socket.
            public string user { get; set; } // Identifica che utente si è conesso da quel socket.
        }
        public class OldFriends
        {
            public List<Friend> friend { get; set; }
            public string User { get; set; }
        }
    }
}
