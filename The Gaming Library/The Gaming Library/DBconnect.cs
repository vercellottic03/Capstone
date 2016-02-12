//Allows code to understand SQL commands and objects
using MySql.Data.MySqlClient;
using System.Collections.Generic;
//Outputs visual errors and information
using System.Windows.Forms;
using System.Diagnostics;
//namespaces so I do not need to put system. and system.IO. in front of every command
using System;
using System.IO;
using System.Data;

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
        private string connectionString;

        //Constructor
        public void DBConnect()
        {
            //Creates an instance of the DBConnect object, with variables filled in
            Initialize();
        }

        //Initialize values to use as credentials for database connection
        private void Initialize()
        {
            server = "192.185.150.102";
            database = "feathers_ptag";
            uid = "feathers_ptag";
            password = "P3@c0ck$";

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
        public bool Validate(string username, string password)
        {
            string query = "SELECT * FROM Users WHERE UserName ='" + username + "'and Password ='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();


            if (dataReader.Read())
            {
                dataReader.Close();
                this.CloseConnection();
                return true;
            }
            else
            {
                dataReader.Close();
                this.CloseConnection();
                return false;
            }
        }
        public bool isAdmin(string username)
        {
            string query = "SELECT Role FROM Users WHERE UserName ='" + username + "'";
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                string role = Convert.ToString(cmd.ExecuteScalar());
                if (role == "admin")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

