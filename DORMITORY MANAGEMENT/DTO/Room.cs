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

        public Room(string ID, string number, string capacity, string type, string area, string status, string roomStudents) { 
            this.RoomID = ID;
            this.RoomCapacity = capacity;
            this.RoomType = type;
            this.roomArea = area;
            this.RoomStatus = status;
            this.RoomNumber = number;
            this.RoomStudents = roomStudents;
            
        }

        public Room(DataRow row)
        {
            this.RoomID = row["RoomID"].ToString();
            this.RoomCapacity = row["RoomCapacity"].ToString();
            this.RoomType = row["RoomType"].ToString();
            this.RoomArea = row["RoomArea"].ToString();
            this.RoomNumber = row["RoomNumber"].ToString();
            this.RoomStatus = row["RoomStatus"].ToString();
            this.RoomStudents = row["StudentCount"].ToString();
        }

        private string roomID;
        private string roomNumber;
        private string roomCapacity;
        private string roomType;
        private string roomStatus;
        private string roomStudents;
        private string roomArea;


        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public string RoomCapacity { get => roomCapacity; set => roomCapacity = value; }
        public string RoomType { get => roomType; set => roomType = value; }
        public string RoomStatus { get => roomStatus; set => roomStatus = value; }
        public string RoomStudents { get => roomStudents; set => roomStudents = value; }
        public string RoomArea { get => roomArea; set => roomArea = value; }
    }
}
