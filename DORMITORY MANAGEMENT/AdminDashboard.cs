using DORMITORY_MANAGEMENT.DTO;
using System;
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
    public partial class AdminDashboard : Form
    {

        // DI CHUYỂN WINDOW BẰNG CHUỘT
        #region Mouse Move

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void topPanelDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        public AdminDashboard()
        {
            InitializeComponent();
            AuthService.SetLoggedInUserId(10001);
        }

        public AdminDashboard(int StaffID)
        {
            InitializeComponent();
            AuthService.SetLoggedInUserId(StaffID);
        }

        #region Events
        private void btn_Overview_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Overview.Text.ToString();
            txt_showMainNameofPage.Text = "Trang chủ";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Students_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Students.Text.ToString();
            txt_showMainNameofPage.Text = "Thêm sinh viên";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Rooms.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý phòng";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Contracts_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Contracts.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý hợp đồng";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_ContractsDate_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_ContractsDate.Text.ToString();
            txt_showMainNameofPage.Text = "Gia hạn hợp đồng";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Servives_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Servives.Text.ToString();
            txt_showMainNameofPage.Text = "Dịch vụ sử dụng";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_ServiceManagement_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_ServiceManagement.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý dịch vụ";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Bills_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Bills.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý hoá đơn";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_StudentBills_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_StudentBills.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý hoá đơn sinh viên";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Statistics_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Statistics.Text.ToString();
            txt_showMainNameofPage.Text = "Thống kê hệ thống";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_Settings_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Settings.Text.ToString();
            txt_showMainNameofPage.Text = "Thông tin tài khoản";

            PageManagement.SetPage(((Control)sender).Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            loginPage loginPage = new loginPage();
            loginPage.Visible = true;
            this.Visible = false;
        }
    }
}
