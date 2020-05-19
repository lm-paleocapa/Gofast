namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    using OfficialChat.Properties;
    public partial class userLeft : UserControl
    {
        public bool hover { get; set; }
        public userLeft()
        {
            InitializeComponent();
        }
        public bool LA
        {
            get
            {
                return labelLastAccess.Visible;
            }
            set
            {
                labelLastAccess.Visible = value;
            }
        }
        public BorderStyle Border
        {
            get
            {
                return this.BorderStyle;
            }
            set
            {
                this.BorderStyle = value;
            }
        }
        public string name
        {
            get
            {
                return labelUsername.Text;
            }
            set
            {
                labelUsername.Text = value;
            }
        }
        public string lastAccess
        {
            get
            {
                return labelLastAccess.Text;
            }
            set
            {
                labelLastAccess.Text = value;
            }
        }
        public Image picture
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
        private void userLeft_Click(object sender, EventArgs e)
        {
            if (Form1.MainChat.dropdownlist.Visible)
            {
                Form1.MainChat.dropdownlist.Visible = false;
                Form1.MainChat.myUser.setting.Image = Resources.icons8_menu_2_30;
            }

            Form1.MainChat.nameOfUserSelected = this.name;
            Form1.MainChat.imageOfUserSelected = picture;
            Form1.MainChat.lastAccessOfUserSelected = lastAccess;

            Form1.MainChat.panelUserSelected.Visible = true;

            mainChatControl.To = this.name;
            Form1.MainChat.panelTypingBox.Visible = true;
            foreach (Panel i in Form1.MainChat.flowLayoutPanelChat.Controls)
            {
                if (i.Name == this.name)
                {
                    i.Show();
                }
                else
                {
                    i.Hide();
                }
            }
        }
        private void userLeft_Load(object sender, EventArgs e)
        {
            int width = Form1.MainChat.flowLayoutPanelChat.Size.Width;
            int height = Form1.MainChat.flowLayoutPanelChat.Size.Height;

            Panel panelChat = new Panel
            {
                Name = this.name,
                Visible = false,
                Size = new Size(width, height)
            };
            Form1.MainChat.flowLayoutPanelChat.Controls.Add(panelChat);
        }
        private void userLeft_MouseEnter(object sender, EventArgs e)
        {
            if (!hover)
            this.BackColor = Color.FromArgb(69, 79, 89);
        }
        private void userLeft_MouseLeave(object sender, EventArgs e)
        {
            if (!hover)
            this.BackColor = Color.FromArgb(49, 59, 69);
        }
    }
}