using System;
using System.Drawing;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class CardRoom : UserControl
    {
        public CardRoom()
        {
            InitializeComponent();
        }

        #region Declaration  

        private int progressValue; // Giá trị thanh progress hoàn thành

        private int subValue; // Giá trị thanh progress chưa hoàn thành

        private string roomID; // Tên card

        private string nameSubValue; // Giá trị còn lại

        private string nameMainValue; // Giá trị thực

        private int total; // Giá trị tổng
        
        private int roomRate;

        public int ProgressValue
        {
            get => progressValue;
            set
            {
                progressValue = value;
                //CircleProgress_Room.Value = progressValue;
                lbl_value.Text = progressValue.ToString();
            }

        }

        public int SubValue
        {
            get => subValue;
            set
            {
                subValue = value;
                lbl_subValue.Text = subValue.ToString();
            }
        }
        public string RoomID
        {
            get => roomID;
            set
            {
                roomID = value;
                lbl_RoomID.Text = roomID;
            }
        }
        public string NameSubValue
        {
            get => nameSubValue;
            set
            {
                nameSubValue = value;
                lbl_nameSubValue.Text = nameSubValue;
            }
        }
        public string NameMainValue
        {
            get => nameMainValue;
            set
            {
                nameMainValue = value;
                lbl_nameMainValue.Text = nameMainValue;
            }
        }

        public int Total
        {
            get => total;
            set
            {
                total = value;
            }
        }

        public int RoomRate { get => roomRate;
            set
            {
                roomRate = value;
                rate_roomRating.Value = roomRate;
            }
        }
        #endregion

        #region Method

        public void setAllValue(string RoomID, int total, int value, string roomRating)
        {
            this.ProgressValue = value;
            this.Total = total;
            this.SubValue = total - value;
            this.RoomID = RoomID;

            if (roomRating == "VIP1")
                this.RoomRate = 1;
            else if (roomRating == "VIP2")
            {
                this.RoomRate = 2;
            }
            else
                this.RoomRate = 3;

            if (value == total)
            {
                lbl_nameMainValue.ForeColor = Color.Black;
                lbl_nameSubValue.ForeColor = Color.Black;
                this.BackColor = Color.FromArgb(219, 89, 98);
                lbl_nameMainValue.ForeColor = lbl_nameSubValue.ForeColor = lbl_RoomID.ForeColor = lbl_subValue.ForeColor = lbl_value.ForeColor = Color.White;
            }
            //this.CircleProgress_Room.Value = value;
        }

        #endregion

        #region Events

        private void CardRoom_Load(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
