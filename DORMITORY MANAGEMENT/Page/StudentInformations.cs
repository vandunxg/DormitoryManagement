using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT.Page
{
    public partial class StudentInformations : Form
    {

        // DI CHUYỂN WINDOW BẰNG CHUỘT
        #region Mouse Move

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

        public StudentInformations()
        {
            InitializeComponent();
        }

        public StudentInformations(string StudentID, string StudentName, string ClassID, string SpecializationName, string StudentGender, string StudentDOB, string StudentPersonalID, string StudentEmail, string StudentPhone, string StudentAddress, string StudentLived)

        {

            InitializeComponent();

            #region Get Specializations to Combo box
            DataTable dataSpecializations = DataProvider.Instance.ExcuteQuery("GetSpecializations");
            cmb_Specializations.DisplayMember = "SpecializationName";
            cmb_Specializations.ValueMember = "SpecializationID";
            cmb_Specializations.DataSource = dataSpecializations;
            #endregion

            txt_StudentID.Text = StudentID;
            StudentDeleteID = StudentID;
            txt_StudentName.Text = StudentName;
            txt_StudentPersonalID.Text = StudentPersonalID;
            txt_StudentEmail.Text = StudentEmail;
            txt_StudentAddress.Text = StudentAddress;
            txt_StudentPhone.Text = StudentPhone;
            cmb_Specializations.SelectedIndex = cmb_Specializations.FindString(SpecializationName);
            cmb_ClassID.SelectedIndex = cmb_ClassID.FindString(ClassID);
            cmb_StudentGender.SelectedIndex = cmb_StudentGender.FindString(StudentGender);
            date_StudentDOB.Value = DateTime.Parse(StudentDOB);
            if (StudentLived == "True")
            {
                checkbox_Lived.Checked = true;
            }
            else
            {
                checkbox_Lived.Checked = false;
            }

        }

        private void StudentInformations_Load(object sender, EventArgs e)
        {
            btn_Saved.Enabled = false;
            btn_DeleteStudents.Enabled = true;
            btn_EditStudents.Enabled = true;

            txt_StudentAddress.Enabled = false;
            txt_StudentPhone.Enabled = false;
            txt_StudentName.Enabled = false;
            txt_StudentPersonalID.Enabled = false;
            txt_StudentEmail.Enabled = false;
            txt_StudentID.Enabled = false;
            cmb_ClassID.Enabled = false;
            cmb_Specializations.Enabled = false;
            cmb_StudentGender.Enabled = false;
            date_StudentDOB.Enabled = false;

        }

        private void btn_EditStudents_Click(object sender, EventArgs e)
        {
            btn_Saved.Enabled = true;
            btn_DeleteStudents.Enabled = false;

            txt_StudentAddress.Enabled = true;
            txt_StudentPhone.Enabled = true;
            txt_StudentName.Enabled = true;
            txt_StudentPersonalID.Enabled = true;
            txt_StudentEmail.Enabled = true;
            txt_StudentID.Enabled = true;
            cmb_ClassID.Enabled = true;
            cmb_Specializations.Enabled = true;
            cmb_StudentGender.Enabled = true;
            date_StudentDOB.Enabled = true;
        }

        private void cmb_ClassID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Specializations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Specializations.SelectedIndex != -1)
            {
                string SpecializationID = cmb_Specializations.SelectedValue.ToString();
                #region Get Classroom to Combo box
                DataTable dataClassroom = DataProvider.Instance.ExcuteQuery("GetClassroom @SpecializationID", new object[] { SpecializationID });
                cmb_ClassID.DisplayMember = "ClassName";
                cmb_ClassID.ValueMember = "ClassID";
                cmb_ClassID.DataSource = dataClassroom;
                #endregion
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string StudentDeleteID = "";

        private void btn_Saved_Click(object sender, EventArgs e)
        {
            if (txt_StudentName.Text != "" && txt_StudentAddress.Text != "" && txt_StudentPhone.Text != "" && cmb_ClassID.SelectedIndex > -1 && cmb_StudentGender.SelectedIndex > -1 &&
               txt_StudentPersonalID.Text != "" && cmb_Specializations.SelectedIndex != -1 && txt_StudentEmail.Text != "")
            {
                #region Raw Data
                // Lấy dữ liệu từ trường nhập vào
                string StudentID = txt_StudentID.Text.ToString();

                string StudentName = txt_StudentName.Text.ToString();
                string StudentDOB = date_StudentDOB.Value.GetDateTimeFormats().First().ToString();
                string StudentAddress = txt_StudentAddress.Text.ToString();
                string StudentPhone = txt_StudentPhone.Text.ToString();
                string StudentEmail = txt_StudentEmail.Text.ToString();
                string ClassID = cmb_ClassID.SelectedValue.ToString();
                string StudentGender = cmb_StudentGender.SelectedItem.ToString();
                string StudentPersonalID = txt_StudentPersonalID.Text.ToString();
                int StudentLived = 0;
                if (checkbox_Lived.Checked)
                    StudentLived = 1;
                #endregion

                #region check định dạng hợp lệ

                // check độ dài của địa chỉ
                if (StudentAddress.Length > 50)
                {
                    MessageBox.Show("Địa chỉ quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check email hợp lệ
                if (StudentEmail.Length > 50 && studentsDAO.Instance.checkValidEmail(StudentEmail) == false)
                {
                    MessageBox.Show("Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng số điện thoại
                if (studentsDAO.Instance.checkValidNumberPhone(StudentPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng CCCD
                if (studentsDAO.Instance.checkValidNumber(StudentPersonalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (StudentID.Length > 12)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Update Data to Sql
                DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn sửa thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultNotify == DialogResult.Yes)
                {
                    // Truy vấn sửa data trong CSDL
                    string query = "UpdateDataStudents @StudentID , @ClassID , @StudentName , @StudentGender , @StudentDOB  , @StudentPersonalID , @StudentPhone , @StudentEmail , @StudentAddress , @StudentLived  ;";
                    DataTable dataStudents = DataProvider.Instance.ExcuteQuery(query, new object[] { StudentID, ClassID, StudentName, StudentGender, StudentDOB, StudentPersonalID, StudentEmail, StudentPhone, StudentAddress, StudentLived });

                    if (dataStudents.Rows.Count > -1)
                    {
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xoá các trường dữ liệu sau khi thêm thành công
                        //clearInputData();
                    }

                }

                // Reload lại dữ liệu trong bảng
                StudentInformations_Load(sender, e);
                #endregion

            }
            else
            {
                MessageBox.Show("Có trường thông tin bị bỏ trống, vui lòng điền đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Method

        private void clearInputData()
        {
            txt_StudentAddress.Clear();
            txt_StudentName.Clear();
            txt_StudentPersonalID.Clear();
            txt_StudentPhone.Clear();
            txt_StudentID.Clear();
            txt_StudentEmail.Clear();
            cmb_ClassID.SelectedIndex = -1;
            cmb_Specializations.SelectedIndex = -1;
            cmb_StudentGender.SelectedIndex = -1;
            date_StudentDOB.Value = DateTime.Now.Date;
            checkbox_Lived.Checked = false;
        }

        #endregion

        private void btn_DeleteStudents_Click(object sender, EventArgs e)
        {
            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn xoá thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                // TRuy vấn xoá data trong CSDL
                DataTable CheckContract = DataProvider.Instance.ExcuteQuery("SELECT * FROM Contracts WHERE Contracts.StudentID = @StudentID ", new object[] { StudentDeleteID });


                if(CheckContract.Rows.Count > 0)
                {
                    MessageBox.Show("Xoá không thành công, học sinh đang có hợp đồng trong hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "DeleteDataStudents @StudentID ";
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery(query, new object[] { StudentDeleteID });

                if (CheckStatus > 0)
                {

                    MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xoá các trường dữ liệu sau khi thêm thành công
                    this.Close();
                }

            }
        }
    }
}
