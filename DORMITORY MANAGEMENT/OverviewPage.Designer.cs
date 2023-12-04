namespace DORMITORY_MANAGEMENT
{
    partial class OverviewPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardShowOverview_payBill = new DORMITORY_MANAGEMENT.cardShowOverview();
            this.cardShowOverview_totalRoom = new DORMITORY_MANAGEMENT.cardShowOverview();
            this.cardShowInfor_total = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo_water = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo_Electricity = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.SuspendLayout();
            // 
            // cardShowOverview_payBill
            // 
            this.cardShowOverview_payBill.BackColor = System.Drawing.Color.White;
            this.cardShowOverview_payBill.Location = new System.Drawing.Point(634, 186);
            this.cardShowOverview_payBill.Name = "cardShowOverview_payBill";
            this.cardShowOverview_payBill.NameCard = null;
            this.cardShowOverview_payBill.NameMainValue = null;
            this.cardShowOverview_payBill.NameSubValue = null;
            this.cardShowOverview_payBill.ProgressValue = 0;
            this.cardShowOverview_payBill.Size = new System.Drawing.Size(466, 425);
            this.cardShowOverview_payBill.SubValue = 0;
            this.cardShowOverview_payBill.TabIndex = 73;
            this.cardShowOverview_payBill.Total = 0;
            this.cardShowOverview_payBill.Load += new System.EventHandler(this.cardShowOverview_payBill_Load);
            // 
            // cardShowOverview_totalRoom
            // 
            this.cardShowOverview_totalRoom.BackColor = System.Drawing.Color.White;
            this.cardShowOverview_totalRoom.Location = new System.Drawing.Point(39, 186);
            this.cardShowOverview_totalRoom.Name = "cardShowOverview_totalRoom";
            this.cardShowOverview_totalRoom.NameCard = null;
            this.cardShowOverview_totalRoom.NameMainValue = null;
            this.cardShowOverview_totalRoom.NameSubValue = null;
            this.cardShowOverview_totalRoom.ProgressValue = 0;
            this.cardShowOverview_totalRoom.Size = new System.Drawing.Size(466, 425);
            this.cardShowOverview_totalRoom.SubValue = 0;
            this.cardShowOverview_totalRoom.TabIndex = 72;
            this.cardShowOverview_totalRoom.Total = 0;
            this.cardShowOverview_totalRoom.Load += new System.EventHandler(this.cardShowOverview_totalRoom_Load_1);
            // 
            // cardShowInfor_total
            // 
            this.cardShowInfor_total.BackColor = System.Drawing.Color.White;
            this.cardShowInfor_total.Location = new System.Drawing.Point(786, 19);
            this.cardShowInfor_total.Money = 0;
            this.cardShowInfor_total.Name = "cardShowInfor_total";
            this.cardShowInfor_total.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfor_total.TabIndex = 71;
            this.cardShowInfor_total.TextLabel = null;
            // 
            // cardShowInfo_water
            // 
            this.cardShowInfo_water.BackColor = System.Drawing.Color.White;
            this.cardShowInfo_water.Location = new System.Drawing.Point(412, 19);
            this.cardShowInfo_water.Money = 0;
            this.cardShowInfo_water.Name = "cardShowInfo_water";
            this.cardShowInfo_water.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo_water.TabIndex = 70;
            this.cardShowInfo_water.TextLabel = null;
            // 
            // cardShowInfo_Electricity
            // 
            this.cardShowInfo_Electricity.BackColor = System.Drawing.Color.White;
            this.cardShowInfo_Electricity.Location = new System.Drawing.Point(39, 19);
            this.cardShowInfo_Electricity.Money = 0;
            this.cardShowInfo_Electricity.Name = "cardShowInfo_Electricity";
            this.cardShowInfo_Electricity.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo_Electricity.TabIndex = 69;
            this.cardShowInfo_Electricity.TextLabel = null;
            this.cardShowInfo_Electricity.Load += new System.EventHandler(this.cardShowInfo_Electricity_Load);
            // 
            // OverviewPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.cardShowOverview_payBill);
            this.Controls.Add(this.cardShowOverview_totalRoom);
            this.Controls.Add(this.cardShowInfor_total);
            this.Controls.Add(this.cardShowInfo_water);
            this.Controls.Add(this.cardShowInfo_Electricity);
            this.Name = "OverviewPage";
            this.Size = new System.Drawing.Size(1138, 800);
            this.Load += new System.EventHandler(this.OverviewPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private cardShowInfo cardShowInfo_Electricity;
        private cardShowInfo cardShowInfo_water;
        private cardShowInfo cardShowInfor_total;
        private cardShowOverview cardShowOverview_totalRoom;
        private cardShowOverview cardShowOverview_payBill;
    }
}
