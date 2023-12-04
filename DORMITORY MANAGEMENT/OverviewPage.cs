using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class OverviewPage : UserControl
    {
        public OverviewPage()
        {
            InitializeComponent();
            
        }


        #region Method

        private void OverviewPage_Load(object sender, EventArgs e)
        {
            // card hiển thị thông tiền tiền điện
            cardShowInfo_Electricity.TextLabel = "Tiền điện";
            

            // card hiển thị thông tin tiền nước
            cardShowInfo_water.TextLabel = "Tiền nước";

            // card hiển thị tổng tiền đã thu
            cardShowInfor_total.TextLabel = "Tiền thu về";
            cardShowInfor_total.Money = 100000;



            cardShowOverview_totalRoom.setAllValue(100, 70, "Thông tin phòng", "Còn trống", "Đã đầy");
            cardShowOverview_payBill.setAllValue(100, 80, "Phòng đã thanh toán tiền", "Chưa thanh toán", "Đã thanh toán");
        }

        private void cardShowInfo_Electricity_Load(object sender, EventArgs e)
        {
            
        }


        #endregion


        #region Events  
        private void cardShowOverview_totalRoom_Load(object sender, EventArgs e)
        {


        }

        private void cardShowOverview_payBill_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void cardShowOverview_totalRoom_Load_1(object sender, EventArgs e)
        {

        }
    }
}
