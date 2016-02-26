using System;
using System.Drawing;
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
        private void button1_Click(object sender, EventArgs e)
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
            button1.BackColor = Color.DarkGreen;
        }
        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chartreuse;
        }

        private void checkIn_Click(object sender, EventArgs e)
        {
            DBconnect inchk = new DBconnect();
            inchk.DBConnect();
            if (inchk.checkinEligible(name) == true)
            {
                checkIn1.Visible = true;
                checkIn1.CheckInUPC.Focus();
                this.AcceptButton = checkIn1.button1;
            }
            else
            {
                MessageBox.Show("You cannot check-in a game if you have not checked one out.\nPlease hit the Check-Out button to select a game to rent.");
            }
        }

        private void checkOut_Click(object sender, EventArgs e)
        {
            DBconnect outchk = new DBconnect();
            outchk.DBConnect();
            if (outchk.checkoutEligible(name) == true)
            {
                checkOut1.Visible = true;
                checkOut1.CheckOutUPC.Focus();
                this.AcceptButton = checkOut1.submit;
            }
            else
            {
                MessageBox.Show("You already have a game checked out!\nYou can only have one game checked out at a time.\nPlease check in the game you previously rented before renting another.");
            }
            
        }
    }
}

