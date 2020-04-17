using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Fleck;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Server
{
    class Program
    {
        private static WebSocketServer server = new WebSocketServer($"ws://0.0.0.0:8181");
        private static MySqlConnection cnn = new MySqlConnection("server=192.168.1.108;database=gofastdb;port=3306;uid=gofast;pwd=qGZGg01k0lbWXkKD;");
        private static List<WebsocketUsers> userConnected = new List<WebsocketUsers>();
        private static List<string> AllUsers = new List<string>();

        static void Main()
        {
            MySqlCommand command = new MySqlCommand("select user from account", cnn);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) // Aggiunge ad una lista i nomi di tutti gli utenti.
            {
                AllUsers.Add(reader[0].ToString());
            }

            server.RestartAfterListenError = true;
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    foreach (var i in userConnected)
                    {
                        if (i.socketId == socket)
                        {
                            i.connected = true;
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
                        connected = true
                    };
                    userConnected.Add(user);
                    Console.WriteLine($"<{DateTime.Now}> Connect: Client");
                };

                socket.OnClose = () =>
                {
                    foreach (var i in userConnected)
                    {
                        if (i.socketId == socket)
                        {
                            i.connected = false;
                            if (i.user != "none")
                            {
                                Console.WriteLine($"<{DateTime.Now}> Disconect: {i.user}");
                                string query = $"UPDATE account SET state = '{DateTime.Now}' WHERE user = '{i.user}';";
                                MySqlCommand cmd = new MySqlCommand(query, cnn);
                                cmd.ExecuteNonQuery();
                            }
                            else
                            {
                                Console.WriteLine($"<{DateTime.Now}> Disconect: empty");
                            }
                        }
                    }
                };

                socket.OnMessage = message =>
                {
                    Json json0 = JsonConvert.DeserializeObject<Json>(message);

                    switch (json0.id)
                    {
                        case 1:
                            {
                                string query;
                                MySqlCommand cmd;
                                List<Friend> Friends = new List<Friend>();
                                MySqlDataReader reader;
                                string ToClient;


                                try // L'utente esiste.
                                {
                                    query = $"SELECT user FROM account WHERE user= '{json0.username}' limit 1;";
                                    cmd = new MySqlCommand(query, cnn);
                                    string dbUser = cmd.ExecuteScalar().ToString();

                                    query = $"SELECT password FROM account WHERE user= '{json0.username}' limit 1;";
                                    cmd = new MySqlCommand(query, cnn);

                                    if (json0.password == cmd.ExecuteScalar().ToString()) // Password corretta.
                                    {
                                        foreach (var i in userConnected)
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
                                                user = reader[0].ToString()
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
                                catch // L'utente non esiste.
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
                    }
                };
            });

            Console.Clear();
            Console.WriteLine($"<{DateTime.Now}> Server status: Open.");

            while (true)
            {
                if (cnn.State != System.Data.ConnectionState.Open)
                {
                    try
                    {
                        cnn.Open();
                        Console.WriteLine($"<{DateTime.Now}> MySql Connection attemp: Successful.");

                    }
                    catch (Exception)
                    {
                        Console.WriteLine($"<{DateTime.Now}> MySql Connection attemp: Failed.");
                    }
                }
                Thread.Sleep(5000);
            }
        }

        private static void SecondThread() // Prepara tutti i messaggi.
        {
            string query;
            MySqlCommand cmd;
            MySqlDataReader reader;

            List<Users_Messages> List = new List<Users_Messages>();

            while (true)
            {
                foreach(var i in userConnected)
                {
                    if (i.connected == true) //from
                    {
                        
                    }
                }
            }
        }

        public class Json
        {
            public int id { get; set; }

            public string username { get; set; }
            public bool uok { get; set; }

            public string password { get; set; }
            public bool pok { get; set; }

            public int age { get; set; }

            public string image { get; set; }

            public List<Friend> friends { get; set; }
        }
        public class Friend
        {
            public string image { get; set; }
            public string user { get; set; }
        }

        private class WebsocketUsers
        {
            public bool connected { get; set; }
            public IWebSocketConnection socketId { get; set; }
            public string user { get; set; }
        }

        public class Messages
        {
            public DateTime date { get; set; }
            public string text { get; set; }
        }
        public class To
        {
            public string user { get; set; }
            public List<Messages> Messages { get; set; }
        }
        public class Users_Messages
        {
            public string from { get; set; }
            public List<To> to { get; set; }
        }
    }
}