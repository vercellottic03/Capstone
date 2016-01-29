using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace The_Gaming_Library
{
    public partial class LOGINWINDOW : Form
    {
        public LOGINWINDOW()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text;
            string password = textBox2.Text;
            DBconnect data = new DBconnect();
            data.DBConnect();
            bool isOpen = data.OpenConnection();
            if(isOpen == false)
            {
                MessageBox.Show("Failed to establish database connection");
            }
            else
            {
                if (data.Validate(userName, password) == false)
                {
                    MessageBox.Show("Invalid user name or password, please try again");
                }
                else
                {
                    MessageBox.Show("Were in");
                }
            }
        }
    }
}
