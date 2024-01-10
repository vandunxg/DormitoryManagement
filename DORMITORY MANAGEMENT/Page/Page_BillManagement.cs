using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace DORMITORY_MANAGEMENT
{
    public partial class Page_BillManagement : UserControl
    {
        public Page_BillManagement()
        {
            InitializeComponent();
        }

        #region Events

        private void Bills_Load(object sender, EventArgs e)
        {
            dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("GetBills");

            txt_RoomID.Text = string.Empty;
        }

        private void btn_SearchBills_Click(object sender, EventArgs e)
        {
            if (txt_RoomID.Text != string.Empty)
            {
                string RoomID = txt_RoomID.Text.Trim();

                if (RoomID.Length > 20)
                {
                    MessageBox.Show("Mã phòng quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DataProvider.Instance.ExcuteQuery("SELECT * FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows.Count < 1)
                {
                    MessageBox.Show("Mã phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBills @RoomID ", new object[] { RoomID });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_BillState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_BillState.SelectedIndex != -1)
            {
                if (cmb_BillState.SelectedIndex == 0)
                {
                    dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBillsPaid @BillPaid ", new object[] { 1 });
                }
                else
                {
                    dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBillsPaid @BillPaid ", new object[] { 0 });
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Bills_Load(sender, e);
        }

        private void btn_AddNewBill_Click(object sender, EventArgs e)
        {
            Form_AddNewBill addNewBill = new Form_AddNewBill();
            addNewBill.ShowDialog();
        }

        private void dgv_Bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Bills.Rows.Count && e.ColumnIndex < dgv_Bills.Columns.Count)
            {
                string BillID = dgv_Bills.Rows[e.RowIndex].Cells[0].Value.ToString();
                string RoomID = dgv_Bills.Rows[e.RowIndex].Cells[1].Value.ToString();
                string RoomName = DataProvider.Instance.ExcuteQuery("SELECT RoomName FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["RoomName"].ToString();
                int RoomTypeID = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT RoomTypeID FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["RoomTypeID"].ToString());
                string RoomTypeName = DataProvider.Instance.ExcuteQuery("SELECT RoomTypeName FROM RoomTypes WHERE RoomTypeID = @RoomTypeID ", new object[] { RoomTypeID }).Rows[0]["RoomTypeName"].ToString();
                int AreaID = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT AreaID FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["AreaID"].ToString());
                string AreaName = DataProvider.Instance.ExcuteQuery("SELECT AreaName FROM Areas WHERE AreaID = @AreaID ", new object[] { AreaID }).Rows[0]["AreaName"].ToString();

                int Months = int.Parse(dgv_Bills.Rows[e.RowIndex].Cells[2].Value.ToString());
                int Years = int.Parse(dgv_Bills.Rows[e.RowIndex].Cells[3].Value.ToString());
                string StaffID = dgv_Bills.Rows[e.RowIndex].Cells[5].Value.ToString();
                int BillPaid;
                
                Form_ShowBill showBills = new Form_ShowBill(BillID, AreaName, RoomTypeName, RoomID, RoomName, Months, Years, StaffID, 0);
                showBills.ShowDialog();
            }
        }

        private void txt_RoomID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }

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
            int middleColumn = dgv_Bills.Columns.Count / 2 + 1;

            // Gán giá trị và làm cho nó trung tâm
            application.Cells[1, middleColumn] = "DANH SÁCH HOÁ ĐƠN TRONG HỆ THỐNG";
            Excel.Range infoCell = application.Cells[1, middleColumn];
            infoCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Thiết lập thuộc tính font, cỡ chữ và màu đỏ cho dòng thông báo
            infoCell.Font.Name = "Arial";
            infoCell.Font.Size = 24;
            infoCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            // Gộp các ô của dòng thông báo và làm cho chúng trung tâm
            Excel.Range infoRange = application.Range[application.Cells[1, 1], application.Cells[1, dgv_Bills.Columns.Count]];
            infoRange.Merge();
            infoRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Gán giá trị cho các header và thiết lập thuộc tính font, cỡ chữ, độ đậm
            for (int i = 0; i < dgv_Bills.Columns.Count; i++)
            {
                application.Cells[2, i + 1] = dgv_Bills.Columns[i].HeaderText;

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
            for (int i = 0; i < dgv_Bills.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_Bills.Columns.Count; j++)
                {
                    application.Cells[i + 3, j + 1] = dgv_Bills.Rows[i].Cells[j].Value;

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
