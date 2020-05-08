namespace OfficialChat.Chat.Controls
{
    partial class typingBoxChat
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
            this.box = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box.HintForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.box.HintText = "Text...";
            this.box.isPassword = false;
            this.box.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.box.LineIdleColor = System.Drawing.Color.Silver;
            this.box.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(179)))), ((int)(((byte)(16)))));
            this.box.LineThickness = 3;
            this.box.Location = new System.Drawing.Point(16, 1);
            this.box.Margin = new System.Windows.Forms.Padding(4);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(602, 28);
            this.box.TabIndex = 0;
            this.box.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.box.OnValueChanged += new System.EventHandler(this.box_OnValueChanged);
            this.box.Click += new System.EventHandler(this.box_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Image = global::OfficialChat.Properties.Resources._330407_32_1_;
            this.pictureBox.Location = new System.Drawing.Point(595, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(32, 32);
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            this.pictureBox.Visible = false;
            this.pictureBox.Click += new System.EventHandler(this.box_Click);
            this.pictureBox.MouseEnter += new System.EventHandler(this.pictureBox_MouseEnter);
            this.pictureBox.MouseLeave += new System.EventHandler(this.pictureBox_MouseLeave);
            // 
            // timer
            // 
            this.timer.Interval = 200;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // typingBoxChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(140)))), ((int)(((byte)(193)))));
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.box);
            this.Name = "typingBoxChat";
            this.Size = new System.Drawing.Size(640, 35);
            this.Click += new System.EventHandler(this.box_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox box;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
    }
}
