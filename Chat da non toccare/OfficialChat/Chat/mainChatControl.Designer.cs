namespace OfficialChat.Chat
{
    partial class mainChatControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainChatControl));
            this.blockPanelUp = new System.Windows.Forms.Panel();
            this.myUser = new OfficialChat.Chat.Controls.myUser();
            this.panelForUserS = new System.Windows.Forms.Panel();
            this.userSelected = new OfficialChat.Chat.Controls.UserSelected();
            this.blockPanelLeft = new System.Windows.Forms.Panel();
            this.blockPanelDown = new System.Windows.Forms.Panel();
            this.typingBox1 = new OfficialChat.Chat.Controls.typingBoxChat();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.blockPanelUp.SuspendLayout();
            this.panelForUserS.SuspendLayout();
            this.blockPanelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // blockPanelUp
            // 
            this.blockPanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.blockPanelUp.Controls.Add(this.myUser);
            this.blockPanelUp.Controls.Add(this.panelForUserS);
            this.blockPanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.blockPanelUp.Location = new System.Drawing.Point(0, 0);
            this.blockPanelUp.Name = "blockPanelUp";
            this.blockPanelUp.Size = new System.Drawing.Size(881, 59);
            this.blockPanelUp.TabIndex = 1;
            // 
            // myUser
            // 
            this.myUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.myUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.myUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.myUser.image = ((System.Drawing.Image)(resources.GetObject("myUser.image")));
            this.myUser.Location = new System.Drawing.Point(0, 0);
            this.myUser.name = "MyUsername";
            this.myUser.Name = "myUser";
            this.myUser.Size = new System.Drawing.Size(202, 59);
            this.myUser.TabIndex = 0;
            // 
            // panelForUserS
            // 
            this.panelForUserS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.panelForUserS.Controls.Add(this.userSelected);
            this.panelForUserS.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelForUserS.Location = new System.Drawing.Point(202, 0);
            this.panelForUserS.Name = "panelForUserS";
            this.panelForUserS.Size = new System.Drawing.Size(679, 59);
            this.panelForUserS.TabIndex = 2;
            this.panelForUserS.Visible = false;
            // 
            // userSelected
            // 
            this.userSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.userSelected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userSelected.imageUserSelected = ((System.Drawing.Image)(resources.GetObject("userSelected.imageUserSelected")));
            this.userSelected.Location = new System.Drawing.Point(1, 0);
            this.userSelected.Name = "userSelected";
            this.userSelected.Size = new System.Drawing.Size(677, 59);
            this.userSelected.state = "state";
            this.userSelected.TabIndex = 2;
            this.userSelected.usernameSelected = "Username";
            // 
            // blockPanelLeft
            // 
            this.blockPanelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(79)))), ((int)(((byte)(89)))));
            this.blockPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.blockPanelLeft.Location = new System.Drawing.Point(0, 59);
            this.blockPanelLeft.Name = "blockPanelLeft";
            this.blockPanelLeft.Size = new System.Drawing.Size(202, 550);
            this.blockPanelLeft.TabIndex = 2;
            // 
            // blockPanelDown
            // 
            this.blockPanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(39)))), ((int)(((byte)(49)))));
            this.blockPanelDown.Controls.Add(this.typingBox1);
            this.blockPanelDown.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.blockPanelDown.Location = new System.Drawing.Point(202, 560);
            this.blockPanelDown.Name = "blockPanelDown";
            this.blockPanelDown.Size = new System.Drawing.Size(679, 49);
            this.blockPanelDown.TabIndex = 3;
            this.blockPanelDown.Visible = false;
            // 
            // typingBox1
            // 
            this.typingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.typingBox1.Location = new System.Drawing.Point(20, 9);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(640, 35);
            this.typingBox1.TabIndex = 0;
            // 
            // flpChat
            // 
            this.flpChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.flpChat.Location = new System.Drawing.Point(202, 59);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(679, 501);
            this.flpChat.TabIndex = 4;
            // 
            // mainChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flpChat);
            this.Controls.Add(this.blockPanelDown);
            this.Controls.Add(this.blockPanelLeft);
            this.Controls.Add(this.blockPanelUp);
            this.Name = "mainChatControl";
            this.Size = new System.Drawing.Size(881, 609);
            this.Load += new System.EventHandler(this.mainChatControl_Load);
            this.blockPanelUp.ResumeLayout(false);
            this.panelForUserS.ResumeLayout(false);
            this.blockPanelDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel blockPanelUp;
        private System.Windows.Forms.Panel blockPanelLeft;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        public Controls.myUser myUser;
        private System.Windows.Forms.Panel blockPanelDown;
        private Controls.typingBoxChat typingBox1;
        private System.Windows.Forms.Panel panelForUserS;
        private Controls.UserSelected userSelected;
    }
}
