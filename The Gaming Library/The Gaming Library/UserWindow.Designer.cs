namespace The_Gaming_Library
{
    partial class UserWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.checkOut = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkIn1 = new The_Gaming_Library.CheckIn();
            this.checkOut1 = new The_Gaming_Library.CheckOut();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-342, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2060, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To The Gaming Locker! What Would You  Like To Do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(153, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 55);
            this.label2.TabIndex = 1;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout.BackColor = System.Drawing.Color.Chartreuse;
            this.Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(12, 787);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(140, 70);
            this.Logout.TabIndex = 2;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseEnter += new System.EventHandler(this.logOut_MouseEnter);
            this.Logout.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            // 
            // checkOut
            // 
            this.checkOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkOut.BackColor = System.Drawing.Color.Chartreuse;
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(544, 449);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(355, 164);
            this.checkOut.TabIndex = 6;
            this.checkOut.Text = "Check-Out";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.Click += new System.EventHandler(this.checkOut_Click);
            this.checkOut.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.checkOut.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkIn
            // 
            this.checkIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIn.BackColor = System.Drawing.Color.LawnGreen;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(544, 231);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(355, 164);
            this.checkIn.TabIndex = 5;
            this.checkIn.Text = "Check-In";
            this.checkIn.UseVisualStyleBackColor = false;
            this.checkIn.Click += new System.EventHandler(this.checkIn_Click);
            this.checkIn.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.checkIn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 659);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 7;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.logOut_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            // 
            // checkIn1
            // 
            this.checkIn1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkIn1.Location = new System.Drawing.Point(158, 205);
            this.checkIn1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.checkIn1.Name = "checkIn1";
            this.checkIn1.Size = new System.Drawing.Size(1014, 531);
            this.checkIn1.TabIndex = 9;
            this.checkIn1.Visible = false;
            // 
            // checkOut1
            // 
            this.checkOut1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOut1.Location = new System.Drawing.Point(158, 205);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(1019, 531);
            this.checkOut1.TabIndex = 8;
            this.checkOut1.Visible = false;
            // 
            // UserWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(1362, 741);
            this.ControlBox = false;
            this.Controls.Add(this.checkIn1);
            this.Controls.Add(this.checkOut1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "UserWindow";
            this.Text = "PTAG Gaming Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.Button checkIn;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button button1;
        private CheckOut checkOut1;
        private CheckIn checkIn1;
    }
}