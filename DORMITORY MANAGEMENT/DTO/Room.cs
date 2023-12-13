using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
