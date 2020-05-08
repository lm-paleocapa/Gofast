namespace OfficialChat.Chat.Controls
{
    partial class User
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
            this.components = new System.ComponentModel.Container();
            this.pictureboxAdd = new System.Windows.Forms.PictureBox();
            this.pictureSetting = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureboxAdd
            // 
            this.pictureboxAdd.Image = global::OfficialChat.Properties.Resources.icons8_plus_math_30;
            this.pictureboxAdd.Location = new System.Drawing.Point(127, 14);
            this.pictureboxAdd.Name = "pictureboxAdd";
            this.pictureboxAdd.Size = new System.Drawing.Size(30, 30);
            this.pictureboxAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureboxAdd.TabIndex = 2;
            this.pictureboxAdd.TabStop = false;
            this.pictureboxAdd.Click += new System.EventHandler(this.pictureboxAdd_Click);
            this.pictureboxAdd.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureboxAdd.MouseLeave += new System.EventHandler(this.pictureboxAdd_MouseLeave);
            // 
            // pictureSetting
            // 
            this.pictureSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureSetting.Image = global::OfficialChat.Properties.Resources.icons8_menu_2_30;
            this.pictureSetting.Location = new System.Drawing.Point(172, 13);
            this.pictureSetting.Margin = new System.Windows.Forms.Padding(0);
            this.pictureSetting.Name = "pictureSetting";
            this.pictureSetting.Size = new System.Drawing.Size(20, 32);
            this.pictureSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureSetting.TabIndex = 1;
            this.pictureSetting.TabStop = false;
            this.pictureSetting.Click += new System.EventHandler(this.pictureSetting_Click);
            this.pictureSetting.MouseEnter += new System.EventHandler(this.pictureSetting_MouseEnter);
            this.pictureSetting.MouseLeave += new System.EventHandler(this.pictureSetting_MouseLeave);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(8, 7);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(45, 45);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 5;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(59)))), ((int)(((byte)(69)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pictureboxAdd);
            this.Controls.Add(this.pictureSetting);
            this.Controls.Add(this.pictureBox);
            this.Name = "User";
            this.Size = new System.Drawing.Size(200, 57);
            this.Load += new System.EventHandler(this.User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox pictureSetting;
        private System.Windows.Forms.PictureBox pictureboxAdd;
        private System.Windows.Forms.Timer timer;
    }
}
