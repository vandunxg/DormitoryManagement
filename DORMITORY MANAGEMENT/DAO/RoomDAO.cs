using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DORMITORY_MANAGEMENT.DAO
{
    public class RoomDAO
    {
        private static RoomDAO instance;

        //private string connectionString = @"Data Source=VANDUNXG;Initial Catalog=DormitoryManagement;Integrated Security=True";

        private RoomDAO() { }

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { instance = value; }

        }

        public bool checkLength(string checkString)
        {
            if(checkString.Length > 10)
                return false;
            return true;
        }

        public bool checkRepeatInformation(string textNeedCheck, string query)
        {

            DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { textNeedCheck });

            if (data.Rows.Count == 1)
                return true;

            return false;
        }
    }
}
