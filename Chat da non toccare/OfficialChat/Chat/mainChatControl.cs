namespace OfficialChat.Chat
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Drawing;
    using OfficialChat.Chat.Controls;

    public partial class mainChatControl : UserControl
    {
        public static string To = "";
        public static string from = "";
        public static List<Panel> Chats = new List<Panel>();
        public mainChatControl()
        {
            InitializeComponent();
        }
        public UserSelected panelUserSelected
        {
            get 
            {
                return userSelected;
            }
            set
            {
                userSelected = value;
            }
        }
        public Panel panelTypingBox
        {
            get
            {
                return blockPanelDown;
            }
            set
            {
                blockPanelDown = value;
            }
        }
        public Image imageOfUserSelected
        {
            get
            {
                return userSelected.imageUserSelected;
            }
            set
            {
                userSelected.imageUserSelected = value;
            }
        }
        public string lastAccessOfUserSelected
        {
            get
            {
                return userSelected.state;
            }
            set
            {
                userSelected.state = value;
            }
        }
        public string nameOfUserSelected
        {
            get
            {
                return userSelected.usernameSelected;
            }
            set
            {
                userSelected.usernameSelected = value;
            }
        }

        public FlowLayoutPanel flowLayoutPanelChat
        {
            get
            {
                return flpChat;
            }
            set
            {
                flpChat = value;
            }
        }
        public Panel panelUsers
        {
            get
            {
                return leftPanel.Users;
            }
            set
            {
                leftPanel.Users = value;
            }
        }
    }
}