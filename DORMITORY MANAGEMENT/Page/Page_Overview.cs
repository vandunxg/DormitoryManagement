﻿using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_Overview : UserControl
    {
        public Page_Overview()
        {
            InitializeComponent();

        }

        #region Method


        #endregion

        #region Events  
        

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            OverviewPage_Load(sender, e);
        }

        private void OverviewPage_Load(object sender, EventArgs e)
        {
            // card hiển thị thông tiền tiền điện

            string Months = DateTime.Now.Month.ToString();
            string Years = DateTime.Now.Year.ToString();

            DataTable GetData = DataProvider.Instance.ExcuteQuery("TotalUsageCost @ServiceID , @Months , @Years ", new object[] { "1", Months, Years });
            string ElectricMoney = "0đ";

            if (GetData.Rows.Count > 0)
            {
                ElectricMoney = GetData.Rows[0]["TotalUsageCost"].ToString();
            }

            cardShowInfo_Electricity.setAllValue($"Điện tháng {Months}", ElectricMoney);

            GetData = DataProvider.Instance.ExcuteQuery("TotalUsageCost @ServiceID , @Months , @Years ", new object[] { "2", Months, Years });
            string WaterMoney = "0đ";
            if (GetData.Rows.Count > 0)
            {
                WaterMoney = GetData.Rows[0]["TotalUsageCost"].ToString();
            }
            cardShowInfo_water.setAllValue($"Nước tháng {Months}", WaterMoney);

            GetData = DataProvider.Instance.ExcuteQuery("GetTotalMoney");
            string TotalMoney = "0đ";

            if (GetData.Rows.Count > 0)
            {
                TotalMoney = GetData.Rows[0]["TotalPaidAmount"].ToString();
            }

            cardShowInfor_total.setAllValue($"Đã thu", TotalMoney);

            int TotalRooms = int.Parse(DataProvider.Instance.ExcuteQuery("CountRooms").Rows[0]["AmountRoom"].ToString());
            int RoomsActive = int.Parse(DataProvider.Instance.ExcuteQuery("CountRoomsActive").Rows[0]["AmountRoom"].ToString());

            int TotalBill = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(BillID) AS NumofBills FROM StudentBills").Rows[0]["NumofBills"].ToString());
            int BillPaid = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT COUNT(BillID) AS NumofBills FROM StudentBills WHERE BillPaid = @BillPaid", new object[] { 1 }).Rows[0]["NumofBills"].ToString());

            cardShowOverview_totalRoom.setAllValue(TotalRooms, TotalRooms - RoomsActive, "Thông tin phòng", "Còn trống", "Đã đầy");
            cardShowOverview_payBill.setAllValue(TotalBill, BillPaid, "Sinh viên đã thanh toán tiền", "Chưa thanh toán", "Đã thanh toán");
        }

        private void cardShowInfo_Electricity_Load(object sender, EventArgs e)
        {

        }
        #endregion

    }
}
