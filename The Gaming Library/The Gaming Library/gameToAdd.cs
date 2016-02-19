using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class gameToAdd : Form
    {
        public gameToAdd()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            //Pass all of the parsed variables from the AdminAddGame User control to be displayed here
            //they are passed on the loading of the form so the data will be displayed right when the window pops up
            gameName.Text = AdminAddGame.gameName;
            gamePrice.Text = AdminAddGame.console;
            description.Text = AdminAddGame.description;
            string url = AdminAddGame.imageLink;
            displayImage(url);
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }

        //Displays the URL taken from the XML as a picture 
        private void displayImage(string imageURL)
        {
            //MessageBox.Show(imageURL);
            var request = WebRequest.Create(imageURL);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
                pictureBox1.Visible = true;
            }
            request = null;
        }

        //Cancel button, clears the image and closes the form
        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            this.Close();
        }

        //Function called when yes is selected, begins the process of 
        private void button1_Click(object sender, EventArgs e)
        {
            //Admin must choose a genre from a drop down menu as genre is not provided by Walmart, will deny if genre hasn't been selected
            string genre = genreBox.Text;
            if(genre == "Choose Here")
            {
                MessageBox.Show("Please select a genre from the drop-down menu");
            }
            else
            {
                //genre is selected, begin the DB insertion process
                DBconnect insert = new DBconnect();
                insert.DBConnect();
                bool isOpen = insert.OpenConnection();
                if (isOpen == false)
                {
                    //Ensure DB coneection is still available
                    MessageBox.Show("Failed to establish database connection");
                }
                else
                {
                    //See DBconnect.cs for implementation, pass all variables in the correct order
                    insert.populateDB(AdminAddGame.gameName, genre, AdminAddGame.console, AdminAddGame.description);
                }
                //always close
                this.Close();
            }  
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
