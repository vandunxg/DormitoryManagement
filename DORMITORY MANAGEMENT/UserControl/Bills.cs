using DORMITORY_MANAGEMENT.DAO;
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
    public partial class Bills : UserControl
    {
        public Bills()
        {
            InitializeComponent();
        }

        private void Bills_Load(object sender, EventArgs e)
        {
            dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("GetBills");

            cmb_BillState.SelectedIndex = -1;
            cmb_BillState.Text = "Tình trạng";

            txt_RoomID.Text = string.Empty;
        }

        private void btn_SearchBills_Click(object sender, EventArgs e)
        {
            if(txt_RoomID.Text != string.Empty)
            {
                string RoomID = txt_RoomID.Text.Trim();

                if(RoomID.Length > 20)
                {
                    MessageBox.Show("Mã phòng quá dài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(DataProvider.Instance.ExcuteQuery("SELECT * FROM Rooms WHERE RoomID = @RoomID ", new object[] { RoomID }).Rows.Count < 1)
                {
                    MessageBox.Show("Mã phòng không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dgv_Bills.DataSource = DataProvider.Instance.ExcuteQuery("SearchBills @RoomID ", new object[] {RoomID});
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void cmb_BillState_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_BillState.SelectedIndex != -1)
            {
                if(cmb_BillState.SelectedIndex == 0)
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
            AddNewBill addNewBill = new AddNewBill();
            addNewBill.ShowDialog();
        }
    }
}
