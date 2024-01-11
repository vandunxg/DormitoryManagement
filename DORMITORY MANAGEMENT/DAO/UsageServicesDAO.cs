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
