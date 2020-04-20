namespace PCTO_GoFast
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Home = new System.Windows.Forms.Panel();
            this.BtnSignInHome = new System.Windows.Forms.Button();
            this.TxtPassHome = new System.Windows.Forms.TextBox();
            this.TxtUserHome = new System.Windows.Forms.TextBox();
            this.LblPassHome = new System.Windows.Forms.Label();
            this.LblUserHome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblRecoveryHome = new System.Windows.Forms.Label();
            this.BtnLoginHome = new System.Windows.Forms.Button();
            this.SignIn = new System.Windows.Forms.Panel();
            this.TxtAgeReg = new System.Windows.Forms.TextBox();
            this.TxtConfPassReg = new System.Windows.Forms.TextBox();
            this.FrecciaReg = new System.Windows.Forms.PictureBox();
            this.TxtPassReg = new System.Windows.Forms.TextBox();
            this.TxtUserReg = new System.Windows.Forms.TextBox();
            this.TxtMailReg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FrecciaRec = new System.Windows.Forms.PictureBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.LblNomeChat = new System.Windows.Forms.Label();
            this.TxtChat = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.Home.SuspendLayout();
            this.SignIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrecciaReg)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrecciaRec)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Home);
            this.flowLayoutPanel1.Controls.Add(this.SignIn);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1390, 617);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Home.Controls.Add(this.BtnSignInHome);
            this.Home.Controls.Add(this.TxtPassHome);
            this.Home.Controls.Add(this.TxtUserHome);
            this.Home.Controls.Add(this.LblPassHome);
            this.Home.Controls.Add(this.LblUserHome);
            this.Home.Controls.Add(this.label2);
            this.Home.Controls.Add(this.LblRecoveryHome);
            this.Home.Controls.Add(this.BtnLoginHome);
            this.Home.Location = new System.Drawing.Point(3, 3);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(287, 329);
            this.Home.TabIndex = 2;
            // 
            // BtnSignInHome
            // 
            this.BtnSignInHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnSignInHome.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.BtnSignInHome.FlatAppearance.BorderSize = 0;
            this.BtnSignInHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnSignInHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSignInHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnSignInHome.Location = new System.Drawing.Point(92, 269);
            this.BtnSignInHome.Name = "BtnSignInHome";
            this.BtnSignInHome.Size = new System.Drawing.Size(109, 34);
            this.BtnSignInHome.TabIndex = 7;
            this.BtnSignInHome.Text = "Sign In";
            this.BtnSignInHome.UseVisualStyleBackColor = false;
            // 
            // TxtPassHome
            // 
            this.TxtPassHome.Location = new System.Drawing.Point(115, 129);
            this.TxtPassHome.Name = "TxtPassHome";
            this.TxtPassHome.PasswordChar = '•';
            this.TxtPassHome.Size = new System.Drawing.Size(100, 22);
            this.TxtPassHome.TabIndex = 6;
            // 
            // TxtUserHome
            // 
            this.TxtUserHome.Location = new System.Drawing.Point(115, 83);
            this.TxtUserHome.Name = "TxtUserHome";
            this.TxtUserHome.Size = new System.Drawing.Size(100, 22);
            this.TxtUserHome.TabIndex = 5;
            // 
            // LblPassHome
            // 
            this.LblPassHome.AutoSize = true;
            this.LblPassHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassHome.ForeColor = System.Drawing.SystemColors.Control;
            this.LblPassHome.Location = new System.Drawing.Point(16, 129);
            this.LblPassHome.Name = "LblPassHome";
            this.LblPassHome.Size = new System.Drawing.Size(83, 18);
            this.LblPassHome.TabIndex = 4;
            this.LblPassHome.Text = "Password";
            // 
            // LblUserHome
            // 
            this.LblUserHome.AutoSize = true;
            this.LblUserHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserHome.ForeColor = System.Drawing.SystemColors.Control;
            this.LblUserHome.Location = new System.Drawing.Point(25, 87);
            this.LblUserHome.Name = "LblUserHome";
            this.LblUserHome.Size = new System.Drawing.Size(44, 18);
            this.LblUserHome.TabIndex = 3;
            this.LblUserHome.Text = "User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(101, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "GoFast";
            // 
            // LblRecoveryHome
            // 
            this.LblRecoveryHome.AutoSize = true;
            this.LblRecoveryHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRecoveryHome.ForeColor = System.Drawing.SystemColors.Control;
            this.LblRecoveryHome.Location = new System.Drawing.Point(76, 195);
            this.LblRecoveryHome.Name = "LblRecoveryHome";
            this.LblRecoveryHome.Size = new System.Drawing.Size(150, 17);
            this.LblRecoveryHome.TabIndex = 1;
            this.LblRecoveryHome.Text = "Recovery Password";
            // 
            // BtnLoginHome
            // 
            this.BtnLoginHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnLoginHome.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.BtnLoginHome.FlatAppearance.BorderSize = 0;
            this.BtnLoginHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnLoginHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoginHome.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnLoginHome.Location = new System.Drawing.Point(92, 228);
            this.BtnLoginHome.Name = "BtnLoginHome";
            this.BtnLoginHome.Size = new System.Drawing.Size(109, 34);
            this.BtnLoginHome.TabIndex = 0;
            this.BtnLoginHome.Text = "Login";
            this.BtnLoginHome.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SignIn.Controls.Add(this.TxtAgeReg);
            this.SignIn.Controls.Add(this.TxtConfPassReg);
            this.SignIn.Controls.Add(this.FrecciaReg);
            this.SignIn.Controls.Add(this.TxtPassReg);
            this.SignIn.Controls.Add(this.TxtUserReg);
            this.SignIn.Controls.Add(this.TxtMailReg);
            this.SignIn.Controls.Add(this.label4);
            this.SignIn.Controls.Add(this.label6);
            this.SignIn.Controls.Add(this.label10);
            this.SignIn.Controls.Add(this.label11);
            this.SignIn.Controls.Add(this.label12);
            this.SignIn.Controls.Add(this.BtnRegister);
            this.SignIn.Controls.Add(this.label13);
            this.SignIn.Location = new System.Drawing.Point(296, 3);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(317, 329);
            this.SignIn.TabIndex = 16;
            // 
            // TxtAgeReg
            // 
            this.TxtAgeReg.Location = new System.Drawing.Point(177, 223);
            this.TxtAgeReg.Name = "TxtAgeReg";
            this.TxtAgeReg.Size = new System.Drawing.Size(100, 22);
            this.TxtAgeReg.TabIndex = 14;
            // 
            // TxtConfPassReg
            // 
            this.TxtConfPassReg.Location = new System.Drawing.Point(177, 187);
            this.TxtConfPassReg.Name = "TxtConfPassReg";
            this.TxtConfPassReg.PasswordChar = '•';
            this.TxtConfPassReg.Size = new System.Drawing.Size(100, 22);
            this.TxtConfPassReg.TabIndex = 13;
            // 
            // FrecciaReg
            // 
            this.FrecciaReg.Image = ((System.Drawing.Image)(resources.GetObject("FrecciaReg.Image")));
            this.FrecciaReg.Location = new System.Drawing.Point(3, 3);
            this.FrecciaReg.Name = "FrecciaReg";
            this.FrecciaReg.Size = new System.Drawing.Size(51, 43);
            this.FrecciaReg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrecciaReg.TabIndex = 2;
            this.FrecciaReg.TabStop = false;
            // 
            // TxtPassReg
            // 
            this.TxtPassReg.Location = new System.Drawing.Point(177, 149);
            this.TxtPassReg.Name = "TxtPassReg";
            this.TxtPassReg.PasswordChar = '•';
            this.TxtPassReg.Size = new System.Drawing.Size(100, 22);
            this.TxtPassReg.TabIndex = 12;
            // 
            // TxtUserReg
            // 
            this.TxtUserReg.Location = new System.Drawing.Point(177, 109);
            this.TxtUserReg.Name = "TxtUserReg";
            this.TxtUserReg.Size = new System.Drawing.Size(100, 22);
            this.TxtUserReg.TabIndex = 11;
            // 
            // TxtMailReg
            // 
            this.TxtMailReg.Location = new System.Drawing.Point(177, 71);
            this.TxtMailReg.Name = "TxtMailReg";
            this.TxtMailReg.Size = new System.Drawing.Size(100, 22);
            this.TxtMailReg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(34, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(34, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(34, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "User";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(34, 154);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 17);
            this.label11.TabIndex = 8;
            this.label11.Text = "Password";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(34, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 17);
            this.label12.TabIndex = 7;
            this.label12.Text = "E-mail";
            // 
            // BtnRegister
            // 
            this.BtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtnRegister.FlatAppearance.BorderSize = 0;
            this.BtnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.BtnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnRegister.Location = new System.Drawing.Point(97, 268);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(109, 35);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(116, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 26);
            this.label13.TabIndex = 3;
            this.label13.Text = "GoFast";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.FrecciaRec);
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(619, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(276, 329);
            this.panel1.TabIndex = 17;
            // 
            // FrecciaRec
            // 
            this.FrecciaRec.Image = ((System.Drawing.Image)(resources.GetObject("FrecciaRec.Image")));
            this.FrecciaRec.Location = new System.Drawing.Point(3, 3);
            this.FrecciaRec.Name = "FrecciaRec";
            this.FrecciaRec.Size = new System.Drawing.Size(51, 43);
            this.FrecciaRec.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FrecciaRec.TabIndex = 2;
            this.FrecciaRec.TabStop = false;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(131, 98);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(37, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "E-mail";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(82, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Send e-mail";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(101, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "GoFast";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.TxtChat);
            this.panel2.Controls.Add(this.LblNomeChat);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Location = new System.Drawing.Point(901, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(317, 329);
            this.panel2.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Forte", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(19, 3);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 26);
            this.label15.TabIndex = 3;
            this.label15.Text = "GoFast";
            // 
            // LblNomeChat
            // 
            this.LblNomeChat.AutoSize = true;
            this.LblNomeChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeChat.ForeColor = System.Drawing.SystemColors.Control;
            this.LblNomeChat.Location = new System.Drawing.Point(128, 42);
            this.LblNomeChat.Name = "LblNomeChat";
            this.LblNomeChat.Size = new System.Drawing.Size(49, 17);
            this.LblNomeChat.TabIndex = 8;
            this.LblNomeChat.Text = "Name";
            // 
            // TxtChat
            // 
            this.TxtChat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtChat.Location = new System.Drawing.Point(4, 296);
            this.TxtChat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtChat.Name = "TxtChat";
            this.TxtChat.Size = new System.Drawing.Size(264, 30);
            this.TxtChat.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(269, 294);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 639);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "GoFast";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.SignIn.ResumeLayout(false);
            this.SignIn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrecciaReg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrecciaRec)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel Home;
        private System.Windows.Forms.TextBox TxtPassHome;
        private System.Windows.Forms.TextBox TxtUserHome;
        private System.Windows.Forms.Label LblPassHome;
        private System.Windows.Forms.Label LblUserHome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblRecoveryHome;
        private System.Windows.Forms.Button BtnLoginHome;
        private System.Windows.Forms.Panel SignIn;
        private System.Windows.Forms.TextBox TxtAgeReg;
        private System.Windows.Forms.TextBox TxtConfPassReg;
        private System.Windows.Forms.PictureBox FrecciaReg;
        private System.Windows.Forms.TextBox TxtPassReg;
        private System.Windows.Forms.TextBox TxtUserReg;
        private System.Windows.Forms.TextBox TxtMailReg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtnSignInHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox FrecciaRec;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox TxtChat;
        private System.Windows.Forms.Label LblNomeChat;
        private System.Windows.Forms.Label label15;
    }
}

