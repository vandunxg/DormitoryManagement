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

    public partial class forgotPasswordPage : Form
    {

        #region Mouse Move

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void forgotPasswordPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        public forgotPasswordPage()
        {
            InitializeComponent();
        }



        #region Events

        private void bunifuImageButton1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void backtoLogin_Click(object sender, EventArgs e)
        {

            loginPage newLoginPage = new loginPage();
            newLoginPage.Show();
            this.Close();
        }

        private void btn_resetPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("LIÊN HỆ ADMIN ĐỂ CẤP LẠI MẬT KHẨU", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        #endregion

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
