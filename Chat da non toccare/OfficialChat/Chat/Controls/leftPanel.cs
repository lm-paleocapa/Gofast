namespace OfficialChat.Chat.Controls
{
    using OfficialChat.Properties;
    using System;
    using System.Windows.Forms;
    public partial class leftPanel : UserControl
    {
        public leftPanel()
        {
            InitializeComponent();
        }
        public Panel Users
        {
            get
            {
                return panelForUser;
            }
            set
            {
                panelForUser = value;
            }
        }
        private void bunifuTextbox1_Click(object sender, EventArgs e)
        {
            textboxSearch.text = "";
            if (Form1.MainChat.dropdownlist.Visible)
            {
                Form1.MainChat.dropdownlist.Visible = false;
                Form1.MainChat.myUser.setting.Image = Resources.icons8_menu_2_30;
            }
        }
        private void textboxSearch_OnTextChange(object sender, EventArgs e)
        {
            string text = textboxSearch.text;
            if (string.IsNullOrEmpty(text))
                foreach (userLeft i in panelForUser.Controls)
                    i.Visible = true;
            else
            foreach (userLeft i in panelForUser.Controls)
                if (text.ToLower().Contains(i.name.ToLower()))
                    i.Visible = true;
                else
                    i.Visible = false;
        }
        private void textboxSearch_Leave(object sender, EventArgs e)
        {
            textboxSearch.text = "Search...";
            foreach (userLeft i in panelForUser.Controls)
                i.Visible = true;
        }
    }
}