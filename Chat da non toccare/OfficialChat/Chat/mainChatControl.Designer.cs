namespace OfficialChat.Chat
{
    partial class mainChatControl
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainChatControl));
            this.blockPanelUp = new System.Windows.Forms.Panel();
            this.userSelected = new OfficialChat.Chat.Controls.UserSelected();
            this.blockPanelDown = new System.Windows.Forms.Panel();
            this.typingBox1 = new OfficialChat.Chat.Controls.typingBoxChat();
            this.flpChat = new System.Windows.Forms.FlowLayoutPanel();
            this.dropdownList = new OfficialChat.Chat.Controls.dropdownList();
            this.myUser = new OfficialChat.Chat.Controls.User();
            this.leftPanel = new OfficialChat.Chat.Controls.leftPanel();
            this.blockPanelUp.SuspendLayout();
            this.blockPanelDown.SuspendLayout();
            this.SuspendLayout();
            // 
            // blockPanelUp
            // 
            this.blockPanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.blockPanelUp.Controls.Add(this.userSelected);
            this.blockPanelUp.Location = new System.Drawing.Point(202, 0);
            this.blockPanelUp.Margin = new System.Windows.Forms.Padding(0);
            this.blockPanelUp.Name = "blockPanelUp";
            this.blockPanelUp.Size = new System.Drawing.Size(674, 57);
            this.blockPanelUp.TabIndex = 1;
            this.blockPanelUp.Visible = false;
            this.blockPanelUp.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // userSelected
            // 
            this.userSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.userSelected.imageUserSelected = ((System.Drawing.Image)(resources.GetObject("userSelected.imageUserSelected")));
            this.userSelected.Location = new System.Drawing.Point(0, 0);
            this.userSelected.Name = "userSelected";
            this.userSelected.Size = new System.Drawing.Size(674, 57);
            this.userSelected.state = "state";
            this.userSelected.TabIndex = 0;
            this.userSelected.usernameSelected = "Username";
            this.userSelected.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // blockPanelDown
            // 
            this.blockPanelDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.blockPanelDown.Controls.Add(this.typingBox1);
            this.blockPanelDown.Location = new System.Drawing.Point(202, 563);
            this.blockPanelDown.Margin = new System.Windows.Forms.Padding(0);
            this.blockPanelDown.Name = "blockPanelDown";
            this.blockPanelDown.Size = new System.Drawing.Size(674, 49);
            this.blockPanelDown.TabIndex = 3;
            this.blockPanelDown.Visible = false;
            this.blockPanelDown.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // typingBox1
            // 
            this.typingBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.typingBox1.Location = new System.Drawing.Point(20, 9);
            this.typingBox1.Margin = new System.Windows.Forms.Padding(0);
            this.typingBox1.Name = "typingBox1";
            this.typingBox1.Size = new System.Drawing.Size(640, 35);
            this.typingBox1.TabIndex = 0;
            this.typingBox1.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // flpChat
            // 
            this.flpChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.flpChat.Location = new System.Drawing.Point(202, 57);
            this.flpChat.Margin = new System.Windows.Forms.Padding(0);
            this.flpChat.Name = "flpChat";
            this.flpChat.Size = new System.Drawing.Size(674, 506);
            this.flpChat.TabIndex = 4;
            this.flpChat.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // dropdownList
            // 
            this.dropdownList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dropdownList.Location = new System.Drawing.Point(61, 47);
            this.dropdownList.Margin = new System.Windows.Forms.Padding(1);
            this.dropdownList.Name = "dropdownList";
            this.dropdownList.Padding = new System.Windows.Forms.Padding(1);
            this.dropdownList.Size = new System.Drawing.Size(131, 132);
            this.dropdownList.TabIndex = 0;
            this.dropdownList.Visible = false;
            this.dropdownList.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // myUser
            // 
            this.myUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(60)))), ((int)(((byte)(93)))));
            this.myUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.myUser.image = global::OfficialChat.Properties.Resources.user;
            this.myUser.Location = new System.Drawing.Point(0, 0);
            this.myUser.Margin = new System.Windows.Forms.Padding(0);
            this.myUser.Name = "myUser";
            this.myUser.Size = new System.Drawing.Size(202, 57);
            this.myUser.TabIndex = 0;
            this.myUser.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.leftPanel.Location = new System.Drawing.Point(0, 57);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(202, 555);
            this.leftPanel.TabIndex = 5;
            this.leftPanel.Click += new System.EventHandler(this.flpChat_Click);
            // 
            // mainChatControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.Controls.Add(this.dropdownList);
            this.Controls.Add(this.myUser);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.flpChat);
            this.Controls.Add(this.blockPanelDown);
            this.Controls.Add(this.blockPanelUp);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "mainChatControl";
            this.Size = new System.Drawing.Size(876, 612);
            this.Click += new System.EventHandler(this.flpChat_Click);
            this.blockPanelUp.ResumeLayout(false);
            this.blockPanelDown.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel blockPanelUp;
        private System.Windows.Forms.FlowLayoutPanel flpChat;
        private System.Windows.Forms.Panel blockPanelDown;
        private Controls.typingBoxChat typingBox1;
        public Controls.User myUser;
        private Controls.leftPanel leftPanel;
        private Controls.UserSelected userSelected;
        private Controls.dropdownList dropdownList;
    }
}