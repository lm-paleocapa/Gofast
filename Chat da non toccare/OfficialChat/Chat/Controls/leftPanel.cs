namespace OfficialChat.Chat.Controls
{
    using OfficialChat.Properties;
    using System.Windows.Forms;
    public partial class leftPanel : UserControl
    {
        public leftPanel()
        {
            InitializeComponent();
        }
        public Panel Users
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

        private void bunifuTextbox1_Click(object sender, System.EventArgs e)
        {
            if (Form1.MainChat.dropdownlist.Visible)
            {
                Form1.MainChat.dropdownlist.Visible = false;
                Form1.MainChat.myUser.setting.Image = Resources.icons8_menu_2_30;
            }
        }
    }
}