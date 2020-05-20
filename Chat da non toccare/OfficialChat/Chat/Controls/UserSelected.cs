namespace OfficialChat.Chat.Controls
{
    using System.Drawing;
    using System.Windows.Forms;
    public partial class UserSelected : UserControl
    {
        public UserSelected()
        {
            InitializeComponent();
        }
        public string usernameSelected
        {
            get
            {
                return labelUsername.Text;
            }
            set
            {
                labelUsername.Text = value;
            }
        }
        public Image imageUserSelected
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
    }
}
