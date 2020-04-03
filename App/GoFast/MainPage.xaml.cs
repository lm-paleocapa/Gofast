using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Forms;
//using Newtonsoft.Json;
//using WebSocket4Net;

namespace GoFast
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
       // static WebSocket socket = new WebSocket("ws://"); // Da completare
        public MainPage()
        {
            InitializeComponent();

            //Thread threadBackGround = new Thread(BackGround);
            //threadBackGround.Start();
        }

        static void BackGround()
        {
            bool ok = false;
            while (true)
            {
                if (!ok)
                {
                    try
                    {
                        ok = true;
                       // socket.Open();
                    }
                    catch
                    {
                        //Errore di conessione al server
                    }
                }
            }
        }

        #region FirstPage

        static Json0 json = new Json0();
        static string user = "";
        static string password = "";

        void FocusedUsername(object sender, FocusEventArgs e)
        {
            Entry entry = sender as Entry;
            if (entry.Text == "Username")
                entry.Text = "";

            user = entry.Text;
        }
        void UnfocusedUsername(object sender, FocusEventArgs e)
        {
            Entry entry = sender as Entry;
            if (entry.Text == "")
                entry.Text = "Username";

            user = "";
        }
        void FocusedPassword(object sender, FocusEventArgs e)
        {
            Entry entry = sender as Entry;
            if (entry.Text == "Password")
            {
                entry.Text = "";
                entry.IsPassword = true;
            }

            password = entry.Text;
        }
        void UnfocusedPassword(object sender, FocusEventArgs e)
        {
            Entry entry = sender as Entry;
            if (entry.Text == "")
            {
                entry.Text = "Password";
                entry.IsPassword = false;
            }

            password = "";
        }

        static Button buttonLogin;
        void ClickLogin(object sender, ClickedEventArgs e)
        {
            /*
            if (user == "")
            {
                // Messaggio a schermo .
                return;
            }else if (password == "")
            {
                // Messaggio a schermo.
                return;
            }

            json.User = user;
            json.password = password;

            string attempLogin = JsonConvert.SerializeObject(json);

            socket.Send(attempLogin);

            password = "";
            user = "";
            */
            buttonLogin = sender as Button;
            buttonLogin.IsEnabled = false;
        }

        class Json0
        {
            public string id { get; set; }
            public string User { get; set; }
            public string password { get; set; }
            public bool ok { get; set; }
        }

        void Button_Clicked(System.Object sender, EventArgs e)
        {
            buttonLogin = sender as Button;
            buttonLogin.IsEnabled = false;
        }
        #endregion
    }
}