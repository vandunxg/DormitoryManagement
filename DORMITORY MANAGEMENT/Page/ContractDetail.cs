using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ContractDetail : Form
    {

        #region mouse move
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

        public ContractDetail()
        {
            InitializeComponent();
        }

        public ContractDetail(string ContractID, string StudentID, string AreaID, string RoomTypeID, string RoomID, string date_CheckIn, string date_CheckOut, string ContractState, string StaffID)
        {

            InitializeComponent();



            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");

            lbl_ContractID.Text = ContractID;
            txt_StudentID.Text = StudentID;
            txt_StaffID.Text = StaffID;
            cmb_Areas.SelectedIndex = cmb_Areas.FindString(AreaID);
            date_ContractCheckin.Value = DateTime.Parse(date_CheckIn);
            date_ContractCheckout.Value = DateTime.Parse(date_CheckOut);
            cmb_ContractState.SelectedIndex = cmb_ContractState.FindString(ContractState);

            int CheckContractState = cmb_ContractState.SelectedIndex;
            if (CheckContractState == 0)
            {
                lbl_ContractID.ForeColor = Color.FromArgb(72, 186, 120);
            }
            else
            {
                lbl_ContractID.ForeColor = Color.FromArgb(219, 89, 98);
            }


        }

        #region Events
        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Areas.SelectedIndex != -1)
            {
                cmb_RoomTypes.DisplayMember = "RoomTypeName";
                cmb_RoomTypes.ValueMember = "RoomTypeID";
                cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            }
        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Rooms.DisplayMember = "RoomName";
            cmb_Rooms.ValueMember = "RoomID";
            cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ", new object[] { int.Parse(cmb_Areas.SelectedValue.ToString()), int.Parse(cmb_RoomTypes.SelectedValue.ToString()) });
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_DeleteContracts_Click(object sender, EventArgs e)
        {
            string ContractID = lbl_ContractID.Text;

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn xoá hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("DeleteContracts @ContractID ", new object[] { ContractID });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Xoá hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                else
                {
                    MessageBox.Show("Xoá hợp đồng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void btn_SavedContracts_Click(object sender, EventArgs e)
        {
            string ContractID = lbl_ContractID.Text.Trim();
            //string StudentID = txt_StudentID.Text.Trim();
            int AreaID = int.Parse(cmb_Areas.SelectedValue.ToString());
            int RoomTypeID = int.Parse(cmb_RoomTypes.SelectedValue.ToString());
            int RoomID = int.Parse(cmb_Rooms.SelectedValue.ToString());
            int ContractState;
            if (cmb_ContractState.SelectedIndex == 0)
            {
                ContractState = 1;
            }
            else
            {
                ContractState = 0;
            }

            DialogResult CheckNotify = MessageBox.Show("Bạn có chắc chắn muốn sửa hợp đồng này chứ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (CheckNotify == DialogResult.Yes)
            {
                int CheckStatus = DataProvider.Instance.ExecuteNonQuery("UpdateContracts @ContractID , @ContractState ", new object[] { ContractID, ContractState });

                if (CheckStatus > 0)
                {
                    MessageBox.Show("Chỉnh sửa hợp đồng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                else
                {
                    MessageBox.Show("Chỉnh sửa hợp đồng không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void cmb_ContractState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_ContractState.SelectedIndex != -1)
            {
                int CheckContractState = cmb_ContractState.SelectedIndex;
                if (CheckContractState == 0)
                {
                    lbl_ContractID.ForeColor = Color.FromArgb(72, 186, 120);
                }
                else
                {
                    lbl_ContractID.ForeColor = Color.FromArgb(219, 89, 98);
                }
            }
        }
        #endregion


    }
}
