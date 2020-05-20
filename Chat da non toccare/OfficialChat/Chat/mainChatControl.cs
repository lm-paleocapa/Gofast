namespace OfficialChat.Chat
{
    using System.Collections.Generic;
    using System.Windows.Forms;
    using System.Drawing;
    using OfficialChat.Chat.Controls;
    using OfficialChat.Properties;
    using OfficialChat.Lib.Client;

    public partial class mainChatControl : UserControl
    {
        public static string To = "";
        public static string from = "";
        public static List<Panel> Chats = new List<Panel>();
        public mainChatControl()
        {
            InitializeComponent();
        }
        public Panel objectLeft
        {
            get
            {
                return panelForObject;
            }
            set
            {
                panelForObject = value;
            }
        }
        public Panel ControlMain
        {
            get
            {
                return panelBlockLeft;
            }
            set
            {
                panelBlockLeft = value;
            }
        }
        public Panel panelUserSelected
        {
            get 
            {
                return blockPanelUp;
            }
            set
            {
                blockPanelUp = value;
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
        public dropdownList dropdownlist
        {
            get
            {
                return dropdownList;
            }
            set
            {
                dropdownList = value;
            }
        }
        private void flpChat_Click(object sender, System.EventArgs e)
        {
            if (dropdownlist.Visible)
            {
                dropdownlist.Visible = false;
                myUser.setting.Image = Resources.icons8_menu_2_30;
            }
        }
        private void mainChatControl_Load(object sender, System.EventArgs e)
        {
        }
    }
}