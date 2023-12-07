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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomStudentManager));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.lbl_RoomID = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgv_Students = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.btn_exit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cardShowInfo3 = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo2 = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowInfo1 = new DORMITORY_MANAGEMENT.cardShowInfo();
            this.cardShowOverview1 = new DORMITORY_MANAGEMENT.cardShowOverview();
            this.btn_addRoom = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.cmb_RoomStatus = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
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
            this.bunifuPanel1.Controls.Add(this.btn_exit);
            this.bunifuPanel1.Location = new System.Drawing.Point(-3, -2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1124, 73);
            this.bunifuPanel1.TabIndex = 5;
            this.bunifuPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bunifuPanel1_MouseDown_1);
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
            // cardShowInfo3
            // 
            this.cardShowInfo3.BackColor = System.Drawing.Color.White;
            this.cardShowInfo3.Location = new System.Drawing.Point(770, 90);
            this.cardShowInfo3.Money = 0;
            this.cardShowInfo3.Name = "cardShowInfo3";
            this.cardShowInfo3.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo3.TabIndex = 3;
            this.cardShowInfo3.TextLabel = null;
            // 
            // cardShowInfo2
            // 
            this.cardShowInfo2.BackColor = System.Drawing.Color.White;
            this.cardShowInfo2.Location = new System.Drawing.Point(404, 90);
            this.cardShowInfo2.Money = 0;
            this.cardShowInfo2.Name = "cardShowInfo2";
            this.cardShowInfo2.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo2.TabIndex = 2;
            this.cardShowInfo2.TextLabel = null;
            // 
            // cardShowInfo1
            // 
            this.cardShowInfo1.BackColor = System.Drawing.Color.White;
            this.cardShowInfo1.Location = new System.Drawing.Point(36, 90);
            this.cardShowInfo1.Money = 0;
            this.cardShowInfo1.Name = "cardShowInfo1";
            this.cardShowInfo1.Size = new System.Drawing.Size(314, 144);
            this.cardShowInfo1.TabIndex = 1;
            this.cardShowInfo1.TextLabel = null;
            // 
            // cardShowOverview1
            // 
            this.cardShowOverview1.BackColor = System.Drawing.Color.White;
            this.cardShowOverview1.Location = new System.Drawing.Point(618, 273);
            this.cardShowOverview1.Name = "cardShowOverview1";
            this.cardShowOverview1.NameCard = null;
            this.cardShowOverview1.NameMainValue = null;
            this.cardShowOverview1.NameSubValue = null;
            this.cardShowOverview1.ProgressValue = 0;
            this.cardShowOverview1.Size = new System.Drawing.Size(466, 425);
            this.cardShowOverview1.SubValue = 0;
            this.cardShowOverview1.TabIndex = 6;
            this.cardShowOverview1.Total = 0;
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
            // cmb_RoomStatus
            // 
            this.cmb_RoomStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmb_RoomStatus.BackgroundColor = System.Drawing.Color.White;
            this.cmb_RoomStatus.BorderColor = System.Drawing.Color.Transparent;
            this.cmb_RoomStatus.BorderRadius = 1;
            this.cmb_RoomStatus.Color = System.Drawing.Color.Transparent;
            this.cmb_RoomStatus.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cmb_RoomStatus.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_RoomStatus.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cmb_RoomStatus.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cmb_RoomStatus.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cmb_RoomStatus.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cmb_RoomStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmb_RoomStatus.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cmb_RoomStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_RoomStatus.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_RoomStatus.FillDropDown = true;
            this.cmb_RoomStatus.FillIndicator = false;
            this.cmb_RoomStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_RoomStatus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_RoomStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.cmb_RoomStatus.FormattingEnabled = true;
            this.cmb_RoomStatus.Icon = null;
            this.cmb_RoomStatus.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_RoomStatus.IndicatorColor = System.Drawing.Color.Gray;
            this.cmb_RoomStatus.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cmb_RoomStatus.ItemBackColor = System.Drawing.Color.White;
            this.cmb_RoomStatus.ItemBorderColor = System.Drawing.Color.White;
            this.cmb_RoomStatus.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(54)))), ((int)(((byte)(116)))));
            this.cmb_RoomStatus.ItemHeight = 40;
            this.cmb_RoomStatus.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.cmb_RoomStatus.ItemHighLightForeColor = System.Drawing.Color.White;
            this.cmb_RoomStatus.Items.AddRange(new object[] {
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cmb_RoomStatus.ItemTopMargin = 3;
            this.cmb_RoomStatus.Location = new System.Drawing.Point(36, 740);
            this.cmb_RoomStatus.Name = "cmb_RoomStatus";
            this.cmb_RoomStatus.Size = new System.Drawing.Size(275, 46);
            this.cmb_RoomStatus.TabIndex = 43;
            this.cmb_RoomStatus.Text = "Tình trạng thanh toán";
            this.cmb_RoomStatus.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_RoomStatus.TextLeftMargin = 5;
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
            this.bunifuButton1.ButtonText = "Cập nhật";
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
            this.bunifuButton1.Location = new System.Drawing.Point(423, 736);
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
            this.bunifuButton1.Size = new System.Drawing.Size(135, 50);
            this.bunifuButton1.TabIndex = 45;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            // 
            // RoomStudentManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1120, 808);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.cmb_RoomStatus);
            this.Controls.Add(this.btn_addRoom);
            this.Controls.Add(this.cardShowOverview1);
            this.Controls.Add(this.cardShowInfo3);
            this.Controls.Add(this.dgv_Students);
            this.Controls.Add(this.cardShowInfo2);
            this.Controls.Add(this.cardShowInfo1);
            this.Controls.Add(this.lbl_RoomID);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomStudentManager";
            this.Text = "RoomStudentManager";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Students)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private cardShowInfo cardShowInfo3;
        private cardShowInfo cardShowInfo2;
        private cardShowInfo cardShowInfo1;
        private Bunifu.UI.WinForms.BunifuLabel lbl_RoomID;
        private Bunifu.UI.WinForms.BunifuDataGridView dgv_Students;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_exit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private cardShowOverview cardShowOverview1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_addRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_RoomStatus;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}