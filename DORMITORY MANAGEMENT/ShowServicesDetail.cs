using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ShowServicesDetail : Form
    {
        public ShowServicesDetail()
        {
            InitializeComponent();
        }
        public ShowServicesDetail(string ServiceName, int ServicePrice, int ServiceID, string ServiceUnit)
        {
            InitializeComponent();
            txt_ServiceID.Text = ServiceID.ToString();
            txt_ServiceName.Text = ServiceName;
            txt_ServicePrice.Text = ServicePrice.ToString();
            txt_ServiceUnit.Text = ServiceUnit.ToString();
        }


        #region mouse move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        #endregion

        #region Events
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_ServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }

        }



        #endregion

        
    }
}
