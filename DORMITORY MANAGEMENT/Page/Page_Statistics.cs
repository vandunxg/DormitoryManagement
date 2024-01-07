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
    public partial class Page_Statistics : UserControl
    {
        public Page_Statistics()
        {
            InitializeComponent();

            LoadData();
        }

        #region Method

        private void LoadData()
        {
            lbl_NumberofStudents.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(StudentID) AS numofStudents FROM Students", new object[] { }).Rows[0]["numofStudents"].ToString();
            lbl_NumberofRooms.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS numofRoom FROM Rooms", new object[] { }).Rows[0]["numofRoom"].ToString();
            lbl_NumberofNonPaid.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(BillID) AS NumofBills FROM StudentBills WHERE BillPaid = @BillPaid", new object[] { 0 }).Rows[0]["NumofBills"].ToString();
            lbl_NumberofPaid.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(BillID) AS NumofBills FROM StudentBills WHERE BillPaid = @BillPaid", new object[] { 1 }).Rows[0]["NumofBills"].ToString();
            lbl_ContractsOutDate.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Contracts WHERE CheckOutDate < GETDATE();", new object[] { }).Rows[0]["NumofRoom"].ToString();
            lbl_EmptyRoom.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Rooms WHERE RoomStatus = N'Hoạt động';", new object[] { }).Rows[0]["NumofRoom"].ToString();
            lbl_FixedRoom.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Rooms WHERE RoomStatus = N'Bảo trì';", new object[] { }).Rows[0]["NumofRoom"].ToString();
        }

        #endregion

        #region Events

        private void CarđebtBills_Click(object sender, EventArgs e)
        {
            Form_DebtBills form_DebtBills = new Form_DebtBills();
            form_DebtBills.ShowDialog();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            card_Empty1_Load(sender, e);

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            card_Empty1_Load(sender, e);
        }

        private void lbl_NumberofStudents_Click(object sender, EventArgs e)
        {
            card_Empty1_Load(sender, e);
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            CarđebtBills_Click(sender, e);
        }

        private void lbl_NumberofNonPaid_Click(object sender, EventArgs e)
        {
            CarđebtBills_Click(sender, e);
        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {
            CarđebtBills_Click(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            card_Empty4_Click(sender, e);
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            card_Empty4_Click(sender, e);
        }

        private void lbl_NumberofPaid_Click(object sender, EventArgs e)
        {
            card_Empty4_Click(sender, e);
        }

        private void lbl_name_Click(object sender, EventArgs e)
        {
            card_Empty5_Click(sender, e);
        }

        private void bunifuPictureBox4_Click(object sender, EventArgs e)
        {
            card_Empty5_Click(sender, e);
        }

        private void lbl_ContractsOutDate_Click(object sender, EventArgs e)
        {
            card_Empty5_Click(sender, e);
        }

        private void card_Empty4_Click(object sender, EventArgs e)
        {
            Form_PaidBill form_PaidBill = new Form_PaidBill();
            form_PaidBill.ShowDialog();
        }

        private void card_Empty5_Click(object sender, EventArgs e)
        {
            Form_ContractsOutDate form_ContractsOutDate = new Form_ContractsOutDate();
            form_ContractsOutDate.ShowDialog();
        }

        private void card_Empty1_Load(object sender, EventArgs e)
        {
            
        }

        private void card_Empty2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void card_Empty4_Click_1(object sender, EventArgs e)
        {
            Form_PaidBill form_PaidBill1 = new Form_PaidBill();
            form_PaidBill1.ShowDialog();
        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void card_Empty7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void card_Empty8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính năng đang cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion


    }
}
