namespace DORMITORY_MANAGEMENT
{
    partial class ManageRoomControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRoomControl));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.cmb_stateRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmb_floorOfRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmb_typeOfRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btn_clearSelected = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearSelected)).BeginInit();
            this.bunifuPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.Location = new System.Drawing.Point(39, 19);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(65, 31);
            this.bunifuLabel1.TabIndex = 0;
            this.bunifuLabel1.Text = "Bộ lọc";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.bunifuButton1);
            this.bunifuPanel1.Controls.Add(this.btn_login);
            this.bunifuPanel1.Controls.Add(this.btn_clearSelected);
            this.bunifuPanel1.Controls.Add(this.cmb_typeOfRoom);
            this.bunifuPanel1.Controls.Add(this.cmb_floorOfRoom);
            this.bunifuPanel1.Controls.Add(this.cmb_stateRoom);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1138, 275);
            this.bunifuPanel1.TabIndex = 1;
            // 
            // cmb_stateRoom
            // 
            this.cmb_stateRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmb_stateRoom.BackgroundColor = System.Drawing.Color.White;
            this.cmb_stateRoom.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_stateRoom.BorderRadius = 1;
            this.cmb_stateRoom.Color = System.Drawing.Color.Transparent;
            this.cmb_stateRoom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_stateRoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_stateRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_stateRoom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_stateRoom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_stateRoom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_stateRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_stateRoom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_stateRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stateRoom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_stateRoom.FillDropDown = true;
            this.cmb_stateRoom.FillIndicator = false;
            this.cmb_stateRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_stateRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stateRoom.ForeColor = System.Drawing.Color.Black;
            this.cmb_stateRoom.FormattingEnabled = true;
            this.cmb_stateRoom.Icon = null;
            this.cmb_stateRoom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_stateRoom.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_stateRoom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_stateRoom.ItemBackColor = System.Drawing.Color.White;
            this.cmb_stateRoom.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_stateRoom.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_stateRoom.ItemHeight = 40;
            this.cmb_stateRoom.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_stateRoom.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_stateRoom.Items.AddRange(new object[] {
            "Còn trống",
            "Đã đầy"});
            this.cmb_stateRoom.ItemTopMargin = 3;
            this.cmb_stateRoom.Location = new System.Drawing.Point(39, 73);
            this.cmb_stateRoom.Name = "cmb_stateRoom";
            this.cmb_stateRoom.Size = new System.Drawing.Size(238, 46);
            this.cmb_stateRoom.TabIndex = 30;
            this.cmb_stateRoom.Text = "Trạng thái";
            this.cmb_stateRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_stateRoom.TextLeftMargin = 5;
            // 
            // cmb_floorOfRoom
            // 
            this.cmb_floorOfRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmb_floorOfRoom.BackgroundColor = System.Drawing.Color.White;
            this.cmb_floorOfRoom.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_floorOfRoom.BorderRadius = 1;
            this.cmb_floorOfRoom.Color = System.Drawing.Color.Transparent;
            this.cmb_floorOfRoom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_floorOfRoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_floorOfRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_floorOfRoom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_floorOfRoom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_floorOfRoom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_floorOfRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_floorOfRoom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_floorOfRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_floorOfRoom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_floorOfRoom.FillDropDown = true;
            this.cmb_floorOfRoom.FillIndicator = false;
            this.cmb_floorOfRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_floorOfRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_floorOfRoom.ForeColor = System.Drawing.Color.Black;
            this.cmb_floorOfRoom.FormattingEnabled = true;
            this.cmb_floorOfRoom.Icon = null;
            this.cmb_floorOfRoom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_floorOfRoom.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_floorOfRoom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_floorOfRoom.ItemBackColor = System.Drawing.Color.White;
            this.cmb_floorOfRoom.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_floorOfRoom.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_floorOfRoom.ItemHeight = 40;
            this.cmb_floorOfRoom.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_floorOfRoom.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_floorOfRoom.Items.AddRange(new object[] {
            "Tầng 1",
            "Tầng 2",
            "Tầng 3",
            "Tầng 4",
            "Tầng 5"});
            this.cmb_floorOfRoom.ItemTopMargin = 3;
            this.cmb_floorOfRoom.Location = new System.Drawing.Point(406, 73);
            this.cmb_floorOfRoom.Name = "cmb_floorOfRoom";
            this.cmb_floorOfRoom.Size = new System.Drawing.Size(238, 46);
            this.cmb_floorOfRoom.TabIndex = 31;
            this.cmb_floorOfRoom.Text = "Tầng";
            this.cmb_floorOfRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_floorOfRoom.TextLeftMargin = 5;
            // 
            // cmb_typeOfRoom
            // 
            this.cmb_typeOfRoom.BackColor = System.Drawing.Color.Transparent;
            this.cmb_typeOfRoom.BackgroundColor = System.Drawing.Color.White;
            this.cmb_typeOfRoom.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_typeOfRoom.BorderRadius = 1;
            this.cmb_typeOfRoom.Color = System.Drawing.Color.Transparent;
            this.cmb_typeOfRoom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_typeOfRoom.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_typeOfRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_typeOfRoom.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_typeOfRoom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_typeOfRoom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_typeOfRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_typeOfRoom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_typeOfRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_typeOfRoom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_typeOfRoom.FillDropDown = true;
            this.cmb_typeOfRoom.FillIndicator = false;
            this.cmb_typeOfRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_typeOfRoom.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_typeOfRoom.ForeColor = System.Drawing.Color.Black;
            this.cmb_typeOfRoom.FormattingEnabled = true;
            this.cmb_typeOfRoom.Icon = null;
            this.cmb_typeOfRoom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_typeOfRoom.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_typeOfRoom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_typeOfRoom.ItemBackColor = System.Drawing.Color.White;
            this.cmb_typeOfRoom.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_typeOfRoom.ItemForeColor = System.Drawing.Color.Black;
            this.cmb_typeOfRoom.ItemHeight = 40;
            this.cmb_typeOfRoom.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_typeOfRoom.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_typeOfRoom.Items.AddRange(new object[] {
            "Phòng dịch vụ 1",
            "Phòng dịch vụ 2",
            "Phòng dịch vụ 3",
            "Phòng dịch vụ 4"});
            this.cmb_typeOfRoom.ItemTopMargin = 3;
            this.cmb_typeOfRoom.Location = new System.Drawing.Point(748, 73);
            this.cmb_typeOfRoom.Name = "cmb_typeOfRoom";
            this.cmb_typeOfRoom.Size = new System.Drawing.Size(238, 46);
            this.cmb_typeOfRoom.TabIndex = 32;
            this.cmb_typeOfRoom.Text = "Loại phòng";
            this.cmb_typeOfRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_typeOfRoom.TextLeftMargin = 5;
            // 
            // btn_clearSelected
            // 
            this.btn_clearSelected.AllowFocused = false;
            this.btn_clearSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clearSelected.AutoSizeHeight = true;
            this.btn_clearSelected.BorderRadius = 17;
            this.btn_clearSelected.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearSelected.Image")));
            this.btn_clearSelected.IsCircle = true;
            this.btn_clearSelected.Location = new System.Drawing.Point(1063, 79);
            this.btn_clearSelected.Name = "btn_clearSelected";
            this.btn_clearSelected.Size = new System.Drawing.Size(34, 34);
            this.btn_clearSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clearSelected.TabIndex = 33;
            this.btn_clearSelected.TabStop = false;
            this.btn_clearSelected.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btn_clearSelected.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // btn_login
            // 
            this.btn_login.AllowAnimations = true;
            this.btn_login.AllowMouseEffects = true;
            this.btn_login.AllowToggling = false;
            this.btn_login.AnimationSpeed = 200;
            this.btn_login.AutoGenerateColors = false;
            this.btn_login.AutoRoundBorders = false;
            this.btn_login.AutoSizeLeftIcon = true;
            this.btn_login.AutoSizeRightIcon = true;
            this.btn_login.BackColor = System.Drawing.Color.Transparent;
            this.btn_login.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_login.BackgroundImage")));
            this.btn_login.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.ButtonText = "Tìm kiếm";
            this.btn_login.ButtonTextMarginLeft = 0;
            this.btn_login.ColorContrastOnClick = 45;
            this.btn_login.ColorContrastOnHover = 45;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_login.CustomizableEdges = borderEdges2;
            this.btn_login.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_login.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_login.IconMarginLeft = 11;
            this.btn_login.IconPadding = 10;
            this.btn_login.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_login.IconSize = 25;
            this.btn_login.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.IdleBorderRadius = 10;
            this.btn_login.IdleBorderThickness = 1;
            this.btn_login.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.IdleIconLeftImage = null;
            this.btn_login.IdleIconRightImage = null;
            this.btn_login.IndicateFocus = false;
            this.btn_login.Location = new System.Drawing.Point(748, 186);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_login.OnDisabledState.BorderRadius = 10;
            this.btn_login.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnDisabledState.BorderThickness = 1;
            this.btn_login.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_login.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_login.OnDisabledState.IconLeftImage = null;
            this.btn_login.OnDisabledState.IconRightImage = null;
            this.btn_login.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_login.onHoverState.BorderRadius = 10;
            this.btn_login.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.onHoverState.BorderThickness = 1;
            this.btn_login.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_login.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_login.onHoverState.IconLeftImage = null;
            this.btn_login.onHoverState.IconRightImage = null;
            this.btn_login.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.OnIdleState.BorderRadius = 10;
            this.btn_login.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnIdleState.BorderThickness = 1;
            this.btn_login.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnIdleState.IconLeftImage = null;
            this.btn_login.OnIdleState.IconRightImage = null;
            this.btn_login.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.OnPressedState.BorderRadius = 10;
            this.btn_login.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_login.OnPressedState.BorderThickness = 1;
            this.btn_login.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_login.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_login.OnPressedState.IconLeftImage = null;
            this.btn_login.OnPressedState.IconRightImage = null;
            this.btn_login.Size = new System.Drawing.Size(153, 50);
            this.btn_login.TabIndex = 34;
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_login.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_login.TextMarginLeft = 0;
            this.btn_login.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_login.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuDataGridView1);
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 281);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1138, 519);
            this.bunifuPanel2.TabIndex = 2;
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = false;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Thêm Phòng";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 25;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.IdleBorderRadius = 10;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = false;
            this.bunifuButton1.Location = new System.Drawing.Point(927, 186);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 10;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 10;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.OnIdleState.BorderRadius = 10;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 10;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(170, 50);
            this.bunifuButton1.TabIndex = 35;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuDataGridView1.ColumnHeadersHeight = 40;
            this.bunifuDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBgColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(39, 0);
            this.bunifuDataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowHeadersWidth = 51;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(1058, 466);
            this.bunifuDataGridView1.TabIndex = 1;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // ManageRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ManageRoomControl";
            this.Size = new System.Drawing.Size(1138, 800);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearSelected)).EndInit();
            this.bunifuPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_floorOfRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_stateRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_typeOfRoom;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_clearSelected;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}
