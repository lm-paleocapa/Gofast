namespace OfficialChat.Register
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Lib.Client;
    using Newtonsoft.Json;
    public partial class RegisterPage : UserControl
    {
        public RegisterPage()
        {
            InitializeComponent();
        }
        public static Panel panelDown;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            panelDown.Invoke(new Action(() =>
            {
                panelDown.Size = new Size(463, 493);
                foreach (UserControl i in panelDown.Controls)
                    i.Visible = false;
                panelDown.Controls.Add(Form1.loginPage);
                Form1.loginPage.Show();
            }));
        }
        public static string userImage;
        private void buttonImage_Click_1(object sender, EventArgs e)
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
            userImage = Convert.ToBase64String(imageBytes);
            pictureBox.Image = Image.FromStream(m);
            pictureBoxRemove.Visible = true;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            bool ok = false;

            #region User
            if (string.IsNullOrEmpty(typingBoxUser.text) || typingBoxUser.text == "Username")
            {
                typingBoxUser.labelErrorControl.Text = "Inset a username";
                typingBoxUser.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxUser.labelErrorControl.Visible = true;
            }
            else
            {
                // Cerca nel db se il nome è già stato usato;
                //JSON json = new JSON
                //{

                //};
                //string to = JsonConvert.SerializeObject(json);
                //WS.Send(to);
            }
            #endregion

            #region mail
            if (string.IsNullOrEmpty(typingBoxMail.text) || typingBoxMail.text == "Mail")
            {
                typingBoxMail.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxMail.labelErrorControl.Text = "Insert a mail";
                typingBoxMail.labelErrorControl.Visible = true;
            }
            else if (!isEmail(typingBoxMail.text))
            {
                typingBoxMail.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxMail.labelErrorControl.Text = "Invalid mail";
                typingBoxMail.labelErrorControl.Visible = true;
            }
            #endregion

            if (numericUpDown.Value < 16)
                labelNumberError.Visible = true;

            if (!ok)
            {
                MessageBox.Show("Metti la registrazione");
                //JSON json = new JSON
                //{
                    
                //    // Register
                //};
                //string to = JsonConvert.SerializeObject(json);
                //WS.Send(to);
            }
        }
        private static bool isEmail(string inputEmail)
        {
            string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                  @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                  @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }
        private void pictureBoxRemove_Click(object sender, EventArgs e)
        {
            userImage = "";
            pictureBox.Visible = false;
            pictureBoxRemove.Visible = false;
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            labelNumberError.Visible = false;
        }
    }
}