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
        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            cmb_typeOfRoom.SelectedIndex = -1;
            cmb_stateRoom.SelectedIndex = -1;
        }

        

        private void bunifuButton1_Click(object sender, EventArgs e)
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
                cardRoom.setAllValue(room.RoomID, int.Parse(room.RoomCapacity), 10);
                flowLayoutRoom.Controls.Add(cardRoom);
            }
        }

        #endregion

        private void flowLayoutRoom_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
