using DORMITORY_MANAGEMENT.DAO;
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
    public partial class Form_PaidBill : Form
    {
        public Form_PaidBill()
        {
            InitializeComponent();

            cmb_Months.DisplayMember = "MonthName";
            cmb_Months.ValueMember = "MonthID";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");
            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";

            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");
            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";

            dgv_PaidBills.DataSource = DataProvider.Instance.ExcuteQuery("GetPaidBills");
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

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1)
            {
                string Months = cmb_Months.SelectedValue.ToString();
                string Years = cmb_Years.SelectedValue.ToString();

                dgv_PaidBills.DataSource = DataProvider.Instance.ExcuteQuery("GetPaidBillsFilter @Months , @Years ", new object[] { Months, Years });
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";

            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";

            dgv_PaidBills.DataSource = DataProvider.Instance.ExcuteQuery("GetPaidBills");
        }
    }
}
