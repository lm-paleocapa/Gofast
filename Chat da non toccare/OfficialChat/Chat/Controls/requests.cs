namespace OfficialChat.Chat.Controls
{
    using System.Drawing;
    using System.Windows.Forms;
    public partial class requests : UserControl
    {
        public requests()
        {
            InitializeComponent();
        }
        public Panel panelForItem
        {
            get
            {
                return panelForUser;
            }
            set
            {
                panelForUser = value;
            }
        }
        public static Panel panelDown;
        private void pictureBoxBack_Click(object sender, System.EventArgs e)
        {
            this.Visible = false;
            panelDown.Size = new Size(876, 612);
            Form1.MainChat.Visible = true;
            panelDown.Controls.Add(Form1.MainChat);
        }
    }
}