namespace DORMITORY_MANAGEMENT
{
    partial class Card_ShowOverview
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card_ShowOverview));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_nameCard = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_nameSubValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox7 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_nameMainValue = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.Gauge = new Bunifu.UI.WinForms.BunifuRadialGauge();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_nameCard
            // 
            this.lbl_nameCard.AllowParentOverrides = false;
            this.lbl_nameCard.AutoEllipsis = false;
            this.lbl_nameCard.BackColor = System.Drawing.Color.White;
            this.lbl_nameCard.CursorType = null;
            this.lbl_nameCard.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_nameCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_nameCard.Location = new System.Drawing.Point(28, 22);
            this.lbl_nameCard.Name = "lbl_nameCard";
            this.lbl_nameCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_nameCard.Size = new System.Drawing.Size(150, 37);
            this.lbl_nameCard.TabIndex = 69;
            this.lbl_nameCard.Text = "Tổng Phòng";
            this.lbl_nameCard.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_nameCard.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_nameSubValue
            // 
            this.lbl_nameSubValue.AllowParentOverrides = false;
            this.lbl_nameSubValue.AutoEllipsis = false;
            this.lbl_nameSubValue.BackColor = System.Drawing.Color.White;
            this.lbl_nameSubValue.CursorType = null;
            this.lbl_nameSubValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_nameSubValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lbl_nameSubValue.Location = new System.Drawing.Point(68, 348);
            this.lbl_nameSubValue.Name = "lbl_nameSubValue";
            this.lbl_nameSubValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_nameSubValue.Size = new System.Drawing.Size(145, 28);
            this.lbl_nameSubValue.TabIndex = 71;
            this.lbl_nameSubValue.Text = "Chưa thanh toán";
            this.lbl_nameSubValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_nameSubValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox7
            // 
            this.bunifuPictureBox7.AllowFocused = false;
            this.bunifuPictureBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox7.AutoSizeHeight = true;
            this.bunifuPictureBox7.BorderRadius = 7;
            this.bunifuPictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox7.Image")));
            this.bunifuPictureBox7.IsCircle = true;
            this.bunifuPictureBox7.Location = new System.Drawing.Point(44, 356);
            this.bunifuPictureBox7.Name = "bunifuPictureBox7";
            this.bunifuPictureBox7.Size = new System.Drawing.Size(15, 15);
            this.bunifuPictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox7.TabIndex = 70;
            this.bunifuPictureBox7.TabStop = false;
            this.bunifuPictureBox7.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_nameMainValue
            // 
            this.lbl_nameMainValue.AllowParentOverrides = false;
            this.lbl_nameMainValue.AutoEllipsis = false;
            this.lbl_nameMainValue.BackColor = System.Drawing.Color.White;
            this.lbl_nameMainValue.CursorType = null;
            this.lbl_nameMainValue.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_nameMainValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lbl_nameMainValue.Location = new System.Drawing.Point(68, 381);
            this.lbl_nameMainValue.Name = "lbl_nameMainValue";
            this.lbl_nameMainValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_nameMainValue.Size = new System.Drawing.Size(124, 28);
            this.lbl_nameMainValue.TabIndex = 74;
            this.lbl_nameMainValue.Text = "Đã thanh toán";
            this.lbl_nameMainValue.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_nameMainValue.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuPictureBox1.BorderRadius = 7;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(44, 390);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(15, 15);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 73;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Gauge
            // 
            this.Gauge.AutoGenerateProgressColorWhenHigh = true;
            this.Gauge.AutoGenerateProgressColorWhenLow = false;
            this.Gauge.BackColor = System.Drawing.Color.Transparent;
            this.Gauge.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.Gauge.LighteningFactor = 70;
            this.Gauge.Location = new System.Drawing.Point(48, 56);
            this.Gauge.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Gauge.Maximum = 100;
            this.Gauge.Minimum = 0;
            this.Gauge.Name = "Gauge";
            this.Gauge.Prefix = "";
            this.Gauge.ProgressBackColor = System.Drawing.SystemColors.ControlLight;
            this.Gauge.ProgressBgColor = System.Drawing.SystemColors.ControlLight;
            this.Gauge.ProgressCap = Bunifu.UI.WinForms.BunifuRadialGauge.CapStyles.Round;
            this.Gauge.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(24)))), ((int)(((byte)(255)))));
            this.Gauge.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(24)))), ((int)(((byte)(255)))));
            this.Gauge.ProgressColor2 = System.Drawing.Color.Crimson;
            this.Gauge.ProgressColorHigh = System.Drawing.Color.Crimson;
            this.Gauge.ProgressColorLow = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(24)))), ((int)(((byte)(255)))));
            this.Gauge.ProgressHighValueMark = 90;
            this.Gauge.RangeEnd = 100;
            this.Gauge.RangeLabelsColor = System.Drawing.Color.Black;
            this.Gauge.RangeLabelsFont = new System.Drawing.Font("Segoe UI", 8F);
            this.Gauge.RangeStart = 0;
            this.Gauge.ShowRangeLabels = true;
            this.Gauge.ShowValueLabel = true;
            this.Gauge.Size = new System.Drawing.Size(367, 275);
            this.Gauge.Suffix = "";
            this.Gauge.TabIndex = 76;
            this.Gauge.Thickness = 30;
            this.Gauge.Value = 40;
            this.Gauge.ValueByTransition = 40;
            this.Gauge.ValueLabelColor = System.Drawing.Color.Black;
            this.Gauge.WarningMark = 90;
            // 
            // Card_ShowOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_nameMainValue);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.lbl_nameSubValue);
            this.Controls.Add(this.bunifuPictureBox7);
            this.Controls.Add(this.lbl_nameCard);
            this.Controls.Add(this.Gauge);
            this.Name = "Card_ShowOverview";
            this.Size = new System.Drawing.Size(466, 425);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nameCard;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nameSubValue;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox7;
        private Bunifu.UI.WinForms.BunifuLabel lbl_nameMainValue;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuRadialGauge Gauge;
    }
}
