using System;
using System.Windows.Forms;

namespace The_Gaming_Library
{
    public partial class CheckOut : UserControl
    {
        public static string checkOutUPCIn;
        public static string qname;
        public static string qConsole;
        public static string qDescr;
        public static string qImage;
        string username = LOGINWINDOW.userName;
        public CheckOut()
        {
            InitializeComponent();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void submit_Click(object sender, EventArgs e)
        {
            checkOutUPCIn = CheckOutUPC.Text;
            if (checkOutUPCIn == "")
            {
                MessageBox.Show("Please scan a game before hitting enter");
            }
            else
            {
                DBconnect chkout = new DBconnect();
                chkout.DBConnect();
                Tuple<string,string,string,string> output = chkout.checkoutQuery(username, checkOutUPCIn);
                if (output.Item1 != "")
                {
                    qname = output.Item1;
                    qConsole = output.Item2;
                    qDescr = output.Item3;
                    qImage = output.Item4;
                    //MessageBox.Show(qname+"\n"+qConsole);
                    confirmCheckout confirm = new confirmCheckout();
                    confirm.Show();
                    CheckOutUPC.Clear();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("The item you scanned is not in our database\nYou must scan a game currently available in the locker");
                }
            }
        }
    }
}
