namespace DORMITORY_MANAGEMENT
{
    partial class Card_ShowInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card_ShowInfo));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_name = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_money = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 43;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(25, 27);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(86, 86);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_name
            // 
            this.lbl_name.AllowParentOverrides = false;
            this.lbl_name.AutoEllipsis = true;
            this.lbl_name.BackColor = System.Drawing.Color.White;
            this.lbl_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_name.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lbl_name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(174)))), ((int)(((byte)(208)))));
            this.lbl_name.Location = new System.Drawing.Point(120, 37);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_name.Size = new System.Drawing.Size(79, 28);
            this.lbl_name.TabIndex = 39;
            this.lbl_name.Text = "Tiền điện";
            this.lbl_name.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_name.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_money
            // 
            this.lbl_money.AllowParentOverrides = false;
            this.lbl_money.AutoEllipsis = false;
            this.lbl_money.BackColor = System.Drawing.Color.White;
            this.lbl_money.CursorType = null;
            this.lbl_money.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_money.Location = new System.Drawing.Point(120, 71);
            this.lbl_money.Name = "lbl_money";
            this.lbl_money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_money.Size = new System.Drawing.Size(138, 37);
            this.lbl_money.TabIndex = 44;
            this.lbl_money.Text = "12.001.123đ";
            this.lbl_money.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_money.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cardShowInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_money);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "cardShowInfo";
            this.Size = new System.Drawing.Size(351, 144);
            this.Load += new System.EventHandler(this.cardShowInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_money;
        private Bunifu.UI.WinForms.BunifuLabel lbl_name;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
    }
}
