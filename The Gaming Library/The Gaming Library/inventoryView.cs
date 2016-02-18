using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class inventoryView : Form
    {
        private MySqlDataAdapter da;
        private DataSet ds;
        private string sTable = "Games";
        public inventoryView()
        {
            InitializeComponent();
        }

        private void inventoryView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'games._Games' table. You can move, or remove it, as needed.
            this.gamesTableAdapter.Fill(this.games._Games);

        }

        private void inventoryGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            inventoryGrid.Update();
            inventoryGrid.EndEdit();
            MessageBox.Show("It works");
        }
    }
}
