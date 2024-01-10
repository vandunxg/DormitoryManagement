using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Form_UpdateUsageService : Form
    {
        public Form_UpdateUsageService()
        {
            InitializeComponent();
        }

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

        #region Events
        private void btn_exit_Click(object sender, EventArgs e)
        {
            
                this.Close();
            
        }

        private void AddServices_Load(object sender, EventArgs e)
        {
            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");

            cmb_Services.DisplayMember = "ServiceName";
            cmb_Services.ValueMember = "ServiceID";
            cmb_Services.DataSource = DataProvider.Instance.ExcuteQuery("GetServices");

            cmb_Months.DisplayMember = "MonthName";
            cmb_Months.ValueMember = "MonthID";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");

            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");

        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";
            }
        }

        private void cmb_Areas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Areas.SelectedIndex != -1)
            {
                cmb_RoomTypes.DisplayMember = "RoomTypeName";
                cmb_RoomTypes.ValueMember = "RoomTypeID";
                cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            }
        }

        private void btn_AddServices_Click(object sender, EventArgs e)
        {
            if (cmb_Rooms.SelectedIndex != -1 && cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1
                && cmb_Services.SelectedIndex != -1 && txt_ServiceQuantity.Text != string.Empty)
            {
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                string ServiceID = cmb_Services.SelectedValue.ToString();
                int Months = int.Parse(cmb_Months.SelectedValue.ToString());
                int Years = int.Parse(cmb_Years.SelectedValue.ToString());
                int Quantity = int.Parse(txt_ServiceQuantity.Text);

                if (Months > DateTime.Now.Month && Years == DateTime.Now.Year)
                {
                    MessageBox.Show("Thời gian không thể lớn hơn thời điểm hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Years > DateTime.Now.Year)
                {
                    MessageBox.Show("Thời gian không thể lớn hơn thời điểm hiện tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DataProvider.Instance.ExcuteQuery("CheckDuplicateUsage @RoomID , @Months , @Years , @ServiceID ", new object[] { RoomID, Months, Years, ServiceID }).Rows.Count > 0)
                {
                    MessageBox.Show("Dịch vụ đã được thêm trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string query = "InsertUsages @RoomID , @ServiceID , @Months , @Years , @UsageQuantity ;";
                int checkStatusInsertData = DataProvider.Instance.ExecuteNonQuery(query, new object[] { RoomID, ServiceID, Months, Years, Quantity });

                if (checkStatusInsertData > 0)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearInput();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm dữ liệu không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void txt_ServiceQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
        }
        #endregion

        #region Methods
        private void ClearInput()
        {
            txt_ServiceQuantity.Text = string.Empty;
            cmb_Areas.SelectedIndex = -1;
            cmb_Areas.Text = "Khu";
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            cmb_Rooms.SelectedIndex = -1;
            cmb_Rooms.Text = "Phòng";
            cmb_Services.SelectedIndex = -1;
            cmb_Services.Text = "Dịch vụ";
            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";
            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";
        }


        #endregion


    }
}
