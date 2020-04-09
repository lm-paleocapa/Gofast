using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace GoFast.Pages
{
    public class Element
    {
        public static List<webSocket.Friend> friends = new List<webSocket.Friend>();
        public static List<webSocket.Message> messages = new List<webSocket.Message>();
    }
    public partial class FriendsAndGroups : ContentPage
    {
        public FriendsAndGroups()
        {
            addFriends();
        }

        public void addFriends()
        {
            StackLayout stackLayout = new StackLayout();


            if (Element.friends.Count != 0)
            {
                foreach (var i in Element.friends)
                {
                    Button btn = new Button
                    {
                        Text = i.user
                    };
                    btn.Clicked += btnClick;
                    stackLayout.Children.Add(btn);
                }
            }
            else
            {
                DisplayAlert("Message", "non hai amici","ok");
            }
            
            Content = new ScrollView
            {
                Content = stackLayout
            };
        }

        static void btnClick(object sender, EventArgs e)
        {
            //apre la chat dell'utente selezionato
        }
    }
}