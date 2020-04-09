using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GoFast
{
    public partial class MainPage : ContentPage
    {
        public void csuads()
        {
            List<string> friends = new List<string>();
            friends.Add("sad");
            friends.Add("sad");

            StackLayout stackLayout = new StackLayout();

            foreach (var i in friends)
            {
                Button btn = new Button
                {
                    Text = "sdsasa"
                };
                stackLayout.Children.Add(btn);
            }
            
            
            Content = new ScrollView
            {
                Content = stackLayout
            };
        }

        public MainPage()
        {
            csuads();
        }
    }
}