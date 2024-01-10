namespace DORMITORY_MANAGEMENT
{
    partial class Form_SaleStatistics
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SaleStatistics));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmb_StatisticChoosen = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_Text = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.cmb_Months = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmb_Years = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_AddServices = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_Years2 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // cmb_StatisticChoosen
            // 
            this.cmb_StatisticChoosen.BackColor = System.Drawing.Color.Transparent;
            this.cmb_StatisticChoosen.BackgroundColor = System.Drawing.Color.White;
            this.cmb_StatisticChoosen.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_StatisticChoosen.BorderRadius = 1;
            this.cmb_StatisticChoosen.Color = System.Drawing.Color.Transparent;
            this.cmb_StatisticChoosen.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_StatisticChoosen.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_StatisticChoosen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_StatisticChoosen.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_StatisticChoosen.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_StatisticChoosen.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_StatisticChoosen.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_StatisticChoosen.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_StatisticChoosen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_StatisticChoosen.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_StatisticChoosen.FillDropDown = true;
            this.cmb_StatisticChoosen.FillIndicator = false;
            this.cmb_StatisticChoosen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_StatisticChoosen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_StatisticChoosen.ForeColor = System.Drawing.Color.Black;
            this.cmb_StatisticChoosen.FormattingEnabled = true;
            this.cmb_StatisticChoosen.Icon = null;
            this.cmb_StatisticChoosen.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_StatisticChoosen.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_StatisticChoosen.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_StatisticChoosen.ItemBackColor = System.Drawing.Color.White;
            this.cmb_StatisticChoosen.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_StatisticChoosen.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_StatisticChoosen.ItemHeight = 40;
            this.cmb_StatisticChoosen.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_StatisticChoosen.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_StatisticChoosen.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cmb_StatisticChoosen.ItemTopMargin = 3;
            this.cmb_StatisticChoosen.Location = new System.Drawing.Point(16, 90);
            this.cmb_StatisticChoosen.Name = "cmb_StatisticChoosen";
            this.cmb_StatisticChoosen.Size = new System.Drawing.Size(211, 46);
            this.cmb_StatisticChoosen.TabIndex = 102;
            this.cmb_StatisticChoosen.Text = "Loại thống kê";
            this.cmb_StatisticChoosen.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_StatisticChoosen.TextLeftMargin = 5;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.White;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.btn_exit);
            this.bunifuPanel1.Controls.Add(this.lbl_Text);
            this.bunifuPanel1.Location = new System.Drawing.Point(-10, -9);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(814, 63);
            this.bunifuPanel1.TabIndex = 103;
            // 
            // btn_exit
            // 
            this.btn_exit.AllowAnimations = true;
            this.btn_exit.AllowMouseEffects = true;
            this.btn_exit.AllowToggling = false;
            this.btn_exit.AnimationSpeed = 200;
            this.btn_exit.AutoGenerateColors = false;
            this.btn_exit.AutoRoundBorders = false;
            this.btn_exit.AutoSizeLeftIcon = true;
            this.btn_exit.AutoSizeRightIcon = true;
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_exit.ButtonText = "";
            this.btn_exit.ButtonTextMarginLeft = 0;
            this.btn_exit.ColorContrastOnClick = 45;
            this.btn_exit.ColorContrastOnHover = 45;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btn_exit.CustomizableEdges = borderEdges4;
            this.btn_exit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_exit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_exit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_exit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_exit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_exit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_exit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_exit.IconMarginLeft = 11;
            this.btn_exit.IconPadding = 10;
            this.btn_exit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_exit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_exit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_exit.IconSize = 25;
            this.btn_exit.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.IdleBorderRadius = 10;
            this.btn_exit.IdleBorderThickness = 1;
            this.btn_exit.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.IdleIconLeftImage")));
            this.btn_exit.IdleIconRightImage = null;
            this.btn_exit.IndicateFocus = false;
            this.btn_exit.Location = new System.Drawing.Point(738, 11);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_exit.OnDisabledState.BorderRadius = 10;
            this.btn_exit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_exit.OnDisabledState.BorderThickness = 1;
            this.btn_exit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_exit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_exit.OnDisabledState.IconLeftImage = null;
            this.btn_exit.OnDisabledState.IconRightImage = null;
            this.btn_exit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.onHoverState.BorderRadius = 10;
            this.btn_exit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_exit.onHoverState.BorderThickness = 1;
            this.btn_exit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_exit.onHoverState.IconLeftImage = null;
            this.btn_exit.onHoverState.IconRightImage = null;
            this.btn_exit.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.OnIdleState.BorderRadius = 10;
            this.btn_exit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_exit.OnIdleState.BorderThickness = 1;
            this.btn_exit.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btn_exit.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.OnIdleState.IconLeftImage")));
            this.btn_exit.OnIdleState.IconRightImage = null;
            this.btn_exit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.OnPressedState.BorderRadius = 10;
            this.btn_exit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_exit.OnPressedState.BorderThickness = 1;
            this.btn_exit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn_exit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_exit.OnPressedState.IconLeftImage = null;
            this.btn_exit.OnPressedState.IconRightImage = null;
            this.btn_exit.Size = new System.Drawing.Size(52, 51);
            this.btn_exit.TabIndex = 44;
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_exit.TextMarginLeft = 0;
            this.btn_exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_exit.UseDefaultRadiusAndThickness = true;
            // 
            // lbl_Text
            // 
            this.lbl_Text.AllowParentOverrides = false;
            this.lbl_Text.AutoEllipsis = false;
            this.lbl_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Text.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Text.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_Text.Location = new System.Drawing.Point(26, 19);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Text.Size = new System.Drawing.Size(233, 35);
            this.lbl_Text.TabIndex = 3;
            this.lbl_Text.Text = "Thống kê doanh thu";
            this.lbl_Text.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Text.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel6.Location = new System.Drawing.Point(16, 64);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(95, 20);
            this.bunifuLabel6.TabIndex = 105;
            this.bunifuLabel6.Text = "Thống kê theo";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.cmb_StatisticChoosen;
            // 
            // cmb_Months
            // 
            this.cmb_Months.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Months.BackgroundColor = System.Drawing.Color.White;
            this.cmb_Months.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_Months.BorderRadius = 1;
            this.cmb_Months.Color = System.Drawing.Color.Transparent;
            this.cmb_Months.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_Months.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Months.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_Months.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Months.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_Months.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_Months.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Months.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_Months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Months.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Months.FillDropDown = true;
            this.cmb_Months.FillIndicator = false;
            this.cmb_Months.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Months.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Months.ForeColor = System.Drawing.Color.Black;
            this.cmb_Months.FormattingEnabled = true;
            this.cmb_Months.Icon = null;
            this.cmb_Months.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Months.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_Months.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Months.ItemBackColor = System.Drawing.Color.White;
            this.cmb_Months.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_Months.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_Months.ItemHeight = 40;
            this.cmb_Months.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_Months.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_Months.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cmb_Months.ItemTopMargin = 3;
            this.cmb_Months.Location = new System.Drawing.Point(262, 90);
            this.cmb_Months.Name = "cmb_Months";
            this.cmb_Months.Size = new System.Drawing.Size(135, 46);
            this.cmb_Months.TabIndex = 106;
            this.cmb_Months.Text = "Tháng";
            this.cmb_Months.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Months.TextLeftMargin = 5;
            // 
            // cmb_Years
            // 
            this.cmb_Years.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Years.BackgroundColor = System.Drawing.Color.White;
            this.cmb_Years.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_Years.BorderRadius = 1;
            this.cmb_Years.Color = System.Drawing.Color.Transparent;
            this.cmb_Years.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_Years.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Years.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_Years.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Years.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_Years.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_Years.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Years.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_Years.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Years.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Years.FillDropDown = true;
            this.cmb_Years.FillIndicator = false;
            this.cmb_Years.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Years.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Years.ForeColor = System.Drawing.Color.Black;
            this.cmb_Years.FormattingEnabled = true;
            this.cmb_Years.Icon = null;
            this.cmb_Years.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Years.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_Years.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Years.ItemBackColor = System.Drawing.Color.White;
            this.cmb_Years.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_Years.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_Years.ItemHeight = 40;
            this.cmb_Years.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_Years.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_Years.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cmb_Years.ItemTopMargin = 3;
            this.cmb_Years.Location = new System.Drawing.Point(433, 90);
            this.cmb_Years.Name = "cmb_Years";
            this.cmb_Years.Size = new System.Drawing.Size(135, 46);
            this.cmb_Years.TabIndex = 107;
            this.cmb_Years.Text = "Năm";
            this.cmb_Years.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Years.TextLeftMargin = 5;
            // 
            // btn_AddServices
            // 
            this.btn_AddServices.AllowAnimations = true;
            this.btn_AddServices.AllowMouseEffects = true;
            this.btn_AddServices.AllowToggling = false;
            this.btn_AddServices.AnimationSpeed = 200;
            this.btn_AddServices.AutoGenerateColors = false;
            this.btn_AddServices.AutoRoundBorders = false;
            this.btn_AddServices.AutoSizeLeftIcon = true;
            this.btn_AddServices.AutoSizeRightIcon = true;
            this.btn_AddServices.BackColor = System.Drawing.Color.Transparent;
            this.btn_AddServices.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_AddServices.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_AddServices.BackgroundImage")));
            this.btn_AddServices.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AddServices.ButtonText = "Thống kê";
            this.btn_AddServices.ButtonTextMarginLeft = 0;
            this.btn_AddServices.ColorContrastOnClick = 45;
            this.btn_AddServices.ColorContrastOnHover = 45;
            this.btn_AddServices.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_AddServices.CustomizableEdges = borderEdges3;
            this.btn_AddServices.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_AddServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AddServices.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AddServices.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_AddServices.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_AddServices.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddServices.ForeColor = System.Drawing.Color.White;
            this.btn_AddServices.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddServices.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddServices.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_AddServices.IconMarginLeft = 11;
            this.btn_AddServices.IconPadding = 10;
            this.btn_AddServices.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddServices.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_AddServices.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_AddServices.IconSize = 25;
            this.btn_AddServices.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_AddServices.IdleBorderRadius = 45;
            this.btn_AddServices.IdleBorderThickness = 1;
            this.btn_AddServices.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_AddServices.IdleIconLeftImage = null;
            this.btn_AddServices.IdleIconRightImage = null;
            this.btn_AddServices.IndicateFocus = false;
            this.btn_AddServices.Location = new System.Drawing.Point(613, 157);
            this.btn_AddServices.Name = "btn_AddServices";
            this.btn_AddServices.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_AddServices.OnDisabledState.BorderRadius = 45;
            this.btn_AddServices.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AddServices.OnDisabledState.BorderThickness = 1;
            this.btn_AddServices.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_AddServices.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_AddServices.OnDisabledState.IconLeftImage = null;
            this.btn_AddServices.OnDisabledState.IconRightImage = null;
            this.btn_AddServices.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_AddServices.onHoverState.BorderRadius = 45;
            this.btn_AddServices.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AddServices.onHoverState.BorderThickness = 1;
            this.btn_AddServices.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_AddServices.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_AddServices.onHoverState.IconLeftImage = null;
            this.btn_AddServices.onHoverState.IconRightImage = null;
            this.btn_AddServices.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_AddServices.OnIdleState.BorderRadius = 45;
            this.btn_AddServices.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AddServices.OnIdleState.BorderThickness = 1;
            this.btn_AddServices.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_AddServices.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_AddServices.OnIdleState.IconLeftImage = null;
            this.btn_AddServices.OnIdleState.IconRightImage = null;
            this.btn_AddServices.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_AddServices.OnPressedState.BorderRadius = 45;
            this.btn_AddServices.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_AddServices.OnPressedState.BorderThickness = 1;
            this.btn_AddServices.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_AddServices.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_AddServices.OnPressedState.IconLeftImage = null;
            this.btn_AddServices.OnPressedState.IconRightImage = null;
            this.btn_AddServices.Size = new System.Drawing.Size(158, 50);
            this.btn_AddServices.TabIndex = 108;
            this.btn_AddServices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_AddServices.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_AddServices.TextMarginLeft = 0;
            this.btn_AddServices.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_AddServices.UseDefaultRadiusAndThickness = true;
            // 
            // cmb_Years2
            // 
            this.cmb_Years2.BackColor = System.Drawing.Color.Transparent;
            this.cmb_Years2.BackgroundColor = System.Drawing.Color.White;
            this.cmb_Years2.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_Years2.BorderRadius = 1;
            this.cmb_Years2.Color = System.Drawing.Color.Transparent;
            this.cmb_Years2.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_Years2.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Years2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_Years2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_Years2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_Years2.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_Years2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_Years2.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_Years2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Years2.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Years2.FillDropDown = true;
            this.cmb_Years2.FillIndicator = false;
            this.cmb_Years2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Years2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Years2.ForeColor = System.Drawing.Color.Black;
            this.cmb_Years2.FormattingEnabled = true;
            this.cmb_Years2.Icon = null;
            this.cmb_Years2.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Years2.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_Years2.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_Years2.ItemBackColor = System.Drawing.Color.White;
            this.cmb_Years2.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_Years2.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_Years2.ItemHeight = 40;
            this.cmb_Years2.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_Years2.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_Years2.Items.AddRange(new object[] {
            "Tháng",
            "Năm"});
            this.cmb_Years2.ItemTopMargin = 3;
            this.cmb_Years2.Location = new System.Drawing.Point(262, 90);
            this.cmb_Years2.Name = "cmb_Years2";
            this.cmb_Years2.Size = new System.Drawing.Size(135, 46);
            this.cmb_Years2.TabIndex = 109;
            this.cmb_Years2.Text = "Năm";
            this.cmb_Years2.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Years2.TextLeftMargin = 5;
            // 
            // Form_SaleStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 767);
            this.Controls.Add(this.btn_AddServices);
            this.Controls.Add(this.cmb_Years);
            this.Controls.Add(this.cmb_Months);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuPanel1);
            this.Controls.Add(this.cmb_StatisticChoosen);
            this.Controls.Add(this.cmb_Years2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SaleStatistics";
            this.Text = "SaleStatistics";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_StatisticChoosen;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_exit;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Text;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_Years;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_Months;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_AddServices;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_Years2;
    }
}