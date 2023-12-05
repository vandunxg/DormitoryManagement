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

        public Room(string ID, string number, string capacity, string type, string status) { 
            this.RoomID = ID;
            this.RoomCapacity = capacity;
            this.RoomType = type;
            this.RoomStatus = status;
            this.RoomNumber = number;

        }

        public Room(DataRow row)
        {
            this.RoomID = row["RoomID"].ToString();
            this.RoomCapacity = row["RoomCapacity"].ToString();
            this.RoomType = row["RoomType"].ToString();
            this.RoomNumber = row["RoomNumber"].ToString();
            this.RoomStatus = row["RoomStatus"].ToString();

        }

        private string roomID;
        private string roomNumber;
        private string roomCapacity;
        private string roomType;
        private string roomStatus;

        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomCapacity { get => roomCapacity; set => roomCapacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
    }
}
