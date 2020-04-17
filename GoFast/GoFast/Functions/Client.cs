using System;
using Newtonsoft.Json;
using WebSocket4Net;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading;
using Xamarin.Essentials;

namespace GoFast
{
    public class webSocket
    {
        public static WebSocket ws = new WebSocket("ws://79.24.89.93:8181");
        public static void WsOpen()
        {
            ws.MessageReceived += WsMessage;
            ws.Open();
        }

        public static void WsClose()
        {
            ws.Close();
        }

        static void WsMessage(object sender, MessageReceivedEventArgs e)
        {
            Json json0 = JsonConvert.DeserializeObject<Json>(e.Message);

            switch (json0.id)
            {
                case 1: // Login accettato
                    {
                        Pages.Element.friends = json0.friends;
                        Pages.Element.messages = json0.messages;

                        MainThread.BeginInvokeOnMainThread(() =>
                        {
                            Application.Current.MainPage = new NavigationPage(new Pages.FriendsAndGroups());
                        });


                        Json json1 = new Json
                        {
                            id = 2
                        };
                        string ToServer = JsonConvert.SerializeObject(json1);
                        ws.Send(ToServer);

                        break;
                    }
                case 2: // Login non accettato
                    {
                        if (!json0.uok)// utente non trovato
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                Application.Current.MainPage.DisplayAlert("Error","Utente non trovato","ok");
                                Pages.Login.btnLogin.IsEnabled = true;
                            });
                        }

                        if (json0.uok && !json0.pok)// utente ok, password errata
                        {
                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                Application.Current.MainPage.DisplayAlert("Error", "Password errata", "ok");
                                Pages.Login.btnLogin.IsEnabled = true;
                            });
                        }
                        break;
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
            public List<Message> messages { get; set; }
        }

        public class Friend
        {
            public string image { get; set; }
            public string user { get; set; }
        }

        public class Message
        {
            public string user { get; set; }
            public DateTime date { get; set; }
            public string text { get; set; }
        }
    }
}