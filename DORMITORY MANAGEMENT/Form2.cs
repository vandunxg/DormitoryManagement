using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{

    public partial class forgotPasswordPage : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public forgotPasswordPage()
        {
            InitializeComponent();
        }

        private void forgotPasswordPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

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


    }
}
