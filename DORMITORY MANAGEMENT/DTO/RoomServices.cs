using System.Data;

namespace DORMITORY_MANAGEMENT.DTO
{
    public class RoomServices
    {
        //public RoomServices() { }

        private string serviceID;
        private string serviceElectricity;
        private string serviceWater;
        private string serviceTotal;
        private string serviceInternet;
        private string roomID;
        private string paid;
        private string serviceCleaning;

        public RoomServices()
        {
            this.ServiceID = "0";
            this.ServiceElectricity = "0";
            this.ServiceWater = "0";
            this.ServiceInternet = "0";
            this.ServiceTotal = "0";
            this.RoomID = "0";
            this.Paid = "0";
            this.ServiceCleaning = "0";
        }

        public RoomServices(DataRow row)
        {
            this.ServiceID = row["ServiceID"].ToString();
            this.ServiceElectricity = row["ServiceElectricity"].ToString();
            this.ServiceWater = row["ServiceWater"].ToString();
            this.ServiceInternet = row["ServiceInternet"].ToString();
            this.ServiceTotal = row["ServiceTotal"].ToString();
            this.RoomID = row["RoomID"].ToString();
            this.Paid = row["Paid"].ToString();
            this.ServiceCleaning = row["ServiceCleaning"].ToString();
        }

        public string ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceElectricity { get => serviceElectricity; set => serviceElectricity = value; }
        public string ServiceWater { get => serviceWater; set => serviceWater = value; }
        public string ServiceTotal { get => serviceTotal; set => serviceTotal = value; }
        public string ServiceInternet { get => serviceInternet; set => serviceInternet = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public string Paid { get => paid; set => paid = value; }
        public string ServiceCleaning { get => serviceCleaning; set => serviceCleaning = value; }
    }
}
