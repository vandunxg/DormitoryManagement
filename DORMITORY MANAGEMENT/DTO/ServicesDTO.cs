using System.Data;

namespace DORMITORY_MANAGEMENT.DTO
{
    public class ServicesDTO
    {
        private int serviceID;
        private string serviceName;
        private int servicePrice;
        private string serviceUnit;

        public int ServiceID { get => serviceID; set => serviceID = value; }
        public string ServiceName { get => serviceName; set => serviceName = value; }
        public int ServicePrice { get => servicePrice; set => servicePrice = value; }
        public string ServiceUnit { get => serviceUnit; set => serviceUnit = value; }

        public ServicesDTO()
        {

        }

        public ServicesDTO(DataRow row)
        {
            ServiceID = int.Parse(row["ServiceID"].ToString());
            ServiceName = row["ServiceName"].ToString();
            ServicePrice = int.Parse(row["ServicePrice"].ToString());
            ServiceUnit = row["ServiceUnit"].ToString();
        }
    }
}
