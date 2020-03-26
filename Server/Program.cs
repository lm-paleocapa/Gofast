using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Fleck;
using Newtonsoft.Json;

// Server 0.0.1

namespace Server
{
    class Program
    {
        public static string LocalIp()
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

        static WebSocketServer server = new WebSocketServer($"ws://{LocalIp()}:55000");
        static List<IWebSocketConnection> SocketList = new List<IWebSocketConnection>();

        static void Main()
        {
            server.Start(socket =>
            {
                socket.OnOpen = () =>
                {
                    SocketList.Add(socket);
                };

                socket.OnClose = () =>
                {
                    SocketList.Remove(socket);
                };

                socket.OnMessage = message =>
                {
                    JsonToServer json0 = JsonConvert.DeserializeObject<JsonToServer>(message);

                    switch ()
                    {
                        case "1": //controllo esistenza dell'account in fase di registrazione dal sito web
                            {
                                bool esiste = false;

                                //controllo presenza dell'account

                                if (!esiste)
                                {
                                    socket.Send("Fa");
                                }
                                else if (esiste)
                                {
                                    socket.Send("Ta");
                                }

                                break;
                            }

                        case "2":
                            {
                                break;
                            }
                    }
                };
            });

            while (true)
            {
                startComand(Console.ReadLine());
            }
            
        }

        private static void startComand(string comand)
        {
            switch (comand)
            {
                case "clear":
                    {
                        Console.Clear();
                        break;
                    }
                case "location":
                    {
                        Console.WriteLine(server.Location);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Comand not found");
                        break;
                    }
            }
        }
    }
}