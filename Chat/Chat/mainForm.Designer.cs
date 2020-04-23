namespace Chat
{
    partial class mainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelRegister_Login = new System.Windows.Forms.Label();
            this.rbtnRememberMe_Login = new System.Windows.Forms.RadioButton();
            this.btnLogin_Login = new System.Windows.Forms.Button();
            this.labelPassword_Login = new System.Windows.Forms.Label();
            this.tbPassword_Login = new System.Windows.Forms.TextBox();
            this.labelUser_Login = new System.Windows.Forms.Label();
            this.tbUser_Login = new System.Windows.Forms.TextBox();
            this.labelLogo_Login = new System.Windows.Forms.Label();
            this.panelRecentChat = new System.Windows.Forms.Panel();
            this.labelNoFriendsOrChat_RecentChat = new System.Windows.Forms.Label();
            this.btnBack_RecentChat = new System.Windows.Forms.Button();
            this.pictureBoxImage_RecentChat = new System.Windows.Forms.PictureBox();
            this.listViewChat_RecentChat = new System.Windows.Forms.ListView();
            this.ColumUser_Chat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumLastAccess_Chat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelLogo_RecentChat = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.btnBack_Register = new System.Windows.Forms.Button();
            this.labelLogo_Register = new System.Windows.Forms.Label();
            this.numericUpAndDown_Register = new System.Windows.Forms.NumericUpDown();
            this.btnRegister_Register = new System.Windows.Forms.Button();
            this.btnImage_Register = new System.Windows.Forms.Button();
            this.labelImage_Register = new System.Windows.Forms.Label();
            this.labelAge_Register = new System.Windows.Forms.Label();
            this.labelMail_Register = new System.Windows.Forms.Label();
            this.labelCPassword_Register = new System.Windows.Forms.Label();
            this.labelPassword_Register = new System.Windows.Forms.Label();
            this.labelUser_Register = new System.Windows.Forms.Label();
            this.tbUser_Register = new System.Windows.Forms.TextBox();
            this.tbMail_Register = new System.Windows.Forms.TextBox();
            this.tbCPassword_Register = new System.Windows.Forms.TextBox();
            this.tbPassword_Register = new System.Windows.Forms.TextBox();
            this.panelForChat = new System.Windows.Forms.Panel();
            this.flowLayoutPanel.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelRecentChat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_RecentChat)).BeginInit();
            this.panelRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpAndDown_Register)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.Controls.Add(this.panelLogin);
            this.flowLayoutPanel.Controls.Add(this.panelRecentChat);
            this.flowLayoutPanel.Controls.Add(this.panelRegister);
            this.flowLayoutPanel.Controls.Add(this.panelForChat);
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(1444, 881);
            this.flowLayoutPanel.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelRegister_Login);
            this.panelLogin.Controls.Add(this.rbtnRememberMe_Login);
            this.panelLogin.Controls.Add(this.btnLogin_Login);
            this.panelLogin.Controls.Add(this.labelPassword_Login);
            this.panelLogin.Controls.Add(this.tbPassword_Login);
            this.panelLogin.Controls.Add(this.labelUser_Login);
            this.panelLogin.Controls.Add(this.tbUser_Login);
            this.panelLogin.Controls.Add(this.labelLogo_Login);
            this.panelLogin.Location = new System.Drawing.Point(3, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(275, 358);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.Visible = false;
            // 
            // labelRegister_Login
            // 
            this.labelRegister_Login.AutoSize = true;
            this.labelRegister_Login.Location = new System.Drawing.Point(28, 335);
            this.labelRegister_Login.Name = "labelRegister_Login";
            this.labelRegister_Login.Size = new System.Drawing.Size(227, 13);
            this.labelRegister_Login.TabIndex = 7;
            this.labelRegister_Login.Text = "If you do not have an account, click to register";
            this.labelRegister_Login.Click += new System.EventHandler(this.labelRegister_Login_Click);
            // 
            // rbtnRememberMe_Login
            // 
            this.rbtnRememberMe_Login.AutoSize = true;
            this.rbtnRememberMe_Login.Checked = true;
            this.rbtnRememberMe_Login.Location = new System.Drawing.Point(165, 182);
            this.rbtnRememberMe_Login.Name = "rbtnRememberMe_Login";
            this.rbtnRememberMe_Login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbtnRememberMe_Login.Size = new System.Drawing.Size(93, 17);
            this.rbtnRememberMe_Login.TabIndex = 6;
            this.rbtnRememberMe_Login.TabStop = true;
            this.rbtnRememberMe_Login.Text = "Remember me";
            this.rbtnRememberMe_Login.UseVisualStyleBackColor = true;
            this.rbtnRememberMe_Login.Click += new System.EventHandler(this.rbtnRememberMe_Login_Click);
            // 
            // btnLogin_Login
            // 
            this.btnLogin_Login.Location = new System.Drawing.Point(107, 282);
            this.btnLogin_Login.Name = "btnLogin_Login";
            this.btnLogin_Login.Size = new System.Drawing.Size(75, 23);
            this.btnLogin_Login.TabIndex = 5;
            this.btnLogin_Login.Text = "Login";
            this.btnLogin_Login.UseVisualStyleBackColor = true;
            this.btnLogin_Login.Click += new System.EventHandler(this.btnLogin_Login_Click);
            // 
            // labelPassword_Login
            // 
            this.labelPassword_Login.AutoSize = true;
            this.labelPassword_Login.Location = new System.Drawing.Point(48, 125);
            this.labelPassword_Login.Name = "labelPassword_Login";
            this.labelPassword_Login.Size = new System.Drawing.Size(56, 13);
            this.labelPassword_Login.TabIndex = 4;
            this.labelPassword_Login.Text = "Password:";
            // 
            // tbPassword_Login
            // 
            this.tbPassword_Login.Location = new System.Drawing.Point(107, 121);
            this.tbPassword_Login.MaxLength = 12;
            this.tbPassword_Login.Name = "tbPassword_Login";
            this.tbPassword_Login.Size = new System.Drawing.Size(151, 20);
            this.tbPassword_Login.TabIndex = 3;
            this.tbPassword_Login.UseSystemPasswordChar = true;
            this.tbPassword_Login.Click += new System.EventHandler(this.ChangeColorPassword);
            // 
            // labelUser_Login
            // 
            this.labelUser_Login.AutoSize = true;
            this.labelUser_Login.Location = new System.Drawing.Point(48, 88);
            this.labelUser_Login.Name = "labelUser_Login";
            this.labelUser_Login.Size = new System.Drawing.Size(32, 13);
            this.labelUser_Login.TabIndex = 2;
            this.labelUser_Login.Text = "User:";
            this.labelUser_Login.Click += new System.EventHandler(this.ChangeColorUser);
            // 
            // tbUser_Login
            // 
            this.tbUser_Login.Location = new System.Drawing.Point(107, 84);
            this.tbUser_Login.MaxLength = 12;
            this.tbUser_Login.Name = "tbUser_Login";
            this.tbUser_Login.Size = new System.Drawing.Size(151, 20);
            this.tbUser_Login.TabIndex = 1;
            this.tbUser_Login.Click += new System.EventHandler(this.ChangeColorUser);
            // 
            // labelLogo_Login
            // 
            this.labelLogo_Login.AutoSize = true;
            this.labelLogo_Login.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogo_Login.Location = new System.Drawing.Point(89, 28);
            this.labelLogo_Login.Name = "labelLogo_Login";
            this.labelLogo_Login.Size = new System.Drawing.Size(93, 25);
            this.labelLogo_Login.TabIndex = 0;
            this.labelLogo_Login.Text = "GoFast";
            // 
            // panelRecentChat
            // 
            this.panelRecentChat.Controls.Add(this.labelNoFriendsOrChat_RecentChat);
            this.panelRecentChat.Controls.Add(this.btnBack_RecentChat);
            this.panelRecentChat.Controls.Add(this.pictureBoxImage_RecentChat);
            this.panelRecentChat.Controls.Add(this.listViewChat_RecentChat);
            this.panelRecentChat.Controls.Add(this.labelLogo_RecentChat);
            this.panelRecentChat.Location = new System.Drawing.Point(284, 3);
            this.panelRecentChat.Name = "panelRecentChat";
            this.panelRecentChat.Size = new System.Drawing.Size(353, 358);
            this.panelRecentChat.TabIndex = 2;
            this.panelRecentChat.Visible = false;
            // 
            // labelNoFriendsOrChat_RecentChat
            // 
            this.labelNoFriendsOrChat_RecentChat.AutoSize = true;
            this.labelNoFriendsOrChat_RecentChat.Location = new System.Drawing.Point(133, 205);
            this.labelNoFriendsOrChat_RecentChat.Name = "labelNoFriendsOrChat_RecentChat";
            this.labelNoFriendsOrChat_RecentChat.Size = new System.Drawing.Size(95, 13);
            this.labelNoFriendsOrChat_RecentChat.TabIndex = 5;
            this.labelNoFriendsOrChat_RecentChat.Text = "No chat or groups.";
            this.labelNoFriendsOrChat_RecentChat.Visible = false;
            // 
            // btnBack_RecentChat
            // 
            this.btnBack_RecentChat.Location = new System.Drawing.Point(3, 8);
            this.btnBack_RecentChat.Name = "btnBack_RecentChat";
            this.btnBack_RecentChat.Size = new System.Drawing.Size(45, 40);
            this.btnBack_RecentChat.TabIndex = 4;
            this.btnBack_RecentChat.Text = "Exit";
            this.btnBack_RecentChat.UseVisualStyleBackColor = true;
            this.btnBack_RecentChat.Click += new System.EventHandler(this.btnBack_RecentChat_Click);
            // 
            // pictureBoxImage_RecentChat
            // 
            this.pictureBoxImage_RecentChat.Location = new System.Drawing.Point(54, 8);
            this.pictureBoxImage_RecentChat.Name = "pictureBoxImage_RecentChat";
            this.pictureBoxImage_RecentChat.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxImage_RecentChat.TabIndex = 3;
            this.pictureBoxImage_RecentChat.TabStop = false;
            // 
            // listViewChat_RecentChat
            // 
            this.listViewChat_RecentChat.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumUser_Chat,
            this.ColumLastAccess_Chat});
            this.listViewChat_RecentChat.HideSelection = false;
            this.listViewChat_RecentChat.Location = new System.Drawing.Point(21, 56);
            this.listViewChat_RecentChat.Name = "listViewChat_RecentChat";
            this.listViewChat_RecentChat.Size = new System.Drawing.Size(316, 292);
            this.listViewChat_RecentChat.TabIndex = 2;
            this.listViewChat_RecentChat.UseCompatibleStateImageBehavior = false;
            this.listViewChat_RecentChat.View = System.Windows.Forms.View.Details;
            this.listViewChat_RecentChat.SelectedIndexChanged += new System.EventHandler(this.listViewChat_RecentChat_SelectedIndexChanged);
            // 
            // ColumUser_Chat
            // 
            this.ColumUser_Chat.Text = "User";
            this.ColumUser_Chat.Width = 211;
            // 
            // ColumLastAccess_Chat
            // 
            this.ColumLastAccess_Chat.Text = "Last access";
            this.ColumLastAccess_Chat.Width = 100;
            // 
            // labelLogo_RecentChat
            // 
            this.labelLogo_RecentChat.AutoSize = true;
            this.labelLogo_RecentChat.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelLogo_RecentChat.Location = new System.Drawing.Point(131, 23);
            this.labelLogo_RecentChat.Name = "labelLogo_RecentChat";
            this.labelLogo_RecentChat.Size = new System.Drawing.Size(93, 25);
            this.labelLogo_RecentChat.TabIndex = 1;
            this.labelLogo_RecentChat.Text = "GoFast";
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.btnBack_Register);
            this.panelRegister.Controls.Add(this.labelLogo_Register);
            this.panelRegister.Controls.Add(this.numericUpAndDown_Register);
            this.panelRegister.Controls.Add(this.btnRegister_Register);
            this.panelRegister.Controls.Add(this.btnImage_Register);
            this.panelRegister.Controls.Add(this.labelImage_Register);
            this.panelRegister.Controls.Add(this.labelAge_Register);
            this.panelRegister.Controls.Add(this.labelMail_Register);
            this.panelRegister.Controls.Add(this.labelCPassword_Register);
            this.panelRegister.Controls.Add(this.labelPassword_Register);
            this.panelRegister.Controls.Add(this.labelUser_Register);
            this.panelRegister.Controls.Add(this.tbUser_Register);
            this.panelRegister.Controls.Add(this.tbMail_Register);
            this.panelRegister.Controls.Add(this.tbCPassword_Register);
            this.panelRegister.Controls.Add(this.tbPassword_Register);
            this.panelRegister.Location = new System.Drawing.Point(643, 3);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(347, 358);
            this.panelRegister.TabIndex = 3;
            this.panelRegister.Visible = false;
            // 
            // btnBack_Register
            // 
            this.btnBack_Register.Location = new System.Drawing.Point(3, 3);
            this.btnBack_Register.Name = "btnBack_Register";
            this.btnBack_Register.Size = new System.Drawing.Size(45, 40);
            this.btnBack_Register.TabIndex = 15;
            this.btnBack_Register.Text = "Back";
            this.btnBack_Register.UseVisualStyleBackColor = true;
            this.btnBack_Register.Click += new System.EventHandler(this.btnBack_Register_Click);
            // 
            // labelLogo_Register
            // 
            this.labelLogo_Register.AutoSize = true;
            this.labelLogo_Register.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold);
            this.labelLogo_Register.Location = new System.Drawing.Point(131, 23);
            this.labelLogo_Register.Name = "labelLogo_Register";
            this.labelLogo_Register.Size = new System.Drawing.Size(93, 25);
            this.labelLogo_Register.TabIndex = 4;
            this.labelLogo_Register.Text = "GoFast";
            // 
            // numericUpAndDown_Register
            // 
            this.numericUpAndDown_Register.Location = new System.Drawing.Point(175, 216);
            this.numericUpAndDown_Register.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpAndDown_Register.Name = "numericUpAndDown_Register";
            this.numericUpAndDown_Register.Size = new System.Drawing.Size(100, 20);
            this.numericUpAndDown_Register.TabIndex = 14;
            this.numericUpAndDown_Register.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnRegister_Register
            // 
            this.btnRegister_Register.Location = new System.Drawing.Point(136, 313);
            this.btnRegister_Register.Name = "btnRegister_Register";
            this.btnRegister_Register.Size = new System.Drawing.Size(75, 23);
            this.btnRegister_Register.TabIndex = 13;
            this.btnRegister_Register.Text = "Register";
            this.btnRegister_Register.UseVisualStyleBackColor = true;
            this.btnRegister_Register.Click += new System.EventHandler(this.btnRegister_Register_Click);
            // 
            // btnImage_Register
            // 
            this.btnImage_Register.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImage_Register.Location = new System.Drawing.Point(175, 242);
            this.btnImage_Register.Name = "btnImage_Register";
            this.btnImage_Register.Size = new System.Drawing.Size(36, 31);
            this.btnImage_Register.TabIndex = 12;
            this.btnImage_Register.Text = "...";
            this.btnImage_Register.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImage_Register.UseVisualStyleBackColor = true;
            this.btnImage_Register.Click += new System.EventHandler(this.BtnImage_Register_Click);
            // 
            // labelImage_Register
            // 
            this.labelImage_Register.AutoSize = true;
            this.labelImage_Register.Location = new System.Drawing.Point(71, 254);
            this.labelImage_Register.Name = "labelImage_Register";
            this.labelImage_Register.Size = new System.Drawing.Size(36, 13);
            this.labelImage_Register.TabIndex = 11;
            this.labelImage_Register.Text = "Image";
            // 
            // labelAge_Register
            // 
            this.labelAge_Register.AutoSize = true;
            this.labelAge_Register.Location = new System.Drawing.Point(71, 219);
            this.labelAge_Register.Name = "labelAge_Register";
            this.labelAge_Register.Size = new System.Drawing.Size(26, 13);
            this.labelAge_Register.TabIndex = 10;
            this.labelAge_Register.Text = "Age";
            // 
            // labelMail_Register
            // 
            this.labelMail_Register.AutoSize = true;
            this.labelMail_Register.Location = new System.Drawing.Point(71, 184);
            this.labelMail_Register.Name = "labelMail_Register";
            this.labelMail_Register.Size = new System.Drawing.Size(26, 13);
            this.labelMail_Register.TabIndex = 9;
            this.labelMail_Register.Text = "Mail";
            // 
            // labelCPassword_Register
            // 
            this.labelCPassword_Register.AutoSize = true;
            this.labelCPassword_Register.Location = new System.Drawing.Point(71, 148);
            this.labelCPassword_Register.Name = "labelCPassword_Register";
            this.labelCPassword_Register.Size = new System.Drawing.Size(90, 13);
            this.labelCPassword_Register.TabIndex = 8;
            this.labelCPassword_Register.Text = "Confirm password";
            // 
            // labelPassword_Register
            // 
            this.labelPassword_Register.AutoSize = true;
            this.labelPassword_Register.Location = new System.Drawing.Point(71, 111);
            this.labelPassword_Register.Name = "labelPassword_Register";
            this.labelPassword_Register.Size = new System.Drawing.Size(53, 13);
            this.labelPassword_Register.TabIndex = 7;
            this.labelPassword_Register.Text = "Password";
            // 
            // labelUser_Register
            // 
            this.labelUser_Register.AutoSize = true;
            this.labelUser_Register.Location = new System.Drawing.Point(71, 75);
            this.labelUser_Register.Name = "labelUser_Register";
            this.labelUser_Register.Size = new System.Drawing.Size(29, 13);
            this.labelUser_Register.TabIndex = 6;
            this.labelUser_Register.Text = "User";
            // 
            // tbUser_Register
            // 
            this.tbUser_Register.Location = new System.Drawing.Point(175, 72);
            this.tbUser_Register.MaxLength = 12;
            this.tbUser_Register.Name = "tbUser_Register";
            this.tbUser_Register.Size = new System.Drawing.Size(100, 20);
            this.tbUser_Register.TabIndex = 5;
            // 
            // tbMail_Register
            // 
            this.tbMail_Register.Location = new System.Drawing.Point(175, 181);
            this.tbMail_Register.MaxLength = 12;
            this.tbMail_Register.Name = "tbMail_Register";
            this.tbMail_Register.Size = new System.Drawing.Size(100, 20);
            this.tbMail_Register.TabIndex = 2;
            // 
            // tbCPassword_Register
            // 
            this.tbCPassword_Register.Location = new System.Drawing.Point(175, 145);
            this.tbCPassword_Register.MaxLength = 12;
            this.tbCPassword_Register.Name = "tbCPassword_Register";
            this.tbCPassword_Register.Size = new System.Drawing.Size(100, 20);
            this.tbCPassword_Register.TabIndex = 1;
            // 
            // tbPassword_Register
            // 
            this.tbPassword_Register.Location = new System.Drawing.Point(175, 108);
            this.tbPassword_Register.MaxLength = 12;
            this.tbPassword_Register.Name = "tbPassword_Register";
            this.tbPassword_Register.Size = new System.Drawing.Size(100, 20);
            this.tbPassword_Register.TabIndex = 0;
            // 
            // panelForChat
            // 
            this.panelForChat.Location = new System.Drawing.Point(996, 3);
            this.panelForChat.Name = "panelForChat";
            this.panelForChat.Size = new System.Drawing.Size(396, 384);
            this.panelForChat.TabIndex = 4;
            this.panelForChat.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1444, 881);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "mainForm";
            this.Text = "GoFast";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.flowLayoutPanel.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRecentChat.ResumeLayout(false);
            this.panelRecentChat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_RecentChat)).EndInit();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpAndDown_Register)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label labelRegister_Login;
        private System.Windows.Forms.RadioButton rbtnRememberMe_Login;
        private System.Windows.Forms.Button btnLogin_Login;
        private System.Windows.Forms.Label labelPassword_Login;
        private System.Windows.Forms.TextBox tbPassword_Login;
        private System.Windows.Forms.Label labelUser_Login;
        private System.Windows.Forms.TextBox tbUser_Login;
        private System.Windows.Forms.Label labelLogo_Login;
        private System.Windows.Forms.Panel panelRecentChat;
        private System.Windows.Forms.PictureBox pictureBoxImage_RecentChat;
        private System.Windows.Forms.ListView listViewChat_RecentChat;
        private System.Windows.Forms.ColumnHeader ColumUser_Chat;
        private System.Windows.Forms.ColumnHeader ColumLastAccess_Chat;
        private System.Windows.Forms.Label labelLogo_RecentChat;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.NumericUpDown numericUpAndDown_Register;
        private System.Windows.Forms.Button btnRegister_Register;
        private System.Windows.Forms.Button btnImage_Register;
        private System.Windows.Forms.Label labelImage_Register;
        private System.Windows.Forms.Label labelAge_Register;
        private System.Windows.Forms.Label labelMail_Register;
        private System.Windows.Forms.Label labelCPassword_Register;
        private System.Windows.Forms.Label labelPassword_Register;
        private System.Windows.Forms.Label labelUser_Register;
        private System.Windows.Forms.TextBox tbUser_Register;
        private System.Windows.Forms.TextBox tbMail_Register;
        private System.Windows.Forms.TextBox tbCPassword_Register;
        private System.Windows.Forms.TextBox tbPassword_Register;
        private System.Windows.Forms.Label labelLogo_Register;
        private System.Windows.Forms.Panel panelForChat;
        private System.Windows.Forms.Button btnBack_RecentChat;
        private System.Windows.Forms.Button btnBack_Register;
        private System.Windows.Forms.Label labelNoFriendsOrChat_RecentChat;
    }
}

