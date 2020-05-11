namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficialChat.Properties;
    public partial class User : UserControl
    {
        public PictureBox setting
        {
            get
            {
                return pictureSetting;
            }
            set
            {
                pictureSetting = value;
            }
        }
        public Image image
        {
            get
            {
                return pictureBox.Image;
            }
            set
            {
                pictureBox.Image = value;
            }
        }
        public User()
        {
            InitializeComponent();
        }
        bool isCollapsed = true;
        private Image icon1 = Resources.icons8_menu_2_30;
        private Image icon2 = Resources.icons8_menu_2_30_1_;
        private void pictureSetting_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                pictureSetting.Image = icon2;
                Form1.MainChat.dropdownlist.Visible = true;
                isCollapsed = false;
            }
            else
            {
                pictureSetting.Image = icon1;
                Form1.MainChat.dropdownlist.Visible = false;
                isCollapsed = true;
            }
        }
        private void pictureSetting_MouseEnter(object sender, EventArgs e)
        {
            if (isCollapsed)
            pictureSetting.Image = icon2;
        }
        private void pictureSetting_MouseLeave(object sender, EventArgs e)
        {
            if (isCollapsed && !Form1.MainChat.dropdownlist.Visible)
            pictureSetting.Image = icon1;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureboxAdd.Image = Resources.Cose;
        }
        private void pictureboxAdd_MouseLeave(object sender, EventArgs e)
        {
            pictureboxAdd.Image = Resources.icons8_plus_math_30;
        }
        private void pictureboxAdd_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void User_Load(object sender, EventArgs e)
        {
            Form1.MainChat.objectLeft.Controls.Add(panelAddUser);
        }
        private int i = 0;
        private int k = -620;
        public addFriends panelAddUser = new addFriends()
        {
            Location = new Point(0,-620)
        };
        private void timer_Tick(object sender, EventArgs e)
        {
            if (i < 220)
            {
                Form1.MainChat.ControlMain.Location = new Point(i * -1, 0);
                i += 10;
            }
            else if (panelAddUser.Location.Y < 0)
            {
                panelAddUser.Location = new Point(0,k);
                k += 20;
            }
            else
            {
                timer.Stop();
                k = -620;
                i = 0;
            }
        }
    }
}