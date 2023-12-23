using System.Data;

namespace DORMITORY_MANAGEMENT.DTO
{
    public class UsageServices
    {
        public UsageServices() { }

        public UsageServices(DataRow row)
        {
            this.ServiceName = row["ServiceName"].ToString();
            this.ServiceQuantity = int.Parse(row["UsageQuantity"].ToString());
            this.ServicePrice = int.Parse(row["ServicePrice"].ToString());
            this.TotalMoney = ServiceQuantity * ServicePrice;
            this.ID = row["ServiceID"].ToString();
        }

        private string serviceName;
        private int serviceQuantity;
        private int servicePrice;
        private int totalMoney;
        private string iD;

        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServiceQuantity { get => serviceQuantity; set => serviceQuantity = value; }
        public int ServicePrice { get => servicePrice; set => servicePrice = value; }
        public int TotalMoney { get => totalMoney; set => totalMoney = value; }
        public string ID { get => iD; set => iD = value; }
    }

}
