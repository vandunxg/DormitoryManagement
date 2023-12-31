﻿using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Form_AddNewBill : Form
    {
        public Form_AddNewBill()
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

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();
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
        private void txt_StaffID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }

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

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();

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

                if(DataProvider.Instance.ExcuteQuery("ChecKBill @RoomID , @BillMonth , @BillYear ", new object[] {RoomID, Months, Years}).Rows.Count > 0)
                {
                    MessageBox.Show("Đã tồn tại 1 hoá đơn trong tháng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(Months > DateTime.Now.Month || Years > DateTime.Now.Year)
                {
                    MessageBox.Show("Thời gian không thể lớn hơn thời điểm hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("InsertBills @RoomID , @StaffID , @Months , @Years , @DateCreation ", new object[] { RoomID, StaffID, Months, Years, DateCreation });

                if (CheckStatus > 0)
                {

                    DataTable StudentIDData = DataProvider.Instance.ExcuteQuery("SELECT StudentID FROM Contracts WHERE RoomID = @RoomID ", new object[] { RoomID });

                    double TotalMoney = 1.0 * double.Parse(DataProvider.Instance.ExcuteQuery("CalTotalMoneyBill @RoomID , @Months , @Years ", new object[] { RoomID, Months, Years }).Rows[0][0].ToString()) / StudentIDData.Rows.Count;

                    for (int i = 0; i < StudentIDData.Rows.Count; i++)
                    {
                        int InsertData = DataProvider.Instance.ExecuteNonQuery("InsertStudentBills @RoomID , @StudentID , @BillMonth , @BillYear , @BillCreationDate , @StaffID , @BillTotalMoney , @BillPaid", new object[] { RoomID, StudentIDData.Rows[i][0], Months, Years, DateCreation, StaffID, TotalMoney, 0 });
                    }

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
