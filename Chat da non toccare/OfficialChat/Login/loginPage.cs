namespace OfficialChat.Login
{
    using System;
    using System.Windows.Forms;
    using Lib.Client;
    using System.Drawing;
    using OfficialChat.Chat;
    public partial class LoginPage : UserControl
    {
        bool ok = true;
        public bool controlEnabled
        {
            get
            {
                return ok;
            }
            set
            {
                ok = value;
                tbPass.Enabled = ok;
                tbUsername.Enabled = ok;
                buttonLogin.Enabled = ok;
            }
        }
        public LoginPage()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (tbPass.Text == "Password" || string.IsNullOrEmpty(tbPass.Text))
            {
                lbPassword.ForeColor = SystemColors.ControlLightLight;
                lbPassword.Text = "Insert the password";
                lbPassword.Visible = true;
                ok = true;
            }
            if (tbPass.Text.Length < 8)
            {
                lbPassword.ForeColor = SystemColors.ControlLightLight;
                lbPassword.Text = "Password too short";
                lbPassword.Visible = true;
                ok = true;
            }

            if (tbUsername.Text == "Username" || string.IsNullOrEmpty(tbUsername.Text))
            {
                lbUsername.ForeColor = SystemColors.ControlLightLight;
                lbUsername.Text = "Inser the username";
                lbUsername.Visible = true;
                ok = true;
            }
            if (!ok)
            {
                controlEnabled = false;

                JSON json = new JSON
                {
                    id = 1,
                    username = tbUsername.Text,
                    password = tbPass.Text
                };
                WS.Send(json);

                mainChatControl.from = tbUsername.Text;
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
        private void LoginPage_Load(object sender, EventArgs e) // da rimuovere
        {
           
        }
        private void tbUsername_Enter(object sender, EventArgs e)
        {
            if (tbUsername.Text == "Username")
                tbUsername.Text = "";
        }
        private void tbUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
                tbUsername.Text = "Username";
        }
        private void tbPass_Enter(object sender, EventArgs e)
        {
            if (tbPass.Text == "Password")
                tbPass.Text = "";
        }
        private void tbPass_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text))
                tbPass.Text = "Password";
        }
        private void passChanged(object sender, EventArgs e)
        {
            if (tbPass.Text != "Password" || tbPass.Text != "")
                tbPass.isPassword = true;
            else
                tbPass.isPassword = false;
            if (lbPassword.Visible)
                lbPassword.Visible = false;
        }
        private void userChangeed(object sender, EventArgs e)
        {
            if (lbUsername.Visible)
                lbUsername.Visible = false;
        }
    }
}