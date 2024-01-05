using DORMITORY_MANAGEMENT.DAO;
using System;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class Page_BillManagement : UserControl
    {
        public Page_BillManagement()
        {
            InitializeComponent();
        }

        #region Events

        private void Bills_Load(object sender, EventArgs e)
        {
            dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("GetBills");

            cmb_BillState.SelectedIndex = -1;
            cmb_BillState.Text = "Tình trạng";

            txt_RoomID.Text = string.Empty;
        }

        private void btn_SearchBills_Click(object sender, EventArgs e)
        {
            if (txt_RoomID.Text != string.Empty)
            {
                string RoomID = txt_RoomID.Text.Trim();

                if (RoomID.Length > 20)
                {
                    MessageBox.Show("Mã phòng quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (DataProvider.Instance.ExcuteQuery("SELECT * FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows.Count < 1)
                {
                    MessageBox.Show("Mã phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBills @RoomID ", new object[] { RoomID });
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_BillState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_BillState.SelectedIndex != -1)
            {
                if (cmb_BillState.SelectedIndex == 0)
                {
                    dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBillsPaid @BillPaid ", new object[] { 1 });
                }
                else
                {
                    dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBillsPaid @BillPaid ", new object[] { 0 });
                }
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Bills_Load(sender, e);
        }

        private void btn_AddNewBill_Click(object sender, EventArgs e)
        {
            Form_AddNewBill addNewBill = new Form_AddNewBill();
            addNewBill.ShowDialog();
        }

        private void dgv_Bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.RowIndex < dgv_Bills.Rows.Count && e.ColumnIndex < dgv_Bills.Columns.Count)
            {
                string BillID = dgv_Bills.Rows[e.RowIndex].Cells[0].Value.ToString();
                string RoomID = dgv_Bills.Rows[e.RowIndex].Cells[1].Value.ToString();
                string RoomName = DataProvider.Instance.ExcuteQuery("SELECT RoomName FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["RoomName"].ToString();
                int RoomTypeID = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT RoomTypeID FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["RoomTypeID"].ToString());
                string RoomTypeName = DataProvider.Instance.ExcuteQuery("SELECT RoomTypeName FROM RoomTypes WHERE RoomTypeID = @RoomTypeID ", new object[] { RoomTypeID }).Rows[0]["RoomTypeName"].ToString();
                int AreaID = int.Parse(DataProvider.Instance.ExcuteQuery("SELECT AreaID FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows[0]["AreaID"].ToString());
                string AreaName = DataProvider.Instance.ExcuteQuery("SELECT AreaName FROM Areas WHERE AreaID = @AreaID ", new object[] { AreaID }).Rows[0]["AreaName"].ToString();

                int Months = int.Parse(dgv_Bills.Rows[e.RowIndex].Cells[2].Value.ToString());
                int Years = int.Parse(dgv_Bills.Rows[e.RowIndex].Cells[3].Value.ToString());
                string StaffID = dgv_Bills.Rows[e.RowIndex].Cells[5].Value.ToString();
                int BillPaid;
                if (dgv_Bills.Rows[e.RowIndex].Cells[6].Value.ToString() == "True")
                {
                    BillPaid = 0;
                }
                else
                {
                    BillPaid = 1;
                }
                Form_ShowBill showBills = new Form_ShowBill(BillID, AreaName, RoomTypeName, RoomID, RoomName, Months, Years, StaffID, BillPaid);
                showBills.ShowDialog();
            }
        }

        private void txt_RoomID_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Loại bỏ ký tự nếu không phải là số
            }

        }

        #endregion  
    }
}
