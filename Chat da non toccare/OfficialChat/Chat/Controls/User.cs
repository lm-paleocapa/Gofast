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
        bool isCollpsed = false;
        private Image icon1 = Resources.icons8_menu_2_30;
        private Image icon2 = Resources.icons8_menu_2_30_1_;
        private void pictureSetting_Click(object sender, EventArgs e)
        {
            if (!isCollpsed == true)
            {
                pictureSetting.Image = icon2;
                Form1.MainChat.dropdownlist.Visible = true;
                isCollpsed = false;
            }
            else
            {
                pictureSetting.Image = icon1;
                Form1.MainChat.dropdownlist.Visible = false;
                isCollpsed = true;
            }
        }
        private void pictureSetting_MouseEnter(object sender, EventArgs e)
        {
            if (!isCollpsed)
            pictureSetting.Image = icon2;
        }
        private void pictureSetting_MouseLeave(object sender, EventArgs e)
        {
            if (!isCollpsed && !Form1.MainChat.dropdownlist.Visible)
            pictureSetting.Image = icon1;
        }
    }
}