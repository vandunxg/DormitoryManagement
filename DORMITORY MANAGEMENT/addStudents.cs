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
using Utilities.BunifuTextBox.Transitions;

namespace DORMITORY_MANAGEMENT
{
    public partial class addStudents : UserControl
    {
        public addStudents()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void addStudents_Load(object sender, EventArgs e)
        {
            string query = "SELECT studentID, fullname, phoneNumber, birthday, address, sex, personalID, classroom, startContract, dateofContract, lived, regStay FROM dbo.dataStudents";
            DataSet data = DataProvider.Instance.ExcuteQueryDataSet(query);
            dgv_studentsData.DataSource = data.Tables[0];
            

        }

        private void dgv_studentsData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_insertInformation.Enabled = false;
            btn_editButton.Enabled = true;
            btn_deleteButton.Enabled = true;

            

        }

        private void btn_insertInformation_Click(object sender, EventArgs e)
        {
            if(txt_inputFullname.Text != "" || txt_inputAddress.Text != "" || txt_inputPhone.Text != "" || cmb_classroom.SelectedIndex != -1 || cmb_sex.SelectedIndex == -1 || cmb_TermContract.SelectedIndex != -1 ||
               txt_inputPersonalID.Text != "" || cmb_room.SelectedIndex != -1)
            {
                string txtIDstudents = txt_studentID.Text.ToString();
                string txtfullname = txt_inputFullname.Text.ToString();
                string txtbirthday = date_birthday.Value.GetDateTimeFormats().First().ToString();
                string txtaddress = txt_inputAddress.Text.ToString();
                string txtnumberPhone = txt_inputPhone.Text.ToString();
                string txtclassroom = cmb_classroom.SelectedItem.ToString();
                string txtsex = cmb_sex.SelectedItem.ToString();
                string txtpersonalID = txt_inputPersonalID.Text.ToString();
                int checklived = 0, checkregStay = 0;
                if (checkbox_lived.Checked)
                    checklived = 1;
                if (checkbox_tempLived.Checked)
                    checkregStay = 1;
                string txtstartContract = date_dateContact.Value.GetDateTimeFormats().First().ToString();
                string txtendContract = "6";

                string query = "INSERT INTO dataStudents (studentID , fullname , phoneNumber , birthday , address , sex , personalID , classroom , startContract , dateofContract , lived , regStay) VALUES ( @txtIDstudents , @txtfullname , @txtnumberPhone , @txtbirthday , @txtaddress , @txtsex , @txtpersonalID , @txtclassroom , @txtstartContract , @txtendContract , @checklived , @checkregStay );";

               DataTable data = DataProvider.Instance.ExcuteQuery(query, new object[] { txtIDstudents, txtfullname, txtnumberPhone, txtbirthday, txtaddress, txtsex, txtpersonalID, txtclassroom, txtstartContract, txtendContract, checklived, checkregStay });

                addStudents_Load(sender, e);
                if (data.Rows.Count > 0)
                    MessageBox.Show("OK");
            }
        }

        
    }
}
