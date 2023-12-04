using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class ManageRoomControl : UserControl
    {
        public ManageRoomControl()
        {
            InitializeComponent();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            cmb_typeOfRoom.SelectedIndex = -1;
            cmb_stateRoom.SelectedIndex = -1;
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        public void loadTable()
        {
            for (int i = 0; i < 10; i++)
            {
                CardRoom newCardRoom = new CardRoom(); // Tạo một thể hiện mới của cardRooms
                newCardRoom.setAllValue("P10" + i.ToString(), 100, 100 - i * 10);
                
                flowLayoutPanel2.Controls.Add(newCardRoom); // Thêm thể hiện mới vào flowLayoutPanel2
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            addNewRoom addNewRoom = new addNewRoom();
            addNewRoom.ShowDialog();
        }

        private void ManageRoomControl_Load(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
