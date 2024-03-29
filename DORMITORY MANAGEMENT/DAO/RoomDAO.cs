﻿using DORMITORY_MANAGEMENT.DTO;
using System.Collections.Generic;
using System.Data;

/*
    Author : @vandunxg
    Github : @vandunxg
    Blog : vandunxg.vercel.app
    Leetcode : @vandunxg
    Facebook : @vandunxg
*/

/* Copyright (C) 2024 Nguyen Van Dung - All Rights Reserved
 * You may use, distribute and modify this code under the
 * terms of the MIT license, which unfortunately won't be
 * written for another century.
 *
 * You should have received a copy of the MIT license with
 * this file. If not, please write to: vandunxg.dev@gmail.com, or visit : vandunxg.vercel.app
 */


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
            if (checkString.Length > 20)
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

            DataTable data = DataProvider.Instance.ExcuteQuery("GetRooms");

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
