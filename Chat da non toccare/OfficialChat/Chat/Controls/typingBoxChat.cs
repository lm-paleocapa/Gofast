namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using System.Threading;
    using OfficialChat.Lib;
    using OfficialChat.Lib.Client;

    using Newtonsoft.Json;
    using OfficialChat.Properties;

    public partial class typingBoxChat : UserControl
    {
        public typingBoxChat()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Arrounder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private static int n = 0;
        private void box_OnValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(box.Text))
            {
                pictureBox.Visible = true;
                if (n == 0)
                {
                    Size size = new Size();
                    size.Width = box.Width - 40;
                    size.Height = box.Height;
                    box.Size = size;
                    n++;
                }
            }
            else
            {
                pictureBox.Visible = false;
                if (n == 1)
                {
                    Size size = new Size();
                    size.Width = box.Width + 40;
                    size.Height = box.Height;
                    box.Size = size;
                    n--;
                }
            }
        }
        private void typingBox_Load(object sender, EventArgs e)
        {

        }

        private void box_Click(object sender, EventArgs e)
        {
            if (Form1.MainChat.dropdownlist.Visible)
            {
                Form1.MainChat.dropdownlist.Visible = false;
                Form1.MainChat.myUser.setting.Image = Resources.icons8_menu_2_30;
            }
        }
    }
}