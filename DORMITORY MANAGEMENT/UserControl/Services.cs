using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Services : UserControl
    {
        public Services()
        {
            InitializeComponent();
        }

        private void cardShowInfo2_Load(object sender, EventArgs e)
        {

        }

        private void btn_deleteInput_Click(object sender, EventArgs e)
        {
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomArea.Text = "Khu";
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            cmb_Rooms.SelectedIndex = -1;
            cmb_Rooms.Text = "Phòng";
            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";
            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";

            dgv_Usages.DataSource = DataProvider.Instance.ExcuteQuery("GetUsageDetails");
        }

        private void btn_AddServices_Click(object sender, EventArgs e)
        {
            AddServices addServices = new AddServices();
            addServices.ShowDialog();
        }

        private void Services_Load(object sender, EventArgs e)
        {
            dgv_Usages.DataSource = DataProvider.Instance.ExcuteQuery("GetUsageDetails");

            cmb_RoomArea.DisplayMember = "AreaName";
            cmb_RoomArea.ValueMember = "AreaID";
            cmb_RoomArea.DataSource = DataProvider.Instance.ExcuteQuery("GetAreas");
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomArea.Text = "Khu";

            cmb_Months.DisplayMember = "MonthID";
            cmb_Months.ValueMember = "MonthName";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");
            cmb_Months.SelectedIndex = -1;
            cmb_Months.Text = "Tháng";

            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");
            cmb_Years.SelectedIndex = -1;
            cmb_Years.Text = "Năm";
        }

        private void cmb_RoomArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomArea.SelectedIndex != -1)
            {
                cmb_RoomTypes.DisplayMember = "RoomTypeName";
                cmb_RoomTypes.ValueMember = "RoomTypeID";
                cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
                cmb_RoomTypes.SelectedIndex = -1;
                cmb_RoomTypes.Text = "Loại phòng";
            }
        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomID";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ", new object[] { cmb_RoomArea.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = -1;
                cmb_Rooms.Text = "Phòng";
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(cmb_Rooms.SelectedIndex != -1 && cmb_Months.SelectedIndex != -1 && cmb_Years.SelectedIndex != -1)
            {
                string RoomID = cmb_Rooms.SelectedValue.ToString();
                int Months = int.Parse(cmb_Months.SelectedValue.ToString());
                int Years = int.Parse((cmb_Years.SelectedValue.ToString()));

                dgv_Usages.DataSource = DataProvider.Instance.ExcuteQuery("SearchUsageDetails @RoomID , @Months , @Years ;", new object[] { RoomID, Months, Years });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ trường dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
