namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using OfficialChat.Lib.Client;
    using OfficialChat.Properties;
    public partial class dropdownList : UserControl
    {
        public dropdownList()
        {
            InitializeComponent();
        }
        public static Panel panelDown;
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            panelDown.Controls.Clear();
            panelDown.Size = new Size(463, 493);
            Form1.loginPage = new Login.LoginPage();
            panelDown.Controls.Add(Form1.loginPage);
        }
        public static PictureBox img;
        private void btnProfileSetting_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            User.isCollapsed = true;

            img.Invoke(new Action(() =>
            {
                img.Image = Resources.icons8_menu_2_30;
            }));

            Form1.MainChat.Invoke(new Action(() =>
            {
                Form1.MainChat.Visible = false;
            }));

            panelDown.Invoke(new Action(() =>
            {
                WS.panelUserSetting.Visible = true;
                panelDown.Size = new Size(400, 450);
                panelDown.Controls.Add(WS.panelUserSetting);
            }));
        }
        private void friendshipRequest_Click(object sender, EventArgs e)
        {

        }
    }
}