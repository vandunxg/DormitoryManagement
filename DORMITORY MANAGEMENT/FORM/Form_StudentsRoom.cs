using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

/*
    Author : @vandunxg
    Github : @vandunxg
    Blog : vandunxg.vercel.app
    Leetcode : @vandunxg
    Facebook : @vandunxg
*/

/* Copyright (C) 2024 Nguyen Van Dung - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the MIT license, which unfortunately won't be
 * written for another century.
 *
 * You should have received a copy of the MIT license with
 * this file. If not, please write to: vandunxg.dev@gmail.com, or visit : vandunxg.vercel.app
 */


namespace DORMITORY_MANAGEMENT
{
    public partial class Form_StudentsRoom : Form
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

        public Form_StudentsRoom()
        {
            InitializeComponent();
        }

        private string RoomID;

        public Form_StudentsRoom(string RoomID)
        {
            InitializeComponent();
            lbl_RoomID.Text = RoomID;
            this.RoomID = RoomID;

            string query = "GetStudentsinRoom @RoomID";
            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { RoomID });
            dgv_Students.DataSource = data;

            List<UsageServices> usageServices = UsageServicesDAO.Instance.LoadUsageServicesList(RoomID);

            int TotalMoney = 0;

            foreach (UsageServices usage in usageServices)
            {
                if (usage.ID == "1")
                {
                    cardShowInfo_Electricity.setAllValue(usage.ServiceName, usage.TotalMoney.ToString());

                }
                else if (usage.ID == "2")
                {
                    cardShowInfo_Water.setAllValue(usage.ServiceName, usage.TotalMoney.ToString());

                }

                TotalMoney += usage.TotalMoney;
            }

            cardShowInfo_Total.setAllValue("Tổng thanh toán", TotalMoney.ToString());


        }

        #region Events

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        #endregion

        private void RoomStudentManager_Load(object sender, EventArgs e)
        {
            string Months = DateTime.Now.Month.ToString();
            string Years = DateTime.Now.Year.ToString();



            DataTable RoomBills = DataProvider.Instance.ExcuteQuery("SELECT * FROM Bills WHERE RoomID = @RoomID ", new object[] { RoomID });
            if (RoomBills.Rows.Count > 0)
            {

            }

            DataTable DataUsageServices = DataProvider.Instance.ExcuteQuery("GetInforUsageServices @RoomID , @Months , @Years", new object[] { RoomID, Months, Years });
            dgv_UsageService.DataSource = DataUsageServices;
        }

        private void btn_UpdateServiceState_Click(object sender, EventArgs e)
        {

        }


    }
}
