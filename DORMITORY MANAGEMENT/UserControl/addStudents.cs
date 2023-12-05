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

        private void addStudents_Load(object sender, EventArgs e)
        {
            string query = "SELECT StudentID, StudentName, StudentPhone, StudentDOB, StudentAddress, StudentGender, StudentPersonalID, StudentClassroom , RoomID FROM dbo.Students";
            DataSet data = DataProvider.Instance.ExcuteQueryDataSet(query);
            dgv_studentsData.DataSource = data.Tables[0];

            btn_deleteButton.Enabled = false;
            btn_editButton.Enabled = false;
            //dgv_studentsData.AutoGenerateColumns = false;

        }

        private void dgv_studentsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_editButton.Enabled = true;
            btn_deleteButton.Enabled = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_studentsData.Rows.Count && e.ColumnIndex < dgv_studentsData.Columns.Count)
            {
                int index = -1;
                string selectedValue = "";

                // data to textbox
                txt_inputStudentID.Text = dgv_studentsData.Rows[e.RowIndex].Cells[0].Value.ToString();

                // data to textbox
                txt_inputStudentName.Text = dgv_studentsData.Rows[e.RowIndex].Cells[1].Value.ToString();

                // data to textbox
                txt_inputStudentPhone.Text = dgv_studentsData.Rows[e.RowIndex].Cells[2].Value.ToString();

                // data to date
                date_inputStudentDOB.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[3].Value.ToString());

                // data to textbox
                txt_inputStudentAddress.Text = dgv_studentsData.Rows[e.RowIndex].Cells[4].Value.ToString();

                // data to cmb
                selectedValue = dgv_studentsData.Rows[e.RowIndex].Cells[5].Value.ToString();
                index = cmb_inutStudentGender.FindString(selectedValue);
                cmb_inutStudentGender.SelectedIndex = index;

                // data to textbox
                txt_inputStudentPersonalID.Text = dgv_studentsData.Rows[e.RowIndex].Cells[6].Value.ToString();

                // data to cmb
                selectedValue = dgv_studentsData.Rows[e.RowIndex].Cells[7].Value.ToString();
                index = cmb_inputStudentClassroom.FindString(selectedValue);
                cmb_inputStudentClassroom.SelectedIndex = index;

                // data to date
               // date_inputCheckOutDate.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[8].Value.ToString());

                

                // data to check box
                if (dgv_studentsData.Rows[e.RowIndex].Cells[11].Value.ToString() == "True")
                    checkbox_inputLived.Checked = true;
                else
                    checkbox_inputLived.Checked = false;

                // data to check box
                if (dgv_studentsData.Rows[e.RowIndex].Cells[12].Value.ToString() == "True")
                    checkbox_inputRegStay.Checked = true;
                else
                    checkbox_inputRegStay.Checked = false;



            }

        }

        // Clear data sau khi thêm sửa xoá
        


        private void btn_insertInformation_Click(object sender, EventArgs e)
        {
            if (txt_inputStudentName.Text != "" && txt_inputStudentAddress.Text != "" && txt_inputStudentPhone.Text != "" && cmb_inputStudentClassroom.SelectedIndex > -1 && cmb_inutStudentGender.SelectedIndex > -1 &&
               txt_inputStudentPersonalID.Text != "" && txt_inputRoomID.Text != "")
            {
                // Lấy dữ liệu từ trường nhập vào
                string txt_StudentID = txt_inputStudentID.Text.ToString();
                string txt_StudentName = txt_inputStudentName.Text.ToString();
                string txt_StudentDOB = date_inputStudentDOB.Value.GetDateTimeFormats().First().ToString();
                string txt_StudentAddress = txt_inputStudentAddress.Text.ToString();
                string txt_StudentPhone = txt_inputStudentPhone.Text.ToString();
                string txt_StudentClassroom = cmb_inputStudentClassroom.SelectedItem.ToString();
                string txt_StudentGender = cmb_inutStudentGender.SelectedItem.ToString();
                string txt_StudentPersonalID = txt_inputStudentPersonalID.Text.ToString();
                string txt_RoomID = txt_inputRoomID.Text.ToString();
                int StudentLived = 0, StudentRegResident = 0;
                if (checkbox_inputLived.Checked)
                    StudentLived = 1;
                if (checkbox_inputRegStay.Checked)
                    StudentRegResident = 1;
                string txt_CheckInDate = date_inputCheckInDate.Value.GetDateTimeFormats().First().ToString();
                string txt_CheckOutDate = date_inputCheckOutDate.Value.GetDateTimeFormats().First().ToString();

                // check định dạng số điện thoại
                if (studentsDAO.Instance.checkValidNumberPhone(txt_StudentPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng CCCD
                if (studentsDAO.Instance.checkValidNumber(txt_StudentPersonalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (txt_StudentID.Length > 12)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng CCCD trong CSDL
                if (studentsDAO.Instance.checkRepeatInformation(txt_StudentPersonalID, "SELECT * FROM dbo.Students WHERE StudentPersonalID = @textNeedCheck") == true)
                {
                    MessageBox.Show("CCCD đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng Mã SV trùng trong CSDL
                if (studentsDAO.Instance.checkRepeatInformation(txt_StudentID, "SELECT * FROM dbo.Students WHERE StudentID = @textNeedCheck") == true)
                {
                    MessageBox.Show("MÃ SV đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm data vào CSDL
                string query = "INSERT INTO Students (StudentID , StudentName , StudentPhone , StudentDOB , StudentAddress , StudentGender , StudentPersonalID , StudentClassroom , RoomID , StudentLived , StudentRegResident) VALUES ( @txt_StudentID , @txt_StudentName , @txt_StudentPhone , @txt_StudentDOB , @txt_StudentAddress , @txt_StudentGender , @txt_StudentPersonalID , @txt_StudentClassroom , @txt_RoomID , @StudentLived , @StudentRegResident );";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_StudentID, txt_StudentName, txt_StudentPhone, txt_StudentDOB, txt_StudentAddress, txt_StudentGender, txt_StudentPersonalID, txt_StudentClassroom , txt_RoomID , StudentLived, StudentRegResident });

                // Thông báo dữ liệu được thêm thành công
                if (data.Rows.Count > -1)
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

        private void btn_editButton_Click(object sender, EventArgs e)
        {
            if (txt_inputStudentName.Text != "" && txt_inputStudentAddress.Text != "" && txt_inputStudentPhone.Text != "" && cmb_inputStudentClassroom.SelectedIndex > -1 && cmb_inutStudentGender.SelectedIndex > -1 &&
               txt_inputStudentPersonalID.Text != "" && txt_inputRoomID.Text != "")
            {
                // Lấy dữ liệu từ trường nhập vào
                string txt_StudentID = txt_inputStudentID.Text.ToString();
                string txt_StudentName = txt_inputStudentName.Text.ToString();
                string txt_StudentDOB = date_inputStudentDOB.Value.GetDateTimeFormats().First().ToString();
                string txt_StudentAddress = txt_inputStudentAddress.Text.ToString();
                string txt_StudentPhone = txt_inputStudentPhone.Text.ToString();
                string txt_StudentClassroom = cmb_inputStudentClassroom.SelectedItem.ToString();
                string txtStudentGender = cmb_inutStudentGender.SelectedItem.ToString();
                string txt_StudentPersonalID = txt_inputStudentPersonalID.Text.ToString();
                int StudentLived = 0, StudentRegResident = 0;
                if (checkbox_inputLived.Checked)
                    StudentLived = 1;
                if (checkbox_inputRegStay.Checked)
                    StudentRegResident = 1;
                string txt_CheckInDate = date_inputCheckOutDate.Value.GetDateTimeFormats().First().ToString();
                string txt_CheckOutDate = "6";

                // check định dạng số điện thoại
                if (studentsDAO.Instance.checkValidNumberPhone(txt_StudentPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng CCCD
                if (studentsDAO.Instance.checkValidNumber(txt_StudentPersonalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (txt_StudentID.Length > 12)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn sửa thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultNotify == DialogResult.Yes)
                {
                    // Truy vấn sửa data trong CSDL
                    string query = "UPDATE dataStudents SET StudentName = @txt_StudentName , StudentPhone = @txt_StudentPhone , StudentDOB = @txt_StudentDOB , StudentAddress = @txt_StudentAddress , StudentGender = @txtStudentGender , StudentPersonalID = @txt_StudentPersonalID , StudentClassroom = @txt_StudentClassroom , CheckInDate = @txt_CheckInDate , CheckOutDate = @txt_CheckOutDate , lived = @StudentLived , regStay = @StudentRegResident WHERE StudentID = @txt_StudentID ;";
                    DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_StudentName, txt_StudentPhone, txt_StudentDOB, txt_StudentAddress, txtStudentGender, txt_StudentPersonalID, txt_StudentClassroom, txt_CheckInDate, txt_CheckOutDate, StudentLived, StudentRegResident, txt_StudentID });

                    if (data.Rows.Count > -1)
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
            string IDstudent = dgv_studentsData.Rows[index].Cells[0].Value.ToString();




            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn xoá thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                // TRuy vấn xoá data trong CSDL
                string query = "DELETE FROM dataStudents WHERE StudentID = @IDstudent";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { IDstudent });

                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xoá các trường dữ liệu sau khi thêm thành công
                    clearInputData();
                }

            }

            // Load lại data trong bảng
            addStudents_Load(sender, e);
        }

        #endregion

        #region Method
        private void clearInputData()
        {
            txt_inputStudentAddress.Clear();
            txt_inputStudentName.Clear();
            txt_inputStudentPersonalID.Clear();
            txt_inputStudentPhone.Clear();
            txt_inputStudentID.Clear();
            cmb_inputStudentClassroom.SelectedIndex = -1;
            txt_inputRoomID.Clear();
            cmb_inutStudentGender.SelectedIndex = -1;
            date_inputStudentDOB.Value = DateTime.Now.Date;
            date_inputCheckOutDate.Value = DateTime.Now.Date;
        }
        #endregion
    }
}
