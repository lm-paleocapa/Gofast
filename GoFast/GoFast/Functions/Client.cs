using System;
using Newtonsoft.Json;
using WebSocket4Net;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Threading;
using Xamarin.Essentials;
using System.Drawing;
using System.IO;

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

        public static List<Messages> messagesList = new List<Messages>(); // Messaggi che devono essere caricati dentro le chat

        static void WsMessage(object sender, MessageReceivedEventArgs e)
        {
            Json json0 = JsonConvert.DeserializeObject<Json>(e.Message);

            switch (json0.id)
            {
                case 1: // Login accettato
                    {
                        if (json0.pok && json0.uok)
                        {
                            Pages.Element.friends = json0.friends;
                            string base64Image = json0.image;

                            byte[] Base64Stream = Convert.FromBase64String(base64Image);
                            //XAML.Source = ImageSource.FromStream(() => new MemoryStream(Base64Stream)); Invece di XAML mettere il nome della posizione dell'immagine dell'utente conesso

                            MainThread.BeginInvokeOnMainThread(() =>
                            {
                                Application.Current.MainPage = new NavigationPage(new Pages.FriendsAndGroups());
                            });
                        }
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
                case 3: // Messaggio in entrata
                    {
                        Messages message = new Messages
                        {
                            messageType = json0.messageType,
                            message = json0.message,
                            date = json0.date,
                            from = json0.from,
                        };
                        messagesList.Add(message);
                        break;
                    }
            }

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
        public class Friend
        {
            public string image { get; set; }
            public string user { get; set; }
        }
        public class Messages
        {
            public string from { get; set; }
            public DateTime date { get; set; }
            public string message { get; set; }
            public string messageType { get; set; }
        }
    }
}