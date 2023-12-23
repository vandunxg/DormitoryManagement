using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Admin_Dashboard : Form
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

        public Admin_Dashboard()
        {
            InitializeComponent();

        }

        #region Events
        private void btn_Overview_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Overview.Text.ToString();
            txt_showMainNameofPage.Text = "Trang chủ";

            pages.SetPage(((Control)sender).Text);



        }

        private void btn_addStudents_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_addStudents.Text.ToString();
            txt_showMainNameofPage.Text = "Thêm sinh viên";

            pages.SetPage(((Control)sender).Text);
        }

        private void btn_ManageRooms_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_ManageRooms.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý phòng";
            pages.SetPage(((Control)sender).Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Contracts.Text.ToString();
            txt_showMainNameofPage.Text = "Hợp đồng";

            pages.SetPage(((Control)sender).Text);

        }

        private void overviewPage1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Servives.Text.ToString();
            txt_showMainNameofPage.Text = "Dịch vụ";

            pages.SetPage(((Control)sender).Text);
        }

        private void ManageServices_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = ManageServices.Text.ToString();
            txt_showMainNameofPage.Text = "Quản lý dịch vụ";

            pages.SetPage(((Control)sender).Text);
        }

        private void Bills_Click(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Bills.Text.ToString();
            txt_showMainNameofPage.Text = "Hoá đơn";

            pages.SetPage(((Control)sender).Text);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginPage loginPage = new loginPage();
            loginPage.Show();

        }

        private void bunifuButton2_Click_1(object sender, EventArgs e)
        {
            text_showNameofPage.Text = btn_Settings.Text.ToString();
            txt_showMainNameofPage.Text = "Thông tin nhân viên";

            pages.SetPage(((Control)sender).Text);
        }

        #endregion


    }
}
