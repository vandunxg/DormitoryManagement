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
