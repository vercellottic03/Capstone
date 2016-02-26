using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class confirmCheckout : Form
    {
        string userName = LOGINWINDOW.userName;
        string gameTitle = CheckOut.qname;
        public confirmCheckout()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            //Pass all of the parsed variables from the AdminAddGame User control to be displayed here
            //they are passed on the loading of the form so the data will be displayed right when the window pops up
            gameName.Text = CheckOut.qname;
            console.Text = CheckOut.qConsole;
            description.Text = CheckOut.qDescr;
            string url = CheckOut.qImage;
            displayImage(url);
            // Call the base class OnLoad to ensure any delegate event handlers are still callled
            base.OnLoad(e);
        }
        private void displayImage(string imageURL)
        {
            MessageBox.Show(imageURL);
            var request = WebRequest.Create(imageURL);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                pictureBox1.Image = Bitmap.FromStream(stream);
                pictureBox1.Visible = true;
            }
            request = null;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //Pop-up that asks if you would like to sign off, if yes, then login page is recalled and session terminated
            MessageBox.Show("Rental cancelled.");
            this.Close();
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            DBconnect chckOut = new DBconnect();
            chckOut.DBConnect();
            chckOut.checkoutConfirm(userName, gameTitle);
            this.Close();
        }
    }
}
