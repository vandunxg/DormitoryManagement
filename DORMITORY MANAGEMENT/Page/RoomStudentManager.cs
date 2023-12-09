using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class RoomStudentManager : Form
    {

        #region mouse move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void bunifuPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        public RoomStudentManager()
        {
            InitializeComponent();
        }

        private string RoomID;

        public RoomStudentManager(string RoomID)
        {
            InitializeComponent();
            lbl_RoomID.Text = RoomID;
            this.RoomID = RoomID;

            string query = "SELECT StudentName, StudentID FROM Students WHERE RoomID = @RoomID ";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { RoomID });
            dgv_Students.DataSource = data;

        }

        #region Events

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

        private void RoomStudentManager_Load(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Services WHERE RoomID = @RoomID", new object[] { RoomID });
            
            if(data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];
                RoomServices roomServices = new RoomServices(row);
                cardShowInfo_Electricity.setAllValue("Tiền điện", roomServices.ServiceElectricity);
                cardShowInfo_Water.setAllValue("Tiền nước", roomServices.ServiceWater);
                cardShowInfo_Total.setAllValue("Tổng tiền", roomServices.ServiceTotal);
                if (roomServices.Paid == "True")
                {
                    lbl_PaidState.ForeColor = Color.FromArgb(19, 186, 126);
                    lbl_PaidState.Text = "Đã thanh toán";
                }
                else
                {
                    lbl_PaidState.ForeColor = Color.FromArgb(219, 89, 98);
                    lbl_PaidState.Text = "Chưa thanh toán";
                }
                lbl_ServiceElectricity.Text = roomServices.ServiceElectricity + "đ";
                lbl_ServiceWater.Text = roomServices.ServiceWater + "đ";
                lbl_ServiceInternet.Text = roomServices.ServiceInternet + "đ";
                lbl_ServiceCleaning.Text = roomServices.ServiceCleaning + "đ";
                lbl_ServiceTotal.Text = roomServices.ServiceTotal + "đ";
            }
            else
            {
                RoomServices roomServices = new RoomServices();
                cardShowInfo_Electricity.setAllValue("Tiền điện", roomServices.ServiceElectricity);
                cardShowInfo_Water.setAllValue("Tiền nước", roomServices.ServiceWater);
                cardShowInfo_Total.setAllValue("Tổng tiền", roomServices.ServiceTotal);
            }

           



        }

        private void btn_UpdateServiceState_Click(object sender, EventArgs e)
        {
            if(cmb_RoomServiceState.SelectedIndex == 0)
            {
                DataTable data = DataProvider.Instance.ExcuteQuery("UPDATE Services SET Paid = @Paid WHERE RoomID = @RoomID", new object[] { 1 , RoomID});
                if(data.Rows.Count > 0)
                {

                    MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                    
                    
            }
            else
            {
                DataTable data = DataProvider.Instance.ExcuteQuery("UPDATE Services SET Paid = @Paid WHERE RoomID = @RoomID", new object[] { 0, RoomID });
                if (data.Rows.Count > 0)
                {

                    MessageBox.Show("Đã cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            RoomStudentManager_Load(sender, e);
        }

        
    }
}
