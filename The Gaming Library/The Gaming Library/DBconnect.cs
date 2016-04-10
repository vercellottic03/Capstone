//Allows code to understand SQL commands and objects
using MySql.Data.MySqlClient;
//Outputs visual errors and information
using System.Windows.Forms;
//namespaces so I do not need to put system. and system.IO. in front of every command
using System;
using System.Text;
using System.Security.Cryptography;

namespace The_Gaming_Library
{
    class DBconnect
    {
        //database object
        private MySqlConnection connection;
        //server string, will be assigned value of feathersup serverC:\Users\cody\Documents\Capstone\The Gaming Library\The Gaming Library\DBconnect.cs
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
            using (MySqlCommand cmd = new MySqlCommand("select UserName from Users where UserName = @name", connection))
            {
                cmd.Parameters.AddWithValue("name", username);
                string confirm = Convert.ToString(cmd.ExecuteScalar());
                MessageBox.Show(confirm);
                if (confirm != "")
                {
                    using (MySqlCommand cmd2 = new MySqlCommand("select Salt from Users where UserName = @name", connection))
                    {
                        cmd2.Parameters.AddWithValue("name", username);
                        string salt = Convert.ToString(cmd2.ExecuteScalar());
                        MessageBox.Show(salt);
                        string combined = salt + password;
                        MessageBox.Show(combined);
                        string hashedPassword = hashPassword(combined);
                        MessageBox.Show(hashedPassword);
                        using (MySqlCommand cmd3 = new MySqlCommand("select Password from Users where UserName = @name", connection))
                        {
                            cmd3.Parameters.AddWithValue("name", username);
                            string origHash = Convert.ToString(cmd3.ExecuteScalar());
                            if(hashedPassword == origHash)
                            {
                                MessageBox.Show("It works!");
                                this.CloseConnection();
                                return true;
                            }
                            else
                            {
                                MessageBox.Show(origHash + "\n" + hashedPassword);
                                this.CloseConnection();
                                return false;
                            }
                        }
                    }
                } else
                {
                    this.CloseConnection();
                    return false;
                }
            }
        }

        //If user is authenticated, then it must be determined if they are admin status, this function checks the role field for "admin"
        public string hashPassword(string password)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += String.Format("{0:x2}", x);
            }
            return hashString;
        }
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
                    this.CloseConnection();
                    return true;
                }
                else
                {
                    this.CloseConnection();
                    return false;
                }
            }
            else
            {
                this.CloseConnection();
                return false;
            }
        }
        //Called when an admin approves of the addition of a new game, adds that games information to the DB
        //If game is already in the DB, just increment the count column for that game, cut down reduncancy
        public void populateDB(string name, string genre, string console, string descr, string upc, string image)
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
                    MessageBox.Show("Games already in the db, incrementing counter.");
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
                    using (MySqlCommand cmd = new MySqlCommand("INSERT INTO Games(name, console, genre, description, image, UPC) values (@name, @console, @genre, @description, @image, @UPC)", connection))
                    {
                        //Assigns all variables to their repspective MySql fields
                        //I am using this method as it is a means of sanitizing the input, preventing any form of Sql injection
                        cmd.Parameters.AddWithValue("name", name);
                        cmd.Parameters.AddWithValue("console", console);
                        cmd.Parameters.AddWithValue("genre", genre);
                        cmd.Parameters.AddWithValue("description", descr);
                        cmd.Parameters.AddWithValue("image", image);
                        cmd.Parameters.AddWithValue("UPC", upc);
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

        private static string qName, qConsole, qSDescr, qImage;
        public Tuple<string, string, string, string> checkoutQuery(string username, string gameCode)
        {
            int exists = 0;
            this.CloseConnection();
            this.OpenConnection();
            qName = ""; qConsole = ""; qSDescr = ""; qImage = "";
            using (MySqlCommand cmd = new MySqlCommand("select name, console, description, image from Games where UPC = @gamecode", connection))
            {
                cmd.Parameters.AddWithValue("gamecode", gameCode);
                exists = Convert.ToInt32(cmd.ExecuteNonQuery());
                //MessageBox.Show(Convert.ToString(exists));
                if (exists != 0)
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            qName = reader.GetString(0);
                            qConsole = reader.GetString(1);
                            qSDescr = reader.GetString(2);
                            qImage = reader.GetString(3);
                            //MessageBox.Show(qConsole, qImage);
                        }
                    }
                }
                else
                {
                    //MessageBox.Show("The item you scanned is not in our database\nYou must scan a game currently available in the locker");
                    return Tuple.Create("", "", "", "");
                }
            }
            //MessageBox.Show(qName + "\n" + qConsole + "\n" + qSDescr + "\n" + qImage);
            return Tuple.Create(qName, qConsole, qSDescr, qImage);
        }
        public void checkoutConfirm(string username, string gameName)
        {
            DateTime dateIn = DateTime.Now;
            DateTime dateDue = DateTime.Now.AddDays(7.5);
            this.CloseConnection();
            this.OpenConnection();
            using(MySqlCommand cmd = new MySqlCommand("Insert into CheckoutLog(userId,gameId,checkoutTime,dueDate) values(@username,@gamename,@outtime,@duedate)",connection))
            {
                cmd.Parameters.AddWithValue("username", username);
                cmd.Parameters.AddWithValue("gamename", gameName);
                cmd.Parameters.AddWithValue("outtime", dateIn);
                cmd.Parameters.AddWithValue("duedate", dateDue);
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("Game Checked Out!\nYour game is due back " + dateDue);
            this.CloseConnection();
        }
        public void checkInConfirm(string username, string gameId)
        {
            string game = "";
            this.CloseConnection();
            this.OpenConnection();
            using (MySqlCommand findName = new MySqlCommand("select name from Games where UPC = @upc", connection))
            {
                findName.Parameters.AddWithValue("upc", gameId);
                game = Convert.ToString(findName.ExecuteScalar());
                MessageBox.Show(game);
            }
            if (game != "")
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT TransactionId FROM CheckoutLog WHERE gameId = @game1 AND userId = @name1 AND completed = " + 0, connection))
                {
                    cmd.Parameters.AddWithValue("name1", username);
                    cmd.Parameters.AddWithValue("game1", game);
                    int result = Convert.ToInt32(cmd.ExecuteScalar());
                    MessageBox.Show(Convert.ToString(result));
                    using (MySqlCommand update = new MySqlCommand("UPDATE CheckoutLog SET completed = 1 WHERE TransactionId = @id", connection))
                    {
                        update.Parameters.AddWithValue("id", result);
                        update.ExecuteNonQuery();
                    }
                        MessageBox.Show("Game Successfully returned!\nThank you for using the Gaming Locker!\nYou may pick another game to checkout now.");
                }
            }
            else
            {
                MessageBox.Show("An error occurred and we were unable to process your requst.\nThe item you scanned was not the game you have checked out, please scan the proper item.");
            }
        }
        public bool checkinEligible(string username)
        {
            this.CloseConnection();
            this.OpenConnection();
            int exists = 0;
            using (MySqlCommand cmd = new MySqlCommand("SELECT TransactionId FROM CheckoutLog WHERE userId = @username AND completed = "+0, connection))
            {
                cmd.Parameters.AddWithValue("username", username);
                exists = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (exists != 0)
            {
                this.CloseConnection();
                return true;

            }
            else
            {
                //MessageBox.Show("You can't check in a game if you have not checked one out");
                this.CloseConnection();
                return false;
            }
        }
        public bool checkoutEligible(string username)
        {
            this.CloseConnection();
            this.OpenConnection();
            int exists = 0;
            using (MySqlCommand cmd = new MySqlCommand("SELECT TransactionId FROM CheckoutLog WHERE userId = @username AND completed = " + 0, connection))
            {
                cmd.Parameters.AddWithValue("username", username);
                exists = Convert.ToInt32(cmd.ExecuteScalar());
            }
            if (exists != 0)
            {
                this.CloseConnection();
                return false;

            }
            else
            {
                //MessageBox.Show("You can't check in a game if you have not checked one out");
                this.CloseConnection();
                return true;
            }
        }
    }
}
    


