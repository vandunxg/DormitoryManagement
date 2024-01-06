using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_RenewContracts : UserControl
    {
        public Page_RenewContracts()
        {
            InitializeComponent();

            cmb_DateCheckOut.DisplayMember = "DateContractName";
            cmb_DateCheckOut.ValueMember = "DateContractID";
            cmb_DateCheckOut.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM DateContract");
            cmb_DateCheckOut.SelectedIndex = -1;
            cmb_DateCheckOut.Text = "Thời hạn";

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();

            dgv_ContractsOutDate.DataSource = DataProvider.Instance.ExcuteQuery("GetContractOutDate");
        }

        #region Events
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            cmb_DateCheckOut.SelectedIndex = -1;
            cmb_DateCheckOut.Text = "Thời hạn";

            txt_StaffID.Text = AuthService.GetLoggedInUserId().ToString();
            txt_ContractID.Text = string.Empty;

            dgv_ContractsOutDate.DataSource = DataProvider.Instance.ExcuteQuery("GetContractOutDate");
        }

        private void btn_AddContracts_Click(object sender, EventArgs e)
        {
            if(txt_ContractID.Text != string.Empty && txt_StaffID.Text != string.Empty && cmb_DateCheckOut.SelectedIndex != -1)
            {
                string ContractID = txt_ContractID.Text.Trim();
                string StaffID = txt_StaffID.Text.Trim();
                int NewDate = int.Parse(cmb_DateCheckOut.SelectedValue.ToString());
                string NewCheckOutDate = DateTime.Now.Date.AddMonths(NewDate).ToString();
                string NewCheckInDate = DateTime.Now.Date.ToString();

                DataTable ContractData = DataProvider.Instance.ExcuteQuery("SELECT CheckOutDate FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID });

                if(ContractData.Rows.Count > 0)
                {
                    DateTime CheckDate = DateTime.Parse(ContractData.Rows[0]["CheckOutDate"].ToString());

                    if(CheckDate.Date > DateTime.Now.Date)
                    {
                        MessageBox.Show("Hợp đồng vẫn còn hiệu lực", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {

                        string StudentID = DataProvider.Instance.ExcuteQuery("SELECT StudentID FROM Contracts WHERE ContractID = @ContractID ", new object[] { ContractID }).Rows[0]["StudentID"].ToString();

                        DateTime CheckStudentDate  = DateTime.Parse(DataProvider.Instance.ExcuteQuery("SELECT CheckOutDate FROM Contracts WHERE StudentID = @StudentID ORDER BY CheckOutDate DESC;", new object[] { StudentID }).Rows[0][0].ToString());


                        if(CheckStudentDate.Date > DateTime.Now.Date)
                        {
                            MessageBox.Show("Sinh viên này đang có hợp đồng còn hiệu lực" , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        int CheckStatus = DataProvider.Instance.ExecuteNonQuery("RenewContracts @ContractID , @StaffID , @CheckInDate , @CheckOutDate ", new object[] { ContractID, StaffID, NewCheckInDate, NewCheckOutDate });

                        if(CheckStatus > 0)
                        {
                            MessageBox.Show("Gia hạn thành công", "Thông báoo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btn_Refresh_Click(sender, e);
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Gia hạn không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }


                }
                else
                {
                    MessageBox.Show("Không tìm thấy hợp đồng trên hệ thông", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
