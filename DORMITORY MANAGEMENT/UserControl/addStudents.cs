using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.Page;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class addStudents : UserControl
    {
        public addStudents()
        {
            InitializeComponent();
        }

        #region Events

        public void addStudents_Load(object sender, EventArgs e)
        {

            #region get Students
            DataSet data = DataProvider.Instance.ExcuteQueryDataSet("GetStudents");
            dgv_studentsData.DataSource = data.Tables[0];
            #endregion



            #region Get Specializations to Combo box
            DataTable dataSpecializations = DataProvider.Instance.ExcuteQuery("GetSpecializations");
            cmb_Specializations.DisplayMember = "SpecializationName";
            cmb_Specializations.ValueMember = "SpecializationID";
            cmb_Specializations.DataSource = dataSpecializations;
            cmb_Specializations.SelectedIndex = -1;
            cmb_Specializations.Text = "Chuyên nghành";
            #endregion


        }

        private void dgv_studentsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_studentsData.Rows.Count && e.ColumnIndex < dgv_studentsData.Columns.Count)
            {

                string StudentID = dgv_studentsData.Rows[e.RowIndex].Cells[0].Value.ToString();
                string ClassID = dgv_studentsData.Rows[e.RowIndex].Cells[8].Value.ToString();
                string SpecializationID = DataProvider.Instance.ExcuteQuery("SELECT SpecializationID FROM Classrooms WHERE ClassID = @ClassID ", new object[] { ClassID }).Rows[0]["SpecializationID"].ToString();
                string SpecializationName = DataProvider.Instance.ExcuteQuery("SELECT SpecializationName FROM Specializations WHERE SpecializationID = @SpecializationID ", new object[] { SpecializationID }).Rows[0]["SpecializationName"].ToString();
                //cmb_Specializations.SelectedIndex = cmb_Specializations.FindString(SpecializationName);
                //string ClassID = cmb_ClassID.FindString(ClassID);
                string StudentName = dgv_studentsData.Rows[e.RowIndex].Cells[1].Value.ToString();
                string StudentGender = dgv_studentsData.Rows[e.RowIndex].Cells[4].Value.ToString();
                string StudentDOB = dgv_studentsData.Rows[e.RowIndex].Cells[2].Value.ToString();
                string StudentPersonalID = dgv_studentsData.Rows[e.RowIndex].Cells[7].Value.ToString();
                string StudentEmail = dgv_studentsData.Rows[e.RowIndex].Cells[6].Value.ToString();
                string StudentPhone = dgv_studentsData.Rows[e.RowIndex].Cells[5].Value.ToString();
                string StudentAddress = dgv_studentsData.Rows[e.RowIndex].Cells[3].Value.ToString();
                string StudentLived = dgv_studentsData.Rows[e.RowIndex].Cells[9].Value.ToString();

                StudentInformations studentInformationsDialog = new StudentInformations(StudentID, StudentName, ClassID, SpecializationName, StudentGender, StudentDOB, StudentPersonalID, StudentEmail, StudentPhone, StudentAddress, StudentLived); ;
                studentInformationsDialog.ShowDialog();
            }

        }

        private void btn_insertInformation_Click(object sender, EventArgs e)
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

                #region check Valid data

                // check độ dài của địa chỉ
                if (StudentAddress.Length > 50)
                {
                    MessageBox.Show("Địa chỉ quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng số điện thoại
                if (studentsDAO.Instance.checkValidNumberPhone(StudentPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng email
                if (StudentEmail.Length > 50 && studentsDAO.Instance.checkValidEmail(StudentEmail) == false)
                {
                    MessageBox.Show("Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // check định dạng CCCD
                if (studentsDAO.Instance.checkValidNumber(StudentPersonalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (StudentID.Length > 20)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng CCCD trong CSDL
                if (studentsDAO.Instance.checkRepeatInformation(StudentPersonalID, "SELECT * FROM dbo.Students WHERE StudentPersonalID = @textNeedCheck") == true)
                {
                    MessageBox.Show("CCCD đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng Mã SV trùng trong CSDL
                if (studentsDAO.Instance.checkRepeatInformation(StudentID, "SELECT * FROM dbo.Students WHERE StudentID = @textNeedCheck") == true)
                {
                    MessageBox.Show("MÃ SV đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                #endregion

                #region Insert Data 
                // Thêm data vào CSDL
                string query = "InsertDataStudents @StudentID , @ClassID , @StudentName , @StudentGender , @StudentDOB  , @StudentPersonalID , @StudentPhone , @StudentEmail , @StudentAddress , @StudentLived  ;";
                int checkInsertDataStatus = DataProvider.Instance.ExecuteNonQuery(query, new object[] { StudentID, ClassID, StudentName, StudentGender, StudentDOB, StudentPersonalID, StudentEmail, StudentPhone, StudentAddress, StudentLived });

                // Thông báo dữ liệu được thêm thành công
                if (checkInsertDataStatus > 0)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Reload lại dữ liệu trong bảng
                addStudents_Load(sender, e);

                // Xoá các trường dữ liệu sau khi thêm thành công
                clearInputData();
                #endregion

            }
            else
            {
                MessageBox.Show("Có trường thông tin bị bỏ trống, vui lòng điền đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btn_editInformation_Click(object sender, EventArgs e)
        {



        }

        private void btn_deleteButton_Click(object sender, EventArgs e)
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

        private void btn_SearchContracts_Click(object sender, EventArgs e)
        {
            string StudentID = txt_SearchStudentID.Text.Trim();

            if (StudentID.Length > 20)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(StudentID) FROM Students WHERE StudentID = @StudentID ", new object[] { StudentID }).Rows[0][0].ToString()) == 0)
            {
                MessageBox.Show("Không tìm thấy mã sinh viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataTable DataStudents = DataProvider.Instance.ExcuteQuery("SearchStudents @StudentID ", new object[] { StudentID });

            if (DataStudents.Rows.Count < 1)
            {
                MessageBox.Show("Không tìm thấy hợp đồng trên hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dgv_studentsData.DataSource = DataStudents;
        }

        private void btn_AddContracts_Click(object sender, EventArgs e)
        {
            addStudents_Load(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_SearchStudentID.Text = string.Empty;
            txt_StudentAddress.Text = string.Empty;
            txt_StudentEmail.Text = string.Empty;
            txt_StudentID.Text = string.Empty;
            txt_StudentName.Text = string.Empty;
            txt_StudentPersonalID.Text = string.Empty;
            txt_StudentPhone.Text = string.Empty;
            cmb_StudentGender.SelectedIndex = -1;
            cmb_StudentGender.Text = "Giới tính";

            addStudents_Load(sender, e);
        }

        private void txt_StudentPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }

        private void txt_StudentPersonalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }

        #endregion

        #region Method

        private void clearInputData()
        {
            txt_StudentAddress.Clear();
            txt_StudentName.Clear();
            txt_StudentPersonalID.Clear();
            txt_StudentPhone.Clear();
            txt_StudentID.Clear();
            txt_StudentEmail.Clear();
            
            cmb_Specializations.SelectedIndex = -1;
            cmb_Specializations.Text = "Chuyên nghành";

            cmb_ClassID.SelectedIndex = -1;
            cmb_ClassID.Text = "Lớp";

            cmb_StudentGender.SelectedIndex = -1;
            cmb_StudentGender.Text = "Giới tính";
            date_StudentDOB.Value = DateTime.Now.Date;
            checkbox_Lived.Checked = false;
        }



        #endregion

        
    }
}