namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using OfficialChat.Lib.Client;
    using Properties;
    public partial class requestItem : UserControl
    {
        public string Username
        {
            get
            {
                return username.name;
            }
            set
            {
                username.name = value;
            }
        }
        public Image Image
        {
            get
            {
                return username.picture;
            }
            set
            {
                username.picture = value;
            }
        }
        public requestItem()
        {
            InitializeComponent();
        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userLeft user = new userLeft
            {
                name = this.Name,
                lastAccess = "Da mettere",
                picture = this.Image,
                Dock = DockStyle.Top
            };
            Form1.MainChat.panelUsers.Controls.Add(user);

            JSON json = new JSON
            {
                id = 8,
                username = Username
            };
            WS.Send(json);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.icons8_cancel_35_1_;
        }
        private void btnOk_MouseEnter(object sender, EventArgs e)
        {
            btnOk.Image = Resources.icons8_ok_35_1_;
        }
        private void btnOk_MouseLeave(object sender, EventArgs e)
        {
            btnOk.Image = Resources.icons8_ok_35;
        }
        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.icons8_cancel_35_1_;
        }
        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.Image = Resources.icons8_cancel_35;
        }
    }
}