using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class loginPage : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public loginPage()
        {
            InitializeComponent();
        }

        #region Events

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginPage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_exitLoginPage_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("BẠN CÓ MUỐN THOÁT ỨNG DỤNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void leftBackgroundImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

            forgotPasswordPage newForm = new forgotPasswordPage();
            newForm.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string inputEmailLogin = txt_InputEmailLogin.Text.ToString();
            string inputPasswordEmail = txt_inputPasswordLogin.Text.ToString();

            if (string.IsNullOrEmpty(inputEmailLogin) || string.IsNullOrEmpty(inputPasswordEmail))
            {
                MessageBox.Show("Email và Password không được để trống!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (Account.Instance.checkValidEmail(inputEmailLogin) == false)
                {
                    MessageBox.Show("Email không đúng định dạng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(inputEmailLogin.Length > 50 || inputPasswordEmail.Length > 20)
                {
                    MessageBox.Show("Email hoặc mật khẩu sai định dạng!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Account.Instance.checkValidAccount(inputEmailLogin, inputPasswordEmail))
                {
                    Admin_Dashboard adminPage = new Admin_Dashboard();

                    AuthService.SetLoggedInUserId(int.Parse(DataProvider.Instance.ExcuteQuery("SELECT StaffID FROM Staffs WHERE StaffEmail = @StaffEmail ", new object[] { inputEmailLogin }).Rows[0]["StaffID"].ToString()));
                    adminPage.Visible = true;
                    this.Visible = false;


                }
                else
                {
                    MessageBox.Show("Email hoặc Mật khẩu không chính xác!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void txt_InputEmailLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_login_Click(sender, e);
            }
        }

        private void txt_inputPasswordLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btn_login_Click(sender, e);
            }
        }

        private void txt_inputPasswordLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region



        #endregion


    }
}
