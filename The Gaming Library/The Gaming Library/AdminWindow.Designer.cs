using System.Windows.Forms;

namespace The_Gaming_Library
{
    partial class AdminWindow
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.Inventory = new System.Windows.Forms.Button();
            this.addGame = new System.Windows.Forms.Button();
            this.adminAddGame = new The_Gaming_Library.AdminAddGame();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 24);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(1296, 64);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Hello Admin! Choose What You Would Like To Do:";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Black;
            this.Logout.Location = new System.Drawing.Point(12, 600);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(140, 70);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            this.Logout.MouseEnter += new System.EventHandler(this.logOut_MouseEnter);
            this.Logout.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            // 
            // Inventory
            // 
            this.Inventory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Inventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Inventory.CausesValidation = false;
            this.Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inventory.Location = new System.Drawing.Point(462, 139);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(404, 235);
            this.Inventory.TabIndex = 3;
            this.Inventory.Text = "View Inventory";
            this.Inventory.UseVisualStyleBackColor = false;
            this.Inventory.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.Inventory.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // addGame
            // 
            this.addGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.addGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGame.Location = new System.Drawing.Point(462, 411);
            this.addGame.Name = "addGame";
            this.addGame.Size = new System.Drawing.Size(404, 235);
            this.addGame.TabIndex = 4;
            this.addGame.Text = "Add New Game";
            this.addGame.UseVisualStyleBackColor = false;
            this.addGame.Click += new System.EventHandler(this.button2_Click);
            this.addGame.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.addGame.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // adminAddGame
            // 
            this.adminAddGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminAddGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminAddGame.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adminAddGame.Location = new System.Drawing.Point(158, 91);
            this.adminAddGame.Name = "adminAddGame";
            this.adminAddGame.Size = new System.Drawing.Size(1008, 579);
            this.adminAddGame.TabIndex = 5;
            this.adminAddGame.Visible = false;
            // 
            // AdminWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1320, 682);
            this.ControlBox = false;
            this.Controls.Add(this.adminAddGame);
            this.Controls.Add(this.addGame);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.welcomeLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button addGame;
        private AdminAddGame adminAddGame;
    }
}