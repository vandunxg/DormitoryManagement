using DORMITORY_MANAGEMENT.DTO;
using System.Collections.Generic;
using System.Data;

namespace DORMITORY_MANAGEMENT.DAO
{
    public class UsageServicesDAO
    {
        #region Declaration 

        private static UsageServicesDAO instance;

        private UsageServicesDAO() { }

        public static UsageServicesDAO Instance
        {
            get { if (instance == null) instance = new UsageServicesDAO(); return UsageServicesDAO.instance; }
            private set { instance = value; }

        }

        #endregion

        public List<UsageServices> LoadUsageServicesList(string RoomID)
        {
            List<UsageServices> list = new List<UsageServices>();

            DataTable data = DataProvider.Instance.ExcuteQuery("GetUsageService @RoomID", new object[] { RoomID });

            foreach (DataRow row in data.Rows)
            {
                UsageServices usageServices = new UsageServices(row);
                list.Add(usageServices);
            }

            return list;

        }
    }
}
