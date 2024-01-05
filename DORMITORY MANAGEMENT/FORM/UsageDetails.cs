using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class UsageDetails : Form
    {

        #region mouse move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void bunifuPanel1_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        #endregion

        public UsageDetails()
        {
            InitializeComponent();
        }

        public UsageDetails(string UsageID, string AreaName, string RoomTypeName, string Room, string ServiceName, int Months, int Years, int Quantity)
        {
            InitializeComponent();

            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");

            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");

            cmb_Rooms.DisplayMember = "RoomName";
            cmb_Rooms.ValueMember = "RoomID";
            cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });

            cmb_Services.DisplayMember = "ServiceName";
            cmb_Services.ValueMember = "ServiceID";
            cmb_Services.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Services");

            cmb_Months.DisplayMember = "MonthName";
            cmb_Months.ValueMember = "MonthID";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");

            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");


            lbl_UsageID.Text = UsageID;
            cmb_Areas.SelectedIndex = cmb_Areas.FindString(AreaName);
            cmb_Services.SelectedIndex = cmb_Services.FindString(ServiceName);
            cmb_Months.SelectedIndex = cmb_Months.FindString(Months.ToString());
            cmb_Years.SelectedIndex = cmb_Years.FindString(Years.ToString());
            txt_ServiceQuantity.Text = Quantity.ToString();

        }

        #region Events

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeleteUsage_Click(object sender, EventArgs e)
        {
            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn xoá thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                string UsageID = lbl_UsageID.Text;

                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Usages WHERE UsageID = @UsageID ", new object[] { UsageID });
                if (CheckStatus > 0)
                {
                    MessageBox.Show("Xoá hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá hợp đồng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_SavedUsage_Click(object sender, EventArgs e)
        {
            string UsageID = lbl_UsageID.Text;
            int RoomID = int.Parse(cmb_Rooms.SelectedValue.ToString());
            int ServiceID = int.Parse(cmb_Services.SelectedValue.ToString());
            int Quantity = int.Parse(txt_ServiceQuantity.Text.ToString());
            int Months = int.Parse(cmb_Months.SelectedValue.ToString());
            int Years = int.Parse(cmb_Years.SelectedValue.ToString());

            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn sửa thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateUsages @UsageID , @RoomID , @ServiceID , @UsageQuantity , @Months , @Years ", new object[] { UsageID, RoomID, ServiceID, Quantity, Months, Years });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void txt_ServiceQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }


        #endregion


    }
}
