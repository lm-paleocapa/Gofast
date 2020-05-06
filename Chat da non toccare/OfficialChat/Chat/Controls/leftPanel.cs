namespace OfficialChat.Chat.Controls
{
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
    }
}