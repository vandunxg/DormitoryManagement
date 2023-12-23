using DORMITORY_MANAGEMENT.DAO;
using DORMITORY_MANAGEMENT.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

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

            #region Get Areas from Sql
            DataTable dataAreas = DataProvider.Instance.ExcuteQuery("GetAreas");
            cmb_RoomArea.DisplayMember = "AreaName";
            cmb_RoomArea.ValueMember = "AreaID";
            cmb_RoomArea.DataSource = dataAreas;
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomArea.Text = "Khu";
            #endregion

            #region Get RoomTypes from Sql
            DataTable dataRoomTypes = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = dataRoomTypes;
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            #endregion
        }

        private void btn_deleteInput_Click(object sender, EventArgs e)
        {
            cmb_RoomStatus.SelectedIndex = -1;
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomArea.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            cmb_RoomArea.Text = "Khu";
            cmb_RoomStatus.Text = "Trạng thái";
            txt_inputRoomID.Clear();
            ManageRoomControl_Load(sender, e);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            List<Room> originalList = RoomDAO.Instance.LoadRoomList();
            List<Room> filteredList = new List<Room>(originalList);

            if (cmb_RoomStatus.SelectedIndex != -1)
            {
                if (cmb_RoomStatus.SelectedIndex == 0)
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
                    if (room.RoomArea != cmb_RoomArea.SelectedValue.ToString())
                    {
                        filteredList.Remove(room);
                    }
                }
            }

            if (cmb_RoomTypes.SelectedIndex != -1)
            {
                foreach (Room room in originalList)
                {
                    if (room.RoomType != cmb_RoomTypes.SelectedValue.ToString())
                    {
                        filteredList.Remove(room);
                    }
                }
            }

            if (!string.IsNullOrEmpty(txt_inputRoomID.Text))
            {

                if (txt_inputRoomID.Text.Length > 20)
                {
                    MessageBox.Show("Mã phòng quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

        private void txt_inputRoomID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }
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


    }
}
