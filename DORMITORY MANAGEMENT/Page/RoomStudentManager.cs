using DORMITORY_MANAGEMENT.DAO;
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

        public RoomStudentManager(string RoomID)
        {
            InitializeComponent();
            lbl_RoomID.Text = RoomID;

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


    }
}
