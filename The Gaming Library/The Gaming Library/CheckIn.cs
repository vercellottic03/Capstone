using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class CheckIn : UserControl
    {
        string username = LOGINWINDOW.userName;
        public CheckIn()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(CheckInUPC.Text == "")
            {
                MessageBox.Show("You must scan a game before hitting enter");
            }
            else
            {
                DialogResult confirmation = MessageBox.Show("Are you sure you want to return this game?", "Check In", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string chkinUPC = CheckInUPC.Text;
                    DBconnect chkin = new DBconnect();
                    chkin.DBConnect();
                    chkin.checkInConfirm(username, chkinUPC);
                    CheckInUPC.Clear();
                    this.Visible = false;
                }
                else if (confirmation == DialogResult.No)
                {
                    //do nothing
                }
            }
        }
    }
}
