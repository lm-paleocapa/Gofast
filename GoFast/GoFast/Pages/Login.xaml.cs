using System;
using System.Collections.Generic;
using Xamarin.Forms;
using WebSocket4Net;
using Newtonsoft.Json;

namespace GoFast.Pages
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        public static Button btnLogin;
        void ButtonLoginClick(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(EntryUsername.Text) && string.IsNullOrEmpty(EntryPassword.Text))
            {
                DisplayAlert("Error", "Inserire una password e un nome utente", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(EntryUsername.Text))
            {
                DisplayAlert("Error", "Inserire un nome utente", "Ok");
                return;
            }
            if (string.IsNullOrEmpty(EntryPassword.Text))
            {
                DisplayAlert("Error", "Inserire una password", "Ok");
                return;
            }else if (EntryPassword.Text.Length < 8)
            {
                DisplayAlert("Error", "Password troppo corta", "Ok");
                return;
            }

            btnLogin = sender as Button;
            webSocket.Json json = new webSocket.Json
            {
                id = 1,
                username = EntryUsername.Text,
                password = EntryPassword.Text
            };
            string Login = JsonConvert.SerializeObject(json);
            webSocket.ws.Send(Login);
            ButtonLogin.IsEnabled = false;
        }
    }
}
