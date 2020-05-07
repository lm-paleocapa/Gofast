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
            typingBoxUser.text = "Username";
            typingBoxPassword.text = "Password";
            typingBoxConfirmPassword.text = "Confirm password";
            typingBoxMail.text = "Mail";
            numericUpDown.Value = 1;
            userImage = "";

            panelDown.Invoke(new Action(() =>
            {
                panelDown.Size = new Size(463, 493);
                foreach (UserControl i in panelDown.Controls)
                    i.Visible = false;
                panelDown.Controls.Add(Form1.loginPage);
                Form1.loginPage.Show();
            }));
        }
        public static string userImage { get; set; }
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
                typingBoxUser.labelErrorControl.Text = "Insert a username";
                typingBoxUser.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxUser.labelErrorControl.Visible = true;
                ok = true;
            }
            #endregion

            #region mail
            if (string.IsNullOrEmpty(typingBoxMail.text) || typingBoxMail.text == "Mail")
            {
                typingBoxMail.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxMail.labelErrorControl.Text = "Insert a mail";
                typingBoxMail.labelErrorControl.Visible = true;
                ok = true;
            }
            else if (!isEmail(typingBoxMail.text))
            {
                typingBoxMail.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxMail.labelErrorControl.Text = "Invalid mail";
                typingBoxMail.labelErrorControl.Visible = true;
                ok = true;
            }
            #endregion

            if (numericUpDown.Value < 16)
            {
                ok = true;
                labelNumberError.Visible = true;
            }

            #region Password
            if (string.IsNullOrEmpty(typingBoxPassword.text) || typingBoxPassword.text == "Password")
            {
                typingBoxPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxPassword.labelErrorControl.Text = "Insert a password";
                typingBoxPassword.labelErrorControl.Visible = true;
                ok = true;
            }
            else if (typingBoxPassword.text.Length < 8)
            {
                typingBoxPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxPassword.labelErrorControl.Text = "Password too short";
                typingBoxPassword.labelErrorControl.Visible = true;
                ok = true;
            }

            if (string.IsNullOrEmpty(typingBoxConfirmPassword.text) || typingBoxConfirmPassword.text == "Confirm password")
            {
                typingBoxConfirmPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxConfirmPassword.labelErrorControl.Text = "Insert the confirm password";
                typingBoxConfirmPassword.labelErrorControl.Visible = true;
                ok = true;
            }
            else if (typingBoxConfirmPassword.text != typingBoxPassword.text)
            {
                typingBoxConfirmPassword.labelErrorControl.ForeColor = SystemColors.ControlLightLight;
                typingBoxConfirmPassword.labelErrorControl.Text = "Invalid confirm password";
                typingBoxConfirmPassword.labelErrorControl.Visible = true;
                ok = true;
            }
            #endregion

            if (!ok)
            {
                if (userImage == null)
                    userImage = "iVBORw0KGgoAAAANSUhEUgAAADAAAAAwCAYAAABXAvmHAAAABmJLR0QA/wD/AP+gvaeTAAABmElEQVRoge3Yv05UQRiG8Z8al0QTjaG1sRIFLgC9CTvopTdciAYi0U5q1FIbUTuvANBQkWALyQakg6zFOZsY2HPcnRmY1cyTvNXuzPd8J1/m/KFQKBT+N2axgi38qrOFZcxk9PorE3iFU/QacoJVdDI5NjKBr5rFz+aLMWviteHl+3mZxXQAs9rHpm2cpmOLX43dAIuB+1zD0wT1o9k2+tXvZzOD7zmOhDdwGFs8xQj1Mq1FmgZ+Rqzdiy2eooGNiLWfEtSPZkZ1JIYcow8z+A5k1egNrGQxbaCDz4aX38D1LKYtdFSPB23jdKK68mMn/yfTeKG6SR3V2cRzYzTzhUKhkIYrifZ4gMeqY/I+7mESt+r/HOIAu9jBd3zDDwmeSEO4iXm8x77w94F9vKv3unEZ4lNYw3GEdFOO8aaukZy7eCvs5X3UnGK9rpmEJ+LGJDRdLMTKL2UQP5tnofKPXM7IDDNScyENfBwD+X4+NEm23Qe6uD1i0xdFF3cG/dDWQO9iXIIZ6Jriq0RWSgO5+ecbKBQKhbz8BlwQZA0cAiNhAAAAAElFTkSuQmCC";
                buttonRegister.Enabled = false;
                JSON json = new JSON
                {
                    id = 3,
                    username = typingBoxUser.text,
                    password = typingBoxPassword.text,
                    age = (int)numericUpDown.Value,
                    image = userImage,
                    mail = typingBoxMail.text
                };
                string to = JsonConvert.SerializeObject(json);
                WS.Send(to);
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
            pictureBoxRemove.Visible = false;
            pictureBox.Image = null;
        }
        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            labelNumberError.Visible = false;
        }
        private void RegisterPage_Load(object sender, EventArgs e)
        {
            WS.ClassFour.btn = buttonRegister;
        }
    }
}