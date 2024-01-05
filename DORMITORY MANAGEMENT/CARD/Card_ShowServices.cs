using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Card_ShowServices : UserControl
    {
        public Card_ShowServices()
        {
            InitializeComponent();
        }

        private int serviceID;
        private string serviceName;
        private int servicePrice;
        private string serviceUnit;

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServicePrice { get => servicePrice; set => servicePrice = value; }
        public string ServiceUnit { get => serviceUnit; set => serviceUnit = value; }


        public Card_ShowServices(string ServiceName, int ServiceID, int ServicePrice, string ServiceUnit)
        {
            InitializeComponent();
            lbl_ServiceName.Text = ServiceName;
            this.ServiceID = ServiceID;
            this.ServiceUnit = ServiceUnit;
            this.ServicePrice = ServicePrice;
            this.ServiceName = ServiceName;
        }

        private void ShowServices_Load(object sender, EventArgs e)
        {

        }

        private void ShowServices_Click(object sender, EventArgs e)
        {

        }

        public void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            ShowServices_Click(sender, e);
        }

        public void lbl_ServiceName_Click(object sender, EventArgs e)
        {
            ShowServices_Click(sender, e);
        }
    }
}
