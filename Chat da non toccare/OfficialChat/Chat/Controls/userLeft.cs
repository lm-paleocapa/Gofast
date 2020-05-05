namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Windows.Forms;
    using System.Drawing;
    public partial class userLeft : UserControl
    {
        public userLeft()
        {
            InitializeComponent();
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
        private Random rnd = new Random();
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
    }
}