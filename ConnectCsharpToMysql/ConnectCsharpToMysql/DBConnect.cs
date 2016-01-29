//Allows code to understand SQL commands and objects
using MySql.Data.MySqlClient;
using System.Collections.Generic;
//Outputs visual errors and information
using System.Windows.Forms;
using System.Diagnostics;
//namespaces so I do not need to put system. and system.IO. in front of every command
using System;
using System.IO;

namespace ConnectCsharpToMysql
{
    //declares DBconnect object, connects to the database to pull values and assign them to local variables
    class DBConnect
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
        public DBConnect()
        {
            //Creates an instance of the DBConnect object, with variables filled in
            Initialize();
        }

        //Initialize values to use as credentials for database connection
        private void Initialize()
        {
            server = "localhost";
            database = "connectcsharptomysql";
            uid = "root";
            password = "spinner";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //attempt to open connection to database
        private bool OpenConnection()
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

        //Close connection and stop communicating with the database
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

        //Insert statement, chooses between 3 randomly preselected people, i hated having all the same person
        public void Insert()
        {
            //crates random variable between 1 and 0, depending on output, 1 of 3 queries will be generated
            Random rand = new Random();
            double human = rand.NextDouble();
            string query;
            if (human <= .25)
            {
                //query that will add John Smith into the database
                query = "INSERT INTO tableinfo (name, age) VALUES('John Smith', '33')";
            }
            else if (human > .25 && human <= .75)
            {
                //query that will add Rachel Simmons into the database
                query = "INSERT INTO tableinfo (name, age) VALUES('Rachel Simmons', '23')";
            }
            else
            {
                //query that will add Bob Evans to the database
                query = "INSERT INTO tableinfo (name, age) VALUES('Bob Evans', '73')";
            }
            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command, add human to the database
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            } else {
                //Throw error if there is an issue
                MessageBox.Show("Cannot connect to server. Error");
            }
        }

        //Update statement, replaces all instances of John Smith with Joe, age 22, so the entire database
        public void Update()
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

        //Delete statement, removes records from the database
        public void Delete()
        {
            //Query that deletes any instance of Joe
            string query = "DELETE FROM tableinfo WHERE name='Joe'";

            if (this.OpenConnection() == true)
            {
                //Execute the delete query and close the database connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Wipe the database clean to restart
        public void ClearDb()
        {
            //Query that deletes everything
            string query = "truncate tableinfo";

            if (this.OpenConnection() == true)
            {
                //Execute the delete query and close the database connection
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement that will acquire all of the records in the databse and place them into an array, only creating an array of 3 for this example
        public List<string>[] Select()
        {
            //Select all query
            string query = "SELECT * FROM tableinfo";

            //Create a 3 element long list to store the first three results
            List<string>[] list = new List<string>[3];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["id"] + "");
                    list[1].Add(dataReader["name"] + "");
                    list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        //Count statement, counts how many records are in the database
        public int Count()
        {
            //select all elements fromt the database, establish count, -1 because 0 would imply empty array
            string query = "SELECT Count(*) FROM tableinfo";
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value, the integer value of the first element of the last record
                //In this database, that is the primary key, which is an auto incrementing number, aka the count.
                Count = int.Parse(cmd.ExecuteScalar() + "");
                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup function, creates a copy of the database with a timestamp
        public void Backup()
        {
            try
            {
                //Assign all variables to current time and date
                DateTime Time = DateTime.Now;
                int year = Time.Year;
                int month = Time.Month;
                int day = Time.Day;
                int hour = Time.Hour;
                int minute = Time.Minute;
                int second = Time.Second;
                int millisecond = Time.Millisecond;

                //Save file to C:\ with the current date as a filename
                string path;
                path = "C:\\Users\\Cody\\Documents\\CSharpTable" + year + "-" + month + "-" + day +
            "-" + hour + "-" + minute + "-" + second + "-" + millisecond + ".sql";
                //Streamwrite allows a string to be written as a physcial path that can be navigated to
                StreamWriter file = new StreamWriter(path);

                //Specifies a set of values that will be used when you start a new process
                ProcessStartInfo psi = new ProcessStartInfo();
                //Assign characteristics to psi object
                psi.FileName = "mysqldump";
                psi.RedirectStandardInput = false;
                psi.RedirectStandardOutput = true;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;

                //Start local system process
                Process process = Process.Start(psi);

                string output;
                //get output of process and assign it to a string value
                output = process.StandardOutput.ReadToEnd();
                file.WriteLine(output);
                process.WaitForExit();
                file.Close();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to backup!");
            }
        }

        //Restore function, reverses the backup process and recreates the database
        public void Restore()
        {
            try
            {
                //Read file from C:\
                string path;
                path = "C:\\Users\\Cody\\Documents\\CSharpTable\\MySqlBackup.sql";
                //read the generated sql file and assign it to a new streamreader object
                StreamReader file = new StreamReader(path);
                string input = file.ReadToEnd();
                file.Close();

                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = "mysql";
                psi.RedirectStandardInput = true;
                psi.RedirectStandardOutput = false;
                psi.Arguments = string.Format(@"-u{0} -p{1} -h{2} {3}",
                    uid, password, server, database);
                psi.UseShellExecute = false;


                Process process = Process.Start(psi);
                process.StandardInput.WriteLine(input);
                process.StandardInput.Close();
                process.WaitForExit();
                process.Close();
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error , unable to Restore!");
            }
        }
    }
}
