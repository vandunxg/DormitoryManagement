using DORMITORY_MANAGEMENT.DAO;
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
            string query = "GetStudents";
            DataSet data = DataProvider.Instance.ExcuteQueryDataSet(query);
            dgv_studentsData.DataSource = data.Tables[0];
            #endregion

            btn_deleteButton.Enabled = false;
            btn_editInformation.Enabled = false;

            #region get Departments from sql
            DataTable DepartmentsData = DataProvider.Instance.ExcuteQuery("GetDepartments");
            cmb_Departments.DisplayMember = "DepartmentName"; // chỉ hiển thị tên
            cmb_Departments.ValueMember = "DepartmentID"; // chỉ định value là ID
            cmb_Departments.DataSource = DepartmentsData;
            #endregion

            #region get TypesRoom from Sql
            DataTable TypesRoomData = DataProvider.Instance.ExcuteQuery("GetTypeRoom");
            cmb_TypesRoom.DisplayMember = "TypeName"; // chỉ hiển thị tên
            cmb_TypesRoom.ValueMember = "TypeID"; // chỉ định value là ID
            cmb_TypesRoom.DataSource = TypesRoomData;
            #endregion



        }

        private void dgv_studentsData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editInformation.Enabled = true;
            btn_deleteButton.Enabled = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_studentsData.Rows.Count && e.ColumnIndex < dgv_studentsData.Columns.Count)
            {
                
                

                txt_StudentID.Text = dgv_studentsData.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_StudentName.Text = dgv_studentsData.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmb_StudentGender.SelectedIndex = cmb_StudentGender.FindString(dgv_studentsData.Rows[e.RowIndex].Cells[2].Value.ToString());
                date_StudentDOB.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[3].Value.ToString());
                txt_StudentAddress.Text = dgv_studentsData.Rows[e.RowIndex].Cells[4].Value.ToString();
                txt_StudentPhone.Text = dgv_studentsData.Rows[e.RowIndex].Cells[5].Value.ToString();
                txt_StudentPersonalID.Text = dgv_studentsData.Rows[e.RowIndex].Cells[6].Value.ToString();
                string DepartmentName = DataProvider.Instance.ExcuteQuery("SELECT DepartmentName FROM Departments WHERE DepartmentID = @DepartmentID ", new object[] { dgv_studentsData.Rows[e.RowIndex].Cells[8].Value.ToString() }).Rows[0]["DepartmentName"].ToString();
                cmb_Departments.SelectedIndex = cmb_Departments.FindString(DepartmentName);
                if(cmb_Departments.SelectedIndex != -1)
                {
                    cmb_ClassID.SelectedIndex = cmb_ClassID.FindString(dgv_studentsData.Rows[e.RowIndex].Cells[7].Value.ToString());
                }
                string TypeRoom = DataProvider.Instance.ExcuteQuery("SELECT TypeID FROM Rooms WHERE RoomID = @RoomID ", new object[] { dgv_studentsData.Rows[e.RowIndex].Cells[9].Value.ToString() }).Rows[0]["TypeID"].ToString();

                cmb_RoomID.DataSource = DataProvider.Instance.ExcuteQuery("SELECT RoomID FROM Rooms WHERE TypeID = @TypeID ", new object[] { TypeRoom });
                cmb_TypesRoom.SelectedIndex = cmb_TypesRoom.FindString(TypeRoom);
                cmb_RoomID.SelectedIndex = cmb_RoomID.FindString(dgv_studentsData.Rows[e.RowIndex].Cells[9].Value.ToString());
                date_CheckInDate.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[10].Value.ToString());
                date_CheckOutDate.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[11].Value.ToString());
                if (dgv_studentsData.Rows[e.RowIndex].Cells[12].Value.ToString() == "True")
                    checkbox_Lived.Checked = true;
                else
                    checkbox_Lived.Checked = false;
                if (dgv_studentsData.Rows[e.RowIndex].Cells[13].Value.ToString() == "True")
                    checkbox_RegStay.Checked = true;
                else
                    checkbox_RegStay.Checked = false;
            }

        }

        private void btn_insertInformation_Click(object sender, EventArgs e)
        {
            
            if (txt_StudentName.Text != "" && txt_StudentAddress.Text != "" && txt_StudentPhone.Text != "" && cmb_ClassID.SelectedIndex > -1 && cmb_StudentGender.SelectedIndex > -1 &&
               txt_StudentPersonalID.Text != "" && cmb_RoomID.SelectedIndex != -1 && cmb_Departments.SelectedIndex != -1 && cmb_TypesRoom.SelectedIndex != -1)
            {
                // Lấy dữ liệu từ trường nhập vào
                string StudentID = txt_StudentID.Text.ToString();
                string StudentName = txt_StudentName.Text.ToString();
                string StudentDOB = date_StudentDOB.Value.GetDateTimeFormats().First().ToString();
                string StudentAddress = txt_StudentAddress.Text.ToString();
                string StudentPhone = txt_StudentPhone.Text.ToString();
                string ClassID = cmb_ClassID.SelectedValue.ToString();
                string StudentGender = cmb_StudentGender.SelectedItem.ToString();
                string StudentPersonalID = txt_StudentPersonalID.Text.ToString();
                string RoomID = cmb_RoomID.SelectedValue.ToString();
                string TypeID = cmb_TypesRoom.SelectedValue.ToString();
                string DepartmentID = cmb_Departments.SelectedValue.ToString();
                
                int StudentLived = 0, StudentRegResident = 0;
                if (checkbox_Lived.Checked)
                    StudentLived = 1;
                if (checkbox_RegStay.Checked)
                    StudentRegResident = 1;
                string CheckInDate = date_CheckInDate.Value.GetDateTimeFormats().First().ToString();
                string CheckOutDate = date_CheckOutDate.Value.GetDateTimeFormats().First().ToString();

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

                // Thêm data vào CSDL
                string query = "InsertDataStudents @StudentID , @StudentName , @StudentGender , @StudentDOB , @StudentAddress , @StudentPhone , @StudentPersonalID , @ClassID , @DepartmentID , @RoomID , @CheckInDate , @CheckOutDate , @StudentLived , @StudentRegResident ;";
                DataTable dataStudents = DataProvider.Instance.ExcuteQuery(query, new object[] { StudentID, StudentName, StudentGender, StudentDOB, StudentAddress, StudentPhone, StudentPersonalID, ClassID, DepartmentID, RoomID, CheckInDate, CheckOutDate, StudentLived, StudentRegResident });

                // Thông báo dữ liệu được thêm thành công
                if (dataStudents.Rows.Count > -1)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // Reload lại dữ liệu trong bảng
                addStudents_Load(sender, e);

                // Xoá các trường dữ liệu sau khi thêm thành công
                clearInputData();


            }
            else
            {
                MessageBox.Show("Có trường thông tin bị bỏ trống, vui lòng điền đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_editInformation_Click(object sender, EventArgs e)
        {
            if (txt_StudentName.Text != "" && txt_StudentAddress.Text != "" && txt_StudentPhone.Text != "" && cmb_ClassID.SelectedIndex > -1 && cmb_StudentGender.SelectedIndex > -1 &&
               txt_StudentPersonalID.Text != "" && cmb_RoomID.SelectedIndex != -1 && cmb_Departments.SelectedIndex != -1 && cmb_TypesRoom.SelectedIndex != -1)
            {
                // Lấy dữ liệu từ trường nhập vào
                string StudentID = txt_StudentID.Text.ToString();
                string StudentName = txt_StudentName.Text.ToString();
                string StudentDOB = date_StudentDOB.Value.GetDateTimeFormats().First().ToString();
                string StudentAddress = txt_StudentAddress.Text.ToString();
                string StudentPhone = txt_StudentPhone.Text.ToString();
                string ClassID = cmb_ClassID.SelectedValue.ToString();
                string StudentGender = cmb_StudentGender.SelectedItem.ToString();
                string StudentPersonalID = txt_StudentPersonalID.Text.ToString();
                string RoomID = cmb_RoomID.SelectedValue.ToString();
                string TypeID = cmb_TypesRoom.SelectedValue.ToString();
                string DepartmentID = cmb_Departments.SelectedValue.ToString();

                int StudentLived = 0, StudentRegResident = 0;
                if (checkbox_Lived.Checked)
                    StudentLived = 1;
                if (checkbox_RegStay.Checked)
                    StudentRegResident = 1;
                string CheckInDate = date_CheckInDate.Value.GetDateTimeFormats().First().ToString();
                string CheckOutDate = date_CheckOutDate.Value.GetDateTimeFormats().First().ToString();

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


                DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn sửa thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultNotify == DialogResult.Yes)
                {
                    // Truy vấn sửa data trong CSDL
                    string query = "UpdateDataStudents";
                    DataTable dataStudents = DataProvider.Instance.ExcuteQuery(query, new object[] { StudentID, StudentName, StudentGender, StudentDOB, StudentAddress, StudentPhone, StudentPersonalID, ClassID, DepartmentID, RoomID, CheckInDate, CheckOutDate, StudentLived, StudentRegResident });

                    if (dataStudents.Rows.Count > -1)
                    {
                        MessageBox.Show("Đã sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Xoá các trường dữ liệu sau khi thêm thành công
                        clearInputData();
                    }

                }


                // Reload lại dữ liệu trong bảng
                addStudents_Load(sender, e);

            }
            else
            {
                MessageBox.Show("Có trường thông tin bị bỏ trống, vui lòng điền đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_deleteButton_Click(object sender, EventArgs e)
        {
            // Khai báo chỉ số index của dòng được chọn và lấy ra chuỗi Mã sinh viên
            int index = dgv_studentsData.SelectedRows[0].Index;
            string StudentID = dgv_studentsData.Rows[index].Cells[0].Value.ToString();




            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn xoá thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                // TRuy vấn xoá data trong CSDL
                string query = "DELETE FROM Students WHERE StudentID = @StudentID ";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { StudentID });

                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xoá các trường dữ liệu sau khi thêm thành công
                    clearInputData();
                }

            }
            clearInputData();
            // Load lại data trong bảng
            addStudents_Load(sender, e);
        }

        private void cmb_Departments_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(cmb_Departments.SelectedIndex != -1)
            {
                string departmentID = cmb_Departments.SelectedValue.ToString();
                cmb_ClassID.SelectedIndex = -1;
                DataTable dataClassroom = DataProvider.Instance.ExcuteQuery("GetClassroom @DepartmentID ", new object[] { departmentID });
                cmb_ClassID.DisplayMember = "ClassName";
                cmb_ClassID.ValueMember = "ClassID";
                cmb_ClassID.DataSource = dataClassroom;
            }

        }

        private void cmb_TypesRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_TypesRoom.SelectedIndex != -1)
            {
                string TypeID = cmb_TypesRoom.SelectedValue.ToString();
                // get Room from Sql
                cmb_RoomID.SelectedIndex = -1;
                DataTable RoomsData = DataProvider.Instance.ExcuteQuery("GetRoomsBelowCapacity @TypeID", new object[] { TypeID });
                cmb_RoomID.DisplayMember = "RoomID"; // chỉ hiển thị tên
                cmb_RoomID.ValueMember = "RoomID"; // chỉ định value là ID
                cmb_RoomID.DataSource = RoomsData;
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
            cmb_ClassID.SelectedIndex = -1;
            cmb_RoomID.SelectedIndex = -1;
            cmb_TypesRoom.SelectedIndex = -1;
            cmb_Departments.SelectedIndex = -1;
            cmb_StudentGender.SelectedIndex = -1;
            date_StudentDOB.Value = DateTime.Now.Date;
            date_CheckOutDate.Value = DateTime.Now.Date;
            checkbox_Lived.Checked = false;
            checkbox_Lived.Enabled = false;
        }


        #endregion

        
    }
}