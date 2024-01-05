using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Form_AddNewService : Form
    {

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

        public Form_AddNewService()
        {
            InitializeComponent();
        }

        #region Events
        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddServices_Click(object sender, EventArgs e)
        {
            if (txt_ServiceName.Text != string.Empty && txt_ServicePrice.Text != string.Empty && txt_ServiceUnit.Text != string.Empty)
            {
                string ServiceName = txt_ServiceName.Text.Trim();
                int ServicePrice = int.Parse(txt_ServicePrice.Text.Trim());
                string ServiceUnit = txt_ServiceUnit.Text.Trim();


                if (ServiceName.Length > 50)
                {
                    MessageBox.Show("Tên dịch vụ quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ServiceUnit.Length > 20)
                {
                    MessageBox.Show("Đơn vị tính quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("InsertServices @ServiceName , @ServicePrice , @ServiceUnit ", new object[] { ServiceName, ServicePrice, ServiceUnit });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Đã thêm dịch vụ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txt_ServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }
        #endregion

        #region Method
        private void ClearInput()
        {
            txt_ServiceName.Text = string.Empty;
            txt_ServicePrice.Text = string.Empty;
            txt_ServiceUnit.Text = string.Empty;
        }
        #endregion
    }
}
