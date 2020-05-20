namespace Server.Lib
{
    using System;
    using Newtonsoft.Json;

    using Server;
    public class Utility
    {
        public static string Now()
        {
            DateTime dt = DateTime.Now; ;
            return $"<{dt.ToString("dd/MMMM/yyyy")}> => ";
        }
        public static void SendMessage()
        {
            Console.WriteLine($"{Now()} Da chi deve partire il messaggio?");
            string from = Console.ReadLine();
            Console.WriteLine($"{Now()} A chi deve arrivare il messsaggio?");
            string to = Console.ReadLine();
            Console.WriteLine($"{Now()} Scrivi il messaggio:");
            string mes = Console.ReadLine();

            foreach (var i in Program.usersConnected)
            {
                if (i.user == to)
                {
                    if (i.SocketConnected)
                    {
                        Obj.Json json = new Obj.Json
                        {
                            id = 3,
                            messageType = "string",
                            from = from,
                            message = mes,
                            date = DateTime.Now.ToString()
                        };
                        string toClient = JsonConvert.SerializeObject(json);
                        i.socketId.Send(toClient);
                        Console.WriteLine($"{Now()} Messaggio inviato con successo!");
                    }
                    else
                    {
                        Obj.Messages message = new Obj.Messages
                        {
                            to = to,
                            from = from,
                            date = DateTime.Now.ToString(),
                            message = mes,
                            messageType = "string"
                        };
                        Program.MessaggiInAttesa.Add(message);
                        Console.WriteLine($"{Now()} Messaggio messo in attesa perché l'utente è offline!");
                    }
                }
            }
            Console.WriteLine($"{Now()} Messaggio non inviato!");
        }
    }
}