using DORMITORY_MANAGEMENT.DAO;
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

        public void ContractsPage_Load(object sender, EventArgs e)
        {
            // Load Area Data to combo box
            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");

            // Load RoomTypes to combo box
            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");

            dgv_Contracts.DataSource = DataProvider.Instance.ExcuteQuery("GetContractDetails");

            btn_AddContracts.Enabled = true;
            btn_DeleteContracts.Enabled = false;
            btn_EditContracts.Enabled = false;
            btn_PrinContracts.Enabled = false;
            btn_SkipSelect.Enabled = false;
        }

        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_RoomTypes.Enabled = true;

        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("LoadRoomToCreateBill @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";
            }
        }

        private void dgv_Contracts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_AddContracts.Enabled = false;
            btn_DeleteContracts.Enabled = true;
            btn_EditContracts.Enabled = true;
            btn_PrinContracts.Enabled = true;
            btn_SkipSelect.Enabled = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Contracts.Rows.Count && e.ColumnIndex < dgv_Contracts.Columns.Count)
            {
                txt_StudentID.Text = dgv_Contracts.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_StaffID.Text = dgv_Contracts.Rows[e.RowIndex].Cells[2].Value.ToString();
                date_ContractCheckin.Value = DateTime.Parse(dgv_Contracts.Rows[e.RowIndex].Cells[4].Value.ToString());
                date_ContractCheckout.Value = DateTime.Parse(dgv_Contracts.Rows[e.RowIndex].Cells[5].Value.ToString());
                cmb_ContractState.SelectedIndex = cmb_ContractState.FindString(dgv_Contracts.Rows[e.RowIndex].Cells[6].Value.ToString());
                cmb_Areas.SelectedIndex = cmb_Areas.FindString(dgv_Contracts.Rows[e.RowIndex].Cells[7].Value.ToString());
                cmb_RoomTypes.SelectedIndex = cmb_RoomTypes.FindString(dgv_Contracts.Rows[e.RowIndex].Cells[8].Value.ToString());
                cmb_Rooms.SelectedIndex = cmb_Rooms.FindString(dgv_Contracts.Rows[e.RowIndex].Cells[3].Value.ToString());
                
             }
            
        }

        private void btn_SearchContracts_Click(object sender, EventArgs e)
        {
            btn_AddContracts.Enabled = false;
            btn_SkipSelect.Enabled = true;
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

            if(DataContracts.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy hợp đồng trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_Contracts.DataSource = DataContracts;
            
        }

        private void btn_AddContracts_Click(object sender, EventArgs e)
        {
            if (txt_StaffID.Text != string.Empty && txt_StudentID.Text != string.Empty && cmb_Rooms.SelectedIndex != -1)
            {
                #region Raw data
                string StudentID = txt_StudentID.Text.ToString().Trim();
                string StaffID = txt_StaffID.Text.ToString().Trim();
                string AreaID = cmb_Areas.SelectedValue.ToString();
                string RoomTypeID = cmb_RoomTypes.SelectedValue.ToString();
                string CheckInDate = date_ContractCheckin.Value.Date.ToString();
                string CheckOutDate = date_ContractCheckout.Value.Date.ToString();
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                int ContractState;
                if (cmb_ContractState.SelectedIndex == 0)
                {
                    ContractState = 1;
                }
                else
                {
                    ContractState = 0;
                }
                #endregion

                #region Check Valid Data

                if(StudentID.Length > 20)
                {
                    MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (StaffID.Length > 20)
                {
                    {
                        MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                if(DateTime.Parse(CheckInDate) > DateTime.Parse(CheckOutDate) || DateTime.Parse(CheckOutDate) < DateTime.Parse(CheckInDate).AddMonths(6) || DateTime.Parse(CheckOutDate) > DateTime.Parse(CheckInDate).AddMonths(12))
                {
                    MessageBox.Show("Hợp đồng phải ít nhất 6 tháng và nhiều nhất là 1 năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(StaffID) FROM Staffs WHERE StaffID = @StaffID ", new object[] { StaffID }).Rows[0][0].ToString()) == 0)
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                string query = "InsertDataContracts @StudentID , @RoomID , @StaffID , @AreaID , @RoomTypeID , @ContractState , @CheckInDate , @CheckOutDate ";
                int checkStatusInsertData = DataProvider.Instance.ExecuteNonQuery(query, new object[] { StudentID, RoomID, StaffID, AreaID, RoomTypeID, ContractState, CheckInDate, CheckOutDate });

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
        }

        #endregion

        #region Methods

        private void ClearInput()
        {
            txt_StaffID.Text = string.Empty;
            txt_StudentID.Text = string.Empty;

            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";

            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";

            cmb_Rooms.SelectedIndex = -1;
            cmb_Rooms.Text = "Phòng";

            date_ContractCheckin.Value = DateTime.Now;
            date_ContractCheckout.Value = DateTime.Now;

        }

        #endregion

        private void btn_DeleteContracts_Click(object sender, EventArgs e)
        {
            int index = dgv_Contracts.CurrentRow.Index;
            string ContractID = dgv_Contracts.Rows[index].Cells[0].Value.ToString();
            
            DialogResult CheckYesorNo = MessageBox.Show("Bạn có chắc chắn xoá hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
            if(CheckYesorNo == DialogResult.Yes)
            {
                int CheckDeleteStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID });
                if(CheckDeleteStatus > 0)
                {
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ContractsPage_Load(sender, e);
                    ClearInput();
                }
            }
        }

        private void btn_SkipSelect_Click(object sender, EventArgs e)
        {
            ContractsPage_Load(sender, e);
        }
    }
}
