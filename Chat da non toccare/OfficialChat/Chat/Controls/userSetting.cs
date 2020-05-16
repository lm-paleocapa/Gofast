namespace OfficialChat.Chat.Controls
{
    using OfficialChat.Lib.Client;
    using System.Drawing;
    using System.Windows.Forms;
    using System;
    public partial class userSetting : UserControl
    {
        public string mailChanged { get; set; }
        public string passChanged { get; set; }
        public Image userImage
        {
            get
            {
                return profileImage.Image;
            }
            set
            {
                profileImage.Image = value;
            }
        }
        public string password
        {
            get
            {
                return textBoxPassword.Text;
            }
            set
            {
                textBoxPassword.Text = value;
            }
        }
        public string mail
        {
            get
            {
                return textBoxMail.Text;
            }
            set
            {
                textBoxMail.Text = value;
            }
        }

        public userSetting()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMail.Text) || string.IsNullOrEmpty(textBoxPassword.Text) || textBoxPassword.Text == "Password"|| textBoxMail.Text == "Mail")
            {
                MessageBox.Show("Compila tutti i campi");
            }
            else
            {
                JSON json = new JSON
                {
                    id = 6,
                    username = Form1.username,
                    mail = textBoxMail.Text,
                    password = textBoxPassword.Text
                };
                WS.Send(json);
            }
        }
        public static Panel panelDown;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            panelDown.Invoke(new Action(() =>
            {
                panelDown.Size = new Size(876, 612);
                Form1.MainChat.Visible = true;
                panelDown.Controls.Add(Form1.MainChat);
            }));
        }
        private void userSetting_VisibleChanged(object sender, EventArgs e)
        {
            textBoxMail.Text = mail;
            textBoxPassword.Text = password;
        }
    }
}