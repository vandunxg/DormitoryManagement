using System.Windows.Forms;

namespace DORMITORY_MANAGEMENT
{
    public partial class cardShowOverview : UserControl
    {
        public cardShowOverview()
        {
            InitializeComponent();
        }

        #region Declaration  

        private int progressValue; // Giá trị thanh progress hoàn thành

        private int subValue; // Giá trị thanh progress chưa hoàn thành

        private string nameCard; // Tên card

        private string nameSubValue; // Giá trị còn lại

        private string nameMainValue; // Giá trị thực

        private int total; // Giá trị tổng

        public int ProgressValue
        {
            get => progressValue;
            set
            {
                progressValue = value;
                CircleProgress.Value = progressValue;
                lbl_mainValue.Text = progressValue.ToString();
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
        public string NameCard
        {
            get => nameCard;
            set
            {
                nameCard = value;
                lbl_nameCard.Text = nameCard;
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

        #endregion

        #region Method  

        public void setAllValue(int total, int progressValue, string nameCard, string nameSubValue, string nameProgressValue)
        {
            CircleProgress.Maximum = total;
            //CircleProgress.Name = nameCard;
            this.ProgressValue = progressValue;
            this.NameCard = nameCard;
            this.SubValue = total - ProgressValue;
            this.NameSubValue = nameSubValue;
            this.NameMainValue = nameProgressValue;

        }

        #endregion

        private void cardShowOverview_Load(object sender, System.EventArgs e)
        {

        }
    }




}
