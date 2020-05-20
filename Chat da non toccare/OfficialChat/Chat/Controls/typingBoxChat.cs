namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using OfficialChat.Lib;
    using OfficialChat.Lib.Client;
    using OfficialChat.Properties;
    public partial class typingBoxChat : UserControl
    {
        public typingBoxChat()
        {
            InitializeComponent();
            Region = Region.FromHrgn(Arrounder.CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
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
        private void box_Click(object sender, EventArgs e)
        {
            timer.Start();
            if (Form1.MainChat.dropdownlist.Visible)
            {
                Form1.MainChat.dropdownlist.Visible = false;
                Form1.MainChat.myUser.setting.Image = Resources.icons8_menu_2_30;
            }
            if (!string.IsNullOrEmpty(box.Text))
            {
                foreach (Panel i in Form1.MainChat.flowLayoutPanelChat.Controls)
                {
                    if (i.Name == Form1.MainChat.nameOfUserSelected)
                    {
                        MeBubble bubble = new MeBubble
                        {
                            Body = box.Text,
                            Dock = DockStyle.Bottom
                        };
                        i.Invoke(new Action(() => i.Controls.Add(bubble)));

                        JSON json = new JSON
                        {
                            id = 2,
                            date = DateTime.Now.ToString(),
                            message = box.Text,
                            messageType = "string",
                            to = i.Name,
                            from = Form1.username
                        };
                        WS.Send(json);
                    }
                }
            }
            box.Text = "";
        }
        int i = 0;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pictureBox.Image = Resources._330407_32_1_;

                i++;
            }
            else if (i == 1)
            {
                pictureBox.Image = Resources._330407_321;
                i++;
            }
            else
            {
                pictureBox.Image = Resources._330407_32_1_;
                i = 0;
                timer.Stop();
            }
        }
        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            pictureBox.Image = Resources._330407_321;
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            pictureBox.Image = Resources._330407_32_1_;
        }
    }
}