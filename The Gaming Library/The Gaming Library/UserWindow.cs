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
    public partial class UserWindow : Form
    {
        
        public UserWindow()
        {
            InitializeComponent();
        }
        string name = LOGINWINDOW.userName;

        public Form RefToLogin { get; set; }

        private void Logout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RefToLogin.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            checkIn.BackColor = Color.DarkGreen;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            checkIn.BackColor = Color.Chartreuse;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            checkOut.BackColor = Color.DarkGreen;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            checkOut.BackColor = Color.Chartreuse;
        }
        private void logOut_MouseEnter(object sender, EventArgs e)
        {
            Logout.BackColor = Color.DarkGreen;
        }
        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            Logout.BackColor = Color.Chartreuse;
        }

        private void UserWindow_Load(object sender, EventArgs e)
        {
            
        }
    }
}

