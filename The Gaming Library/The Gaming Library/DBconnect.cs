//Allows code to understand SQL commands and objects
using MySql.Data.MySqlClient;
using System.Collections.Generic;
//Outputs visual errors and information
using System.Windows.Forms;
using System.Diagnostics;
//namespaces so I do not need to put system. and system.IO. in front of every command
using System;
using System.IO;

namespace The_Gaming_Library
{
    class DBconnect
    {
        //database object
        private MySqlConnection connection;
        //server string, will be assigned value of localhost
        private string server;
        //database string, assigned connectcsharptomysql
        private string database;
        private string uid;
        private string password;

        //Constructor
        public void DBConnect()
        {
            //Creates an instance of the DBConnect object, with variables filled in
            Initialize();
        }

        //Initialize values to use as credentials for database connection
        private void Initialize()
        {
            server = "localhost";
            database = "ptag";
            uid = "root";
            password = "spinner";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //attempt to open connection to database
        public bool OpenConnection()
        {
            try
            {
                //Attempts to open the database connection
                connection.Open();
                return true;
            }
            //Catch any errors that may occur and repor them
            catch (MySqlException ex)
            {
                //When handling errors, you can your application's response based 
                //on the error number.
                //The two most common error numbers when connecting are as follows:
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server. Error");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public void Validate(string username, string password)
        {
            string query = "UPDATE tableinfo SET name='Joe', age='22' WHERE name='John Smith'";

            //Open connection, check if it is functioning properly
            if (this.OpenConnection() == true)
            {
                //create mysql command
                MySqlCommand cmd = new MySqlCommand();
                //Assign the query using CommandText
                cmd.CommandText = query;
                //Assign the connection using Connection
                cmd.Connection = connection;

                //Execute query
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }
    }
}
