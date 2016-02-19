using System;
using System.Xml;
using System.Drawing;
using System.Windows.Forms;
using System.Net;

namespace The_Gaming_Library
{
    public partial class AdminAddGame : UserControl
    {
        //Declare all variables as public so they are accesible by the confirmation form 
        public static string gameName;
        public static string console;
        public static string gamePrice;
        public static string description;
        public static string imageLink;

        public AdminAddGame()
        {
            InitializeComponent();
        }

        //Overloaded the OnLoad function to allow barcode reader to hit enter and automatically call the XML calls and open the confirmation form
        protected override void OnLoad(EventArgs e)
        {
            ParentForm.AcceptButton = submit;
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }
        //Cancel button, makes the user control invisible again, not gone
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
      
        //The main attraction, called when barcode reader hits enter, queries the Walmart API to retrieve all the information on the game scanned
        public void submit_Click(object sender, EventArgs e)
        {
            //Clear all variables in case any were populated from past scans
            gameName = "";
            console = "";
            imageLink = "";
            description = "";
            //This is the entered UPC code from the text field
            string UPC = GameUPC.Text;
            //The URL that is sent to Walmart's API, contains my api key and adds the entered UPC code, outputs an XML document
            string URLString = "http://api.walmartlabs.com/v1/items?apiKey=gnfyqemcbacazx8qwbt6fy53&upc=" + UPC + "&format=xml";
            try
            {
                //Creates a parsable object from the outputted XML code
                XmlReader reader = XmlReader.Create(URLString);

                //Continues to parse through the XML while there is still more nodes or a break is called
                while (reader.Read())
                {
                    //Checks if the current node is an element, only want elements for this app
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        //If element is name
                        if (reader.Name == "name")
                        {
                            reader.Read();
                            //Parses out the console located between ( and ) in the name
                            gameName = reader.Value;
                            int start = gameName.IndexOf("(") + 1;
                            int end = gameName.IndexOf(")", start);
                            try {
                                console = gameName.Substring(start, end - start);
                            }
                            //Old try catch experiments
                            catch(Exception)
                            {
                                //MessageBox.Show("The item scanned is not a video game, please scan a valid game");
                                break;
                            }
                            //Output console to make sure parse function worked properly
                            //MessageBox.Show("console: "+console+"\nName: "+gameName);                        
                        }
                        //If element is shortDescription
                        if (reader.Name == "shortDescription")
                        {
                            reader.Read();
                            description = reader.Value;
                        }
                        //if element is largeImage
                        if (reader.Name == "largeImage")
                        {
                            reader.Read();
                            imageLink = reader.Value;
                            //Break out of the loop here, this is the last element we need, and the first largeImage is always the game cover
                            break;
                        }
                    }
                }
                //Output all parsed information to ensure everything is working properly
                //MessageBox.Show("Game name: '" + gameName + "\nGame Price: " + gamePrice + "\nDescription: " + description+ "\nImage linked from this URL: "+imageLink);
                if (console == "")
                {
                    //If UPC is valid, but not a video game, it will be caught and displayed here
                    MessageBox.Show("The inputted is not a video game, please scan a proper game");
                }
                else
                {
                    //If UPC is a valid game, move on to the gameToAdd form to confirm the choice and add the game tothe DB
                    gameToAdd view = new gameToAdd();
                    view.Show();
                    GameUPC.Clear();
                    this.Refresh();
                }
            }
            //If the UPC is not valid or not found in Walmart's DB, this error will be displayed as the URl entered will spit out an HTTP error
            catch(WebException ex)
            {
                HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
                if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Invalid input, please scan a proper video game or UPC code");
                }
            }
        }

        //More color changing fuctions
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
