using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Drawing;
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
    public partial class Form_ContractDetail : Form
    {

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

        public Form_ContractDetail()
        {
            InitializeComponent();
        }

        public Form_ContractDetail(string ContractID, string StudentID, string AreaID, string RoomTypeID, string RoomID, string date_CheckIn, string date_CheckOut, string StaffID, string ContractDeposit)
        {

            InitializeComponent();



            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");

            lbl_ContractID.Text = ContractID;
            txt_StudentID.Text = StudentID;
            txt_StaffID.Text = StaffID;
            cmb_Areas.SelectedIndex = cmb_Areas.FindString(AreaID);
            date_ContractCheckin.Value = DateTime.Parse(date_CheckIn);

            cmb_DateCheckOut.DisplayMember = "DateContractID";
            cmb_DateCheckOut.ValueMember = "DateContractName";
            cmb_DateCheckOut.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM DateContract");
            cmb_DateCheckOut.Enabled = false;

            cmb_DateCheckOut.SelectedIndex = cmb_DateCheckOut.FindString(date_CheckOut);

            

            txt_DepositPrice.Text = ContractDeposit;

        }

        #region Events
        private void txt_DepositPrice_TextChanged(object sender, EventArgs e)
        {
            txt_TotalMoney.Text = string.Empty;
            long CalTotalMoney = (long.Parse(txt_RoomPrice.Text) * long.Parse(cmb_DateCheckOut.SelectedValue.ToString())) - long.Parse(txt_DepositPrice.Text);
            txt_TotalMoney.Text = CalTotalMoney.ToString();
        }

        private void lbl_ContractID_Click(object sender, EventArgs e)
        {

        }
    
        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Areas.SelectedIndex != -1)
            {
                cmb_RoomTypes.DisplayMember = "RoomTypeName";
                cmb_RoomTypes.ValueMember = "RoomTypeID";
                cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            }
        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ", new object[] { int.Parse(cmb_Areas.SelectedValue.ToString()), int.Parse(cmb_RoomTypes.SelectedValue.ToString()) });
                
                txt_RoomPrice.Text = DataProvider.Instance.ExcuteQuery("SELECT RoomTypePrice FROM RoomTypes WHERE RoomTypeID = @RoomTypeID ", new object[] { cmb_RoomTypes.SelectedValue }).Rows[0]["RoomTypePrice"].ToString();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeleteContracts_Click(object sender, EventArgs e)
        {
            string ContractID = lbl_ContractID.Text;

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn xoá hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DeleteContracts @ContractID ", new object[] { ContractID });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Xoá hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá hợp đồng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_SavedContracts_Click(object sender, EventArgs e)
        {
            string ContractID = lbl_ContractID.Text.Trim();
     
            string ContractDeposit = txt_DepositPrice.Text.Trim();
            

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn sửa hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateContracts @ContractID , @ContractDeposit ", new object[] { ContractID, ContractDeposit });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Chỉnh sửa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa hợp đồng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void cmb_ContractState_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        #endregion
    }

}
