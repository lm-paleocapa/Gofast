namespace NameClient
{
    using WebSocket4Net;
    using Newtonsoft.Json;
    using NameJson;
    using System.Threading;

    using NameMessageRecived;
    public class ClassClient
    {
        public static WebSocket ws = new WebSocket("ws://127.0.0.1:8181");
        public static void OpenThred()
        {
            ws.MessageReceived += MessageRecived;
            bool ok = true;
            while (true)
            {
                if (ws.State != WebSocketState.Open && !ok)
                {
                    ok = true;
                    ws.Open();
                }
                else
                    ok = false;
                
                Thread.Sleep(2500);
            }
        }
        public static void Close()
        {
            ws.Close();
        }
        static void MessageRecived(object sender, MessageReceivedEventArgs e)
        {
            ClassJson json = JsonConvert.DeserializeObject<ClassJson>(e.Message);
            switch (json.id) 
            {
                case 1:
                    {
                        ClassMessageRecived.ClassOne.One(json);
                        break;
                    }
                case 2:
                    {
                        ClassMessageRecived.ClassTwo.Two(json);
                        break;
                    }
                case 3:
                    {
                        ClassMessageRecived.ClassThree.Three(json);
                        break;
                    }
            }
        }
    }
}