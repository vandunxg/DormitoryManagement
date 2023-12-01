using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            cmb_floorOfRoom.SelectedIndex = -1;
            cmb_stateRoom.SelectedIndex = -1;
        }
    }
}
