namespace OfficialChat.Chat.Controls
{
    using OfficialChat.Lib.Client;
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class addFriends : UserControl
    {
        public addFriends()
        {
            InitializeComponent();
        }
        private int i = -210;
        private int k = 0;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Form1.MainChat.dropdownlist.Visible = false;
            User.isCollapsed = true;
            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (k <= 0 && k >= -620)
            {
                Form1.MainChat.myUser.panelAddUser.Location = new Point(0,k);
                k -= 20;
            }
            else if (Form1.MainChat.ControlMain.Location.X < 0)
            {
                Form1.MainChat.ControlMain.Location = new Point(i,0);
                i += 10;
            }
            else
            {
                timer.Stop();
                i = -210;
                k = 0;
            }
        }
        private void textboxSearch_OnTextChange(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxSearch.text) || textboxSearch.text == "Search...")
            {
                JSON json = new JSON
                {
                    id = 4,
                    username = Form1.username,
                    message = textboxSearch.text,
                };
                WS.Send(json);
            }
        }
        private void addFriends_Load(object sender, EventArgs e)
        {
            WS.ClassSix.panel = panelForUser;
        }
        private void textboxSearch_Enter(object sender, EventArgs e)
        {
            if (textboxSearch.text == "Search...")
            textboxSearch.text = "";
        }
        private void textboxSearch_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxSearch.text))
            textboxSearch.text = "Search...";
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            List<FRIENDS> users = new List<FRIENDS>();

            foreach (userToAdd i in panelForUser.Controls)
                if (i.userChecked)
                {
                    FRIENDS item = new FRIENDS
                    {
                        user = i.name
                    };
                    users.Add(item);                
                }

            JSON json = new JSON()
            {
                id = 5,
                username = Form1.username,
                friends = users
            };
            WS.Send(json);
            textboxSearch.text = "Search...";
            panelForUser.Controls.Clear();
        }
    }
}