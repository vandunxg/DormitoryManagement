using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT.Page
{
    public partial class AddServiceUsage : UserControl
    {
        public AddServiceUsage()
        {
            InitializeComponent();
        }

        private void AddServiceUsage_Load(object sender, EventArgs e)
        {
            string query = "SELECT RoomID , ServiceElectricity , ServiceWater , ServiceInternet , ServiceCleaning , Paid FROM Services";
            DataTable data = DataProvider.Instance.ExcuteQuery(query);
            dgv_Services.DataSource = data;
        }

        private void cmb_RoomArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_RoomArea.SelectedIndex != -1)
            {
                string RoomArea = cmb_RoomArea.SelectedItem.ToString();
                DataTable data = DataProvider.Instance.ExcuteQuery("SELECT RoomID FROM Rooms WHERE RoomArea = @RoomArea ", new object[] { RoomArea });
                
                cmb_RoomID.DataSource = data.Rows[0];
                cmb_RoomID.DisplayMember = "RoomID";
                cmb_RoomID.ValueMember = "RoomID";
                cmb_RoomID.SelectedIndex = -1;
            }
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string VIP1 = "100000", VIP2 = "150000", VIP3 = "200000";


            if(cmb_RoomID.SelectedIndex != -1 && cmb_RoomArea.SelectedIndex != -1 && cmb_Paid.SelectedIndex != -1
                && txt_ServiceElectricity.Text.ToString() != "" && txt_ServiceWater.Text.ToString() != "")
            {
                string _ServiceElectricity = txt_ServiceElectricity.Text.ToString();
                string _ServiceWater = txt_ServiceWater.Text.ToString();
                string _RoomID = cmb_RoomID.SelectedValue.ToString();
                if(cmb_Paid.SelectedIndex == 0)
                {
                    string _Paid = "1";
                }
                else
                {
                    string _Paid = "0";
                }
                
                

                string query = "INSERT INTO Services ";

            }
            else
            {
                MessageBox.Show("Có trường thông tin bị bỏ trống, vui lòng điền đầy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmb_RoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_RoomID.SelectedIndex != -1)
            {
                string RoomID = cmb_RoomID.SelectedValue.ToString();
                MessageBox.Show(RoomID.ToString());
            
            }
        }
    }
}
