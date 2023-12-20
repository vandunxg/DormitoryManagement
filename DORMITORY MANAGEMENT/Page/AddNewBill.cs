using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class AddNewBill : Form
    {
        public AddNewBill()
        {
            InitializeComponent();
            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Areas");
            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";

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

        private void AddNewBill_Load(object sender, EventArgs e)
        {
            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Areas");
            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";

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

            txt_StaffID.Text = string.Empty;

        }

        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Areas.SelectedIndex != -1)
            {
                cmb_RoomTypes.DisplayMember = "RoomTypeName";
                cmb_RoomTypes.ValueMember = "RoomTypeID";
                cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
                cmb_RoomTypes.SelectedIndex = -1;
                cmb_RoomTypes.Text = "Loại phòng";
            }
        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";
            }
        }

        private void btn_AddBill_Click(object sender, EventArgs e)
        {
            if (cmb_Rooms.SelectedIndex != -1 && cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1)
            {
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                string StaffID = txt_StaffID.Text.Trim();
                int Months = int.Parse(cmb_Months.SelectedValue.ToString());
                int Years = int.Parse(cmb_Years.SelectedValue.ToString());
                string DateCreation = DateTime.Now.ToString("yyyy/MM/dd");

                if (StaffID.Length > 20)
                {
                    MessageBox.Show("Mã nhân viên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DataProvider.Instance.ExcuteQuery("SELECT * FROM Staffs WHERE StaffID = @StaffID ", new object[] { StaffID }).Rows.Count < 1)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("InsertBills @RoomID , @StaffID , @Months , @Years , @DateCreation ", new object[] { RoomID, StaffID, Months, Years, DateCreation });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Thêm hoá đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AddNewBill_Load(sender, e);
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm hoá đơn không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        #endregion


    }
}
