namespace DORMITORY_MANAGEMENT
{
    partial class RoomStudentManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStudentManager));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_RoomID = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgv_Students = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lbl_PaidState = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_addRoom = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_RoomServiceState = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btn_UpdateServiceState = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ServiceElectricity = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ServiceWater = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ServiceInternet = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ServiceCleaning = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel12 = new Bunifu.UI.WinForms.BunifuLabel();
            this.lbl_ServiceTotal = new Bunifu.UI.WinForms.BunifuLabel();
            this.cardShowInfo_Total = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo_Water = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo_Electricity = new DORMITORY_MANAGEMENT.cardShowInfo();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            this.bunifuPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // lbl_RoomID
            // 
            this.lbl_RoomID.AllowParentOverrides = false;
            this.lbl_RoomID.AutoEllipsis = false;
            this.lbl_RoomID.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_RoomID.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_RoomID.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_RoomID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_RoomID.Location = new System.Drawing.Point(36, 18);
            this.lbl_RoomID.Name = "lbl_RoomID";
            this.lbl_RoomID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_RoomID.Size = new System.Drawing.Size(63, 45);
            this.lbl_RoomID.TabIndex = 0;
            this.lbl_RoomID.Text = "P101";
            this.lbl_RoomID.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_RoomID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgv_Students
            // 
            this.dgv_Students.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgv_Students.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Students.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Students.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Students.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Students.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Students.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Students.ColumnHeadersHeight = 40;
            this.dgv_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentName,
            this.StudentID});
            this.dgv_Students.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgv_Students.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Students.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Students.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Students.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgv_Students.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgv_Students.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Students.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Students.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Students.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Students.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgv_Students.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Students.CurrentTheme.Name = null;
            this.dgv_Students.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Students.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgv_Students.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Students.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgv_Students.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Students.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Students.EnableHeadersVisualStyles = false;
            this.dgv_Students.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgv_Students.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgv_Students.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgv_Students.HeaderForeColor = System.Drawing.Color.White;
            this.dgv_Students.Location = new System.Drawing.Point(36, 273);
            this.dgv_Students.Name = "dgv_Students";
            this.dgv_Students.RowHeadersVisible = false;
            this.dgv_Students.RowHeadersWidth = 51;
            this.dgv_Students.RowTemplate.Height = 40;
            this.dgv_Students.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Students.Size = new System.Drawing.Size(522, 425);
            this.dgv_Students.TabIndex = 0;
            this.dgv_Students.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "Họ và Tên";
            this.StudentName.MinimumWidth = 6;
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "Mã SV";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.dgv_Students;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 3;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lbl_PaidState);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Controls.Add(this.btn_exit);
            this.bunifuPanel1.Location = new System.Drawing.Point(-3, -2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1124, 73);
            this.bunifuPanel1.TabIndex = 5;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseDown_1);
            // 
            // lbl_PaidState
            // 
            this.lbl_PaidState.AllowParentOverrides = false;
            this.lbl_PaidState.AutoEllipsis = false;
            this.lbl_PaidState.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_PaidState.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_PaidState.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_PaidState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.lbl_PaidState.Location = new System.Drawing.Point(130, 25);
            this.lbl_PaidState.Name = "lbl_PaidState";
            this.lbl_PaidState.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_PaidState.Size = new System.Drawing.Size(193, 35);
            this.lbl_PaidState.TabIndex = 46;
            this.lbl_PaidState.Text = "Chưa thanh toán";
            this.lbl_PaidState.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_PaidState.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(113, 17);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(9, 45);
            this.bunifuLabel1.TabIndex = 46;
            this.bunifuLabel1.Text = "|";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.btn_exit.Location = new System.Drawing.Point(1052, 11);
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
            this.btn_exit.Size = new System.Drawing.Size(45, 51);
            this.btn_exit.TabIndex = 43;
            this.btn_exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_exit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_exit.TextMarginLeft = 0;
            this.btn_exit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_exit.UseDefaultRadiusAndThickness = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_addRoom
            // 
            this.btn_addRoom.AllowAnimations = true;
            this.btn_addRoom.AllowMouseEffects = true;
            this.btn_addRoom.AllowToggling = false;
            this.btn_addRoom.AnimationSpeed = 200;
            this.btn_addRoom.AutoGenerateColors = false;
            this.btn_addRoom.AutoRoundBorders = false;
            this.btn_addRoom.AutoSizeLeftIcon = true;
            this.btn_addRoom.AutoSizeRightIcon = true;
            this.btn_addRoom.BackColor = System.Drawing.Color.Transparent;
            this.btn_addRoom.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_addRoom.BackgroundImage")));
            this.btn_addRoom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addRoom.ButtonText = "Xuất hoá đơn";
            this.btn_addRoom.ButtonTextMarginLeft = 0;
            this.btn_addRoom.ColorContrastOnClick = 45;
            this.btn_addRoom.ColorContrastOnHover = 45;
            this.btn_addRoom.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_addRoom.CustomizableEdges = borderEdges2;
            this.btn_addRoom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_addRoom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addRoom.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addRoom.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addRoom.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_addRoom.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRoom.ForeColor = System.Drawing.Color.White;
            this.btn_addRoom.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addRoom.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addRoom.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_addRoom.IconMarginLeft = 11;
            this.btn_addRoom.IconPadding = 10;
            this.btn_addRoom.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_addRoom.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_addRoom.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_addRoom.IconSize = 25;
            this.btn_addRoom.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.IdleBorderRadius = 10;
            this.btn_addRoom.IdleBorderThickness = 1;
            this.btn_addRoom.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.IdleIconLeftImage = null;
            this.btn_addRoom.IdleIconRightImage = null;
            this.btn_addRoom.IndicateFocus = false;
            this.btn_addRoom.Location = new System.Drawing.Point(921, 736);
            this.btn_addRoom.Name = "btn_addRoom";
            this.btn_addRoom.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_addRoom.OnDisabledState.BorderRadius = 10;
            this.btn_addRoom.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addRoom.OnDisabledState.BorderThickness = 1;
            this.btn_addRoom.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_addRoom.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_addRoom.OnDisabledState.IconLeftImage = null;
            this.btn_addRoom.OnDisabledState.IconRightImage = null;
            this.btn_addRoom.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addRoom.onHoverState.BorderRadius = 10;
            this.btn_addRoom.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addRoom.onHoverState.BorderThickness = 1;
            this.btn_addRoom.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_addRoom.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addRoom.onHoverState.IconLeftImage = null;
            this.btn_addRoom.onHoverState.IconRightImage = null;
            this.btn_addRoom.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.OnIdleState.BorderRadius = 10;
            this.btn_addRoom.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addRoom.OnIdleState.BorderThickness = 1;
            this.btn_addRoom.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_addRoom.OnIdleState.IconLeftImage = null;
            this.btn_addRoom.OnIdleState.IconRightImage = null;
            this.btn_addRoom.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.OnPressedState.BorderRadius = 10;
            this.btn_addRoom.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_addRoom.OnPressedState.BorderThickness = 1;
            this.btn_addRoom.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_addRoom.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_addRoom.OnPressedState.IconLeftImage = null;
            this.btn_addRoom.OnPressedState.IconRightImage = null;
            this.btn_addRoom.Size = new System.Drawing.Size(163, 50);
            this.btn_addRoom.TabIndex = 40;
            this.btn_addRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_addRoom.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_addRoom.TextMarginLeft = 0;
            this.btn_addRoom.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_addRoom.UseDefaultRadiusAndThickness = true;
            // 
            // cmb_RoomServiceState
            // 
            this.cmb_RoomServiceState.BackColor = System.Drawing.Color.Transparent;
            this.cmb_RoomServiceState.BackgroundColor = System.Drawing.Color.White;
            this.cmb_RoomServiceState.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_RoomServiceState.BorderRadius = 1;
            this.cmb_RoomServiceState.Color = System.Drawing.Color.Transparent;
            this.cmb_RoomServiceState.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_RoomServiceState.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_RoomServiceState.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_RoomServiceState.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_RoomServiceState.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_RoomServiceState.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_RoomServiceState.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_RoomServiceState.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_RoomServiceState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RoomServiceState.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_RoomServiceState.FillDropDown = true;
            this.cmb_RoomServiceState.FillIndicator = false;
            this.cmb_RoomServiceState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_RoomServiceState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RoomServiceState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.cmb_RoomServiceState.FormattingEnabled = true;
            this.cmb_RoomServiceState.Icon = null;
            this.cmb_RoomServiceState.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_RoomServiceState.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_RoomServiceState.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_RoomServiceState.ItemBackColor = System.Drawing.Color.White;
            this.cmb_RoomServiceState.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_RoomServiceState.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.cmb_RoomServiceState.ItemHeight = 40;
            this.cmb_RoomServiceState.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_RoomServiceState.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_RoomServiceState.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cmb_RoomServiceState.ItemTopMargin = 3;
            this.cmb_RoomServiceState.Location = new System.Drawing.Point(36, 740);
            this.cmb_RoomServiceState.Name = "cmb_RoomServiceState";
            this.cmb_RoomServiceState.Size = new System.Drawing.Size(275, 46);
            this.cmb_RoomServiceState.TabIndex = 43;
            this.cmb_RoomServiceState.Text = "Tình trạng thanh toán";
            this.cmb_RoomServiceState.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_RoomServiceState.TextLeftMargin = 5;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel5.Location = new System.Drawing.Point(36, 714);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(142, 20);
            this.bunifuLabel5.TabIndex = 44;
            this.bunifuLabel5.Text = "Tình trạng thanh toán";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btn_UpdateServiceState
            // 
            this.btn_UpdateServiceState.AllowAnimations = true;
            this.btn_UpdateServiceState.AllowMouseEffects = true;
            this.btn_UpdateServiceState.AllowToggling = false;
            this.btn_UpdateServiceState.AnimationSpeed = 200;
            this.btn_UpdateServiceState.AutoGenerateColors = false;
            this.btn_UpdateServiceState.AutoRoundBorders = false;
            this.btn_UpdateServiceState.AutoSizeLeftIcon = true;
            this.btn_UpdateServiceState.AutoSizeRightIcon = true;
            this.btn_UpdateServiceState.BackColor = System.Drawing.Color.Transparent;
            this.btn_UpdateServiceState.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_UpdateServiceState.BackgroundImage")));
            this.btn_UpdateServiceState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_UpdateServiceState.ButtonText = "Cập nhật";
            this.btn_UpdateServiceState.ButtonTextMarginLeft = 0;
            this.btn_UpdateServiceState.ColorContrastOnClick = 45;
            this.btn_UpdateServiceState.ColorContrastOnHover = 45;
            this.btn_UpdateServiceState.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_UpdateServiceState.CustomizableEdges = borderEdges1;
            this.btn_UpdateServiceState.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_UpdateServiceState.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_UpdateServiceState.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_UpdateServiceState.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_UpdateServiceState.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_UpdateServiceState.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateServiceState.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateServiceState.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_UpdateServiceState.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_UpdateServiceState.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_UpdateServiceState.IconMarginLeft = 11;
            this.btn_UpdateServiceState.IconPadding = 10;
            this.btn_UpdateServiceState.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_UpdateServiceState.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_UpdateServiceState.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_UpdateServiceState.IconSize = 25;
            this.btn_UpdateServiceState.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.IdleBorderRadius = 10;
            this.btn_UpdateServiceState.IdleBorderThickness = 1;
            this.btn_UpdateServiceState.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.IdleIconLeftImage = null;
            this.btn_UpdateServiceState.IdleIconRightImage = null;
            this.btn_UpdateServiceState.IndicateFocus = false;
            this.btn_UpdateServiceState.Location = new System.Drawing.Point(423, 736);
            this.btn_UpdateServiceState.Name = "btn_UpdateServiceState";
            this.btn_UpdateServiceState.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_UpdateServiceState.OnDisabledState.BorderRadius = 10;
            this.btn_UpdateServiceState.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_UpdateServiceState.OnDisabledState.BorderThickness = 1;
            this.btn_UpdateServiceState.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_UpdateServiceState.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_UpdateServiceState.OnDisabledState.IconLeftImage = null;
            this.btn_UpdateServiceState.OnDisabledState.IconRightImage = null;
            this.btn_UpdateServiceState.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_UpdateServiceState.onHoverState.BorderRadius = 10;
            this.btn_UpdateServiceState.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_UpdateServiceState.onHoverState.BorderThickness = 1;
            this.btn_UpdateServiceState.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btn_UpdateServiceState.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateServiceState.onHoverState.IconLeftImage = null;
            this.btn_UpdateServiceState.onHoverState.IconRightImage = null;
            this.btn_UpdateServiceState.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.OnIdleState.BorderRadius = 10;
            this.btn_UpdateServiceState.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_UpdateServiceState.OnIdleState.BorderThickness = 1;
            this.btn_UpdateServiceState.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateServiceState.OnIdleState.IconLeftImage = null;
            this.btn_UpdateServiceState.OnIdleState.IconRightImage = null;
            this.btn_UpdateServiceState.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.OnPressedState.BorderRadius = 10;
            this.btn_UpdateServiceState.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_UpdateServiceState.OnPressedState.BorderThickness = 1;
            this.btn_UpdateServiceState.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(97)))), ((int)(((byte)(242)))));
            this.btn_UpdateServiceState.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateServiceState.OnPressedState.IconLeftImage = null;
            this.btn_UpdateServiceState.OnPressedState.IconRightImage = null;
            this.btn_UpdateServiceState.Size = new System.Drawing.Size(135, 50);
            this.btn_UpdateServiceState.TabIndex = 45;
            this.btn_UpdateServiceState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_UpdateServiceState.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_UpdateServiceState.TextMarginLeft = 0;
            this.btn_UpdateServiceState.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_UpdateServiceState.UseDefaultRadiusAndThickness = true;
            this.btn_UpdateServiceState.Click += new System.EventHandler(this.btn_UpdateServiceState_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.White;
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 3;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.lbl_ServiceTotal);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel12);
            this.bunifuPanel2.Controls.Add(this.lbl_ServiceCleaning);
            this.bunifuPanel2.Controls.Add(this.lbl_ServiceInternet);
            this.bunifuPanel2.Controls.Add(this.lbl_ServiceWater);
            this.bunifuPanel2.Controls.Add(this.lbl_ServiceElectricity);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel7);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel6);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel4);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel3);
            this.bunifuPanel2.Controls.Add(this.bunifuLabel2);
            this.bunifuPanel2.Location = new System.Drawing.Point(589, 273);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(495, 425);
            this.bunifuPanel2.TabIndex = 46;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(198, 26);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(141, 41);
            this.bunifuLabel2.TabIndex = 47;
            this.bunifuLabel2.Text = "HOÁ ĐƠN";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 25;
            this.bunifuElipse3.TargetControl = this.bunifuPanel2;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 5;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel3.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.bunifuLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel3.Location = new System.Drawing.Point(51, 97);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(105, 31);
            this.bunifuLabel3.TabIndex = 48;
            this.bunifuLabel3.Text = "Tiền điện :";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.bunifuLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel4.Location = new System.Drawing.Point(51, 151);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(112, 31);
            this.bunifuLabel4.TabIndex = 49;
            this.bunifuLabel4.Text = "Tiền nước :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel6.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.bunifuLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel6.Location = new System.Drawing.Point(51, 204);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(140, 31);
            this.bunifuLabel6.TabIndex = 50;
            this.bunifuLabel6.Text = "Tiền internet :";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AllowParentOverrides = false;
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel7.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.bunifuLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.bunifuLabel7.Location = new System.Drawing.Point(51, 256);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(131, 31);
            this.bunifuLabel7.TabIndex = 51;
            this.bunifuLabel7.Text = "Tiền vệ sinh :";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel7.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ServiceElectricity
            // 
            this.lbl_ServiceElectricity.AllowParentOverrides = false;
            this.lbl_ServiceElectricity.AutoEllipsis = false;
            this.lbl_ServiceElectricity.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceElectricity.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceElectricity.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_ServiceElectricity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_ServiceElectricity.Location = new System.Drawing.Point(230, 97);
            this.lbl_ServiceElectricity.Name = "lbl_ServiceElectricity";
            this.lbl_ServiceElectricity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceElectricity.Size = new System.Drawing.Size(86, 31);
            this.lbl_ServiceElectricity.TabIndex = 52;
            this.lbl_ServiceElectricity.Text = "100000đ";
            this.lbl_ServiceElectricity.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ServiceElectricity.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ServiceWater
            // 
            this.lbl_ServiceWater.AllowParentOverrides = false;
            this.lbl_ServiceWater.AutoEllipsis = false;
            this.lbl_ServiceWater.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceWater.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceWater.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_ServiceWater.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_ServiceWater.Location = new System.Drawing.Point(230, 151);
            this.lbl_ServiceWater.Name = "lbl_ServiceWater";
            this.lbl_ServiceWater.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceWater.Size = new System.Drawing.Size(86, 31);
            this.lbl_ServiceWater.TabIndex = 53;
            this.lbl_ServiceWater.Text = "100000đ";
            this.lbl_ServiceWater.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ServiceWater.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ServiceInternet
            // 
            this.lbl_ServiceInternet.AllowParentOverrides = false;
            this.lbl_ServiceInternet.AutoEllipsis = false;
            this.lbl_ServiceInternet.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceInternet.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceInternet.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_ServiceInternet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_ServiceInternet.Location = new System.Drawing.Point(230, 204);
            this.lbl_ServiceInternet.Name = "lbl_ServiceInternet";
            this.lbl_ServiceInternet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceInternet.Size = new System.Drawing.Size(86, 31);
            this.lbl_ServiceInternet.TabIndex = 54;
            this.lbl_ServiceInternet.Text = "100000đ";
            this.lbl_ServiceInternet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ServiceInternet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ServiceCleaning
            // 
            this.lbl_ServiceCleaning.AllowParentOverrides = false;
            this.lbl_ServiceCleaning.AutoEllipsis = false;
            this.lbl_ServiceCleaning.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceCleaning.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceCleaning.Font = new System.Drawing.Font("Segoe UI", 13.8F);
            this.lbl_ServiceCleaning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.lbl_ServiceCleaning.Location = new System.Drawing.Point(230, 256);
            this.lbl_ServiceCleaning.Name = "lbl_ServiceCleaning";
            this.lbl_ServiceCleaning.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceCleaning.Size = new System.Drawing.Size(86, 31);
            this.lbl_ServiceCleaning.TabIndex = 55;
            this.lbl_ServiceCleaning.Text = "100000đ";
            this.lbl_ServiceCleaning.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ServiceCleaning.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel12
            // 
            this.bunifuLabel12.AllowParentOverrides = false;
            this.bunifuLabel12.AutoEllipsis = false;
            this.bunifuLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel12.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.bunifuLabel12.Location = new System.Drawing.Point(191, 360);
            this.bunifuLabel12.Name = "bunifuLabel12";
            this.bunifuLabel12.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel12.Size = new System.Drawing.Size(131, 37);
            this.bunifuLabel12.TabIndex = 56;
            this.bunifuLabel12.Text = "Tổng tiền :";
            this.bunifuLabel12.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel12.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lbl_ServiceTotal
            // 
            this.lbl_ServiceTotal.AllowParentOverrides = false;
            this.lbl_ServiceTotal.AutoEllipsis = false;
            this.lbl_ServiceTotal.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceTotal.CursorType = System.Windows.Forms.Cursors.Default;
            this.lbl_ServiceTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold);
            this.lbl_ServiceTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(89)))), ((int)(((byte)(98)))));
            this.lbl_ServiceTotal.Location = new System.Drawing.Point(336, 360);
            this.lbl_ServiceTotal.Name = "lbl_ServiceTotal";
            this.lbl_ServiceTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_ServiceTotal.Size = new System.Drawing.Size(132, 37);
            this.lbl_ServiceTotal.TabIndex = 57;
            this.lbl_ServiceTotal.Text = "10000000đ";
            this.lbl_ServiceTotal.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lbl_ServiceTotal.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cardShowInfo_Total
            // 
            this.cardShowInfo_Total.BackColor = System.Drawing.Color.White;
            this.cardShowInfo_Total.Location = new System.Drawing.Point(770, 90);
            this.cardShowInfo_Total.Money = "";
            this.cardShowInfo_Total.Name = "cardShowInfo_Total";
            this.cardShowInfo_Total.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo_Total.TabIndex = 3;
            this.cardShowInfo_Total.TextLabel = null;
            // 
            // cardShowInfo_Water
            // 
            this.cardShowInfo_Water.BackColor = System.Drawing.Color.White;
            this.cardShowInfo_Water.Location = new System.Drawing.Point(404, 90);
            this.cardShowInfo_Water.Money = "";
            this.cardShowInfo_Water.Name = "cardShowInfo_Water";
            this.cardShowInfo_Water.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo_Water.TabIndex = 2;
            this.cardShowInfo_Water.TextLabel = null;
            // 
            // cardShowInfo_Electricity
            // 
            this.cardShowInfo_Electricity.BackColor = System.Drawing.Color.White;
            this.cardShowInfo_Electricity.Location = new System.Drawing.Point(36, 90);
            this.cardShowInfo_Electricity.Money = "";
            this.cardShowInfo_Electricity.Name = "cardShowInfo_Electricity";
            this.cardShowInfo_Electricity.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo_Electricity.TabIndex = 1;
            this.cardShowInfo_Electricity.TextLabel = null;
            // 
            // RoomStudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1120, 808);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.btn_UpdateServiceState);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.cmb_RoomServiceState);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.cardShowInfo_Total);
            this.Controls.Add(this.dgv_Students);
            this.Controls.Add(this.cardShowInfo_Water);
            this.Controls.Add(this.cardShowInfo_Electricity);
            this.Controls.Add(this.lbl_RoomID);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomStudentManager";
            this.Text = "RoomStudentManager";
            this.Load += new System.EventHandler(this.RoomStudentManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private cardShowInfo cardShowInfo_Total;
        private cardShowInfo cardShowInfo_Water;
        private cardShowInfo cardShowInfo_Electricity;
        private Bunifu.UI.WinForms.BunifuLabel lbl_RoomID;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Students;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_addRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_RoomServiceState;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_UpdateServiceState;
        private Bunifu.UI.WinForms.BunifuLabel lbl_PaidState;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ServiceTotal;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel12;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ServiceCleaning;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ServiceInternet;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ServiceWater;
        private Bunifu.UI.WinForms.BunifuLabel lbl_ServiceElectricity;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
    }
}