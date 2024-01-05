using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Form_ServiceDetail : Form
    {
        public Form_ServiceDetail()
        {
            InitializeComponent();
        }

        public Form_ServiceDetail(string ServiceName, int ServicePrice, int ServiceID, string ServiceUnit)
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
            Close();
        }

        private void txt_ServicePrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }

        }

        private void btn_DeleteServices_Click(object sender, EventArgs e)
        {
            string ServiceID = txt_ServiceID.Text;

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn xoá dịch vụ này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Services WHERE ServiceID = @ServiceID ", new object[] { ServiceID });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_SavedServices_Click(object sender, EventArgs e)
        {
            if (txt_ServiceName.Text != string.Empty && txt_ServiceUnit.Text != string.Empty && txt_ServicePrice.Text != string.Empty)
            {
                string ServiceID = txt_ServiceID.Text.Trim();
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
                    MessageBox.Show("Đơn vị tính dịch vụ quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (ServicePrice > int.MaxValue)
                {
                    MessageBox.Show("Giá dịch vụ quá lớn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn sửa dịch vụ này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (CheckNotify == DialogResult.Yes)
                {
                    int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateServices @ServiceID , @ServiceName , @ServicePrice , @ServiceUnit ", new object[] { ServiceID, ServiceName, ServicePrice, ServiceUnit });
                    if (CheckStatus > 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trường thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


    }
}
