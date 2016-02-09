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

        public static string userName;

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
            userName = UserNameField.Text;
            string password = PasswordField.Text;
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
                    if(data.isAdmin(userName) == true)
                    {
                        MessageBox.Show("Welcome Admin");
                        AdminWindow ad = new AdminWindow();
                        ad.RefToLogin = this;
                        this.Visible = false;
                        ad.Show();
                       
                    }
                    else
                    {
                        MessageBox.Show("Welcome User");
                        UserWindow us = new UserWindow();
                        us.RefToLogin = this;
                        this.Visible = false;
                        us.Show();

                    }
                    UserNameField.Text = string.Empty;
                    PasswordField.Text = string.Empty;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.DarkGreen;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            LogInButton.BackColor = Color.Chartreuse;
        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.DarkGreen;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.BackColor = Color.Chartreuse;
        }
    }
}
