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

        

        private void addStudents_Load(object sender, EventArgs e)
        {
            string query = "SELECT studentID, fullname, phoneNumber, birthday, address, sex, personalID, classroom, startContract, dueTime, lived, regStay FROM dbo.dataStudents";
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
                txt_inputFullname.Text = dgv_studentsData.Rows[e.RowIndex].Cells[1].Value.ToString();

                // data to textbox
                txt_inputPhone.Text = dgv_studentsData.Rows[e.RowIndex].Cells[2].Value.ToString();

                // data to date
                date_inputBirthday.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[3].Value.ToString());

                // data to textbox
                txt_inputAddress.Text = dgv_studentsData.Rows[e.RowIndex].Cells[4].Value.ToString();

                // data to cmb
                selectedValue = dgv_studentsData.Rows[e.RowIndex].Cells[5].Value.ToString();
                index = cmb_inutSex.FindString(selectedValue);
                cmb_inutSex.SelectedIndex = index;

                // data to textbox
                txt_inputPersonalID.Text = dgv_studentsData.Rows[e.RowIndex].Cells[6].Value.ToString();

                // data to cmb
                selectedValue = dgv_studentsData.Rows[e.RowIndex].Cells[7].Value.ToString();
                index = cmb_inputClassroom.FindString(selectedValue);
                cmb_inputClassroom.SelectedIndex = index;

                // data to date
                date_inputDueTime.Value = DateTime.Parse(dgv_studentsData.Rows[e.RowIndex].Cells[8].Value.ToString());

                // data to combo box
                if (dgv_studentsData.Rows[e.RowIndex].Cells[9].Value.ToString() == "6")
                    cmb_inputTermContract.SelectedIndex = 0;
                else
                    cmb_inputTermContract.SelectedIndex = 1;

                // data to check box
                if (dgv_studentsData.Rows[e.RowIndex].Cells[10].Value.ToString() == "True")
                    checkbox_inputLived.Checked = true;
                else
                    checkbox_inputLived.Checked = false;

                // data to check box
                if (dgv_studentsData.Rows[e.RowIndex].Cells[11].Value.ToString() == "True")
                    checkbox_inputRegStay.Checked = true;
                else
                    checkbox_inputRegStay.Checked = false;



            }

        }

        // Clear data sau khi thêm sửa xoá
        private void clearInputData()
        {
            txt_inputAddress.Clear();
            txt_inputFullname.Clear();
            txt_inputPersonalID.Clear();
            txt_inputPhone.Clear();
            txt_inputStudentID.Clear();
            cmb_inputClassroom.SelectedIndex = -1;
            txt_inputRoomID.Clear();
            cmb_inutSex.SelectedIndex = -1;
            cmb_inputTermContract.SelectedIndex = -1;
            date_inputBirthday.Value = DateTime.Now.Date;
            date_inputDueTime.Value = DateTime.Now.Date;
        }


        private void btn_insertInformation_Click(object sender, EventArgs e)
        {
            if (txt_inputFullname.Text != "" && txt_inputAddress.Text != "" && txt_inputPhone.Text != "" && cmb_inputClassroom.SelectedIndex > -1 && cmb_inutSex.SelectedIndex > -1 && cmb_inputTermContract.SelectedIndex > -1 &&
               txt_inputPersonalID.Text != "" && txt_inputRoomID.Text != "")
            {
                // Lấy dữ liệu từ trường nhập vào
                string txt_studentID = txt_inputStudentID.Text.ToString();
                string txt_fullname = txt_inputFullname.Text.ToString();
                string txt_birthday = date_inputBirthday.Value.GetDateTimeFormats().First().ToString();
                string txt_address = txt_inputAddress.Text.ToString();
                string txt_numberPhone = txt_inputPhone.Text.ToString();
                string txt_classroom = cmb_inputClassroom.SelectedItem.ToString();
                string txt_sex = cmb_inutSex.SelectedItem.ToString();
                string txt_personalID = txt_inputPersonalID.Text.ToString();
                int checklived = 0, checkregStay = 0;
                if (checkbox_inputLived.Checked)
                    checklived = 1;
                if (checkbox_inputRegStay.Checked)
                    checkregStay = 1;
                string txt_startContract = date_inputDueTime.Value.GetDateTimeFormats().First().ToString();
                string txt_dueTime = "6";

                // check định dạng số điện thoại
                if (studentsInformation.Instance.checkValidNumberPhone(txt_numberPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng CCCD
                if (studentsInformation.Instance.checkValidNumber(txt_personalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (txt_studentID.Length > 12)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng CCCD trong CSDL
                if (studentsInformation.Instance.checkRepeatInformation(txt_personalID, "SELECT * FROM dbo.dataStudents WHERE personalID = @textNeedCheck") == true)
                {
                    MessageBox.Show("CCCD đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check trùng Mã SV trùng trong CSDL
                if (studentsInformation.Instance.checkRepeatInformation(txt_studentID, "SELECT * FROM dbo.dataStudents WHERE studentID = @textNeedCheck") == true)
                {
                    MessageBox.Show("MÃ SV đã tồn tại trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Thêm data vào CSDL
                string query = "INSERT INTO dataStudents (studentID , fullname , phoneNumber , birthday , address , sex , personalID , classroom , startContract , dueTime , lived , regStay) VALUES ( @txt_studentID , @txt_fullname , @txt_numberPhone , @txt_birthday , @txt_address , @txt_sex , @txt_personalID , @txt_classroom , @txt_startContract , @txt_dueTime , @checklived , @checkregStay );";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_studentID, txt_fullname, txt_numberPhone, txt_birthday, txt_address, txt_sex, txt_personalID, txt_classroom, txt_startContract, txt_dueTime, checklived, checkregStay });

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
            if (txt_inputFullname.Text != "" && txt_inputAddress.Text != "" && txt_inputPhone.Text != "" && cmb_inputClassroom.SelectedIndex > -1 && cmb_inutSex.SelectedIndex > -1 && cmb_inputTermContract.SelectedIndex > -1 &&
               txt_inputPersonalID.Text != "" && txt_inputRoomID.Text != "")
            {
                // Lấy dữ liệu từ trường nhập vào
                string txt_studentID = txt_inputStudentID.Text.ToString();
                string txt_fullname = txt_inputFullname.Text.ToString();
                string txt_birthday = date_inputBirthday.Value.GetDateTimeFormats().First().ToString();
                string txt_address = txt_inputAddress.Text.ToString();
                string txt_numberPhone = txt_inputPhone.Text.ToString();
                string txt_classroom = cmb_inputClassroom.SelectedItem.ToString();
                string txtsex = cmb_inutSex.SelectedItem.ToString();
                string txt_personalID = txt_inputPersonalID.Text.ToString();
                int checklived = 0, checkregStay = 0;
                if (checkbox_inputLived.Checked)
                    checklived = 1;
                if (checkbox_inputRegStay.Checked)
                    checkregStay = 1;
                string txt_startContract = date_inputDueTime.Value.GetDateTimeFormats().First().ToString();
                string txt_dueTime = "6";

                // check định dạng số điện thoại
                if (studentsInformation.Instance.checkValidNumberPhone(txt_numberPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check định dạng CCCD
                if (studentsInformation.Instance.checkValidNumber(txt_personalID) == false)
                {
                    MessageBox.Show("Số CCCD chỉ gồm 12 số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // check địng dạng Mã SV
                if (txt_studentID.Length > 12)
                {
                    MessageBox.Show("Định dạng Mã SV chỉ gồm 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn sửa thông tin này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultNotify == DialogResult.Yes)
                {
                    // Truy vấn sửa data trong CSDL
                    string query = "UPDATE dataStudents SET fullname = @txt_fullname , phoneNumber = @txt_numberPhone , birthday = @txt_birthday , address = @txt_address , sex = @txtsex , personalID = @txt_personalID , classroom = @txt_classroom , startContract = @txt_startContract , dueTime = @txt_dueTime , lived = @checklived , regStay = @checkregStay WHERE studentID = @txt_studentID ;";
                    DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_fullname, txt_numberPhone, txt_birthday, txt_address, txtsex, txt_personalID, txt_classroom, txt_startContract, txt_dueTime, checklived, checkregStay, txt_studentID });

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
                string query = "DELETE FROM dataStudents WHERE studentID = @IDstudent";
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

        
    }
}
