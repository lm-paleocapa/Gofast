namespace OfficialChat
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Lib.Client;
    using Chat;
    using Login;
    using Register;
    using System.IO;
    using Newtonsoft.Json.Serialization;
    using Newtonsoft.Json;
    using OfficialChat.Chat.Controls;
    using OfficialChat.Properties;

    public partial class Form1 : Form
    {
        #region Cose
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        protected virtual void OnMouseDownMoveForm(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion
        public static string username = "";
        public Form1()
        {
            InitializeComponent();
        }
        public static mainChatControl MainChat = new mainChatControl();
        public static LoginPage loginPage = new LoginPage();
        public static RegisterPage registerPage = new RegisterPage();
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginPage.panelDown = panelDown;
            WS.ClassOne.panelForControl = panelDown;
            RegisterPage.panelDown = panelDown;
            WS.Open();

            if (File.Exists("user.json"))
            {
                StreamReader r = new StreamReader("user.json");
                string j = r.ReadToEnd();

                Lib.Local.UserJ user = JsonConvert.DeserializeObject<Lib.Local.UserJ>(j);

                JSON f = new JSON
                {
                    id = 1,
                    username = user.username,
                    password = user.password
                };

                string to = JsonConvert.SerializeObject(f);
                WS.Send(to);
            }
            else
            {
                panelDown.Controls.Clear();
                panelDown.Size = new Size(463, 493);
                panelDown.Controls.Add(loginPage);
            }
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            WS.Close();
            Application.Exit();
        }
        private void labelMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Red;
        }
        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = SystemColors.ControlLightLight;
        }
        private void labelMinimize_MouseEnter(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = Color.Gray;
        }
        private void labelMinimize_MouseLeave(object sender, EventArgs e)
        {
            labelMinimize.ForeColor = SystemColors.ControlLightLight;
        }
    }
}