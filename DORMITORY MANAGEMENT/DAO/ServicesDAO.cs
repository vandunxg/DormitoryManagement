using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DORMITORY_MANAGEMENT.DAO
{
    public class ServicesDAO
    {
        #region Declaration 

        private static ServicesDAO instance;

        private ServicesDAO() { }

        public static ServicesDAO Instance
        {
            get { if (instance == null) instance = new ServicesDAO(); return ServicesDAO.instance; }
            private set { instance = value; }

        }

        #endregion

        public List<ServicesDTO> LoadRoomList()
        {
            List<ServicesDTO> list = new List<ServicesDTO>();

            DataTable data = DataProvider.Instance.ExcuteQuery("SELECT * FROM Services");

            foreach (DataRow row in data.Rows)
            {
                ServicesDTO DataService = new ServicesDTO(row);
                list.Add(DataService);
            }

            return list;

        }
    }
}
