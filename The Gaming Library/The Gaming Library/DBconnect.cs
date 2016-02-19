﻿//Allows code to understand SQL commands and objects
using MySql.Data.MySqlClient;
//Outputs visual errors and information
using System.Windows.Forms;
//namespaces so I do not need to put system. and system.IO. in front of every command
using System;

namespace The_Gaming_Library
{
    class DBconnect
    {
        //database object
        private MySqlConnection connection;
        //server string, will be assigned value of feathersup server
        private string server;
        private string database;
        private string uid;
        private string password;
        public string connectionString;

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
        public bool CloseConnection()
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
        //Used by the login window when user hits submit, checks username and password to ensure credentials are correct
        public bool Validate(string username, string password)
        {
            //Actual Sql statement that checks for a username and if it has a matching password
            string query = "SELECT * FROM Users WHERE UserName ='" + username + "'and Password ='" + password + "'";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            //Create a data reader and Execute the command
            MySqlDataReader dataReader = cmd.ExecuteReader();

            //Condition checker, if datareader was written to, that means there was a matche in the DB, and the user is authenticated
            //If datareader was not written to, there was no match and the login process fails
            if (dataReader.Read())
            {
                dataReader.Close();
                //Must always close connection
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
        //If user is authenticated, then it must be determined if they are admin status, this function checks the role field for "admin"
        public bool isAdmin(string username)
        {
            //Queries the record with the approved username
            string query = "SELECT Role FROM Users WHERE UserName ='" + username + "'";
            if (this.OpenConnection() == true)
            {
                //Pulls the role field from the selected user record, checks if it is admin
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
        //Called when an admin approves of the addition of a new game, adds that games information to the DB
        //If game is already in the DB, just increment the count column for that game, cut down reduncancy
        public void populateDB(string name, string genre, string console, string descr)
        {
            //Connection was open, must close to avoid issues
            this.CloseConnection();
            if (this.OpenConnection() == true)
            {
                //Declares an empty int variable exists, this will become 1 if the entered game is already in the DB
                int exists = 0;
                //Checks for existence of game already in DB
                using (MySqlCommand cmd = new MySqlCommand("select count(*) from Games where name = @name", connection))
                {
                    cmd.Parameters.AddWithValue("name", name);
                    //Value is not int by default, must be converted in order to see value change
                    exists = Convert.ToInt32(cmd.ExecuteScalar());
                }

                //Checks if exists is still 0, if it isn't, just increment the counter
                if (exists != 0)
                {
                    MessageBox.Show("Games already in the db, incrementing counter...");
                    //Count+1 Sql command
                    using (MySqlCommand cmd = new MySqlCommand("UPDATE Games SET count = count + 1 WHERE name=@name", connection))
                    {
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.ExecuteNonQuery();
                    }
                }
                //If exists still equals 0, it is a new game and all of the info must be added
                else
                {
                    //More lengthy Sql statement to insert all data entered into the DB in the appropriate fields
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Games(name, console, genre, description) values (@name, @console, @genre, @description)", connection))
                    {
                        //Assigns all variables to their repspective MySql fields
                        //I am using this method as it is a means of sanitizing the input, preventing any form of Sql injection
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("console", console);
                        cmd.Parameters.AddWithValue("genre", genre);
                        cmd.Parameters.AddWithValue("description", descr);
                        cmd.ExecuteNonQuery();
                    }
                    //Show successful add
                    //ToDo: Make more useful message when done developing
                    MessageBox.Show("Item should be succesfully added, check the DB");
                }
            }
            else
            {
                //In case of error show this box, should not be a problem since the DB will have already been connected at this point
                MessageBox.Show("Issues connecting to the database");
            }
            //Always close the connection
            this.CloseConnection();   
        }
    }
}


