namespace Chat
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using System.IO;
    using Newtonsoft.Json;
    using System.Threading;

    using NameClient;
    using NameMessageRecived;
    using NameJson;

    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
            Application.ApplicationExit += ApplicationClose;

            Thread thread = new Thread(new ThreadStart(ClassClient.OpenThred));
            thread.Start();
        }
        private static void ApplicationClose(object sender, EventArgs e)
        {
            ClassClient.Close();
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            ClassMessageRecived.ClassOne.listViewRecentChat = listViewChat_RecentChat;
            ClassMessageRecived.ClassOne.pictureBoxImage = pictureBoxImage_RecentChat;
            ClassMessageRecived.ClassOne.labelNoChats = labelNoFriendsOrChat_RecentChat;
            ClassMessageRecived.ClassOne.panelLogin = panelLogin;
            ClassMessageRecived.ClassOne.panelRecentChat = panelRecentChat;

            ClassMessageRecived.ClassTwo.labelPassword = labelPassword_Login;
            ClassMessageRecived.ClassTwo.labelUser = labelUser_Login;
            ClassMessageRecived.ClassTwo.tbUser = tbUser_Login;
            ClassMessageRecived.ClassTwo.tbPassword = tbPassword_Login;

            //if (File.Exists("Data"))
            //{
            //    panelRecentChat.Show();
            //    return;
            //}

            panelLogin.Show();
        }

        #region PanelLogin
        private void ChangeColorUser(object sender, EventArgs e)
        {
            if (labelUser_Login.ForeColor == Color.Red)
                labelUser_Login.ForeColor = default;
        }
        private void ChangeColorPassword(object sender, EventArgs e)
        {
            if (labelPassword_Login.ForeColor == Color.Red)
                labelPassword_Login.ForeColor = default;
        }
        private void btnLogin_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser_Login.Text) || string.IsNullOrEmpty(tbPassword_Login.Text))
            {
                if (string.IsNullOrEmpty(tbUser_Login.Text))
                {
                    labelUser_Login.ForeColor = Color.Red;
                }
                if (string.IsNullOrEmpty(tbPassword_Login.Text))
                {
                    labelPassword_Login.ForeColor = Color.Red;
                }
                return;
            }

            if (tbPassword_Login.Text.Length < 8)
            {
                labelPassword_Login.ForeColor = Color.Red;
                return;
            }

            if (rbtnRememberMe_Login.Checked)
            {
                string path = "Data";
                if (!File.Exists(path))
                {
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(tbUser_Login.Text);
                    writer.WriteLine(tbPassword_Login.Text);
                    writer.Close();
                }
                else
                {
                    File.Delete(path);
                    StreamWriter writer = new StreamWriter(path);
                    writer.WriteLine(tbUser_Login.Text);
                    writer.WriteLine(tbPassword_Login.Text);
                    writer.Close();
                }
            }
            else
            {
                if (File.Exists("Data"))
                {
                    File.Delete("Data");
                }
            }

            ClassJson json = new ClassJson
            {
                id = 1,
                username = tbUser_Login.Text,
                password = tbPassword_Login.Text
            };
            string ToServer = JsonConvert.SerializeObject(json);
            ClassClient.ws.Send(ToServer);
        }
        private void labelRegister_Login_Click(object sender, EventArgs e)
        {
            panelLogin.Hide();
            panelRecentChat.Show();
        }

        static int i = 2;
        private void rbtnRememberMe_Login_Click(object sender, EventArgs e)
        {
            if (rbtnRememberMe_Login.Checked && i % 2 == 0)
            {
                rbtnRememberMe_Login.Checked = false;
                i++;
            }
            else
                i++;
        }
        #endregion

        #region PanelRegister
        static string userImage;
        private void BtnImage_Register_Click(object sender, EventArgs e)
        {
            if (labelImage_Register.ForeColor == Color.Red)
                labelImage_Register.ForeColor = default;

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
        }
        private void btnBack_Register_Click(object sender, EventArgs e)
        {
            panelRegister.Hide();
            panelLogin.Show();
        }
        private void btnRegister_Register_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser_Register.Text))
                labelUser_Register.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(tbPassword_Register.Text))
                labelPassword_Login.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(tbCPassword_Register.Text))
                labelCPassword_Register.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(tbMail_Register.Text))
                labelMail_Register.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(userImage))
                labelImage_Register.ForeColor = Color.Red;

            ClassJson json = new ClassJson
            {
                //Preparare nel server la registrazione
            };
            string ToServer = JsonConvert.SerializeObject(json);
            ClassClient.ws.Send(ToServer);

            userImage = "";

            panelRegister.Hide();
            panelLogin.Show();
        }
        #endregion

        #region PanelRecentChat
        private void listViewChat_RecentChat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListViewItem item = sender as ListViewItem;

            // Proseguire all'apertura del pannello.
        }
        private void btnBack_RecentChat_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to exit?",
                       "Message", MessageBoxButtons.YesNo);
            switch (dr)
            {
                case DialogResult.Yes:
                    {
                        if (File.Exists("Data"))
                        {
                            StreamReader reader = new StreamReader("Data");
                            tbUser_Login.Text = reader.ReadLine();
                            tbPassword_Login.Text = reader.ReadLine();
                            reader.Close();
                        }

                        listViewChat_RecentChat.Items.Clear();

                        panelRecentChat.Hide();
                        panelLogin.Show();
                        break;
                    }
                case DialogResult.No:
                    {
                        break;
                    }
            }
        }
        #endregion

    }
}