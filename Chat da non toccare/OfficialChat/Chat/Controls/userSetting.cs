namespace OfficialChat.Chat.Controls
{
    using OfficialChat.Lib.Client;
    using System.Drawing;
    using System.Windows.Forms;
    using System;
    using System.IO;
    using OfficialChat.Properties;
    public partial class userSetting : UserControl
    {
        public static string mailFromDb;
        public static string actualMail;
        public Image defaultImage;
        private bool imageSet = false;
        public static string img;

        public Image userImage
        {
            get
            {
                return profileImage.Image;
            }
            set
            {
                profileImage.Image = value;
            }
        }
        public userSetting()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ps = false;
            bool mail = false;

            if (mailFromDb != actualMail && !string.IsNullOrEmpty(textBoxMail.Text))
                mail = true;

            if (textboxPassword.Text != "Password" && textboxPassword.Text != "" && textboxConfirmPassword.Text != "Confirm password" && textboxConfirmPassword.Text != "")
            {
                if (textboxConfirmPassword.Text == textboxPassword.Text && textboxPassword.Text.Length >= 8)
                    ps = true;
                else
                {
                    MessageBox.Show("Error: Password");
                }
            }

            if (ps && mail)
            {
                JSON json = new JSON
                {
                    id = 6,
                    username = Form1.username,
                    mail = textBoxMail.Text,
                    password = textboxConfirmPassword.Text
                };
                WS.Send(json);
            }
            else if (ps && !mail)
            {
                JSON json = new JSON
                {
                    id = 6,
                    username = Form1.username,
                    password = textboxConfirmPassword.Text
                };
                WS.Send(json);
            }
            else if (!ps && mail)
            {
                JSON json = new JSON
                {
                    id = 6,
                    username = Form1.username,
                    mail = textBoxMail.Text
                };
                WS.Send(json);
            }
            textboxPassword.Text = "Password";
            textboxConfirmPassword.Text = "Confirm password";
            textboxConfirmPassword.isPassword = false;
            textboxPassword.isPassword = false;
            textBoxMail.Text = "Mail";

            if (imageSet)
            {
                JSON json = new JSON
                {
                    id = 7,
                    image = img,
                    username = Form1.username
                };
                WS.Send(json);
            }
        }
        public static Panel panelDown;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            panelDown.Size = new Size(876, 612);
            Form1.MainChat.Visible = true;
            panelDown.Controls.Add(Form1.MainChat);
        }
        private void textboxPassword_Enter(object sender, EventArgs e)
        {
            if (textboxPassword.Text == "Password")
                textboxPassword.Text = "";
        }
        private void textboxPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxPassword.Text))
                textboxPassword.Text = "Password";
        }
        private void textboxConfirmPassword_Enter(object sender, EventArgs e)
        {
            if (textboxConfirmPassword.Text == "Confirm password")
                textboxConfirmPassword.Text = "";
        }
        private void textboxConfirmPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textboxConfirmPassword.Text))
                textboxConfirmPassword.Text = "Confirm password";
        }
        private void textBoxMail_OnValueChanged(object sender, EventArgs e)
        {
            actualMail = textBoxMail.Text;
        }
        private void textboxPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxPassword.Text != "Password" || string.IsNullOrEmpty(textboxPassword.Text))
                textboxPassword.isPassword = true;
            else
                textboxPassword.isPassword = false;
        }
        private void textboxConfirmPassword_OnValueChanged(object sender, EventArgs e)
        {
            if (textboxConfirmPassword.Text != "Confirm password" || string.IsNullOrEmpty(textboxConfirmPassword.Text))
                textboxConfirmPassword.isPassword = true;
            else
                textboxConfirmPassword.isPassword = false;
        }
        private void textBoxMail_Enter(object sender, EventArgs e)
        {
            if (textBoxMail.Text == "Mail")
                textBoxMail.Text = "";
        }
        private void textBoxMail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMail.Text))
                textBoxMail.Text = "Mail";
        }
        private void profileImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Select image";
            fileDialog.Filter = "PNG image (*.png)|*.png|JPEG image (*.jpeg)|*.jpeg";
            string path = null;
            if (fileDialog.ShowDialog() == DialogResult.OK)
                path = fileDialog.FileName;
            else return;

            Image image = Image.FromFile(path);
            MemoryStream m = new MemoryStream();
            image.Save(m, image.RawFormat);
            byte[] imageBytes = m.ToArray();
            img = Convert.ToBase64String(imageBytes);

            defaultImage = image;
            profileImage.Image = image;
            imageSet = true;
        }
        private void profileImage_MouseEnter(object sender, EventArgs e)
        {
            profileImage.Image = Resources.icons8_edit_90;
        }
        private void profileImage_MouseLeave(object sender, EventArgs e)
        {
            profileImage.Image = defaultImage;
        }
    }
}