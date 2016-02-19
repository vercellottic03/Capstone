using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class ViewInventory : Form
    {
        //Declare all my variables above to keep code clean
        private MySqlDataAdapter da;
        private DataSet ds;
        private string sTable = "Games";
        public ViewInventory()
        {
            InitializeComponent();
        }

        private void ViewInventory_Load(object sender, EventArgs e)
        {
            //open dbconnect object to take connectionString and use here to connect to DB
            DBconnect grid = new DBconnect();
            grid.DBConnect();
            MySqlConnection conn = new MySqlConnection(grid.connectionString);
            //Close DBconnect object to avoid collision
            grid.CloseConnection();
            //Start working with the local MySql connection
            conn.Open();
            //Exclude games that have no records
            da = new MySqlDataAdapter("SELECT * FROM Games WHERE count > 0", conn);
            //Fill the DataAdapter with current state of the DB
            ds = new DataSet();
            da.Fill(ds, sTable);
            conn.Close();
            //Show the datagridview of the current DB
            dataGridView1.Refresh();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = sTable;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Sets the environment to run an Sql command with the DataAdapter
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(da);
            //Update command that actually updates the value in the DB with what was inputted in the grid(Only count can be altered)
            da.Update(ds, sTable);
            //Show successful completion and close the form
            MessageBox.Show("Table Updated\n\nThis form will now close");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This is the cancel button, closes the form without doing anything
            this.Close();
        }
    }
}
