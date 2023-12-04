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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.txt_inputAddress = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_login = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_clearSelected = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.cmb_typeOfRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.cmb_stateRoom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
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
            this.bunifuPanel1.Controls.Add(this.txt_inputAddress);
            this.bunifuPanel1.Controls.Add(this.bunifuButton1);
            this.bunifuPanel1.Controls.Add(this.btn_login);
            this.bunifuPanel1.Controls.Add(this.btn_clearSelected);
            this.bunifuPanel1.Controls.Add(this.cmb_typeOfRoom);
            this.bunifuPanel1.Controls.Add(this.cmb_stateRoom);
            this.bunifuPanel1.Controls.Add(this.bunifuLabel1);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1138, 214);
            this.bunifuPanel1.TabIndex = 1;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // txt_inputAddress
            // 
            this.txt_inputAddress.AcceptsReturn = false;
            this.txt_inputAddress.AcceptsTab = false;
            this.txt_inputAddress.AnimationSpeed = 200;
            this.txt_inputAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txt_inputAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txt_inputAddress.BackColor = System.Drawing.Color.Transparent;
            this.txt_inputAddress.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txt_inputAddress.BackgroundImage")));
            this.txt_inputAddress.BorderColorActive = System.Drawing.Color.White;
            this.txt_inputAddress.BorderColorDisabled = System.Drawing.Color.White;
            this.txt_inputAddress.BorderColorHover = System.Drawing.Color.White;
            this.txt_inputAddress.BorderColorIdle = System.Drawing.Color.White;
            this.txt_inputAddress.BorderRadius = 10;
            this.txt_inputAddress.BorderThickness = 1;
            this.txt_inputAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txt_inputAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_inputAddress.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txt_inputAddress.DefaultText = "";
            this.txt_inputAddress.FillColor = System.Drawing.Color.White;
            this.txt_inputAddress.HideSelection = true;
            this.txt_inputAddress.IconLeft = null;
            this.txt_inputAddress.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_inputAddress.IconPadding = 10;
            this.txt_inputAddress.IconRight = null;
            this.txt_inputAddress.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_inputAddress.Lines = new string[0];
            this.txt_inputAddress.Location = new System.Drawing.Point(39, 143);
            this.txt_inputAddress.MaxLength = 32767;
            this.txt_inputAddress.MinimumSize = new System.Drawing.Size(1, 1);
            this.txt_inputAddress.Modified = false;
            this.txt_inputAddress.Multiline = false;
            this.txt_inputAddress.Name = "txt_inputAddress";
            stateProperties9.BorderColor = System.Drawing.Color.White;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_inputAddress.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.White;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txt_inputAddress.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.White;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_inputAddress.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.White;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txt_inputAddress.OnIdleState = stateProperties12;
            this.txt_inputAddress.Padding = new System.Windows.Forms.Padding(3);
            this.txt_inputAddress.PasswordChar = '\0';
            this.txt_inputAddress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(85)))), ((int)(((byte)(90)))));
            this.txt_inputAddress.PlaceholderText = "Mã phòng";
            this.txt_inputAddress.ReadOnly = false;
            this.txt_inputAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_inputAddress.SelectedText = "";
            this.txt_inputAddress.SelectionLength = 0;
            this.txt_inputAddress.SelectionStart = 0;
            this.txt_inputAddress.ShortcutsEnabled = true;
            this.txt_inputAddress.Size = new System.Drawing.Size(350, 50);
            this.txt_inputAddress.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txt_inputAddress.TabIndex = 36;
            this.txt_inputAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_inputAddress.TextMarginBottom = 0;
            this.txt_inputAddress.TextMarginLeft = 10;
            this.txt_inputAddress.TextMarginTop = 0;
            this.txt_inputAddress.TextPlaceholder = "Mã phòng";
            this.txt_inputAddress.UseSystemPasswordChar = false;
            this.txt_inputAddress.WordWrap = true;
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
            this.bunifuButton1.ButtonText = "Quản lý phòng";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges5;
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
            this.bunifuButton1.Location = new System.Drawing.Point(909, 143);
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
            this.bunifuButton1.Size = new System.Drawing.Size(190, 50);
            this.bunifuButton1.TabIndex = 35;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
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
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btn_login.CustomizableEdges = borderEdges6;
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
            this.btn_login.Location = new System.Drawing.Point(687, 143);
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
            // btn_clearSelected
            // 
            this.btn_clearSelected.AllowFocused = false;
            this.btn_clearSelected.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_clearSelected.AutoSizeHeight = true;
            this.btn_clearSelected.BorderRadius = 17;
            this.btn_clearSelected.Image = ((System.Drawing.Image)(resources.GetObject("btn_clearSelected.Image")));
            this.btn_clearSelected.IsCircle = true;
            this.btn_clearSelected.Location = new System.Drawing.Point(1062, 74);
            this.btn_clearSelected.Name = "btn_clearSelected";
            this.btn_clearSelected.Size = new System.Drawing.Size(34, 34);
            this.btn_clearSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_clearSelected.TabIndex = 33;
            this.btn_clearSelected.TabStop = false;
            this.btn_clearSelected.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btn_clearSelected.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
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
            "Phòng thường",
            "Phòng VIP"});
            this.cmb_typeOfRoom.ItemTopMargin = 3;
            this.cmb_typeOfRoom.Location = new System.Drawing.Point(687, 67);
            this.cmb_typeOfRoom.Name = "cmb_typeOfRoom";
            this.cmb_typeOfRoom.Size = new System.Drawing.Size(350, 46);
            this.cmb_typeOfRoom.TabIndex = 32;
            this.cmb_typeOfRoom.Text = "Loại phòng";
            this.cmb_typeOfRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_typeOfRoom.TextLeftMargin = 5;
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
            this.cmb_stateRoom.Location = new System.Drawing.Point(39, 67);
            this.cmb_stateRoom.Name = "cmb_stateRoom";
            this.cmb_stateRoom.Size = new System.Drawing.Size(350, 46);
            this.cmb_stateRoom.TabIndex = 30;
            this.cmb_stateRoom.Text = "Trạng thái";
            this.cmb_stateRoom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cmb_stateRoom.TextLeftMargin = 5;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(254)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(39, 220);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1060, 580);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // ManageRoomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.bunifuPanel1);
            this.Name = "ManageRoomControl";
            this.Size = new System.Drawing.Size(1138, 800);
            this.Load += new System.EventHandler(this.ManageRoomControl_Load);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_clearSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_stateRoom;
        private Bunifu.UI.WinForms.BunifuDropdown cmb_typeOfRoom;
        private Bunifu.UI.WinForms.BunifuPictureBox btn_clearSelected;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_login;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextBox txt_inputAddress;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}
