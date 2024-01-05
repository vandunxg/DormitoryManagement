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
    public partial class StatisticsOverview : UserControl
    {
        public StatisticsOverview()
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
            lbl_ContractsOutDate.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Contracts WHERE CheckOutDate > GETDATE();", new object[] { }).Rows[0]["NumofRoom"].ToString();
            lbl_EmptyRoom.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Rooms WHERE RoomStatus = N'Hoạt động';", new object[] { }).Rows[0]["NumofRoom"].ToString();
            lbl_FixedRoom.Text = DataProvider.Instance.ExcuteQuery("SELECT COUNT(RoomID) AS NumofRoom FROM Rooms WHERE RoomStatus = N'Bảo trì';", new object[] { }).Rows[0]["NumofRoom"].ToString();
        }

        #endregion

        #region Events
        private void emptyCard_Students_Click(object sender, EventArgs e)
        {
            Form_ShowStudents form_ShowStudents = new Form_ShowStudents();
            form_ShowStudents.ShowDialog();
        }

        private void bunifuPictureBox1_Click(object sender, EventArgs e)
        {
            emptyCard_Students_Click(sender, e);

        }

        private void bunifuLabel1_Click(object sender, EventArgs e)
        {
            emptyCard_Students_Click(sender, e);
        }

        private void lbl_NumberofStudents_Click(object sender, EventArgs e)
        {
            emptyCard_Students_Click(sender, e);
        }

        private void emptyCard_DebtBills_Click(object sender, EventArgs e)
        {
            Form_DebtBills form_DebtBills = new Form_DebtBills();
            form_DebtBills.ShowDialog();
        }

        private void bunifuPictureBox5_Click(object sender, EventArgs e)
        {
            emptyCard_DebtBills_Click(sender, e);
        }

        private void lbl_NumberofNonPaid_Click(object sender, EventArgs e)
        {
            emptyCard_DebtBills_Click(sender, e);
        }

        private void bunifuLabel10_Click(object sender, EventArgs e)
        {
            emptyCard_DebtBills_Click(sender, e);
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void emptyCard_PaidBill_Click(object sender, EventArgs e)
        {
            Form_PaidBill form_PaidBill = new Form_PaidBill();
            form_PaidBill.ShowDialog();
        }

        private void bunifuPictureBox3_Click(object sender, EventArgs e)
        {
            emptyCard_PaidBill_Click(sender, e);
        }

        private void bunifuLabel6_Click(object sender, EventArgs e)
        {
            emptyCard_PaidBill_Click(sender, e);
        }

        private void lbl_NumberofPaid_Click(object sender, EventArgs e)
        {
            emptyCard_PaidBill_Click(sender, e);
        }
        #endregion


    }
}
