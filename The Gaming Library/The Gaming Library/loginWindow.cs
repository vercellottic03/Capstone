using System;
using System.Drawing;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class LOGINWINDOW : Form
    {
        //Allows username to be passed to other forms
        public static string userName;

        public LOGINWINDOW()
        {
            InitializeComponent();
        }

        //Exit button, closes the whole application, ending it all
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Submit button, initiates login when clicked
        private void button1_Click(object sender, EventArgs e)
        {
            //Assigns username and password variables to their repsective text fields
            userName = UserNameField.Text;
            string password = PasswordField.Text;
            UserNameField.Focus();
            //Creates DBconnect object that will handle DB work
            DBconnect data = new DBconnect();
            data.DBConnect();
            bool isOpen = data.OpenConnection();
            if(isOpen == false)
            {
                MessageBox.Show("Failed to establish database connection");
            }
            else
            {
                //See DBconnect.cs for implementation, if function returns false, user credentials were denied
                if (data.Validate(userName, password) == false)
                {
                    MessageBox.Show("Invalid user name or password, please try again");
                }
                else
                {
                    //Credentials are legitimate, must check if it was a user or admin 
                    if(data.isAdmin(userName) == true)
                    {
                        //user was admin, open the admin form
                        //MessageBox.Show("Welcome Admin");
                        AdminWindow ad = new AdminWindow();
                        //create reference to admin form window in order to recal this form after it is hidden
                        ad.RefToLogin = this;
                        //hide this form and display admin window
                        this.Visible = false;
                        ad.Show();
                       
                    }
                    else
                    {
                        //User was plain user, open the user form
                        //MessageBox.Show("Welcome User");
                        UserWindow us = new UserWindow();
                        //Same process as the admin
                        us.RefToLogin = this;
                        this.Visible = false;
                        us.Show();

                    }
                    //Clear all text fields and rehighlight the username so when the form is called again 
                    //everything is blank and the username is ready for another
                    UserNameField.Text = string.Empty;
                    PasswordField.Text = string.Empty;
                }
            }
        }

        //Color functions that change color of buttons depending on if a cursor is hovering over it.
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

        private void LOGINWINDOW_Load(object sender, EventArgs e)
        {

        }
    }
}
