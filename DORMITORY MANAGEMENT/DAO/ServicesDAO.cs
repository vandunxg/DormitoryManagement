using DORMITORY_MANAGEMENT.DTO;
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
