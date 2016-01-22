namespace PTAG_GAming_Library_LocalApp
{
    partial class PTAG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PTAG));
            this.welcomeBanner = new System.Windows.Forms.Label();
            this.PTAGlogo = new System.Windows.Forms.PictureBox();
            this.enterButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PTAGlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeBanner
            // 
            this.welcomeBanner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.welcomeBanner.AutoSize = true;
            this.welcomeBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.welcomeBanner.Location = new System.Drawing.Point(154, 165);
            this.welcomeBanner.Name = "welcomeBanner";
            this.welcomeBanner.Size = new System.Drawing.Size(957, 63);
            this.welcomeBanner.TabIndex = 0;
            this.welcomeBanner.Text = "Welcome to the PTAG Gaming Locker!";
            this.welcomeBanner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.welcomeBanner.Click += new System.EventHandler(this.label1_Click);
            // 
            // PTAGlogo
            // 
            this.PTAGlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PTAGlogo.Image = ((System.Drawing.Image)(resources.GetObject("PTAGlogo.Image")));
            this.PTAGlogo.Location = new System.Drawing.Point(327, 243);
            this.PTAGlogo.Name = "PTAGlogo";
            this.PTAGlogo.Size = new System.Drawing.Size(603, 456);
            this.PTAGlogo.TabIndex = 1;
            this.PTAGlogo.TabStop = false;
            // 
            // enterButton
            // 
            this.enterButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.enterButton.AutoSize = true;
            this.enterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enterButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enterButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.enterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enterButton.Location = new System.Drawing.Point(506, 705);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(261, 50);
            this.enterButton.TabIndex = 2;
            this.enterButton.Text = "Click Here To Enter";
            this.enterButton.UseVisualStyleBackColor = false;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // PTAG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1308, 838);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.PTAGlogo);
            this.Controls.Add(this.welcomeBanner);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "PTAG";
            this.Text = "The PTAG Gaming Locker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTAGlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeBanner;
        private System.Windows.Forms.PictureBox PTAGlogo;
        private System.Windows.Forms.Button enterButton;
    }
}

