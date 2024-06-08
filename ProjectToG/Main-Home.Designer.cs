namespace ProjectToG
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Utilities.BunifuPages.BunifuAnimatorNS.Animation animation1 = new Utilities.BunifuPages.BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_area3D = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.btn_area2D = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.formulaItem1 = new ProjectToG.FormulaItem();
            this.area_parallelogram1 = new ProjectToG.area_parallelogram();
            this.area_square1 = new ProjectToG.area_square();
            this.area_rectangle1 = new ProjectToG.area_rectangle();
            this.area_trapezoid1 = new ProjectToG.area_trapezoid();
            this.area_rhombus1 = new ProjectToG.area_rhombus();
            this.area_tangle1 = new ProjectToG.area_tangle();
            this.area_circle1 = new ProjectToG.area_circle();
            this.area_kite1 = new ProjectToG.area_kite();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pages = new Bunifu.UI.WinForms.BunifuPages();
            this.bunifuButton21 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.flowLayout.SuspendLayout();
            this.pages.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_area3D);
            this.panel1.Controls.Add(this.btn_area2D);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 597);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(69, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Volume\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins ExtraBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.label2.Location = new System.Drawing.Point(49, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 48);
            this.label2.TabIndex = 5;
            this.label2.Text = "Calculator\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_area3D
            // 
            this.btn_area3D.AllowAnimations = true;
            this.btn_area3D.AllowMouseEffects = true;
            this.btn_area3D.AllowToggling = false;
            this.btn_area3D.AnimationSpeed = 200;
            this.btn_area3D.AutoGenerateColors = false;
            this.btn_area3D.AutoRoundBorders = false;
            this.btn_area3D.AutoSizeLeftIcon = true;
            this.btn_area3D.AutoSizeRightIcon = true;
            this.btn_area3D.BackColor = System.Drawing.Color.Transparent;
            this.btn_area3D.BackColor1 = System.Drawing.Color.Empty;
            this.btn_area3D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_area3D.BackgroundImage")));
            this.btn_area3D.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area3D.ButtonText = "Volume of 3D Shapes";
            this.btn_area3D.ButtonTextMarginLeft = 0;
            this.btn_area3D.ColorContrastOnClick = 45;
            this.btn_area3D.ColorContrastOnHover = 45;
            this.btn_area3D.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btn_area3D.CustomizableEdges = borderEdges1;
            this.btn_area3D.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_area3D.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_area3D.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_area3D.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_area3D.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_area3D.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_area3D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area3D.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_area3D.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_area3D.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_area3D.IconMarginLeft = 11;
            this.btn_area3D.IconPadding = 10;
            this.btn_area3D.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_area3D.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_area3D.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_area3D.IconSize = 25;
            this.btn_area3D.IdleBorderColor = System.Drawing.Color.Orange;
            this.btn_area3D.IdleBorderRadius = 20;
            this.btn_area3D.IdleBorderThickness = 1;
            this.btn_area3D.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_area3D.IdleIconLeftImage = null;
            this.btn_area3D.IdleIconRightImage = null;
            this.btn_area3D.IndicateFocus = false;
            this.btn_area3D.Location = new System.Drawing.Point(40, 212);
            this.btn_area3D.Name = "btn_area3D";
            this.btn_area3D.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_area3D.OnDisabledState.BorderRadius = 20;
            this.btn_area3D.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area3D.OnDisabledState.BorderThickness = 1;
            this.btn_area3D.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_area3D.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_area3D.OnDisabledState.IconLeftImage = null;
            this.btn_area3D.OnDisabledState.IconRightImage = null;
            this.btn_area3D.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_area3D.onHoverState.BorderRadius = 20;
            this.btn_area3D.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area3D.onHoverState.BorderThickness = 1;
            this.btn_area3D.onHoverState.FillColor = System.Drawing.Color.Empty;
            this.btn_area3D.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area3D.onHoverState.IconLeftImage = null;
            this.btn_area3D.onHoverState.IconRightImage = null;
            this.btn_area3D.OnIdleState.BorderColor = System.Drawing.Color.Orange;
            this.btn_area3D.OnIdleState.BorderRadius = 20;
            this.btn_area3D.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area3D.OnIdleState.BorderThickness = 1;
            this.btn_area3D.OnIdleState.FillColor = System.Drawing.Color.Empty;
            this.btn_area3D.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area3D.OnIdleState.IconLeftImage = null;
            this.btn_area3D.OnIdleState.IconRightImage = null;
            this.btn_area3D.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_area3D.OnPressedState.BorderRadius = 20;
            this.btn_area3D.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area3D.OnPressedState.BorderThickness = 1;
            this.btn_area3D.OnPressedState.FillColor = System.Drawing.Color.Empty;
            this.btn_area3D.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_area3D.OnPressedState.IconLeftImage = null;
            this.btn_area3D.OnPressedState.IconRightImage = null;
            this.btn_area3D.Size = new System.Drawing.Size(181, 40);
            this.btn_area3D.TabIndex = 4;
            this.btn_area3D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_area3D.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_area3D.TextMarginLeft = 0;
            this.btn_area3D.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_area3D.UseDefaultRadiusAndThickness = true;
            this.btn_area3D.Click += new System.EventHandler(this.btn_area3D_Click);
            // 
            // btn_area2D
            // 
            this.btn_area2D.AllowAnimations = true;
            this.btn_area2D.AllowMouseEffects = true;
            this.btn_area2D.AllowToggling = false;
            this.btn_area2D.AnimationSpeed = 200;
            this.btn_area2D.AutoGenerateColors = false;
            this.btn_area2D.AutoRoundBorders = false;
            this.btn_area2D.AutoSizeLeftIcon = true;
            this.btn_area2D.AutoSizeRightIcon = true;
            this.btn_area2D.BackColor = System.Drawing.Color.Transparent;
            this.btn_area2D.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_area2D.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_area2D.BackgroundImage")));
            this.btn_area2D.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area2D.ButtonText = "Area of 2D Shapes";
            this.btn_area2D.ButtonTextMarginLeft = 0;
            this.btn_area2D.ColorContrastOnClick = 45;
            this.btn_area2D.ColorContrastOnHover = 45;
            this.btn_area2D.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_area2D.CustomizableEdges = borderEdges2;
            this.btn_area2D.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_area2D.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_area2D.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_area2D.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_area2D.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btn_area2D.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_area2D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area2D.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_area2D.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_area2D.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_area2D.IconMarginLeft = 11;
            this.btn_area2D.IconPadding = 10;
            this.btn_area2D.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_area2D.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_area2D.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_area2D.IconSize = 25;
            this.btn_area2D.IdleBorderColor = System.Drawing.Color.Orange;
            this.btn_area2D.IdleBorderRadius = 20;
            this.btn_area2D.IdleBorderThickness = 1;
            this.btn_area2D.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_area2D.IdleIconLeftImage = null;
            this.btn_area2D.IdleIconRightImage = null;
            this.btn_area2D.IndicateFocus = false;
            this.btn_area2D.Location = new System.Drawing.Point(40, 147);
            this.btn_area2D.Name = "btn_area2D";
            this.btn_area2D.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_area2D.OnDisabledState.BorderRadius = 20;
            this.btn_area2D.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area2D.OnDisabledState.BorderThickness = 1;
            this.btn_area2D.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_area2D.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_area2D.OnDisabledState.IconLeftImage = null;
            this.btn_area2D.OnDisabledState.IconRightImage = null;
            this.btn_area2D.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btn_area2D.onHoverState.BorderRadius = 20;
            this.btn_area2D.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area2D.onHoverState.BorderThickness = 1;
            this.btn_area2D.onHoverState.FillColor = System.Drawing.Color.Empty;
            this.btn_area2D.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area2D.onHoverState.IconLeftImage = null;
            this.btn_area2D.onHoverState.IconRightImage = null;
            this.btn_area2D.OnIdleState.BorderColor = System.Drawing.Color.Orange;
            this.btn_area2D.OnIdleState.BorderRadius = 20;
            this.btn_area2D.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area2D.OnIdleState.BorderThickness = 1;
            this.btn_area2D.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_area2D.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btn_area2D.OnIdleState.IconLeftImage = null;
            this.btn_area2D.OnIdleState.IconRightImage = null;
            this.btn_area2D.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.btn_area2D.OnPressedState.BorderRadius = 20;
            this.btn_area2D.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btn_area2D.OnPressedState.BorderThickness = 1;
            this.btn_area2D.OnPressedState.FillColor = System.Drawing.Color.Empty;
            this.btn_area2D.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_area2D.OnPressedState.IconLeftImage = null;
            this.btn_area2D.OnPressedState.IconRightImage = null;
            this.btn_area2D.Size = new System.Drawing.Size(181, 41);
            this.btn_area2D.TabIndex = 1;
            this.btn_area2D.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_area2D.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_area2D.TextMarginLeft = 0;
            this.btn_area2D.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_area2D.UseDefaultRadiusAndThickness = true;
            this.btn_area2D.Click += new System.EventHandler(this.btn_area2D_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(847, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Vol 3D";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.tabPage1.Controls.Add(this.bunifuButton21);
            this.tabPage1.Controls.Add(this.flowLayout);
            this.tabPage1.Controls.Add(this.bunifuTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Area 2D";
            // 
            // flowLayout
            // 
            this.flowLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayout.AutoScroll = true;
            this.flowLayout.Controls.Add(this.formulaItem1);
            this.flowLayout.Controls.Add(this.area_parallelogram1);
            this.flowLayout.Controls.Add(this.area_square1);
            this.flowLayout.Controls.Add(this.area_rectangle1);
            this.flowLayout.Controls.Add(this.area_trapezoid1);
            this.flowLayout.Controls.Add(this.area_rhombus1);
            this.flowLayout.Controls.Add(this.area_tangle1);
            this.flowLayout.Controls.Add(this.area_circle1);
            this.flowLayout.Controls.Add(this.area_kite1);
            this.flowLayout.Location = new System.Drawing.Point(19, 85);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(820, 480);
            this.flowLayout.TabIndex = 2;
            // 
            // formulaItem1
            // 
            this.formulaItem1.AllowAnimations = false;
            this.formulaItem1.AllowBorderColorChanges = false;
            this.formulaItem1.AllowMouseEffects = false;
            this.formulaItem1.AnimationSpeed = 200;
            this.formulaItem1.BackColor = System.Drawing.Color.Transparent;
            this.formulaItem1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.formulaItem1.BorderColor = System.Drawing.Color.Gainsboro;
            this.formulaItem1.BorderRadius = 5;
            this.formulaItem1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.formulaItem1.BorderThickness = 1;
            this.formulaItem1.ColorContrastOnClick = 30;
            this.formulaItem1.ColorContrastOnHover = 30;
            this.formulaItem1.Cursor = System.Windows.Forms.Cursors.Default;
            this.formulaItem1.Image = null;
            this.formulaItem1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.formulaItem1.Location = new System.Drawing.Point(3, 3);
            this.formulaItem1.Name = "formulaItem1";
            this.formulaItem1.ShowBorders = true;
            this.formulaItem1.Size = new System.Drawing.Size(250, 222);
            this.formulaItem1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.formulaItem1.TabIndex = 0;
            // 
            // area_parallelogram1
            // 
            this.area_parallelogram1.AllowAnimations = false;
            this.area_parallelogram1.AllowBorderColorChanges = false;
            this.area_parallelogram1.AllowMouseEffects = false;
            this.area_parallelogram1.AnimationSpeed = 200;
            this.area_parallelogram1.BackColor = System.Drawing.Color.Transparent;
            this.area_parallelogram1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_parallelogram1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_parallelogram1.BorderRadius = 5;
            this.area_parallelogram1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_parallelogram1.BorderThickness = 1;
            this.area_parallelogram1.ColorContrastOnClick = 30;
            this.area_parallelogram1.ColorContrastOnHover = 30;
            this.area_parallelogram1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_parallelogram1.Image = null;
            this.area_parallelogram1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_parallelogram1.Location = new System.Drawing.Point(259, 3);
            this.area_parallelogram1.Name = "area_parallelogram1";
            this.area_parallelogram1.ShowBorders = true;
            this.area_parallelogram1.Size = new System.Drawing.Size(273, 222);
            this.area_parallelogram1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_parallelogram1.TabIndex = 1;
            // 
            // area_square1
            // 
            this.area_square1.AllowAnimations = false;
            this.area_square1.AllowBorderColorChanges = false;
            this.area_square1.AllowMouseEffects = false;
            this.area_square1.AnimationSpeed = 200;
            this.area_square1.BackColor = System.Drawing.Color.Transparent;
            this.area_square1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_square1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_square1.BorderRadius = 5;
            this.area_square1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_square1.BorderThickness = 1;
            this.area_square1.ColorContrastOnClick = 30;
            this.area_square1.ColorContrastOnHover = 30;
            this.area_square1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_square1.Image = null;
            this.area_square1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_square1.Location = new System.Drawing.Point(538, 3);
            this.area_square1.Name = "area_square1";
            this.area_square1.ShowBorders = true;
            this.area_square1.Size = new System.Drawing.Size(259, 222);
            this.area_square1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_square1.TabIndex = 2;
            // 
            // area_rectangle1
            // 
            this.area_rectangle1.AllowAnimations = false;
            this.area_rectangle1.AllowBorderColorChanges = false;
            this.area_rectangle1.AllowMouseEffects = false;
            this.area_rectangle1.AnimationSpeed = 200;
            this.area_rectangle1.BackColor = System.Drawing.Color.Transparent;
            this.area_rectangle1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_rectangle1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_rectangle1.BorderRadius = 5;
            this.area_rectangle1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_rectangle1.BorderThickness = 1;
            this.area_rectangle1.ColorContrastOnClick = 30;
            this.area_rectangle1.ColorContrastOnHover = 30;
            this.area_rectangle1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_rectangle1.Image = null;
            this.area_rectangle1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_rectangle1.Location = new System.Drawing.Point(3, 231);
            this.area_rectangle1.Name = "area_rectangle1";
            this.area_rectangle1.ShowBorders = true;
            this.area_rectangle1.Size = new System.Drawing.Size(250, 220);
            this.area_rectangle1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_rectangle1.TabIndex = 3;
            // 
            // area_trapezoid1
            // 
            this.area_trapezoid1.AllowAnimations = false;
            this.area_trapezoid1.AllowBorderColorChanges = false;
            this.area_trapezoid1.AllowMouseEffects = false;
            this.area_trapezoid1.AnimationSpeed = 200;
            this.area_trapezoid1.BackColor = System.Drawing.Color.Transparent;
            this.area_trapezoid1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_trapezoid1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_trapezoid1.BorderRadius = 5;
            this.area_trapezoid1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_trapezoid1.BorderThickness = 1;
            this.area_trapezoid1.ColorContrastOnClick = 30;
            this.area_trapezoid1.ColorContrastOnHover = 30;
            this.area_trapezoid1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_trapezoid1.Image = null;
            this.area_trapezoid1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_trapezoid1.Location = new System.Drawing.Point(259, 231);
            this.area_trapezoid1.Name = "area_trapezoid1";
            this.area_trapezoid1.ShowBorders = true;
            this.area_trapezoid1.Size = new System.Drawing.Size(273, 220);
            this.area_trapezoid1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_trapezoid1.TabIndex = 4;
            // 
            // area_rhombus1
            // 
            this.area_rhombus1.AllowAnimations = false;
            this.area_rhombus1.AllowBorderColorChanges = false;
            this.area_rhombus1.AllowMouseEffects = false;
            this.area_rhombus1.AnimationSpeed = 200;
            this.area_rhombus1.BackColor = System.Drawing.Color.Transparent;
            this.area_rhombus1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_rhombus1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_rhombus1.BorderRadius = 5;
            this.area_rhombus1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_rhombus1.BorderThickness = 1;
            this.area_rhombus1.ColorContrastOnClick = 30;
            this.area_rhombus1.ColorContrastOnHover = 30;
            this.area_rhombus1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_rhombus1.Image = null;
            this.area_rhombus1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_rhombus1.Location = new System.Drawing.Point(538, 231);
            this.area_rhombus1.Name = "area_rhombus1";
            this.area_rhombus1.ShowBorders = true;
            this.area_rhombus1.Size = new System.Drawing.Size(259, 220);
            this.area_rhombus1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_rhombus1.TabIndex = 5;
            // 
            // area_tangle1
            // 
            this.area_tangle1.AllowAnimations = false;
            this.area_tangle1.AllowBorderColorChanges = false;
            this.area_tangle1.AllowMouseEffects = false;
            this.area_tangle1.AnimationSpeed = 200;
            this.area_tangle1.BackColor = System.Drawing.Color.Transparent;
            this.area_tangle1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_tangle1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_tangle1.BorderRadius = 1;
            this.area_tangle1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_tangle1.BorderThickness = 1;
            this.area_tangle1.ColorContrastOnClick = 30;
            this.area_tangle1.ColorContrastOnHover = 30;
            this.area_tangle1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_tangle1.Image = null;
            this.area_tangle1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_tangle1.Location = new System.Drawing.Point(3, 457);
            this.area_tangle1.Name = "area_tangle1";
            this.area_tangle1.ShowBorders = true;
            this.area_tangle1.Size = new System.Drawing.Size(250, 221);
            this.area_tangle1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_tangle1.TabIndex = 8;
            // 
            // area_circle1
            // 
            this.area_circle1.AllowAnimations = false;
            this.area_circle1.AllowBorderColorChanges = false;
            this.area_circle1.AllowMouseEffects = false;
            this.area_circle1.AnimationSpeed = 200;
            this.area_circle1.BackColor = System.Drawing.Color.Transparent;
            this.area_circle1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_circle1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_circle1.BorderRadius = 5;
            this.area_circle1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_circle1.BorderThickness = 1;
            this.area_circle1.ColorContrastOnClick = 30;
            this.area_circle1.ColorContrastOnHover = 30;
            this.area_circle1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_circle1.Image = null;
            this.area_circle1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_circle1.Location = new System.Drawing.Point(259, 457);
            this.area_circle1.Name = "area_circle1";
            this.area_circle1.ShowBorders = true;
            this.area_circle1.Size = new System.Drawing.Size(273, 221);
            this.area_circle1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_circle1.TabIndex = 7;
            // 
            // area_kite1
            // 
            this.area_kite1.AllowAnimations = false;
            this.area_kite1.AllowBorderColorChanges = false;
            this.area_kite1.AllowMouseEffects = false;
            this.area_kite1.AnimationSpeed = 200;
            this.area_kite1.BackColor = System.Drawing.Color.Transparent;
            this.area_kite1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.area_kite1.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.area_kite1.BorderRadius = 5;
            this.area_kite1.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.area_kite1.BorderThickness = 1;
            this.area_kite1.ColorContrastOnClick = 30;
            this.area_kite1.ColorContrastOnHover = 30;
            this.area_kite1.Cursor = System.Windows.Forms.Cursors.Default;
            this.area_kite1.Image = null;
            this.area_kite1.ImageMargin = new System.Windows.Forms.Padding(0);
            this.area_kite1.Location = new System.Drawing.Point(538, 457);
            this.area_kite1.Name = "area_kite1";
            this.area_kite1.ShowBorders = true;
            this.area_kite1.Size = new System.Drawing.Size(259, 221);
            this.area_kite1.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.area_kite1.TabIndex = 6;
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AnimationSpeed = 200;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.AutoSizeHeight = true;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.WhiteSmoke;
            this.bunifuTextBox1.BorderRadius = 25;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCase = Bunifu.UI.WinForms.BunifuTextBox.CharacterCases.Normal;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = null;
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTextBox1.Lines = new string[0];
            this.bunifuTextBox1.Location = new System.Drawing.Point(27, 15);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Multiline = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.bunifuTextBox1.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.WhiteSmoke;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.bunifuTextBox1.OnIdleState = stateProperties4;
            this.bunifuTextBox1.Padding = new System.Windows.Forms.Padding(3);
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.bunifuTextBox1.PlaceholderText = "Enter text";
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(311, 40);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 1;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginBottom = 0;
            this.bunifuTextBox1.TextMarginLeft = 10;
            this.bunifuTextBox1.TextMarginTop = 0;
            this.bunifuTextBox1.TextPlaceholder = "Enter text";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            this.bunifuTextBox1.WordWrap = true;
            // 
            // pages
            // 
            this.pages.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.pages.AllowTransitions = false;
            this.pages.Controls.Add(this.tabPage1);
            this.pages.Controls.Add(this.tabPage4);
            this.pages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pages.Location = new System.Drawing.Point(255, 0);
            this.pages.Multiline = true;
            this.pages.Name = "pages";
            this.pages.Page = this.tabPage1;
            this.pages.PageIndex = 0;
            this.pages.PageName = "tabPage1";
            this.pages.PageTitle = "Area 2D";
            this.pages.SelectedIndex = 0;
            this.pages.Size = new System.Drawing.Size(855, 597);
            this.pages.TabIndex = 1;
            animation1.AnimateOnlyDifferences = false;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.pages.Transition = animation1;
            this.pages.TransitionType = Utilities.BunifuPages.BunifuAnimatorNS.AnimationType.Custom;
            // 
            // bunifuButton21
            // 
            this.bunifuButton21.AllowAnimations = true;
            this.bunifuButton21.AllowMouseEffects = true;
            this.bunifuButton21.AllowToggling = false;
            this.bunifuButton21.AnimationSpeed = 200;
            this.bunifuButton21.AutoGenerateColors = false;
            this.bunifuButton21.AutoRoundBorders = false;
            this.bunifuButton21.AutoSizeLeftIcon = true;
            this.bunifuButton21.AutoSizeRightIcon = true;
            this.bunifuButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton21.BackColor1 = System.Drawing.Color.Empty;
            this.bunifuButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton21.BackgroundImage")));
            this.bunifuButton21.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.ButtonText = "Exit";
            this.bunifuButton21.ButtonTextMarginLeft = 0;
            this.bunifuButton21.ColorContrastOnClick = 45;
            this.bunifuButton21.ColorContrastOnHover = 45;
            this.bunifuButton21.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton21.CustomizableEdges = borderEdges3;
            this.bunifuButton21.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton21.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.bunifuButton21.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuButton21.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton21.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton21.IconMarginLeft = 11;
            this.bunifuButton21.IconPadding = 10;
            this.bunifuButton21.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton21.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton21.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton21.IconSize = 25;
            this.bunifuButton21.IdleBorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton21.IdleBorderRadius = 20;
            this.bunifuButton21.IdleBorderThickness = 1;
            this.bunifuButton21.IdleFillColor = System.Drawing.Color.Empty;
            this.bunifuButton21.IdleIconLeftImage = null;
            this.bunifuButton21.IdleIconRightImage = null;
            this.bunifuButton21.IndicateFocus = false;
            this.bunifuButton21.Location = new System.Drawing.Point(744, 24);
            this.bunifuButton21.Name = "bunifuButton21";
            this.bunifuButton21.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton21.OnDisabledState.BorderRadius = 20;
            this.bunifuButton21.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnDisabledState.BorderThickness = 1;
            this.bunifuButton21.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton21.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton21.OnDisabledState.IconLeftImage = null;
            this.bunifuButton21.OnDisabledState.IconRightImage = null;
            this.bunifuButton21.onHoverState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton21.onHoverState.BorderRadius = 20;
            this.bunifuButton21.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.onHoverState.BorderThickness = 1;
            this.bunifuButton21.onHoverState.FillColor = System.Drawing.Color.Empty;
            this.bunifuButton21.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuButton21.onHoverState.IconLeftImage = null;
            this.bunifuButton21.onHoverState.IconRightImage = null;
            this.bunifuButton21.OnIdleState.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuButton21.OnIdleState.BorderRadius = 20;
            this.bunifuButton21.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnIdleState.BorderThickness = 1;
            this.bunifuButton21.OnIdleState.FillColor = System.Drawing.Color.Empty;
            this.bunifuButton21.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.bunifuButton21.OnIdleState.IconLeftImage = null;
            this.bunifuButton21.OnIdleState.IconRightImage = null;
            this.bunifuButton21.OnPressedState.BorderColor = System.Drawing.Color.White;
            this.bunifuButton21.OnPressedState.BorderRadius = 20;
            this.bunifuButton21.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.bunifuButton21.OnPressedState.BorderThickness = 1;
            this.bunifuButton21.OnPressedState.FillColor = System.Drawing.Color.Empty;
            this.bunifuButton21.OnPressedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuButton21.OnPressedState.IconLeftImage = null;
            this.bunifuButton21.OnPressedState.IconRightImage = null;
            this.bunifuButton21.Size = new System.Drawing.Size(74, 28);
            this.bunifuButton21.TabIndex = 6;
            this.bunifuButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton21.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton21.TextMarginLeft = 0;
            this.bunifuButton21.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton21.UseDefaultRadiusAndThickness = true;
            this.bunifuButton21.Click += new System.EventHandler(this.bunifuButton21_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1110, 597);
            this.Controls.Add(this.pages);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Calculator_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.flowLayout.ResumeLayout(false);
            this.pages.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_area2D;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn_area3D;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private FormulaItem formulaItem1;
        private area_parallelogram area_parallelogram1;
        private area_square area_square1;
        private area_rectangle area_rectangle1;
        private area_trapezoid area_trapezoid1;
        private area_rhombus area_rhombus1;
        private area_tangle area_tangle1;
        private area_circle area_circle1;
        private area_kite area_kite1;
        private Bunifu.UI.WinForms.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuPages pages;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 bunifuButton21;
    }
}

