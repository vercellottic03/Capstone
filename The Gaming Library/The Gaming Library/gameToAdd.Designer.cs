namespace The_Gaming_Library
{
    partial class gameToAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameToAdd));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gameName = new System.Windows.Forms.Label();
            this.gamePrice = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
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
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(517, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Would You Like To Add This Game?";
            // 
            // gameName
            // 
            this.gameName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.ForeColor = System.Drawing.Color.Chartreuse;
            this.gameName.Location = new System.Drawing.Point(518, 87);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(79, 29);
            this.gameName.TabIndex = 2;
            this.gameName.Text = "label2";
            // 
            // gamePrice
            // 
            this.gamePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gamePrice.AutoSize = true;
            this.gamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamePrice.ForeColor = System.Drawing.Color.Chartreuse;
            this.gamePrice.Location = new System.Drawing.Point(518, 125);
            this.gamePrice.Name = "gamePrice";
            this.gamePrice.Size = new System.Drawing.Size(79, 29);
            this.gamePrice.TabIndex = 3;
            this.gamePrice.Text = "label3";
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.description.AutoEllipsis = true;
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Chartreuse;
            this.description.Location = new System.Drawing.Point(520, 166);
            this.description.MaximumSize = new System.Drawing.Size(500, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(51, 20);
            this.description.TabIndex = 4;
            this.description.Text = "label4";
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Chartreuse;
            this.confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm.Location = new System.Drawing.Point(620, 395);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(171, 91);
            this.confirm.TabIndex = 5;
            this.confirm.Text = "YES";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.Chartreuse;
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(944, 395);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(171, 91);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "NO";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // gameToAdd
            // 
            this.AcceptButton = this.confirm;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(1233, 519);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.description);
            this.Controls.Add(this.gamePrice);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameToAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.Label gamePrice;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button cancel;
    }
}