using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Data;
using System.Net.Security;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_Settings : UserControl
    {
        public Page_Settings()
        {
            InitializeComponent();

            LoadData();
        }

        #region Methods
        private void LoadData()
        {


            int StaffID = AuthService.GetLoggedInUserId();
            DataTable StaffData = DataProvider.Instance.ExcuteQuery("SELECT * FROM Staffs WHERE StaffID = @StaffID ", new object[] { StaffID });
            
            if(StaffData.Rows.Count > 0)
            {
                DataRow DataOfStaff = StaffData.Rows[0];

                txt_StaffName.Text = DataOfStaff["StaffName"].ToString();
                txt_StaffID.Text = DataOfStaff["StaffID"].ToString();
                txt_StaffAddress.Text = DataOfStaff["StaffAddress"].ToString();
                txt_StaffPersonalID.Text = DataOfStaff["StaffPersonalID"].ToString();
                txt_StaffPhone.Text = DataOfStaff["StaffPhone"].ToString();
                txt_StaffSalary.Text = DataOfStaff["StaffSalary"].ToString();

                txt_StaffEmail.Text = DataOfStaff["StaffEmail"].ToString();
            }
        }
        #endregion

        #region Events
        private void btn_SavedStaffInfors_Click(object sender, EventArgs e)
        {
            if (txt_StaffName.Text != string.Empty && txt_StaffPersonalID.Text != string.Empty && txt_StaffPhone.Text != string.Empty && txt_StaffAddress.Text != string.Empty)
            {

                int StaffID = int.Parse(txt_StaffID.Text);
                string StaffName = txt_StaffName.Text.Trim();
                string StaffPhone = txt_StaffPhone.Text.Trim();
                string StaffAddress = txt_StaffAddress.Text.Trim();
                string StaffPersonalID = txt_StaffPersonalID.Text.Trim();

                if (StaffName.Length > 50)
                {
                    MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StaffAddress.Length > 50)
                {
                    MessageBox.Show("Tên quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (studentsDAO.Instance.checkValidNumberPhone(StaffPhone) == false)
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StaffPersonalID.Length > 12)
                {
                    MessageBox.Show("CCCD không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (CheckNotify == DialogResult.Yes)
                {
                    int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateStaffs @StaffID , @StaffName , @StaffPhone , @StaffAddress , @StaffPersonalID ", new object[] { StaffID, StaffName, StaffPhone, StaffAddress, StaffPersonalID });

                    if (CheckStatus > 0)
                    {
                        MessageBox.Show("Thay đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trường thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btn_SavedLoginInfor_Click(object sender, EventArgs e)
        {
            if (txt_StaffEmail.Text != string.Empty && txt_NewPassword.Text != string.Empty && txt_RetypeNewPassword.Text != string.Empty)
            {
                string StaffID = txt_StaffID.Text;
                string StaffEmail = txt_StaffEmail.Text.Trim();
                string NewPassword = txt_NewPassword.Text.Trim();
                string RetypePassword = txt_RetypeNewPassword.Text.Trim();



                if (NewPassword != RetypePassword)
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu khớp nhau!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (NewPassword.Length < 5)
                {
                    MessageBox.Show("Mật khẩu quá ngắn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (NewPassword.Length > 20)
                {
                    MessageBox.Show("Mật khẩu quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (StaffEmail.Length > 50)
                {
                    MessageBox.Show("Email quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Account.Instance.checkValidEmail(StaffEmail) == false)
                {
                    MessageBox.Show("Email không đúng định dạng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn thay đổi thông tin này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (CheckNotify == DialogResult.Yes)
                {
                    int CheckEmailChange = DataProvider.Instance.ExecuteNonQuery("UpdateEmail @StaffID , @StaffEmail ", new object[] { StaffID, StaffEmail });
                    int CheckPasswordChange = DataProvider.Instance.ExecuteNonQuery("UpdatePassword @StaffID , @StaffEmail , @Password ", new object[] { StaffID, StaffEmail, NewPassword });


                    if (CheckPasswordChange > 0 && CheckEmailChange > 0)
                    {
                        MessageBox.Show("Thay đổi thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Thay đổi thông tin không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trường thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txt_StaffPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }

        private void txt_StaffPersonalID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }
        #endregion
    }
}
