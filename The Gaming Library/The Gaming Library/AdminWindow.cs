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
    public partial class AdminWindow : Form
    {
        public Form RefToLogin { get; set; }
        string name = LOGINWINDOW.userName;
        public AdminWindow()
        {
            InitializeComponent();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            adminAddGame.Visible = true;
            adminAddGame.GameUPC.Focus();
        }

    }
}
