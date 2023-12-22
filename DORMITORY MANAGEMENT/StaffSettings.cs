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

namespace DORMITORY_MANAGEMENT
{
    public partial class StaffSettings : UserControl
    {
        public StaffSettings()
        {
            InitializeComponent();

            Admin_Dashboard admin_Dashboard = new Admin_Dashboard();
            int StaffID = admin_Dashboard.StaffID1;

            DataRow StaffData = DataProvider.Instance.ExcuteQuery("SELECT * FROM Staffs WHERE StaffID = @StaffID ", new object[] { StaffID }).Rows[0];

            txt_StaffName.Text = StaffData["StaffName"].ToString();
        }
    }
}
