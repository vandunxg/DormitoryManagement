using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_StudentsBill : UserControl
    {
        public Page_StudentsBill()
        {
            InitializeComponent();

            cmb_RoomArea.DisplayMember = "AreaName";
            cmb_RoomArea.ValueMember = "AreaID";
            cmb_RoomArea.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomArea.Text = "Khu";

            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";

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

            cmb_SearchMonths.DisplayMember = "MonthName";
            cmb_SearchMonths.ValueMember = "MonthID";
            cmb_SearchMonths.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");
            cmb_SearchMonths.SelectedIndex = -1;
            cmb_SearchMonths.Text = "Tháng";

            cmb_SearchYears.DisplayMember = "YearName";
            cmb_SearchYears.ValueMember = "YearID";
            cmb_SearchYears.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");
            cmb_SearchYears.SelectedIndex = -1;
            cmb_SearchYears.Text = "Năm";

            dgv_StudentBills.DataSource = DataProvider.Instance.ExcuteQuery("GetStudentBill");
        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1 && cmb_RoomArea.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Rooms WHERE AreaID = @AreaID AND RoomTypeID = @RoomTypeID ", new object[] { cmb_RoomArea.SelectedValue, cmb_RoomTypes.SelectedValue });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomArea.Text = "Khu";

            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";

            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";

            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";

            cmb_SearchMonths.SelectedIndex = -1;
            cmb_SearchMonths.Text = "Tháng";

            cmb_SearchYears.SelectedIndex = -1;
            cmb_SearchYears.Text = "Năm";

            txt_SearchStudentID.Text = string.Empty;

            dgv_StudentBills.DataSource = DataProvider.Instance.ExcuteQuery("GetStudentBill");
        }

        private void btn_Filter_Click(object sender, EventArgs e)
        {
            if (cmb_Rooms.SelectedIndex != -1 && cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1)
            {
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                string Months = cmb_Months.SelectedValue.ToString();
                string Years = cmb_Years.SelectedValue.ToString();
                dgv_StudentBills.DataSource = DataProvider.Instance.ExcuteQuery("GetStudentBillFilter @RoomID , @Months , @Years", new object[] { RoomID, Months, Years });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ bộ lọc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_SearchStudentID.Text != string.Empty && cmb_SearchMonths.SelectedIndex != -1 && cmb_SearchYears.SelectedIndex != -1)
            {

                string StudentID = txt_SearchStudentID.Text.Trim();
                string Months = cmb_Months.SelectedValue.ToString();
                string Years = cmb_Years.SelectedValue.ToString();

                if (StudentID.Length > 20)
                {
                    MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(StudentID) FROM Students WHERE StudentID = @StudentID ", new object[] { StudentID }).Rows[0][0].ToString()) == 0)
                {
                    MessageBox.Show("Không tìm thấy mã sinh viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgv_StudentBills.DataSource = DataProvider.Instance.ExcuteQuery("GetStudentBillSearch @StudentID , @Months , @Years", new object[] { StudentID, Months, Years });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_StudentBills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_StudentBills.Rows.Count && e.ColumnIndex < dgv_StudentBills.Columns.Count)
            {
                string BillID = dgv_StudentBills.Rows[e.RowIndex].Cells[0].Value.ToString();
                Form_StudentsBill studentBillDetail = new Form_StudentsBill(BillID);
                studentBillDetail.ShowDialog();
            }
        }
    }
}
