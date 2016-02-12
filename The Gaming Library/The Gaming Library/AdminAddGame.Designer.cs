namespace The_Gaming_Library
{
    partial class AdminAddGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameUPC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(77, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(993, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Scan The Game You Wish To Add:";
            // 
            // GameUPC
            // 
            this.GameUPC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GameUPC.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.GameUPC.Location = new System.Drawing.Point(448, 248);
            this.GameUPC.Name = "GameUPC";
            this.GameUPC.Size = new System.Drawing.Size(251, 20);
            this.GameUPC.TabIndex = 1;
            this.GameUPC.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.logOut_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.logOut_MouseLeave);
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.Location = new System.Drawing.Point(705, 258);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(10, 10);
            this.submit.TabIndex = 3;
            this.submit.Text = "submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // AdminAddGame
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.submit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GameUPC);
            this.Controls.Add(this.label1);
            this.Name = "AdminAddGame";
            this.Size = new System.Drawing.Size(1155, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public  System.Windows.Forms.TextBox GameUPC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button submit;
    }
}
