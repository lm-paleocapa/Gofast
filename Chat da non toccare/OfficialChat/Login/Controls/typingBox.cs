namespace OfficialChat.Login.Controls
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    public partial class typingBox : UserControl
    {
        public typingBox()
        {
            InitializeComponent();
        }
        public string nameOfPanel { get; set; }
        public int pictureBoxTop
        {
            get
            {
                return pictureBox.Top;
            }
            set
            {
                pictureBox.Top = value;
            }
        }
        public Label labelErrorControl
        {
            get
            {
                return labelError;
            }
            set
            {
                labelError = value;
            }
        }
        public int errorTop
        {
            get
            {
                return labelError.Top;
            }
            set
            {
                labelError.Top = value;
            }
        }
        public int typingBoxTop
        {
            get
            {
                return textBox.Top;
            }
            set
            {
                textBox.Top = value;
            }
        }
        public string text
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public string hint { get; set; }
        public Image img
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
        public bool isPassword { get; set; }
        private void textBox_Enter(object sender, EventArgs e)
        {
            if (textBox.Text == hint)
            {
                textBox.Text = "";
                if (isPassword)
                textBox.isPassword = true;
            }
        }
        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text == "")
            {
                textBox.Text = hint;
                if (isPassword)
                textBox.isPassword = false;
            }
        }
        private void textBox_Clear(object sender, EventArgs e)
        {
            if (pictureBoxTop == 26 && typingBoxTop == 22 && nameOfPanel == "Login")
            {
                pictureBoxTop += 15;
                typingBoxTop += 15;
            }
            labelError.Visible = false;
        }
    }
}