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
    public partial class AdminAddGame : UserControl
    {
        public AdminAddGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void logOut_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
        }
        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chartreuse;
        }
    }
}
