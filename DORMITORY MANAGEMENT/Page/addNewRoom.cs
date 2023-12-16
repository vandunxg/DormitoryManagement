using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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
        private void cmb_inputRoomArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_inputRoomNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_addRoom_Click(object sender, EventArgs e)
        {
            if (cmb_RoomAreas.SelectedIndex != -1 && txt_RoomName.Text != "" && cmb_RoomTypes.SelectedIndex > -1 && cmb_RoomStatus.SelectedIndex != -1)
            {
                //string RoomID = this.txt_RoomID.Text.ToString();
                string RoomName = txt_RoomName.Text.ToString().Trim();
                string RoomStatus = cmb_RoomStatus.SelectedItem.ToString();
                string RoomType = cmb_RoomTypes.SelectedValue.ToString();
                string RoomArea = cmb_RoomAreas.SelectedValue.ToString();



                if (RoomDAO.Instance.checkLength(RoomName) == false)
                {
                    MessageBox.Show("Tên phòng chỉ dài tối đa 20 kí tự", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



                if (DataProvider.Instance.ExcuteQuery("SELECT * FROM dbo.Rooms WHERE RoomName = @RoomName AND AreaID = @AreaID ", new object[] { RoomName, RoomArea }).Rows.Count > 0)
                {
                    MessageBox.Show("Tên phòng đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = "InsertRoomsData  @RoomName , @RoomStatus , @AreaID , @RoomTypeID ;";
                DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { RoomName, RoomStatus, RoomArea, RoomType });

                // Thông báo dữ liệu được thêm thành công
                if (data.Rows.Count > -1)
                {
                    MessageBox.Show("Đã thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void addNewRoom_Load(object sender, EventArgs e)
        {

            DataSet data = DataProvider.Instance.ExcuteQueryDataSet("GetAddRooms");
            dgv_Rooms.DataSource = data.Tables[0];


            #region Get Areas from Sql
            DataTable dataAreas = DataProvider.Instance.ExcuteQuery("GetAreas");
            cmb_RoomAreas.DisplayMember = "AreaName";
            cmb_RoomAreas.ValueMember = "AreaID";
            cmb_RoomAreas.DataSource = dataAreas;
            cmb_RoomAreas.SelectedIndex = -1;
            cmb_RoomAreas.Text = "Khu";
            #endregion

            #region Get RoomTypes from Sql
            DataTable dataRoomTypes = DataProvider.Instance.ExcuteQuery("GetRoomTypes");
            cmb_RoomTypes.DisplayMember = "RoomTypeName";
            cmb_RoomTypes.ValueMember = "RoomTypeID";
            cmb_RoomTypes.DataSource = dataRoomTypes;
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            #endregion

            btn_addRoom.Enabled = true;
            btn_deleteRoom.Enabled = false;
            btn_editRoom.Enabled = false;
            cmb_RoomAreas.Enabled = true;
            cmb_RoomStatus.Enabled = true;
            cmb_RoomTypes.Enabled = true;
            txt_RoomName.Enabled = true;
            clearInputData();

        }

        private void btn_exit_Click_1(object sender, EventArgs e)
        {
            if (cmb_RoomAreas.SelectedIndex != -1 && txt_RoomName.Text != "" && cmb_RoomTypes.SelectedIndex > -1 && cmb_RoomStatus.SelectedIndex != -1)
            {
                DialogResult = MessageBox.Show("Bạn có chắc chắn muốn đóng cửa sổ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.OK)
                {
                    this.Close();
                }
            }
            else
                this.Close();

        }

        private void btn_editRoom_Click(object sender, EventArgs e)
        {


            if (cmb_RoomStatus.SelectedIndex != -1 && cmb_RoomTypes.SelectedIndex != -1)
            {
                string RoomID = txt_RoomID.Text;
                string RoomStatus = cmb_RoomStatus.SelectedItem.ToString();
                string RoomType = cmb_RoomTypes.SelectedValue.ToString();


                DialogResult resultNotify = MessageBox.Show("Bạn có chắc chắn muốn sửa dữ liệu này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (resultNotify == DialogResult.Yes)
                {
                    string query = "UpdateRoomsData @RoomID , @RoomStatus , @RoomTypeID ";
                    DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { RoomID, RoomStatus, RoomType });

                    // Thông báo dữ liệu được thêm thành công
                    if (data.Rows.Count > -1)
                    {
                        MessageBox.Show("Đã sửa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reload lại dữ liệu trong bảng
                        addNewRoom_Load(sender, e);

                    }

                }
            }
            else
            {
                MessageBox.Show("Trường dữ liệu bị thiếu, vui lòng điền đủ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgv_Rooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_deleteRoom.Enabled = true;
            btn_editRoom.Enabled = true;
            txt_RoomName.Enabled = false;
            cmb_RoomAreas.Enabled = false;
            btn_addRoom.Enabled = false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Rooms.Rows.Count && e.ColumnIndex < dgv_Rooms.Columns.Count)
            {
                txt_RoomID.Text = dgv_Rooms.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_RoomName.Text = dgv_Rooms.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmb_RoomStatus.SelectedIndex = cmb_RoomStatus.FindString(dgv_Rooms.Rows[e.RowIndex].Cells[2].Value.ToString());
                cmb_RoomTypes.SelectedIndex = cmb_RoomTypes.FindString(dgv_Rooms.Rows[e.RowIndex].Cells[3].Value.ToString());
                cmb_RoomAreas.SelectedIndex = cmb_RoomAreas.FindString(dgv_Rooms.Rows[e.RowIndex].Cells[4].Value.ToString());
            }


        }

        private void btn_deleteRoom_Click(object sender, EventArgs e)
        {
            // Khai báo chỉ số index của dòng được chọn và lấy ra chuỗi Mã sinh viên
            int index = dgv_Rooms.SelectedRows[0].Index;
            string txt_RoomID = dgv_Rooms.Rows[index].Cells[0].Value.ToString();


            string queryCount = "SELECT * FROM Contracts WHERE RoomID = @txt_RoomID";
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
            txt_RoomID.Clear();
            txt_RoomName.Clear();
            cmb_RoomTypes.SelectedIndex = -1;
            cmb_RoomTypes.Text = "Loại phòng";
            cmb_RoomStatus.SelectedIndex = -1;
            cmb_RoomStatus.Text = "Tình trạng";
            cmb_RoomAreas.SelectedIndex = -1;
            cmb_RoomAreas.Text = "Khu";
        }


        #endregion

        
    }
}
