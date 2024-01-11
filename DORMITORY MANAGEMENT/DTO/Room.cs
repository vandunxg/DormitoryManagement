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
    public class Room
    {
        public Room() { }


        public Room(DataRow row)
        {
            this.RoomID = row["RoomID"].ToString();
            this.RoomType = row["RoomName"].ToString();
            this.RoomStatus = row["RoomStatus"].ToString();
            this.RoomArea = row["AreaID"].ToString();
            this.RoomType = row["RoomTypeID"].ToString();
            this.RoomCapacity = row["RoomCapacity"].ToString();
            this.RoomStudents = row["NumberOfContracts"].ToString();
        }

        private string roomID;
        private string roomName;
        private string roomCapacity;
        private string roomType;
        private string roomStatus;
        private string roomStudents;
        private string roomArea;


        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public string RoomCapacity { get => roomCapacity; set => roomCapacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public string RoomStudents { get => roomStudents; set => roomStudents = value; }
        public string RoomArea { get => roomArea; set => roomArea = value; }
    }
}
