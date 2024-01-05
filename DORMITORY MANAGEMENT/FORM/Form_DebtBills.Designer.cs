namespace DORMITORY_MANAGEMENT
{
    partial class Form_DebtBills
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DebtBills));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lbl_Text = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btn_Refresh = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_Filter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_Years = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmb_Months = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dgv_DebtBills = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1.SuspendLayout();
            this.bunifuGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebtBills)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
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
            this.bunifuPanel1.Location = new System.Drawing.Point(-7, -17);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(936, 80);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseDown);
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btn_exit.CustomizableEdges = borderEdges3;
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
            this.btn_exit.Location = new System.Drawing.Point(873, 23);
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
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_Text
            // 
            this.lbl_Text.AllowParentOverrides = false;
            this.lbl_Text.AutoEllipsis = false;
            this.lbl_Text.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_Text.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_Text.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_Text.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_Text.Location = new System.Drawing.Point(27, 30);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Text.Size = new System.Drawing.Size(294, 35);
            this.lbl_Text.TabIndex = 3;
            this.lbl_Text.Text = "Hoá đơn chưa thanh toán";
            this.lbl_Text.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_Text.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 5;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.btn_Refresh);
            this.bunifuGroupBox1.Controls.Add(this.btn_Filter);
            this.bunifuGroupBox1.Controls.Add(this.cmb_Years);
            this.bunifuGroupBox1.Controls.Add(this.cmb_Months);
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(20, 70);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(888, 88);
            this.bunifuGroupBox1.TabIndex = 2;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Bộ lọc";
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.AllowAnimations = true;
            this.btn_Refresh.AllowMouseEffects = true;
            this.btn_Refresh.AllowToggling = false;
            this.btn_Refresh.AnimationSpeed = 200;
            this.btn_Refresh.AutoGenerateColors = false;
            this.btn_Refresh.AutoRoundBorders = false;
            this.btn_Refresh.AutoSizeLeftIcon = true;
            this.btn_Refresh.AutoSizeRightIcon = true;
            this.btn_Refresh.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.BackColor1 = System.Drawing.Color.Transparent;
            this.btn_Refresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.BackgroundImage")));
            this.btn_Refresh.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Refresh.ButtonText = "";
            this.btn_Refresh.ButtonTextMarginLeft = 0;
            this.btn_Refresh.ColorContrastOnClick = 45;
            this.btn_Refresh.ColorContrastOnHover = 45;
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_Refresh.CustomizableEdges = borderEdges1;
            this.btn_Refresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Refresh.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Refresh.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Refresh.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Refresh.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Refresh.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refresh.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Refresh.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Refresh.IconMarginLeft = 11;
            this.btn_Refresh.IconPadding = 10;
            this.btn_Refresh.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Refresh.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Refresh.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Refresh.IconSize = 25;
            this.btn_Refresh.IdleBorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.IdleBorderRadius = 1;
            this.btn_Refresh.IdleBorderThickness = 1;
            this.btn_Refresh.IdleFillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.IdleIconLeftImage")));
            this.btn_Refresh.IdleIconRightImage = null;
            this.btn_Refresh.IndicateFocus = false;
            this.btn_Refresh.Location = new System.Drawing.Point(823, 23);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Refresh.OnDisabledState.BorderRadius = 1;
            this.btn_Refresh.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Refresh.OnDisabledState.BorderThickness = 1;
            this.btn_Refresh.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Refresh.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Refresh.OnDisabledState.IconLeftImage = null;
            this.btn_Refresh.OnDisabledState.IconRightImage = null;
            this.btn_Refresh.onHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.onHoverState.BorderRadius = 1;
            this.btn_Refresh.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Refresh.onHoverState.BorderThickness = 1;
            this.btn_Refresh.onHoverState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage")));
            this.btn_Refresh.onHoverState.IconRightImage = null;
            this.btn_Refresh.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnIdleState.BorderRadius = 1;
            this.btn_Refresh.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Refresh.OnIdleState.BorderThickness = 1;
            this.btn_Refresh.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("btn_Refresh.OnIdleState.IconLeftImage")));
            this.btn_Refresh.OnIdleState.IconRightImage = null;
            this.btn_Refresh.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnPressedState.BorderRadius = 1;
            this.btn_Refresh.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Refresh.OnPressedState.BorderThickness = 1;
            this.btn_Refresh.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Refresh.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Refresh.OnPressedState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage1")));
            this.btn_Refresh.OnPressedState.IconRightImage = null;
            this.btn_Refresh.Size = new System.Drawing.Size(49, 49);
            this.btn_Refresh.TabIndex = 117;
            this.btn_Refresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Refresh.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Refresh.TextMarginLeft = 0;
            this.btn_Refresh.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Refresh.UseDefaultRadiusAndThickness = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Filter
            // 
            this.btn_Filter.AllowAnimations = true;
            this.btn_Filter.AllowMouseEffects = true;
            this.btn_Filter.AllowToggling = false;
            this.btn_Filter.AnimationSpeed = 200;
            this.btn_Filter.AutoGenerateColors = false;
            this.btn_Filter.AutoRoundBorders = false;
            this.btn_Filter.AutoSizeLeftIcon = true;
            this.btn_Filter.AutoSizeRightIcon = true;
            this.btn_Filter.BackColor = System.Drawing.Color.Transparent;
            this.btn_Filter.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Filter.BackgroundImage")));
            this.btn_Filter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Filter.ButtonText = "Lọc";
            this.btn_Filter.ButtonTextMarginLeft = 0;
            this.btn_Filter.ColorContrastOnClick = 45;
            this.btn_Filter.ColorContrastOnHover = 45;
            this.btn_Filter.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_Filter.CustomizableEdges = borderEdges2;
            this.btn_Filter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Filter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Filter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Filter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Filter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_Filter.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Filter.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filter.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Filter.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_Filter.IconMarginLeft = 11;
            this.btn_Filter.IconPadding = 10;
            this.btn_Filter.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Filter.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_Filter.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_Filter.IconSize = 25;
            this.btn_Filter.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.IdleBorderRadius = 45;
            this.btn_Filter.IdleBorderThickness = 1;
            this.btn_Filter.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.IdleIconLeftImage = null;
            this.btn_Filter.IdleIconRightImage = null;
            this.btn_Filter.IndicateFocus = false;
            this.btn_Filter.Location = new System.Drawing.Point(717, 26);
            this.btn_Filter.Name = "btn_Filter";
            this.btn_Filter.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_Filter.OnDisabledState.BorderRadius = 45;
            this.btn_Filter.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Filter.OnDisabledState.BorderThickness = 1;
            this.btn_Filter.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_Filter.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_Filter.OnDisabledState.IconLeftImage = null;
            this.btn_Filter.OnDisabledState.IconRightImage = null;
            this.btn_Filter.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.onHoverState.BorderRadius = 45;
            this.btn_Filter.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Filter.onHoverState.BorderThickness = 1;
            this.btn_Filter.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.onHoverState.IconLeftImage = null;
            this.btn_Filter.onHoverState.IconRightImage = null;
            this.btn_Filter.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.OnIdleState.BorderRadius = 45;
            this.btn_Filter.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Filter.OnIdleState.BorderThickness = 1;
            this.btn_Filter.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(138)))), ((int)(((byte)(255)))));
            this.btn_Filter.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.OnIdleState.IconLeftImage = null;
            this.btn_Filter.OnIdleState.IconRightImage = null;
            this.btn_Filter.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_Filter.OnPressedState.BorderRadius = 45;
            this.btn_Filter.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_Filter.OnPressedState.BorderThickness = 1;
            this.btn_Filter.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_Filter.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_Filter.OnPressedState.IconLeftImage = null;
            this.btn_Filter.OnPressedState.IconRightImage = null;
            this.btn_Filter.Size = new System.Drawing.Size(100, 46);
            this.btn_Filter.TabIndex = 116;
            this.btn_Filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Filter.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Filter.TextMarginLeft = 0;
            this.btn_Filter.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_Filter.UseDefaultRadiusAndThickness = true;
            this.btn_Filter.Click += new System.EventHandler(this.btn_Filter_Click);
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
            this.cmb_Years.ItemTopMargin = 3;
            this.cmb_Years.Location = new System.Drawing.Point(293, 26);
            this.cmb_Years.Name = "cmb_Years";
            this.cmb_Years.Size = new System.Drawing.Size(240, 46);
            this.cmb_Years.TabIndex = 114;
            this.cmb_Years.Text = "Năm";
            this.cmb_Years.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Years.TextLeftMargin = 5;
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
            this.cmb_Months.ItemTopMargin = 3;
            this.cmb_Months.Location = new System.Drawing.Point(15, 26);
            this.cmb_Months.Name = "cmb_Months";
            this.cmb_Months.Size = new System.Drawing.Size(240, 46);
            this.cmb_Months.TabIndex = 112;
            this.cmb_Months.Text = "Tháng";
            this.cmb_Months.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_Months.TextLeftMargin = 5;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 10;
            this.bunifuElipse3.TargetControl = this.cmb_Months;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 10;
            this.bunifuElipse4.TargetControl = this.cmb_Years;
            // 
            // dgv_DebtBills
            // 
            this.dgv_DebtBills.AllowCustomTheming = false;
            this.dgv_DebtBills.AllowUserToAddRows = false;
            this.dgv_DebtBills.AllowUserToDeleteRows = false;
            this.dgv_DebtBills.AllowUserToResizeColumns = false;
            this.dgv_DebtBills.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_DebtBills.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_DebtBills.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DebtBills.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_DebtBills.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_DebtBills.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_DebtBills.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_DebtBills.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_DebtBills.ColumnHeadersHeight = 40;
            this.dgv_DebtBills.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_DebtBills.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_DebtBills.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DebtBills.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_DebtBills.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_DebtBills.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_DebtBills.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_DebtBills.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_DebtBills.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_DebtBills.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_DebtBills.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_DebtBills.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_DebtBills.CurrentTheme.Name = null;
            this.dgv_DebtBills.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_DebtBills.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_DebtBills.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_DebtBills.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_DebtBills.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_DebtBills.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_DebtBills.EnableHeadersVisualStyles = false;
            this.dgv_DebtBills.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_DebtBills.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_DebtBills.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_DebtBills.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_DebtBills.Location = new System.Drawing.Point(20, 174);
            this.dgv_DebtBills.Name = "dgv_DebtBills";
            this.dgv_DebtBills.RowHeadersVisible = false;
            this.dgv_DebtBills.RowHeadersWidth = 51;
            this.dgv_DebtBills.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_DebtBills.RowTemplate.Height = 40;
            this.dgv_DebtBills.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DebtBills.Size = new System.Drawing.Size(888, 549);
            this.dgv_DebtBills.TabIndex = 3;
            this.dgv_DebtBills.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.dgv_DebtBills;
            // 
            // Form_DebtBills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 746);
            this.Controls.Add(this.dgv_DebtBills);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_DebtBills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá đơn chưa thanh toán";
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebtBills)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_exit;
        private Bunifu.UI.WinForms.BunifuLabel lbl_Text;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_Months;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_Years;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_DebtBills;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Filter;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_Refresh;
    }
}