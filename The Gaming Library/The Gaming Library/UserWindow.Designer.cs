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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.checkOut = new System.Windows.Forms.Button();
            this.checkIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Stencil", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(-128, 49);
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
            this.checkOut.Location = new System.Drawing.Point(701, 481);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(355, 164);
            this.checkOut.TabIndex = 6;
            this.checkOut.Text = "Check-Out";
            this.checkOut.UseVisualStyleBackColor = false;
            this.checkOut.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.checkOut.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // checkIn
            // 
            this.checkIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkIn.BackColor = System.Drawing.Color.LawnGreen;
            this.checkIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkIn.Location = new System.Drawing.Point(701, 245);
            this.checkIn.Name = "checkIn";
            this.checkIn.Size = new System.Drawing.Size(355, 164);
            this.checkIn.TabIndex = 5;
            this.checkIn.Text = "Check-In";
            this.checkIn.UseVisualStyleBackColor = false;
            this.checkIn.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.checkIn.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // UserWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1799, 869);
            this.Controls.Add(this.checkIn);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeBox = false;
            this.Name = "UserWindow";
            this.Text = "PTAG Gaming Library";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.Button checkIn;
    }
}