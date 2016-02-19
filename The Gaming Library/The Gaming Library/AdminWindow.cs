using System;
using System.Drawing;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class AdminWindow : Form
    {
        //Function that allows me to retrive the loginpage after it has been hidden when sign-in complete
        public Form RefToLogin { get; set; }
        //Pass the username from the login form in case the name is needed
        string name = LOGINWINDOW.userName;
        public AdminWindow()
        {
            InitializeComponent();
        }

        //Is called when the logout button is clicked
        private void Logout_Click(object sender, EventArgs e)
        {
            //Pop-up that asks if you would like to sign off, if yes, then login page is recalled and session terminated
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "EXIT", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.RefToLogin.Show();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing if they pick no
            }
        }

        //Activated when Add Game is selected, the AdminAddGame User control that is already present on the page becomes visible
        private void button2_Click(object sender, EventArgs e)
        {
            adminAddGame.Visible = true;
            //Ensures the text field on the user control is highlighted for the sake of the barcode reader 
            adminAddGame.GameUPC.Focus();
        }

        //Activated when Inventory button is selected, just opens the ViewInventory form
        private void Inventory_Click(object sender, EventArgs e)
        {
            ViewInventory grid = new ViewInventory();
            grid.Show();
        }

        //Color functions that indicate whichever button the cursor is currently hovering over
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            addGame.BackColor = Color.DarkGreen;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            addGame.BackColor = Color.Chartreuse;
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Inventory.BackColor = Color.DarkGreen;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Inventory.BackColor = Color.Chartreuse;
        }
        private void logOut_MouseEnter(object sender, EventArgs e)
        {
            Logout.BackColor = Color.DarkGreen;
        }
        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            Logout.BackColor = Color.Chartreuse;
        }
    }
}
