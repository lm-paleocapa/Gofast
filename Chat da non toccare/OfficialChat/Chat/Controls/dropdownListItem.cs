namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficialChat.Properties;
    public partial class dropdownListItem : UserControl
    {
        public string itemName
        {
            get
            {
                return labelItem.Text;
            }
            set
            {
                labelItem.Text = value;
            }
        }
        public Image itemImage
        {
            get
            {
                return pictureboxItem.Image;
            }
            set
            {
                pictureboxItem.Image = value;
            }
        }
        public dropdownListItem()
        {
            InitializeComponent();
        }

        private void dropdownListItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(70,70,70);
            labelItem.ForeColor = Color.FromArgb(217, 179, 16);
        }
        private void dropdownListItem_MouseLeave(object sender, EventArgs e)
        {
            labelItem.ForeColor = SystemColors.ControlLightLight;
            this.BackColor = Color.FromArgb(50, 50, 50);
        }
        public static Panel panelDown;
        public static PictureBox img;
        private void labelItem_Click(object sender, EventArgs e)
        {
            if (this.Name == "btnProfileSetting")
            {
                Form1.MainChat.dropdownlist.Visible = false;
                User.isCollapsed = true;
                img.Image = Resources.icons8_menu_2_30;
                Form1.MainChat.Visible = false;
                Form1.panelUserSetting.Visible = true;
                panelDown.Size = new Size(400, 450);
                panelDown.Controls.Add(Form1.panelUserSetting);
            }
            else if (this.Name == "btnLogOut")
            {
                panelDown.Controls.Clear();
                panelDown.Size = new Size(463, 493);
                Form1.loginPage = new Login.LoginPage();
                panelDown.Controls.Add(Form1.loginPage);
            }
            else if (this.Name == "friendshipRequest")
            {
                Form1.MainChat.dropdownlist.Visible = false;
                User.isCollapsed = true;
                img.Image = Resources.icons8_menu_2_30;
                Form1.MainChat.Visible = false;
                panelDown.Size = new Size(314, 525);
                Form1.rq.Visible = true;
                panelDown.Controls.Add(Form1.rq);
            }
        }
    }
}