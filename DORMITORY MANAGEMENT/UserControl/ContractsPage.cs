using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ContractsPage : UserControl
    {
        public ContractsPage()
        {
            InitializeComponent();

        }

        public ContractsPage(object sender, EventArgs e)
        {
            InitializeComponent();
            ContractsPage_Load(sender, e);
        }

        #region Events

        private void txt_StaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }

        public void ContractsPage_Load(object sender, EventArgs e)
        {
            // Load Area Data to combo box
            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");
            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";

            // Load RoomTypes to combo box
            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";

            cmb_DateCheckOut.DisplayMember = "DateContractName";
            cmb_DateCheckOut.ValueMember = "DateContractID";
            cmb_DateCheckOut.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM DateContract");

            dgv_Contracts.DataSource = DataProvider.Instance.ExcuteQuery("GetContractDetails");

            btn_AddContracts.Enabled = true;
            cmb_RoomTypes.Enabled = false;
            cmb_Rooms.Enabled = false;

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();

            date_ContractCheckIn.Value = DateTime.Now;
        }

        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_RoomTypes.Enabled = true;

        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1 && cmb_Areas.SelectedIndex != -1)
            {
                cmb_Rooms.Enabled = true;
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("LoadRoomToCreateBill @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";

                txt_RoomPrice.Text = DataProvider.Instance.ExcuteQuery("SELECT RoomTypePrice FROM RoomTypes WHERE RoomTypeID = @RoomTypeID ", new object[] { cmb_RoomTypes.SelectedValue }).Rows[0]["RoomTypePrice"].ToString();
            }
        }

        private void dgv_Contracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Contracts.Rows.Count && e.ColumnIndex < dgv_Contracts.Columns.Count)
            {
                string ContractID = dgv_Contracts.Rows[e.RowIndex].Cells[0].Value.ToString();
                string StudentID = dgv_Contracts.Rows[e.RowIndex].Cells[1].Value.ToString();
                string StaffID = dgv_Contracts.Rows[e.RowIndex].Cells[2].Value.ToString();
                string AreaID = dgv_Contracts.Rows[e.RowIndex].Cells[3].Value.ToString();
                string RoomTypeID = dgv_Contracts.Rows[e.RowIndex].Cells[4].Value.ToString();
                string RoomID = dgv_Contracts.Rows[e.RowIndex].Cells[5].Value.ToString();
                string date_ContractCheckin = dgv_Contracts.Rows[e.RowIndex].Cells[6].Value.ToString();
                string ContractCheckout = dgv_Contracts.Rows[e.RowIndex].Cells[7].Value.ToString();
                string ContractDeposit = dgv_Contracts.Rows[e.RowIndex].Cells[8].Value.ToString();
                string MonthsCheckOut = GetMonthsDifference(DateTime.Parse(date_ContractCheckin), DateTime.Parse(ContractCheckout)).ToString();
                ContractDetail ContractDetailPage = new ContractDetail(ContractID, StudentID, AreaID, RoomTypeID, RoomID, date_ContractCheckin, MonthsCheckOut, StaffID, ContractDeposit);
                ContractDetailPage.ShowDialog();

            }

        }

        private void btn_SearchContracts_Click(object sender, EventArgs e)
        {
            btn_AddContracts.Enabled = false;

            string StudentID = txt_SearchStudentID.Text.Trim();

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

            DataTable DataContracts = DataProvider.Instance.ExcuteQuery("SearchContracts @StudentID ", new object[] { StudentID });

            if (DataContracts.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy hợp đồng trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_Contracts.DataSource = DataContracts;

        }

        private void btn_DeleteContracts_Click(object sender, EventArgs e)
        {
            int index = dgv_Contracts.CurrentRow.Index;
            string ContractID = dgv_Contracts.Rows[index].Cells[0].Value.ToString();

            DialogResult CheckYesorNo = MessageBox.Show("Bạn có chắc chắn xoá hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (CheckYesorNo == DialogResult.Yes)
            {
                int CheckDeleteStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID });
                if (CheckDeleteStatus > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContractsPage_Load(sender, e);
                    ClearInput();
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            ClearInput();
            ContractsPage_Load(sender, e);
        }

        private void btn_AddContracts_Click(object sender, EventArgs e)
        {
            if (txt_StaffID.Text != string.Empty && txt_DepositPrice.Text != string.Empty && txt_StudentID.Text != string.Empty && cmb_Rooms.SelectedIndex != -1)
            {
                #region Raw data
                string StudentID = txt_StudentID.Text.ToString().Trim();
                int StaffID = int.Parse(txt_StaffID.Text.ToString().Trim());
                string AreaID = cmb_Areas.SelectedValue.ToString();
                string RoomTypeID = cmb_RoomTypes.SelectedValue.ToString();
                int DepositPrice = int.Parse(txt_DepositPrice.Text.ToString().Trim());
                string CheckInDate = date_ContractCheckIn.Value.Date.ToString();
                int CheckOutMonths = int.Parse(cmb_DateCheckOut.SelectedValue.ToString().Trim());
                string CheckOutDate = date_ContractCheckIn.Value.Date.AddMonths(CheckOutMonths).ToString();
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                
                #endregion

                #region Check Valid Data

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

                if (int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(ContractID) FROM Contracts WHERE StudentID = @StudentID ", new object[] { StudentID }).Rows[0][0].ToString()) > 0)
                {
                    MessageBox.Show("Sinh viên đã tạo hợp đồng trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                #endregion

                #region Insert Data
                string query = "InsertDataContracts @StudentID , @RoomID , @StaffID , @AreaID , @RoomTypeID , @ContractState , @CheckInDate , @CheckOutDate , @ContractDeposit ";
                int checkStatusInsertData = DataProvider.Instance.ExecuteNonQuery(query, new object[] { StudentID, RoomID, StaffID, AreaID, RoomTypeID, 1 , CheckInDate, CheckOutDate , DepositPrice });

                if (checkStatusInsertData > 0)
                {
                    MessageBox.Show("Đã thêm thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ContractsPage_Load(sender, e);
                    ClearInput();
                }
                else
                {
                    MessageBox.Show("Thêm thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                #endregion
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Methods

        private void ClearInput()
        {
            txt_StudentID.Text = string.Empty;
            txt_DepositPrice.Text = string.Empty;
            txt_RoomPrice.Text = string.Empty;
            txt_SearchStudentID.Text = string.Empty;

            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            cmb_Rooms.SelectedIndex = -1;
            cmb_Rooms.Text = "Phòng";
            cmb_DateCheckOut.SelectedIndex = -1;
            cmb_DateCheckOut.Text = "Thời hạn";

            date_ContractCheckIn.Value = DateTime.Now;



        }

        private int GetMonthsDifference(DateTime startDate, DateTime endDate)
        {
            int monthsApart = 12 * (startDate.Year - endDate.Year) + startDate.Month - endDate.Month;

            return Math.Abs(monthsApart);
        }
        #endregion


    }
}
