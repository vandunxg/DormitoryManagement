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

        private string textLabel;

        public string TextLabel
        {
            get => textLabel;
            set
            {
                textLabel = value;
                lbl_name.Text = textLabel;
                OnPropertyChanged("TextLabel");
            }
        }

        public int Money { get => money;
            set
            {
                money = value;
                lbl_money.Text = money.ToString() + "đ";
            }
        }

        private int money;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void cardShowInfo_Load(object sender, EventArgs e)
        {
            lbl_name.Text = TextLabel;
            lbl_money.Text = Money.ToString() + "đ";
        }
    }
}