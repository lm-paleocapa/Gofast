namespace OfficialChat.Login
{
    using System;
    using System.Windows.Forms;
    using Lib.Client;
    using System.Drawing;
    using Newtonsoft.Json;
    using Controls;
    using OfficialChat.Chat;
    using Lib.Local;
    using System.Diagnostics;

    public partial class LoginPage : UserControl
    {
        public typingBox tbUser
        {
            get
            {
                return typingBoxUser;
            }
            set
            {
                typingBoxUser = value;
            }
        }
        public typingBox tbPassword
        {
            get
            {
                return typingBoxPassword;
            }
            set
            {
                typingBoxPassword = value;
            }
        }
        public LoginPage()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (typingBoxPassword.text == "Password" || string.IsNullOrEmpty(typingBoxPassword.text))
            {
                typingBoxPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxPassword.labelErrorControl.Text = "Insert the password";
                typingBoxPassword.labelErrorControl.Visible = true;
                ok = true;
            }
            if (typingBoxPassword.text.Length < 8)
            {
                typingBoxPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxPassword.labelErrorControl.Text = "Password too short";
                typingBoxPassword.labelErrorControl.Visible = true;
                ok = true;
            }

            if (typingBoxUser.text == "Username" || string.IsNullOrEmpty(typingBoxUser.text))
            {
                if (typingBoxUser.pictureBoxTop == 41 && typingBoxUser.typingBoxTop == 37)
                {
                    typingBoxUser.pictureBoxTop -= 15;
                    typingBoxUser.typingBoxTop -= 15;
                }
                typingBoxUser.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxUser.labelErrorControl.Text = "Inser the username";
                typingBoxUser.labelErrorControl.Visible = true;
                ok = true;
            }
            if (!ok)
            {
                JSON json = new JSON
                {
                    id = 1,
                    username = typingBoxUser.text,
                    password = typingBoxPassword.text
                };
                string to = JsonConvert.SerializeObject(json);
                WS.Send(to);

                mainChatControl.from = typingBoxUser.text;
                Form1.MainChat.myUser.name = typingBoxUser.text;

                if (radioButton.Checked)
                {
                    UserJ user = new UserJ
                    {
                        username = typingBoxUser.text,
                        password = typingBoxPassword.text
                    };
                    string s = JsonConvert.SerializeObject(user);

                    System.IO.File.WriteAllText("user.json", s);
                }
            }
        }
        private static int i = 0;
        private void radioButton_Click(object sender, EventArgs e)
        {
            if (radioButton.Checked && i == 0)
            {
                radioButton.Checked = false;
                i++;
            }
            else
            {
                radioButton.Checked = true;
                i--;
            }
        }
        public static Panel panelDown;
        private void labelSignUp_Click(object sender, EventArgs e)
        {
            panelDown.Invoke(new Action(() =>
            {
                panelDown.Size = new Size(463, 529);
                foreach (UserControl i in panelDown.Controls)
                    i.Visible = false;
                Form1.registerPage.Dock = DockStyle.Fill;
                panelDown.Controls.Add(Form1.registerPage);
                Form1.registerPage.Show();
            }));
        }
    }
}