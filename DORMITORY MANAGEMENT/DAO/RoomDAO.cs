﻿using DORMITORY_MANAGEMENT.DTO;
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
        #region Declaration 

        private static RoomDAO instance;

        private RoomDAO() { }

        public static RoomDAO Instance
        {
            get { if (instance == null) instance = new RoomDAO(); return RoomDAO.instance; }
            private set { instance = value; }

        }

        #endregion

        #region Method 

        public bool checkLength(string checkString)
        {
            if (checkString.Length > 10)
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

        public List<Room> LoadRoomList()
        {
            List<Room> list = new List<Room>();

            string query = "SELECT Rooms.RoomID , RoomCapacity , RoomType , RoomArea , RoomNumber , RoomStatus , COUNT(Students.StudentID) AS StudentCount FROM Rooms LEFT JOIN Students ON Rooms.RoomID = Students.RoomID GROUP BY Rooms.RoomID , RoomCapacity , RoomType , RoomArea , RoomNumber , RoomStatus ;";

            

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow row in data.Rows)
            {
                Room room = new Room(row);
                list.Add(room);
            }

            return list;

        }

        #endregion

    }
}
