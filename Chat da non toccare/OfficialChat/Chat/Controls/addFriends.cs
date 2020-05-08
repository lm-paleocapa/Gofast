namespace OfficialChat.Chat.Controls
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    public partial class addFriends : UserControl
    {
        public addFriends()
        {
            InitializeComponent();
        }
        private int i = -210;
        private int k = 0;
        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            timer.Start();
        }   

        private void timer_Tick(object sender, EventArgs e)
        {
            if (k <= 0 && k >= -620)
            {
                Form1.MainChat.myUser.panelAddUser.Location = new Point(0,k);
                k -= 20;
            }
            else if (Form1.MainChat.ControlMain.Location.X < 0)
            {
                Form1.MainChat.ControlMain.Location = new Point(i,0);
                i += 10;
            }
            else
            {
                timer.Stop();
                i = -210;
                k = 0;
            }
        }
    }
}
