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
            RoomStudentManager roomStudentManager = new RoomStudentManager();
            roomStudentManager.ShowDialog();
        }



        #endregion

        
    }
}
