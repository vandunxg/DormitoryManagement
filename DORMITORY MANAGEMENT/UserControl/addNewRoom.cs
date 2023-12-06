using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace DORMITORY_MANAGEMENT
{
    public partial class addNewRoom : Form
    {
        public addNewRoom()
        {
            InitializeComponent();
        }

        #region mouse move
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void bunifuPanel1_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }
        #endregion


        #region Events

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            if (txt_inputRoomID.Text != "" && txt_inputRoomNumber.Text != "" && cmb_RoomCapacity.SelectedIndex > -1 && cmb_inputRoomType.SelectedIndex > -1
               && cmb_RoomStatus.SelectedIndex != -1)
            {
                string txt_RoomID = txt_inputRoomID.Text.ToString();
                string txt_RoomNumber = txt_inputRoomNumber.Text.ToString();
                int RoomCapacity = int.Parse(cmb_RoomCapacity.SelectedItem.ToString());
                string RoomStatus = cmb_RoomStatus.SelectedItem.ToString();
                string RoomType = cmb_inputRoomType.SelectedItem.ToString();

                if (RoomDAO.Instance.checkLength(txt_RoomID) == false)
                {
                    MessageBox.Show("Mã phòng chỉ dài 10 kí tự!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomDAO.Instance.checkLength(txt_RoomNumber) == false)
                {
                    MessageBox.Show("Số phòng chỉ dài tối đa 10 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomDAO.Instance.checkRepeatInformation(txt_RoomID, "SELECT * FROM dbo.Rooms WHERE RoomID = @txt_RoomID") == true)
                {
                    MessageBox.Show("Mã Phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (RoomDAO.Instance.checkRepeatInformation(txt_RoomNumber, "SELECT * FROM dbo.Rooms WHERE RoomNumber = @txt_RoomNumber") == true)
                {
                    MessageBox.Show("Số phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string query = "INSERT INTO Rooms (RoomID , RoomNumber , RoomType , RoomCapacity , RoomStatus) VALUES ( @txt_RoomID , @txt_RoomNumber , @RoomType  , @RoomCapacity , @RoomStatus );";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_RoomID, txt_RoomNumber, RoomType, RoomCapacity, RoomStatus });

                // Thông báo dữ liệu được thêm thành công
                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reload lại dữ liệu trong bảng
                addNewRoom_Load(sender, e);
                ManageRoomControl newManageRoomControl = new ManageRoomControl();
                
                // Xoá các trường dữ liệu sau khi thêm thành công
                clearInputData();
            }
            else
            {
                MessageBox.Show("Trường dữ liệu bị thiếu, vui lòng điền đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addNewRoom_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Rooms";
            DataSet data = DataProvider.Instance.ExcuteQueryDataSet(query);
            dgv_Rooms.DataSource = data.Tables[0];


        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.OK)
            {
                this.Close();
            }

            
        }

        private void btn_editRoom_Click(object sender, EventArgs e)
        {
            if (txt_inputRoomID.Text != "" && txt_inputRoomNumber.Text != "" && cmb_RoomCapacity.SelectedIndex > -1 && cmb_inputRoomType.SelectedIndex > -1
               && cmb_RoomStatus.SelectedIndex != -1)
            {
                string txt_RoomID = txt_inputRoomID.Text.ToString();
                string txt_RoomNumber = txt_inputRoomNumber.Text.ToString();
                int RoomCapacity = int.Parse(cmb_RoomCapacity.SelectedItem.ToString());
                string RoomStatus = cmb_RoomStatus.SelectedItem.ToString();
                string RoomType = cmb_inputRoomType.SelectedItem.ToString();

                
                string query = "UPDATE Rooms SET RoomNumber = @txt_RoomNumber , RoomType = @RoomType , RoomCapacity = @RoomCapacity , RoomStatus = @RoomStatus WHERE RoomID = @txt_RoomID ;";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_RoomNumber, RoomType, RoomCapacity, RoomStatus, txt_RoomID });

                // Thông báo dữ liệu được thêm thành công
                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Reload lại dữ liệu trong bảng
                addNewRoom_Load(sender, e);

                // Xoá các trường dữ liệu sau khi thêm thành công
                clearInputData();
            }
            else
            {
                MessageBox.Show("Trường dữ liệu bị thiếu, vui lòng điền đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Rooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_deleteRoom.Enabled = true;
            btn_editRoom.Enabled = true;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Rooms.Rows.Count && e.ColumnIndex < dgv_Rooms.Columns.Count)
            {
                txt_inputRoomID.Text = dgv_Rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                
                txt_inputRoomNumber.Text = dgv_Rooms.Rows[e.RowIndex].Cells[1].Value.ToString();

                string valueSelected = "";

                valueSelected = dgv_Rooms.Rows[e.RowIndex].Cells[2].Value.ToString();
                cmb_inputRoomType.SelectedIndex = cmb_inputRoomType.FindString(valueSelected);

                valueSelected = dgv_Rooms.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmb_RoomCapacity.SelectedIndex = cmb_RoomCapacity.FindString(valueSelected);

                valueSelected = dgv_Rooms.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmb_RoomStatus.SelectedIndex = cmb_RoomStatus.FindString(valueSelected);
            }


        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            // Khai báo chỉ số index của dòng được chọn và lấy ra chuỗi Mã sinh viên
            int index = dgv_Rooms.SelectedRows[0].Index;
            string txt_RoomID = dgv_Rooms.Rows[index].Cells[0].Value.ToString();


            string queryCount = "SELECT * FROM Students WHERE RoomID = @txt_RoomID";
            DataTable numberOfStudents = DataProvider.Instance.ExcuteQuery(queryCount, new object[] { txt_RoomID });

            if (numberOfStudents.Rows.Count > 0)
            {
                MessageBox.Show("Phòng đang có sinh viên, không thể xoá?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn xoá phòng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultNotify == DialogResult.Yes)
            {
                // TRuy vấn xoá data trong CSDL
                string query = "DELETE FROM Rooms WHERE RoomID = @txt_RoomID";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txt_RoomID });

                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Xoá các trường dữ liệu sau khi thêm thành công
                    clearInputData();
                }

            }

            // Load lại data trong bảng
            addNewRoom_Load(sender, e);
        }
        #endregion


        #region Method

        // Clear data sau khi thêm sửa xoá
        private void clearInputData()
        {
            txt_inputRoomID.Clear();
            txt_inputRoomNumber.Clear();
            cmb_inputRoomType.SelectedIndex = -1;
            cmb_RoomCapacity.SelectedIndex = -1;
            cmb_RoomStatus.SelectedIndex = -1;
        }





        #endregion

        
    }
}
