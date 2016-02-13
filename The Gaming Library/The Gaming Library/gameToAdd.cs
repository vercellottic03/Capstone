using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
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
            gameName.Text = AdminAddGame.gameName;
            gamePrice.Text = AdminAddGame.genre;
            description.Text = AdminAddGame.description;
            string url = AdminAddGame.imageLink;
            displayImage(url);
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }
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

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image.Dispose();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Next step is to add this to the database");
        }
    }
}
