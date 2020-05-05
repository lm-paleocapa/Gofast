namespace Server
{
    using Fleck;
    using MySql.Data.MySqlClient;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Threading;
    using System.Drawing;
    using System.Data;

    using Lib;
    public class Program
    {
        public static List<WebsocketUsers> usersConnected = new List<WebsocketUsers>();
        public static List<Messages> MessaggiInAttesa = new List<Messages>();
        static void Main()
        {
            #region Database
            MySqlConnection cnn = new MySqlConnection("server=192.168.1.108;database=gofastdb;port=3306;uid=gofast;pwd=SDSD123687u21nsad;");
            cnn.Open();
            #endregion

            #region Server
            WebSocketServer server = new WebSocketServer($"ws://127.0.0.1:8181");
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
                    Json json0 = JsonConvert.DeserializeObject<Json>(message);

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
                    }
                };
            });

            void socketOnClose(IWebSocketConnection e)
            {
                foreach (var i in usersConnected)
                {
                    if (i.socketId == e)
                    {
                        i.SocketConnected = false;
                        if (i.user != "none")
                        {
                            string query = $"UPDATE account SET state = '{DateTime.Now}' WHERE user = '{i.user}';";
                            MySqlCommand cmd = new MySqlCommand(query, cnn);
                            cmd.ExecuteNonQuery();
                        }
                        return;
                    }
                }
            }
            void socketOnOpen(IWebSocketConnection e)
            {
                foreach (var i in usersConnected)
                {
                    if (i.socketId == e)
                    {
                        i.SocketConnected = true;
                        return;
                    }
                }
            }

            void Primo(Json json0, IWebSocketConnection socket)
            {
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

                        List<Friend> friends = new List<Friend>();
                        query = $"SELECT friend from friends where user= '{json0.username}';";
                        cmd = new MySqlCommand(query, cnn);
                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Friend friend = new Friend
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
                                img = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAAB20lEQVR42mL8//8/w2AGTAyDHIw6cNg7kAWXBCMjIynm8AOxOhB7ALEWFIsCcS4QryHFIIxMCxLAhokEzEA8DYj/gIzCgScD8UwgLgViNmIciOIOCh2Yj8dh2HAOqQ6kNA0mk6jeid6ZRItE9aL0diAziep56OlAfjp4aHgX1NJk6PlFTFFDrXLwCYlFDAxvJ8U9jLgcQ0RNQm477TUQixFbk1ASxd/J1PeLXmnwApn6ptMrDQoB8WoS0583vetiUM3wgUjHbSEnwCh1IKx+/UbAcSBPKA6UA0HAjIADbchNcpQUM+jV3gc8uZad3AYrtaq6L3jk3g2GPokrkmMeQcvIeqTQ5SfbZCqkQVDR8Raa1vYiiSuiVW/S9MokckAcDsTzgfg5WmaYgKe+/gP1QCM0xHmo6UBQoVxHRAMBvQuwgoB6kINDKHWgGZaQwoWN0RyYQ0ILh4ccB5oRUQgjRyEnmgONSagGz4Na3KQ6cCMJFtzA0cT/TIIZ4aR2O41JyM1CWPoc/CT2QyxJLQclSOxS+qGJJWCJdpK6sfgcyElGLywWjZ9Gon4hWhTUyADUIXoFTU8HqFFxULvbCWoYLIOyZ1HFRCqHIAgYQEORkxruYRwdRB/uDgQIMADK7J2uzc976AAAAABJRU5ErkJggg==";
                            x.image = img;
                        }

                        query = $"select image from account where user= '{json0.username}'";
                        cmd = new MySqlCommand(query, cnn);
                        img = cmd.ExecuteScalar().ToString();

                        Json json1 = new Json
                        {
                            id = 1,
                            uok = true,
                            pok = true,
                            friends = friends,
                            image = img
                        };

                        ToClient = JsonConvert.SerializeObject(json1);
                        socket.Send(ToClient);
                    }
                    else
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
                else
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
            }
            void Secondo(Json json0, IWebSocketConnection socket)
            {
                string query;
                MySqlCommand cmd;
                MySqlDataReader reader;
                List<Friend> Friends = new List<Friend>();
                string ToClient;
                bool ok;

                ok = false;
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
                        ToClient = JsonConvert.SerializeObject(json);
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

            }

            new Thread(() => // Da provare.
            {
                Thread.CurrentThread.Name = "Messaggi in attesa";
                while (true)
                {
                    foreach (var i in MessaggiInAttesa)
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
                                MessaggiInAttesa.Remove(i);
                            }
                        }
                    }
                    Thread.Sleep(50);
                }
            }).Start();

            Update.Start();
            #endregion

            #region Utility
            new Thread(() =>
            {
                Thread.CurrentThread.Name = "Utility";

                while (true)
                {
                    Console.Clear();

                    Console.WriteLine(
                        $"{Utility.Now()}\n" +
                        $"1) Send");
                    try
                    {
                        int i = int.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                {
                                    Utility.SendMessage();
                                    break;
                                }
                        }
                    }
                    finally
                    {
                        Console.Clear();
                    }
                }
            }).Start();
            #endregion
        }
        public class Json
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
            public List<Program.Friend> friend { get; set; }
            public string User { get; set; }
        }
    }
}