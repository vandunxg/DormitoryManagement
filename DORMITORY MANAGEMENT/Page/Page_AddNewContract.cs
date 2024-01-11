using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Data;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

/*
    Author : @vandunxg
    Github : @vandunxg
    Blog : vandunxg.vercel.app
    Leetcode : @vandunxg
    Facebook : @vandunxg
*/

/* Copyright (C) 2024 Nguyen Van Dung - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the MIT license, which unfortunately won't be
 * written for another century.
 *
 * You should have received a copy of the MIT license with
 * this file. If not, please write to: vandunxg.dev@gmail.com, or visit : vandunxg.vercel.app
 */

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_AddNewContract : UserControl
    {
        public Page_AddNewContract()
        {
            InitializeComponent();

        }

        public Page_AddNewContract(object sender, EventArgs e)
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
                Form_ContractDetail ContractDetailPage = new Form_ContractDetail(ContractID, StudentID, AreaID, RoomTypeID, RoomID, date_ContractCheckin, MonthsCheckOut, StaffID, ContractDeposit);
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

                    DateTime CmpDate = DateTime.Parse(DataProvider.Instance.ExcuteQuery("CmpCheckOutDate @StudentID ", new object[] { StudentID }).Rows[0]["CheckOutDate"].ToString());

                    if(CmpDate.Date > DateTime.Now.Date)
                    {
                        MessageBox.Show("Hợp đồng của sinh viên đang khả dụng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

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

        private void txt_DepositPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
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

        private void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất file thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportExcel(string Path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            // Thêm dòng thông báo "THÔNG TIN SINH VIÊN" vào giữa
            int middleColumn = dgv_Contracts.Columns.Count / 2 + 1;

            // Gán giá trị và làm cho nó trung tâm
            application.Cells[1, middleColumn] = "DANH SÁCH HỢP ĐỒNG TRONG HỆ THỐNG";
            Excel.Range infoCell = application.Cells[1, middleColumn];
            infoCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Thiết lập thuộc tính font, cỡ chữ và màu đỏ cho dòng thông báo
            infoCell.Font.Name = "Arial";
            infoCell.Font.Size = 24;
            infoCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            // Gộp các ô của dòng thông báo và làm cho chúng trung tâm
            Excel.Range infoRange = application.Range[application.Cells[1, 1], application.Cells[1, dgv_Contracts.Columns.Count]];
            infoRange.Merge();
            infoRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Gán giá trị cho các header và thiết lập thuộc tính font, cỡ chữ, độ đậm
            for (int i = 0; i < dgv_Contracts.Columns.Count; i++)
            {
                application.Cells[2, i + 1] = dgv_Contracts.Columns[i].HeaderText;

                // Tô màu vàng cho header
                application.Cells[2, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Yellow);

                // Thiết lập font, cỡ chữ và độ đậm cho header
                application.Cells[2, i + 1].Font.Name = "Arial";
                application.Cells[2, i + 1].Font.Size = 14;
                application.Cells[2, i + 1].Font.Bold = true;
                application.Cells[2, i + 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);

                // Thiết lập đường viền cho header
                application.Cells[2, i + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                application.Cells[2, i + 1].Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Canh giữa văn bản trong ô của header
                application.Cells[2, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }

            // Gán giá trị và thiết lập thuộc tính font, cỡ chữ, màu cho tất cả các ô dữ liệu
            for (int i = 0; i < dgv_Contracts.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_Contracts.Columns.Count; j++)
                {
                    application.Cells[i + 3, j + 1] = dgv_Contracts.Rows[i].Cells[j].Value;

                    // Thiết lập font, cỡ chữ và màu cho ô dữ liệu
                    application.Cells[i + 3, j + 1].Font.Name = "Arial";
                    application.Cells[i + 3, j + 1].Font.Size = 14;
                    application.Cells[i + 3, j + 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Black);

                    // Thiết lập đường viền cho ô dữ liệu
                    application.Cells[i + 3, j + 1].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    application.Cells[i + 3, j + 1].Borders.Weight = Excel.XlBorderWeight.xlThin;

                    // Canh giữa văn bản trong ô của ô dữ liệu
                    application.Cells[i + 3, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
            }

            // Tự động điều chỉnh kích thước cột để vừa với dữ liệu
            application.Columns.AutoFit();

            application.ActiveWorkbook.SaveCopyAs(Path);
            application.ActiveWorkbook.Saved = true;
        }
    }
}
