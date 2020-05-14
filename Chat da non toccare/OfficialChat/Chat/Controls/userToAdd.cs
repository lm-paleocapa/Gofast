namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class userToAdd : UserControl
    {
        public bool userChecked
        {
            get
            {
                if (this.BackColor == Color.FromArgb(69, 79, 89))
                    return true;
                else
                    return false;
            }
            set
            {

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
        private int k = 0;
        private void userLeft_MouseEnter(object sender, EventArgs e)
        {
            if (k == 0)
                this.BackColor = Color.FromArgb(69, 79, 89);
        }
        private void userLeft_MouseLeave(object sender, EventArgs e)
        {
            if (k == 0)
                this.BackColor = Color.FromArgb(49, 59, 69);
        }
        public userToAdd()
        {
            InitializeComponent();
        }
        private void userToAdd_Click(object sender, EventArgs e)
        {
            if (k == 0)
            {
                k = 1;
                this.BackColor = Color.FromArgb(69, 79, 89);
                userChecked = true;
            }
            else
            {
                k = 0;
                this.BackColor = Color.FromArgb(49, 59, 69);
                userChecked = false;
            }
        }
    }
}