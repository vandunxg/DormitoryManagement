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
            if(cmb_stateRoom.SelectedIndex == -1 && cmb_typeOfRoom.SelectedIndex == -1 && txt_inputRoomID.Text.ToString() == "")
            {
                ManageRoomControl_Load(sender, e);
            }
            else if(txt_inputRoomID.Text.ToString() != "")
            {
                flowLayoutRoom.Controls.Clear();
                List<Room> list = RoomDAO.Instance.LoadRoomList();

                foreach (Room room in list)
                {
                    if(room.RoomID == txt_inputRoomID.Text.ToString())
                    {
                        CardRoom cardRoom = new CardRoom();
                        cardRoom.Click += cardRoom_Click;
                        cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                        flowLayoutRoom.Controls.Add(cardRoom);
                    }
                }
            }
            else if(cmb_stateRoom.SelectedIndex != -1 && cmb_RoomArea.SelectedIndex == -1 && cmb_typeOfRoom.SelectedIndex == -1 && txt_inputRoomID.Text.ToString() == "")
            {
                flowLayoutRoom.Controls.Clear();
                List<Room> list = RoomDAO.Instance.LoadRoomList();

                if (cmb_stateRoom.SelectedIndex == 0)
                {

                    flowLayoutRoom.Controls.Clear();
                    foreach (Room room in list)
                    {
                        if (int.Parse(room.RoomStudents) < int.Parse(room.RoomCapacity))
                        {
                            CardRoom cardRoom = new CardRoom();
                            cardRoom.Click += cardRoom_Click;
                            cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                            flowLayoutRoom.Controls.Add(cardRoom);
                        }
                    }
                }
                else
                {
                    flowLayoutRoom.Controls.Clear();
                    foreach (Room room in list)
                    {
                        if (int.Parse(room.RoomStudents) == int.Parse(room.RoomCapacity))
                        {
                            CardRoom cardRoom = new CardRoom();
                            cardRoom.Click += cardRoom_Click;
                            cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                            flowLayoutRoom.Controls.Add(cardRoom);
                        }
                    }
                }
            }
            else if(cmb_stateRoom.SelectedIndex == -1 && cmb_RoomArea.SelectedIndex == -1 && cmb_typeOfRoom.SelectedIndex != -1 && txt_inputRoomID.Text.ToString() == "")
            {
                flowLayoutRoom.Controls.Clear();
                List<Room> list = RoomDAO.Instance.LoadRoomList();
                foreach (Room room in list)
                {
                    if (room.RoomType == cmb_typeOfRoom.SelectedItem.ToString())
                    {
                        CardRoom cardRoom = new CardRoom();
                        cardRoom.Click += cardRoom_Click;
                        cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                        flowLayoutRoom.Controls.Add(cardRoom);
                    }
                }
            }
            else if(cmb_stateRoom.SelectedIndex == -1 && cmb_RoomArea.SelectedIndex != -1 && cmb_typeOfRoom.SelectedIndex == -1 && txt_inputRoomID.Text.ToString() == "")
            {
                flowLayoutRoom.Controls.Clear();
                List<Room> list = RoomDAO.Instance.LoadRoomList();
                foreach (Room room in list)
                {
                    if (room.RoomArea == cmb_RoomArea.SelectedItem.ToString())
                    {
                        CardRoom cardRoom = new CardRoom();
                        cardRoom.Click += cardRoom_Click;
                        cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), int.Parse(room.RoomStudents), room.RoomType);
                        flowLayoutRoom.Controls.Add(cardRoom);
                    }
                }

            }
        
        }
    }
}
