using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using Fleck;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
namespace Server
{
    class Program
    {
        private static MySqlConnection connection = new MySqlConnection("server=79.24.89.93;port=3306;username=gofast;password=da inserire");
        private static WebSocketServer server = new WebSocketServer($"ws://{LocalIp()}:8181");
        private static List<Users> userConnected = new List<Users>();
        static void Main()
        {
            server.RestartAfterListenError = true;
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    Users user = new Users
                    {
                        socketId = socket,
                        user = "none"
                    };
                    userConnected.Add(user);
                };
                socket.OnClose = () =>
                {
                    foreach (var i in userConnected)
                    {
                        if (i.socketId == socket)
                        {
                            userConnected.Remove(i);
                        }
                    }
                };
                socket.OnMessage = message =>
                {
                    Json json0 = JsonConvert.DeserializeObject<Json>(message);

                    switch (json0.id)
                    {
                        case 1: // Associa il socket conesso con un utente e ne aggiorna lo stato.
                            {
                                foreach (var i in userConnected)
                                {
                                    if (i.socketId == socket)
                                    {
                                        i.user = json0.user0;
                                        string query0 = $"use gofast; UPDATE account SET state = 'online' WHERE user = '{json0.user0}';";
                                        MySqlCommand cmd0 = connection.CreateCommand();
                                        cmd0.CommandText = (query0);
                                        cmd0.Connection = connection;
                                        cmd0.ExecuteNonQuery();
                                    }
                                }
                                break;
                            }
                        case 2: // Indirizza ad un utente un messagio.
                            {
                                Json json1 = new Json
                                {
                                    id = 1,
                                    text = json0.text,
                                    user0 = json0.user1,
                                    date = json0.date
                                };
                                string mes = JsonConvert.SerializeObject(json1);

                                foreach (var i in userConnected)
                                {
                                    if (i.user == json0.user1)
                                    {
                                        i.socketId.Send(mes);
                                    }
                                }
                                break;
                            }
                        case 3: // Logout del profilo e aggiornamento ultimo accesso.
                            {
                                string user0 = null;
                                foreach (var i in userConnected)
                                {
                                    if (i.socketId == socket)
                                    {
                                        user0 = i.user;
                                    }
                                }
                                string query = $"use gofast; UPDATE account SET state = '{json0.date}' WHERE user = '{user0}';";
                                MySqlCommand cmd = connection.CreateCommand();
                                cmd.CommandText = (query);
                                cmd.Connection = connection;
                                cmd.ExecuteNonQuery();
                                
                                break;
                            }
                    }
                };
            });

            Thread zero = new Thread(thread0);
            zero.Start();
            bool ok = false;
            try
            {
                connection.Open();
                ok = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            if (ok) Console.WriteLine("Database is connected");
        }
        private static void thread0()
        {
            while (true)
            {
                startComand(Console.ReadLine());
            }
        }
        private static string LocalIp() // Trova l'ipv4 in autonomia.
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                }
            }
            return localIP;
        }
        private static void startComand(string comand) // Mette a disposizione dei comandi eseguibili dal terminale
        {
            switch (comand)
            {
                case "clear":
                    {
                        Console.Clear();
                        break;
                    }
                case "kick":
                    {
                        Console.Write("user: ");
                        string user = Console.ReadLine();

                        bool found = false;
                        foreach (var i in userConnected)
                        {
                            if (i.user == user)
                            {
                                found = true;
                                Json json = new Json
                                {
                                    id = 100
                                };
                                i.socketId.Close();
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("user not found.");
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Comand not found");
                        break;
                    }
            }
        }
        private class Json
        {
            public int id { get; set; }
            public string text { get; set; }
            public string user0 { get; set; }
            public string user1 { get; set; }
            public DateTime date { get; set; }
            public string imageBase64 { get; set; }
            public string state { get; set; }
            public string image { get; set; }
        }
        private class Users
        {
            public IWebSocketConnection socketId { get; set; }
            public string user { get; set; }
        }
    }
}
