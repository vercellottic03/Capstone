namespace The_Gaming_Library
{
    partial class confirmCheckout
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(469, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would You Like to check this game out?";
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.Chartreuse;
            this.gameName.Location = new System.Drawing.Point(497, 94);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(95, 36);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "label2";
            // 
            // console
            // 
            this.console.AutoSize = true;
            this.console.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.console.ForeColor = System.Drawing.Color.Chartreuse;
            this.console.Location = new System.Drawing.Point(497, 142);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(95, 36);
            this.console.TabIndex = 3;
            this.console.Text = "label3";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Chartreuse;
            this.description.Location = new System.Drawing.Point(498, 194);
            this.description.MaximumSize = new System.Drawing.Size(600, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(64, 25);
            this.description.TabIndex = 4;
            this.description.Text = "label4";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Chartreuse;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.Location = new System.Drawing.Point(1054, 360);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(149, 83);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Chartreuse;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(503, 360);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(149, 83);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "Confirm";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // confirmCheckout
            // 
            this.AcceptButton = this.confirm;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(1233, 519);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.description);
            this.Controls.Add(this.console);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "confirmCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "confirmCheckout";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label console;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button confirm;
    }
}