using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
    public partial class Form_StudentsBill : Form
    {
        public Form_StudentsBill()
        {
            InitializeComponent();

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

        public Form_StudentsBill(string BillID)
        {
            InitializeComponent();

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

            DataRow BillData = DataProvider.Instance.ExcuteQuery("SELECT * FROM StudentBills WHERE BillID = @BillID ", new object[] { BillID }).Rows[0];    

            txt_StudentID.Text = BillData["StudentID"].ToString();
            txt_StaffID.Text = BillData["StaffID"].ToString();
            txt_RoomID.Text = BillData["RoomID"].ToString();
            txt_TotalMoney.Text = BillData["BillTotalMoney"].ToString();
            date_BillCreation.Value = DateTime.Parse(BillData["BillCreationDate"].ToString());
            cmb_Months.SelectedIndex = cmb_Months.FindString(BillData["BillMonth"].ToString());
            cmb_Years.SelectedIndex = cmb_Years.FindString(BillData["BillYear"].ToString());

            if(BillData["BillPaid"].ToString() == "True")
            {
                cmb_BillPaid.SelectedIndex = 0;
            }
            else
            {
                cmb_BillPaid.SelectedIndex = 1;
            }

            lbl_BillID.Text = BillID;

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

        private void btn_DeleteBills_Click(object sender, EventArgs e)
        {
            DialogResult CheckDialog = MessageBox.Show("Bạn có chắc chắn muốn xoá hoá đơn này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(CheckDialog == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DELETE FROM StudentBills WHERE BillID = @BillID ", new object[] { lbl_BillID });
                if(CheckStatus > 0)
                {
                    MessageBox.Show("Xoá thành công hoá đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }

        private void btn_SavedBills_Click(object sender, EventArgs e)
        {
            if(cmb_BillPaid.SelectedIndex != -1)
            {
                DialogResult CheckResult = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin hoá đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if(CheckResult == DialogResult.Yes)
                {
                    int BillPaid;
                    if(cmb_BillPaid.SelectedIndex == 0)
                    {
                        BillPaid = 1;
                    }
                    else
                    {
                        BillPaid = 0;
                    }

                    string BillID = lbl_BillID.Text;

                    int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UPDATE StudentBills SET BillPaid = @BillPaid WHERE BillID = @BillID ", new object[] { BillPaid, BillID });

                    if(CheckStatus > 0)
                    {
                        MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm thông tin cần thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        #endregion
    }
}
