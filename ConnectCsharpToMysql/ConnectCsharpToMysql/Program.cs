using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConnectCsharpToMysql
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Creates new instance of the DBconnect object, allows the code to modify the Database
            DBConnect newDB = new DBConnect();
            //Add 10 random records into the blank DB
            for (int i = 0; i < 10; i++)
            {
                newDB.Insert();
            }
            //Changes all of the John Smith to Joe
            newDB.Update();
            //Database before the deletion of the Joes
            //Show text box 
            MessageBox.Show("Database before the deletion of the Joes");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Display a form showing the data currently in the database
            Application.Run(new outputTable());
            //Delete all of the Joes form the database
            newDB.Delete();
            //Database after the deletion of the Joes
            MessageBox.Show("Database after the deletion of the Joes");
            Application.EnableVisualStyles();
            //Show table sans the Joes
            Application.Run(new outputTable());
            //Delete the contents of the table
            newDB.ClearDb();
            MessageBox.Show("Table cleared");
            Application.EnableVisualStyles();
            //Show empty table
            Application.Run(new outputTable());


        }
    }
}
