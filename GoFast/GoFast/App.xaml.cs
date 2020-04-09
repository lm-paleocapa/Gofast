using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GoFast
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new Pages.Login());
        }

        protected override void OnStart()
        {
            webSocket.WsOpen();
        }

        protected override void OnSleep()
        {
            webSocket.WsClose();
        }

        protected override void OnResume()
        {
            
        }
    }
}
