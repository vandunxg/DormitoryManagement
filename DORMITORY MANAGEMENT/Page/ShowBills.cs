using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ShowBills : Form
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

        public ShowBills()
        {  
            
        }

        private string RoomName;

        public ShowBills(string BillID, string AreaName, string RoomTypeName,string RoomID,  string RoomName, int Months, int Years, string StaffID, int BillPaid)
        {
            InitializeComponent();

            lbl_BillID.Text = BillID;

            this.RoomName = RoomName;

            cmb_Areas.DisplayMember = "AreaName";
            cmb_Areas.ValueMember = "AreaID";
            cmb_Areas.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Areas");
            cmb_Areas.SelectedIndex = cmb_Areas.FindString(AreaName);

            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.SelectedIndex = cmb_RoomTypes.FindString(RoomTypeName);

            cmb_Months.DisplayMember = "MonthName";
            cmb_Months.ValueMember = "MonthID";
            cmb_Months.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Months");
            cmb_Months.SelectedIndex = cmb_Months.FindString(Months.ToString());


            cmb_Years.DisplayMember = "YearName";
            cmb_Years.ValueMember = "YearID";
            cmb_Years.DataSource = DataProvider.Instance.ExcuteQuery("SELECT * FROM Years");
            cmb_Years.SelectedIndex = cmb_Years.FindString(Years.ToString());

            txt_StaffID.Text = StaffID;

            cmb_BillState.SelectedIndex = BillPaid;


            dgv_RoomServices.DataSource = DataProvider.Instance.ExcuteQuery("GetServicesToBill @RoomID , @Months , @Years ", new object[] {RoomID, Months, Years});

            txt_TotalMoney.Text = DataProvider.Instance.ExcuteQuery("CalTotalMoneyBill @RoomID , @Months , @Years ", new object[] { RoomID, Months, Years }).Rows[0][0].ToString();

        }

        private void cmb_RoomTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_RoomTypes.SelectedIndex != -1 && cmb_RoomTypes.SelectedIndex != -1)
            {
                cmb_Rooms.DisplayMember = "RoomName";
                cmb_Rooms.ValueMember = "RoomID";
                cmb_Rooms.DataSource = DataProvider.Instance.ExcuteQuery("GetRoomServices @AreaID , @RoomTypeID ;", new object[] { cmb_Areas.SelectedValue.ToString(), cmb_RoomTypes.SelectedValue.ToString() });
                cmb_Rooms.SelectedIndex = cmb_Rooms.FindString(this.RoomName);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
