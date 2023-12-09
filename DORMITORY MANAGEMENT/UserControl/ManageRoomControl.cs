using System;
using System.Windows.Forms;
using DORMITORY_MANAGEMENT.DTO;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DORMITORY_MANAGEMENT.DAO;

namespace DORMITORY_MANAGEMENT
{
    public partial class ManageRoomControl : UserControl
    {
        public ManageRoomControl()
        {
            InitializeComponent();

            
        }
        #region Events

        private void btn_refreshRoom_Click(object sender, EventArgs e)
        {
            ManageRoomControl_Load(sender, e);
        }

        private void btn_manageRoom_Click(object sender, EventArgs e)
        {
            addNewRoom addNewRoom = new addNewRoom();
            addNewRoom.ShowDialog();
        }

        public void ManageRoomControl_Load(object sender, EventArgs e)
        {
            flowLayoutRoom.Controls.Clear();
            loadTable();
        }
        #endregion

        #region Method

        public void loadTable()
        {

            List<Room> list = RoomDAO.Instance.LoadRoomList();

            foreach (Room room in list)
            {
                CardRoom cardRoom = new CardRoom();
                cardRoom.Click += cardRoom_Click;
                cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                flowLayoutRoom.Controls.Add(cardRoom);
            }
        }


        public void cardRoom_Click(object sender, EventArgs e)
        {
            CardRoom cardRoom = (CardRoom)sender;
            string txt_RoomID = cardRoom.RoomID;
            
            RoomStudentManager roomStudentManager = new RoomStudentManager(txt_RoomID);
            roomStudentManager.ShowDialog();
        }






        #endregion

        private void btn_deleteInput_Click(object sender, EventArgs e)
        {
            cmb_stateRoom.SelectedIndex = -1;
            cmb_typeOfRoom.SelectedIndex = -1;
            cmb_RoomArea.SelectedIndex = -1;
            txt_inputRoomID.Clear();
            ManageRoomControl_Load(sender, e);
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Room> originalList = RoomDAO.Instance.LoadRoomList();
            List<Room> filteredList = new List<Room>(originalList);

            if (cmb_stateRoom.SelectedIndex != -1)
            {
                if(cmb_stateRoom.SelectedIndex == 0)
                {
                    foreach (Room room in originalList)
                    {
                        if (int.Parse(room.RoomCapacity) == int.Parse(room.RoomStudents))
                        {
                            filteredList.Remove(room);
                        }
                    }
                }
                else
                {
                    foreach (Room room in originalList)
                    {
                        if (int.Parse(room.RoomCapacity) != int.Parse(room.RoomStudents))
                        {
                            filteredList.Remove(room);
                        }
                    }
                }
            }

            if (cmb_RoomArea.SelectedIndex != -1)
            {
                foreach (Room room in originalList)
                {
                    if (room.RoomArea != cmb_RoomArea.SelectedItem.ToString())
                    {
                        filteredList.Remove(room);
                    }
                }
            }

            if (cmb_typeOfRoom.SelectedIndex != -1)
            {
                foreach (Room room in originalList)
                {
                    if (room.RoomType != cmb_typeOfRoom.SelectedItem.ToString())
                    {
                        filteredList.Remove(room);
                    }
                }
            }

            if (!string.IsNullOrEmpty(txt_inputRoomID.Text))
            {
                foreach (Room room in originalList)
                {
                    if (room.RoomID != txt_inputRoomID.Text)
                    {
                        filteredList.Remove(room);
                    }
                }
            }

            flowLayoutRoom.Controls.Clear();

            foreach (Room room in filteredList)
            {
                CardRoom cardRoom = new CardRoom();
                cardRoom.Click += cardRoom_Click;
                cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                flowLayoutRoom.Controls.Add(cardRoom);
            }
        }


    }
}
