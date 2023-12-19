using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ManageServiceControl : UserControl
    {
        public ManageServiceControl()
        {
            InitializeComponent();
        }

        #region Events

        public void cardService_Click(object sender, EventArgs e)
        {
            ShowServices cardService = (ShowServices)sender;

            ShowServicesDetail showServicesDetail = new ShowServicesDetail(cardService.ServiceName, cardService.ServicePrice, cardService.ServiceID, cardService.ServiceUnit);
            showServicesDetail.ShowDialog();
        }

        private void ManageServiceControl_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadTable();
        }

        private void btn_AddNewServices_Click(object sender, EventArgs e)
        {
            NewServices newServices = new NewServices();
            newServices.ShowDialog();
        }

        private void btn_refreshRoom_Click(object sender, EventArgs e)
        {
            ManageServiceControl_Load(sender, e);
        }

        #endregion

        #region Methods

        public void loadTable()
        {

            List<ServicesDTO> list = ServicesDAO.Instance.LoadRoomList();

            foreach (ServicesDTO DataServices in list)
            {
                ShowServices cardService = new ShowServices(DataServices.ServiceName, DataServices.ServiceID, DataServices.ServicePrice, DataServices.ServiceUnit);
                cardService.Click += cardService_Click;
                

                flowLayoutPanel.Controls.Add(cardService);
            }
        }

        #endregion

        
    }

}
