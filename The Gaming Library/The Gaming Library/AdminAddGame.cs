using System;
using System.Xml;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace The_Gaming_Library
{
    public partial class AdminAddGame : UserControl
    {
        public static string gameName;
        public static string genre;
        public static string gamePrice;
        public static string description;
        public static string imageLink;
        public AdminAddGame()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            ParentForm.AcceptButton = submit;
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void logOut_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGreen;
        }
        private void logOut_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.Chartreuse;
        }

        public void submit_Click(object sender, EventArgs e)
        {
            string UPC = GameUPC.Text;
            string URLString = "http://api.walmartlabs.com/v1/items?apiKey=gnfyqemcbacazx8qwbt6fy53&upc=" + UPC + "&format=xml";
            try
            {
                XmlReader reader = XmlReader.Create(URLString);

                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "name")
                        {
                            reader.Read();
                            gameName = reader.Value;
                            int start = gameName.IndexOf("(") + 1;
                            int end = gameName.IndexOf(")", start);
                            try {
                                genre = gameName.Substring(start, end - start);
                            }
                            catch(Exception)
                            {
                                //MessageBox.Show("The item scanned is not a video game, please scan a valid game");
                                break;
                            }
                            //MessageBox.Show("Genre: "+genre+"\nName: "+gameName);                        
                        }
                        if (reader.Name == "msrp")
                        {
                            reader.Read();
                            gamePrice = reader.Value;
                        }
                        if (reader.Name == "salePrice")
                        {
                            reader.Read();
                            gamePrice = reader.Value;
                        }
                        if (reader.Name == "shortDescription")
                        {
                            reader.Read();
                            description = reader.Value;
                        }
                        if (reader.Name == "largeImage" && imageLink == null)
                        {
                            reader.Read();
                            imageLink = reader.Value;
                            //displayImage(imageLink); 
                        }
                    }
                }
                //MessageBox.Show("Game name: '" + gameName + "\nGame Price: " + gamePrice + "\nDescription: " + description+ "\nImage linked from this URL: "+imageLink);
                if (genre == null)
                {
                    MessageBox.Show("Told ya");
                }
                else
                {
                    gameToAdd view = new gameToAdd();
                    view.Show();
                    this.Refresh();
                }
            }
            catch(WebException ex)
            {
                HttpWebResponse errorResponse = ex.Response as HttpWebResponse;
                if (errorResponse.StatusCode == HttpStatusCode.NotFound)
                {
                    MessageBox.Show("Invalid input, please scan a proper video game or UPC code");
                }
            }
        }
    }
}
