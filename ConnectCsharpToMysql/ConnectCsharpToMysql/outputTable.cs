using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    public partial class outputTable : Form
    {
        public outputTable()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void outputTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tableImport.tableinfo' table. You can move, or remove it, as needed.
            this.tableinfoTableAdapter.Fill(this.tableImport.tableinfo);

        }
    }
}
