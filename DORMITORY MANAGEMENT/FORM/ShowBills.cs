using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ShowBills : Form
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

        public ShowBills()
        {

        }

        private string RoomName;

        public ShowBills(string BillID, string AreaName, string RoomTypeName, string RoomID, string RoomName, int Months, int Years, string StaffID, int BillPaid)
        {
            InitializeComponent();

            lbl_BillID.Text = BillID;

            this.RoomName = RoomName;

            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Areas");
            cmb_Areas.SelectedIndex = cmb_Areas.FindString(AreaName);

            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.SelectedIndex = cmb_RoomTypes.FindString(RoomTypeName);

            cmb_Months.DisplayMember = "MonthName";
            cmb_Months.ValueMember = "MonthID";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");
            cmb_Months.SelectedIndex = cmb_Months.FindString(Months.ToString());


            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");
            cmb_Years.SelectedIndex = cmb_Years.FindString(Years.ToString());

            txt_StaffID.Text = StaffID;

            cmb_BillState.SelectedIndex = BillPaid;


            dgv_RoomServices.DataSource = DataProvider.Instance.ExcuteQuery("GetServicesToBill @RoomID , @Months , @Years ", new object[] { RoomID, Months, Years });

            txt_TotalMoney.Text = DataProvider.Instance.ExcuteQuery("CalTotalMoneyBill @RoomID , @Months , @Years ", new object[] { RoomID, Months, Years }).Rows[0][0].ToString();

        }

        #region Events
        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1 && cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = cmb_Rooms.FindString(this.RoomName);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeleteBills_Click(object sender, EventArgs e)
        {
            string BillID = lbl_BillID.Text;

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn xoá hoá đơn này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Bills WHERE BillID = @BillID ", new object[] { BillID });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Xoá hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá hoá đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_SavedBills_Click(object sender, EventArgs e)
        {
            if (cmb_Rooms.SelectedIndex != -1 && cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1 && cmb_BillState.SelectedIndex != -1 && txt_StaffID.Text != string.Empty)
            {
                int RoomID = int.Parse(cmb_Rooms.SelectedValue.ToString());
                int StaffID = int.Parse(txt_StaffID.Text.Trim());
                int BillID = int.Parse(lbl_BillID.Text);
                int Months = int.Parse(cmb_Months.SelectedValue.ToString());
                int Years = int.Parse(cmb_Years.SelectedValue.ToString());
                int BillState;
                if (cmb_BillState.SelectedIndex == 0)
                {
                    BillState = 1;
                }
                else
                {
                    BillState = 0;
                }



                if (DataProvider.Instance.ExcuteQuery("SELECT * FROM Staffs WHERE StaffID = @StaffID ", new object[] { StaffID }).Rows.Count < 1)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn sửa hoá đơn này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (CheckNotify == DialogResult.Yes)
                {
                    int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateBills @BillID , @RoomID , @BillPaid , @StaffID , @Months , @Years ", new object[] { BillID, RoomID, BillState, StaffID, Months, Years });

                    if (CheckStatus > 0)
                    {
                        MessageBox.Show("Sửa hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sửa hoá đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ trường dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txt_StaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }
        #endregion
    }
}
