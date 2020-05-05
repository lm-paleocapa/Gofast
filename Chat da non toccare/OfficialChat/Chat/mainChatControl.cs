namespace OfficialChat.Chat
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Drawing;

    public partial class mainChatControl : UserControl
    {
        public static string To = "";
        public static List<Panel> Chats = new List<Panel>();
        public mainChatControl()
        {
            InitializeComponent();
        }
        public Panel panelUserSelected
        {
            get 
            {
                return panelForUserS;
            }
            set
            {
                panelForUserS = value;
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
                return blockPanelLeft;
            }
            set
            {
                blockPanelLeft = value;
            }
        }
        private void mainChatControl_Load(object sender, EventArgs e)
        {

        }
    }
}