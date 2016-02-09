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
            this.label1 = new System.Windows.Forms.Label();
            this.Logout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Inventory = new System.Windows.Forms.Button();
            this.addGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1296, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome Admin! What would you like to do?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Logout
            // 
            this.Logout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(556, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click here to make sure name is still working";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // 
            // AdminWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1320, 682);
            this.ControlBox = false;
            this.Controls.Add(this.addGame);
            this.Controls.Add(this.Inventory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminWindow";
            this.Text = "AdminWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Inventory;
        private System.Windows.Forms.Button addGame;
    }
}