using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class cardShowInfo : UserControl
    {
        public cardShowInfo()
        {
            InitializeComponent();
        }

        public cardShowInfo(string CardName, string Money)
        {
            InitializeComponent();
            lbl_name.Text = CardName;
            lbl_money.Text = Money + "đ";
        }

        #region Declaration
        public string TextLabel
        {
            get => textLabel;
            set
            {
                textLabel = value;
                lbl_name.Text = textLabel;

            }
        }

        public string Money
        {
            get => money;
            set
            {
                money = value;
                lbl_money.Text = money + "đ";
            }
        }


        
        private string textLabel;
        private string money;
        #endregion


        #region Events

        private void cardShowInfo_Load(object sender, EventArgs e)
        {

        }

        #endregion

        #region Method

        public void setAllValue(string name, string money)
        {
            lbl_name.Text = name;
            lbl_money.Text = money;
        }

        #endregion
    }
}