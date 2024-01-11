using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public partial class Page_RenewContracts : UserControl
    {
        public Page_RenewContracts()
        {
            InitializeComponent();

            cmb_DateCheckOut.DisplayMember = "DateContractName";
            cmb_DateCheckOut.ValueMember = "DateContractID";
            cmb_DateCheckOut.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM DateContract");
            cmb_DateCheckOut.SelectedIndex = -1;
            cmb_DateCheckOut.Text = "Thời hạn";

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();

            dgv_ContractsOutDate.DataSource = DataProvider.Instance.ExcuteQuery("GetContractOutDate");
        }

        #region Events
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_DateCheckOut.SelectedIndex = -1;
            cmb_DateCheckOut.Text = "Thời hạn";

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();
            txt_ContractID.Text = string.Empty;

            dgv_ContractsOutDate.DataSource = DataProvider.Instance.ExcuteQuery("GetContractOutDate");
        }

        private void btn_AddContracts_Click(object sender, EventArgs e)
        {
            if(txt_ContractID.Text != string.Empty && txt_StaffID.Text != string.Empty && cmb_DateCheckOut.SelectedIndex != -1)
            {
                string ContractID = txt_ContractID.Text.Trim();
                string StaffID = txt_StaffID.Text.Trim();
                int NewDate = int.Parse(cmb_DateCheckOut.SelectedValue.ToString());
                string NewCheckOutDate = DateTime.Now.Date.AddMonths(NewDate).ToString();
                string NewCheckInDate = DateTime.Now.Date.ToString();

                DataTable ContractData = DataProvider.Instance.ExcuteQuery("SELECT CheckOutDate FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID });

                if(ContractData.Rows.Count > 0)
                {
                    DateTime CheckDate = DateTime.Parse(ContractData.Rows[0]["CheckOutDate"].ToString());

                    if(CheckDate.Date > DateTime.Now.Date)
                    {
                        MessageBox.Show("Hợp đồng vẫn còn hiệu lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        string StudentID = DataProvider.Instance.ExcuteQuery("SELECT StudentID FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID }).Rows[0]["StudentID"].ToString();

                        DateTime CheckStudentDate  = DateTime.Parse(DataProvider.Instance.ExcuteQuery("SELECT CheckOutDate FROM Contracts WHERE StudentID = @StudentID ORDER BY CheckOutDate DESC;", new object[] { StudentID }).Rows[0][0].ToString());


                        if(CheckStudentDate.Date > DateTime.Now.Date)
                        {
                            MessageBox.Show("Sinh viên này đang có hợp đồng còn hiệu lực" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int CheckStatus = DataProvider.Instance.ExecuteNonQuery("RenewContracts @ContractID , @StaffID , @CheckInDate , @CheckOutDate ", new object[] { ContractID, StaffID, NewCheckInDate, NewCheckOutDate });

                        if(CheckStatus > 0)
                        {
                            MessageBox.Show("Gia hạn thành công", "Thông báoo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Refresh_Click(sender, e);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Gia hạn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng trên hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            int middleColumn = dgv_ContractsOutDate.Columns.Count / 2 + 1;

            // Gán giá trị và làm cho nó trung tâm
            application.Cells[1, middleColumn] = "DANH SÁCH CÁC HỢP ĐỒNG HẾT HẠN";
            Excel.Range infoCell = application.Cells[1, middleColumn];
            infoCell.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Thiết lập thuộc tính font, cỡ chữ và màu đỏ cho dòng thông báo
            infoCell.Font.Name = "Arial";
            infoCell.Font.Size = 24;
            infoCell.Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

            // Gộp các ô của dòng thông báo và làm cho chúng trung tâm
            Excel.Range infoRange = application.Range[application.Cells[1, 1], application.Cells[1, dgv_ContractsOutDate.Columns.Count]];
            infoRange.Merge();
            infoRange.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            // Gán giá trị cho các header và thiết lập thuộc tính font, cỡ chữ, độ đậm
            for (int i = 0; i < dgv_ContractsOutDate.Columns.Count; i++)
            {
                application.Cells[2, i + 1] = dgv_ContractsOutDate.Columns[i].HeaderText;

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
            for (int i = 0; i < dgv_ContractsOutDate.Rows.Count; i++)
            {
                for (int j = 0; j < dgv_ContractsOutDate.Columns.Count; j++)
                {
                    application.Cells[i + 3, j + 1] = dgv_ContractsOutDate.Rows[i].Cells[j].Value;

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
