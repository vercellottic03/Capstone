namespace The_Gaming_Library
{
    partial class inventoryView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.inventoryGrid = new System.Windows.Forms.DataGridView();
            this.games = new The_Gaming_Library.Games();
            this.gamesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gamesTableAdapter = new The_Gaming_Library.GamesTableAdapters.GamesTableAdapter();
            this.gameIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consoleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.games)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryGrid
            // 
            this.inventoryGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inventoryGrid.AutoGenerateColumns = false;
            this.inventoryGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.inventoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gameIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.consoleDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn});
            this.inventoryGrid.DataSource = this.gamesBindingSource;
            this.inventoryGrid.GridColor = System.Drawing.Color.Chartreuse;
            this.inventoryGrid.Location = new System.Drawing.Point(12, 12);
            this.inventoryGrid.Name = "inventoryGrid";
            this.inventoryGrid.Size = new System.Drawing.Size(873, 419);
            this.inventoryGrid.TabIndex = 0;
            this.inventoryGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.inventoryGrid_CellContentClick);
            // 
            // games
            // 
            this.games.DataSetName = "Games";
            this.games.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gamesBindingSource
            // 
            this.gamesBindingSource.DataMember = "Games";
            this.gamesBindingSource.DataSource = this.games;
            // 
            // gamesTableAdapter
            // 
            this.gamesTableAdapter.ClearBeforeFill = true;
            // 
            // gameIdDataGridViewTextBoxColumn
            // 
            this.gameIdDataGridViewTextBoxColumn.DataPropertyName = "gameId";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Chartreuse;
            this.gameIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle11;
            this.gameIdDataGridViewTextBoxColumn.HeaderText = "gameId";
            this.gameIdDataGridViewTextBoxColumn.Name = "gameIdDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Chartreuse;
            this.nameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "genre";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Chartreuse;
            this.genreDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.genreDataGridViewTextBoxColumn.HeaderText = "genre";
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            // 
            // consoleDataGridViewTextBoxColumn
            // 
            this.consoleDataGridViewTextBoxColumn.DataPropertyName = "console";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Chartreuse;
            this.consoleDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.consoleDataGridViewTextBoxColumn.HeaderText = "console";
            this.consoleDataGridViewTextBoxColumn.Name = "consoleDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "count";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Chartreuse;
            this.countDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle15;
            this.countDataGridViewTextBoxColumn.HeaderText = "count";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 135);
            this.button1.TabIndex = 1;
            this.button1.Text = "Confirm Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inventoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(897, 443);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.inventoryGrid);
            this.Name = "inventoryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "inventoryView";
            this.Load += new System.EventHandler(this.inventoryView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.games)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gamesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView inventoryGrid;
        private Games games;
        private System.Windows.Forms.BindingSource gamesBindingSource;
        private GamesTableAdapters.GamesTableAdapter gamesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gameIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consoleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}