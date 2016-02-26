namespace The_Gaming_Library
{
    partial class LOGINWINDOW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOGINWINDOW));
            this.loginTitle = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.UserNameField = new System.Windows.Forms.TextBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.LogInButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PleaseLogin = new System.Windows.Forms.Label();
            this.PTAGLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PTAGLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // loginTitle
            // 
            this.loginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginTitle.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTitle.ForeColor = System.Drawing.Color.Chartreuse;
            this.loginTitle.Location = new System.Drawing.Point(32, 27);
            this.loginTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginTitle.Name = "loginTitle";
            this.loginTitle.Size = new System.Drawing.Size(950, 63);
            this.loginTitle.TabIndex = 0;
            this.loginTitle.Text = "WELCOME TO THE PTAG GAMING LOCKER!";
            this.loginTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.usernameLabel.Location = new System.Drawing.Point(551, 181);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(230, 39);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "USER NAME:";
            // 
            // UserNameField
            // 
            this.UserNameField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserNameField.Location = new System.Drawing.Point(775, 190);
            this.UserNameField.Margin = new System.Windows.Forms.Padding(2);
            this.UserNameField.Name = "UserNameField";
            this.UserNameField.Size = new System.Drawing.Size(187, 22);
            this.UserNameField.TabIndex = 2;
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PasswordField.Location = new System.Drawing.Point(775, 260);
            this.PasswordField.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.PasswordChar = '*';
            this.PasswordField.Size = new System.Drawing.Size(187, 22);
            this.PasswordField.TabIndex = 3;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.passwordLabel.Location = new System.Drawing.Point(554, 251);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(226, 39);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "PASSWORD:";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogInButton
            // 
            this.LogInButton.BackColor = System.Drawing.Color.Chartreuse;
            this.LogInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(805, 329);
            this.LogInButton.Margin = new System.Windows.Forms.Padding(2);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(157, 61);
            this.LogInButton.TabIndex = 6;
            this.LogInButton.Text = "LOGIN";
            this.LogInButton.UseVisualStyleBackColor = false;
            this.LogInButton.Click += new System.EventHandler(this.button1_Click);
            this.LogInButton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.LogInButton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Chartreuse;
            this.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(557, 329);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(159, 61);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "EXIT";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.button2_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // PleaseLogin
            // 
            this.PleaseLogin.AutoSize = true;
            this.PleaseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PleaseLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.PleaseLogin.Location = new System.Drawing.Point(670, 123);
            this.PleaseLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PleaseLogin.Name = "PleaseLogin";
            this.PleaseLogin.Size = new System.Drawing.Size(266, 39);
            this.PleaseLogin.TabIndex = 0;
            this.PleaseLogin.Text = "PLEASE LOGIN";
            // 
            // PTAGLogo
            // 
            this.PTAGLogo.Image = ((System.Drawing.Image)(resources.GetObject("PTAGLogo.Image")));
            this.PTAGLogo.Location = new System.Drawing.Point(111, 141);
            this.PTAGLogo.Name = "PTAGLogo";
            this.PTAGLogo.Size = new System.Drawing.Size(300, 220);
            this.PTAGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PTAGLogo.TabIndex = 8;
            this.PTAGLogo.TabStop = false;
            // 
            // LOGINWINDOW
            // 
            this.AcceptButton = this.LogInButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.CancelButton = this.ExitButton;
            this.ClientSize = new System.Drawing.Size(1028, 434);
            this.Controls.Add(this.PTAGLogo);
            this.Controls.Add(this.PleaseLogin);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LogInButton);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.PasswordField);
            this.Controls.Add(this.UserNameField);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "LOGINWINDOW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            this.Load += new System.EventHandler(this.LOGINWINDOW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PTAGLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginTitle;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox UserNameField;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label PleaseLogin;
        private System.Windows.Forms.PictureBox PTAGLogo;
    }
}

