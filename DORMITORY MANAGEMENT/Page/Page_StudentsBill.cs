using DORMITORY_MANAGEMENT.DAO;
using System;
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
                string Months = cmb_SearchMonths.SelectedValue.ToString();
                string Years = cmb_SearchYears.SelectedValue.ToString();

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
            int middleColumn = dgv_StudentBills.Columns.Count / 2 + 1;

            // Gán giá trị và làm cho nó trung tâm
            application.Cells[1, middleColumn] = "DANH SÁCH HOÁ ĐƠN SINH VIÊN";
            Excel.Range infoCell = application.Cells[1, middleColumn];
            infoCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Thiết lập thuộc tính font, cỡ chữ và màu đỏ cho dòng thông báo
            infoCell.Font.Name = "Arial";
            infoCell.Font.Size = 24;
            infoCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            // Gộp các ô của dòng thông báo và làm cho chúng trung tâm
            Excel.Range infoRange = application.Range[application.Cells[1, 1], application.Cells[1, dgv_StudentBills.Columns.Count]];
            infoRange.Merge();
            infoRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Gán giá trị cho các header và thiết lập thuộc tính font, cỡ chữ, độ đậm
            for (int i = 0; i < dgv_StudentBills.Columns.Count; i++)
            {
                application.Cells[2, i + 1] = dgv_StudentBills.Columns[i].HeaderText;

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
            for (int i = 0; i < dgv_StudentBills.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_StudentBills.Columns.Count; j++)
                {
                    application.Cells[i + 3, j + 1] = dgv_StudentBills.Rows[i].Cells[j].Value;

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
