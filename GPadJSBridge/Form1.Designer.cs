namespace GPadJSBridge
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose( bool disposing )
    {
      if ( disposing && ( components != null ) ) {
        components.Dispose( );
      }
      base.Dispose( disposing );
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent( )
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel1 = new System.Windows.Forms.Panel();
      this.linkLblReleases = new System.Windows.Forms.LinkLabel();
      this.label8 = new System.Windows.Forms.Label();
      this.lblTitle = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.tc1 = new System.Windows.Forms.TabControl();
      this.tabJS1 = new System.Windows.Forms.TabPage();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tlpGrid = new System.Windows.Forms.TableLayoutPanel();
      this.lbInX = new System.Windows.Forms.Label();
      this.lbInY = new System.Windows.Forms.Label();
      this.lbInZ = new System.Windows.Forms.Label();
      this.lbInXr = new System.Windows.Forms.Label();
      this.lbInYr = new System.Windows.Forms.Label();
      this.lbInZr = new System.Windows.Forms.Label();
      this.lbInS1 = new System.Windows.Forms.Label();
      this.lbInS2 = new System.Windows.Forms.Label();
      this.lbInP1 = new System.Windows.Forms.Label();
      this.lbInP2 = new System.Windows.Forms.Label();
      this.lbInP3 = new System.Windows.Forms.Label();
      this.lbInP4 = new System.Windows.Forms.Label();
      this.lbOutX = new System.Windows.Forms.Label();
      this.lbOutY = new System.Windows.Forms.Label();
      this.lbOutZ = new System.Windows.Forms.Label();
      this.lbOutXr = new System.Windows.Forms.Label();
      this.lbOutYr = new System.Windows.Forms.Label();
      this.lbOutZr = new System.Windows.Forms.Label();
      this.lbOutS1 = new System.Windows.Forms.Label();
      this.lbOutS2 = new System.Windows.Forms.Label();
      this.lbOutP1 = new System.Windows.Forms.Label();
      this.lbOutP2 = new System.Windows.Forms.Label();
      this.lbOutP3 = new System.Windows.Forms.Label();
      this.lbOutP4 = new System.Windows.Forms.Label();
      this.lbInBt = new System.Windows.Forms.Label();
      this.lbOutBt = new System.Windows.Forms.Label();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btBStart = new System.Windows.Forms.Button();
      this.btBStop = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.buttonExit = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
      this.timer2 = new System.Windows.Forms.Timer(this.components);
      this.lblFrom = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblDevReport = new System.Windows.Forms.Label();
      this.lblDevice = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.lblvJoyDriver = new System.Windows.Forms.Label();
      this.UC_JoyPanel = new GPadJSBridge.UC_JoyPanel();
      this.label7 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.tc1.SuspendLayout();
      this.tabJS1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tlpGrid.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tc1, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 400F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 559);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel1
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.panel1, 2);
      this.panel1.Controls.Add(this.linkLblReleases);
      this.panel1.Controls.Add(this.label8);
      this.panel1.Controls.Add(this.lblTitle);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(3, 3);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(699, 66);
      this.panel1.TabIndex = 17;
      // 
      // linkLblReleases
      // 
      this.linkLblReleases.AutoSize = true;
      this.linkLblReleases.Location = new System.Drawing.Point(430, 42);
      this.linkLblReleases.Name = "linkLblReleases";
      this.linkLblReleases.Size = new System.Drawing.Size(259, 13);
      this.linkLblReleases.TabIndex = 3;
      this.linkLblReleases.TabStop = true;
      this.linkLblReleases.Text = "For information and updates visit us @ Github ...";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(353, 42);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(58, 13);
      this.label8.TabIndex = 2;
      this.label8.Text = "by Cassini";
      // 
      // lblTitle
      // 
      this.lblTitle.AutoSize = true;
      this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.Location = new System.Drawing.Point(226, 8);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(249, 25);
      this.lblTitle.TabIndex = 1;
      this.lblTitle.Text = "Gamepad - Joystick Bridge";
      // 
      // label4
      // 
      this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
      this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Location = new System.Drawing.Point(0, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(220, 66);
      this.label4.TabIndex = 0;
      // 
      // tc1
      // 
      this.tc1.Controls.Add(this.tabJS1);
      this.tc1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
      this.tc1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.tc1.HotTrack = true;
      this.tc1.ItemSize = new System.Drawing.Size(62, 20);
      this.tc1.Location = new System.Drawing.Point(3, 78);
      this.tc1.Multiline = true;
      this.tc1.Name = "tc1";
      this.tc1.SelectedIndex = 0;
      this.tc1.Size = new System.Drawing.Size(289, 344);
      this.tc1.TabIndex = 16;
      this.tc1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tc1_DrawItem);
      this.tc1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tc1_Selected);
      // 
      // tabJS1
      // 
      this.tabJS1.Controls.Add(this.UC_JoyPanel);
      this.tabJS1.Location = new System.Drawing.Point(4, 24);
      this.tabJS1.Name = "tabJS1";
      this.tabJS1.Padding = new System.Windows.Forms.Padding(3);
      this.tabJS1.Size = new System.Drawing.Size(281, 316);
      this.tabJS1.TabIndex = 0;
      this.tabJS1.Text = "Joystick 1";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tlpGrid);
      this.panel2.Controls.Add(this.lblDevice);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(303, 78);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(399, 394);
      this.panel2.TabIndex = 19;
      // 
      // tlpGrid
      // 
      this.tlpGrid.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
      this.tlpGrid.ColumnCount = 14;
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
      this.tlpGrid.Controls.Add(this.lbInX, 0, 1);
      this.tlpGrid.Controls.Add(this.label7, 0, 0);
      this.tlpGrid.Controls.Add(this.lbInY, 0, 2);
      this.tlpGrid.Controls.Add(this.lbInZ, 0, 3);
      this.tlpGrid.Controls.Add(this.lbInXr, 0, 4);
      this.tlpGrid.Controls.Add(this.lbInYr, 0, 5);
      this.tlpGrid.Controls.Add(this.lbInZr, 0, 6);
      this.tlpGrid.Controls.Add(this.lbInS1, 0, 7);
      this.tlpGrid.Controls.Add(this.lbInS2, 0, 8);
      this.tlpGrid.Controls.Add(this.lbInP1, 0, 9);
      this.tlpGrid.Controls.Add(this.lbInP2, 0, 10);
      this.tlpGrid.Controls.Add(this.lbInP3, 0, 11);
      this.tlpGrid.Controls.Add(this.lbInP4, 0, 12);
      this.tlpGrid.Controls.Add(this.lbOutX, 1, 0);
      this.tlpGrid.Controls.Add(this.lbOutY, 2, 0);
      this.tlpGrid.Controls.Add(this.lbOutZ, 3, 0);
      this.tlpGrid.Controls.Add(this.lbOutXr, 4, 0);
      this.tlpGrid.Controls.Add(this.lbOutYr, 5, 0);
      this.tlpGrid.Controls.Add(this.lbOutZr, 6, 0);
      this.tlpGrid.Controls.Add(this.lbOutS1, 7, 0);
      this.tlpGrid.Controls.Add(this.lbOutS2, 8, 0);
      this.tlpGrid.Controls.Add(this.lbOutP1, 9, 0);
      this.tlpGrid.Controls.Add(this.lbOutP2, 10, 0);
      this.tlpGrid.Controls.Add(this.lbOutP3, 11, 0);
      this.tlpGrid.Controls.Add(this.lbOutP4, 12, 0);
      this.tlpGrid.Controls.Add(this.lbInBt, 0, 13);
      this.tlpGrid.Controls.Add(this.lbOutBt, 13, 0);
      this.tlpGrid.Location = new System.Drawing.Point(3, 3);
      this.tlpGrid.Name = "tlpGrid";
      this.tlpGrid.RowCount = 14;
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpGrid.Size = new System.Drawing.Size(355, 355);
      this.tlpGrid.TabIndex = 0;
      // 
      // lbInX
      // 
      this.lbInX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInX.AutoSize = true;
      this.lbInX.Location = new System.Drawing.Point(4, 82);
      this.lbInX.Name = "lbInX";
      this.lbInX.Size = new System.Drawing.Size(36, 20);
      this.lbInX.TabIndex = 0;
      this.lbInX.Text = "X Axis";
      this.lbInX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInY
      // 
      this.lbInY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInY.AutoSize = true;
      this.lbInY.Location = new System.Drawing.Point(4, 103);
      this.lbInY.Name = "lbInY";
      this.lbInY.Size = new System.Drawing.Size(35, 20);
      this.lbInY.TabIndex = 0;
      this.lbInY.Text = "Y Axis";
      this.lbInY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInZ
      // 
      this.lbInZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInZ.AutoSize = true;
      this.lbInZ.Location = new System.Drawing.Point(4, 124);
      this.lbInZ.Name = "lbInZ";
      this.lbInZ.Size = new System.Drawing.Size(36, 20);
      this.lbInZ.TabIndex = 0;
      this.lbInZ.Text = "Z Axis";
      this.lbInZ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInXr
      // 
      this.lbInXr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInXr.AutoSize = true;
      this.lbInXr.Location = new System.Drawing.Point(4, 145);
      this.lbInXr.Name = "lbInXr";
      this.lbInXr.Size = new System.Drawing.Size(40, 20);
      this.lbInXr.TabIndex = 0;
      this.lbInXr.Text = "rX Axis";
      this.lbInXr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInYr
      // 
      this.lbInYr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInYr.AutoSize = true;
      this.lbInYr.Location = new System.Drawing.Point(4, 166);
      this.lbInYr.Name = "lbInYr";
      this.lbInYr.Size = new System.Drawing.Size(39, 20);
      this.lbInYr.TabIndex = 0;
      this.lbInYr.Text = "rY Axis";
      this.lbInYr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInZr
      // 
      this.lbInZr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInZr.AutoSize = true;
      this.lbInZr.Location = new System.Drawing.Point(4, 187);
      this.lbInZr.Name = "lbInZr";
      this.lbInZr.Size = new System.Drawing.Size(40, 20);
      this.lbInZr.TabIndex = 0;
      this.lbInZr.Text = "rZ Axis";
      this.lbInZr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInS1
      // 
      this.lbInS1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInS1.AutoSize = true;
      this.lbInS1.Location = new System.Drawing.Point(4, 208);
      this.lbInS1.Name = "lbInS1";
      this.lbInS1.Size = new System.Drawing.Size(19, 20);
      this.lbInS1.TabIndex = 0;
      this.lbInS1.Text = "S1";
      this.lbInS1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInS2
      // 
      this.lbInS2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInS2.AutoSize = true;
      this.lbInS2.Location = new System.Drawing.Point(4, 229);
      this.lbInS2.Name = "lbInS2";
      this.lbInS2.Size = new System.Drawing.Size(19, 20);
      this.lbInS2.TabIndex = 0;
      this.lbInS2.Text = "S2";
      this.lbInS2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInP1
      // 
      this.lbInP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInP1.AutoSize = true;
      this.lbInP1.Location = new System.Drawing.Point(4, 250);
      this.lbInP1.Name = "lbInP1";
      this.lbInP1.Size = new System.Drawing.Size(38, 20);
      this.lbInP1.TabIndex = 0;
      this.lbInP1.Text = "POV 1";
      this.lbInP1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInP2
      // 
      this.lbInP2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInP2.AutoSize = true;
      this.lbInP2.Location = new System.Drawing.Point(4, 271);
      this.lbInP2.Name = "lbInP2";
      this.lbInP2.Size = new System.Drawing.Size(38, 20);
      this.lbInP2.TabIndex = 0;
      this.lbInP2.Text = "POV 2";
      this.lbInP2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInP3
      // 
      this.lbInP3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInP3.AutoSize = true;
      this.lbInP3.Location = new System.Drawing.Point(4, 292);
      this.lbInP3.Name = "lbInP3";
      this.lbInP3.Size = new System.Drawing.Size(38, 20);
      this.lbInP3.TabIndex = 0;
      this.lbInP3.Text = "POV 3";
      this.lbInP3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbInP4
      // 
      this.lbInP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInP4.AutoSize = true;
      this.lbInP4.Location = new System.Drawing.Point(4, 313);
      this.lbInP4.Name = "lbInP4";
      this.lbInP4.Size = new System.Drawing.Size(38, 20);
      this.lbInP4.TabIndex = 0;
      this.lbInP4.Text = "POV 4";
      this.lbInP4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbOutX
      // 
      this.lbOutX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutX.AutoSize = true;
      this.lbOutX.Location = new System.Drawing.Point(85, 1);
      this.lbOutX.Name = "lbOutX";
      this.lbOutX.Size = new System.Drawing.Size(14, 65);
      this.lbOutX.TabIndex = 0;
      this.lbOutX.Text = "X Axis";
      this.lbOutX.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutY
      // 
      this.lbOutY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutY.AutoSize = true;
      this.lbOutY.Location = new System.Drawing.Point(106, 1);
      this.lbOutY.Name = "lbOutY";
      this.lbOutY.Size = new System.Drawing.Size(14, 65);
      this.lbOutY.TabIndex = 0;
      this.lbOutY.Text = "Y Axis";
      this.lbOutY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutZ
      // 
      this.lbOutZ.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutZ.AutoSize = true;
      this.lbOutZ.Location = new System.Drawing.Point(127, 1);
      this.lbOutZ.Name = "lbOutZ";
      this.lbOutZ.Size = new System.Drawing.Size(14, 65);
      this.lbOutZ.TabIndex = 0;
      this.lbOutZ.Text = "Z Axis";
      this.lbOutZ.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutXr
      // 
      this.lbOutXr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutXr.AutoSize = true;
      this.lbOutXr.Location = new System.Drawing.Point(148, 1);
      this.lbOutXr.Name = "lbOutXr";
      this.lbOutXr.Size = new System.Drawing.Size(14, 78);
      this.lbOutXr.TabIndex = 0;
      this.lbOutXr.Text = "rX Axis";
      this.lbOutXr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutYr
      // 
      this.lbOutYr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutYr.AutoSize = true;
      this.lbOutYr.Location = new System.Drawing.Point(169, 1);
      this.lbOutYr.Name = "lbOutYr";
      this.lbOutYr.Size = new System.Drawing.Size(14, 78);
      this.lbOutYr.TabIndex = 0;
      this.lbOutYr.Text = "rY Axis";
      this.lbOutYr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutZr
      // 
      this.lbOutZr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutZr.AutoSize = true;
      this.lbOutZr.Location = new System.Drawing.Point(190, 1);
      this.lbOutZr.Name = "lbOutZr";
      this.lbOutZr.Size = new System.Drawing.Size(14, 78);
      this.lbOutZr.TabIndex = 0;
      this.lbOutZr.Text = "rZ Axis";
      this.lbOutZr.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutS1
      // 
      this.lbOutS1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutS1.AutoSize = true;
      this.lbOutS1.Location = new System.Drawing.Point(211, 1);
      this.lbOutS1.Name = "lbOutS1";
      this.lbOutS1.Size = new System.Drawing.Size(14, 26);
      this.lbOutS1.TabIndex = 0;
      this.lbOutS1.Text = "S1";
      this.lbOutS1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutS2
      // 
      this.lbOutS2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutS2.AutoSize = true;
      this.lbOutS2.Location = new System.Drawing.Point(232, 1);
      this.lbOutS2.Name = "lbOutS2";
      this.lbOutS2.Size = new System.Drawing.Size(14, 26);
      this.lbOutS2.TabIndex = 0;
      this.lbOutS2.Text = "S2";
      this.lbOutS2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutP1
      // 
      this.lbOutP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutP1.AutoSize = true;
      this.lbOutP1.Location = new System.Drawing.Point(253, 1);
      this.lbOutP1.Name = "lbOutP1";
      this.lbOutP1.Size = new System.Drawing.Size(14, 52);
      this.lbOutP1.TabIndex = 0;
      this.lbOutP1.Text = "POV 1";
      this.lbOutP1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutP2
      // 
      this.lbOutP2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutP2.AutoSize = true;
      this.lbOutP2.Location = new System.Drawing.Point(274, 1);
      this.lbOutP2.Name = "lbOutP2";
      this.lbOutP2.Size = new System.Drawing.Size(14, 52);
      this.lbOutP2.TabIndex = 0;
      this.lbOutP2.Text = "POV 2";
      this.lbOutP2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutP3
      // 
      this.lbOutP3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutP3.AutoSize = true;
      this.lbOutP3.Location = new System.Drawing.Point(295, 1);
      this.lbOutP3.Name = "lbOutP3";
      this.lbOutP3.Size = new System.Drawing.Size(14, 52);
      this.lbOutP3.TabIndex = 0;
      this.lbOutP3.Text = "POV 3";
      this.lbOutP3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbOutP4
      // 
      this.lbOutP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lbOutP4.AutoSize = true;
      this.lbOutP4.Location = new System.Drawing.Point(316, 1);
      this.lbOutP4.Name = "lbOutP4";
      this.lbOutP4.Size = new System.Drawing.Size(14, 52);
      this.lbOutP4.TabIndex = 0;
      this.lbOutP4.Text = "POV 4";
      this.lbOutP4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // lbInBt
      // 
      this.lbInBt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.lbInBt.AutoSize = true;
      this.lbInBt.Location = new System.Drawing.Point(4, 334);
      this.lbInBt.Name = "lbInBt";
      this.lbInBt.Size = new System.Drawing.Size(42, 20);
      this.lbInBt.TabIndex = 1;
      this.lbInBt.Text = "#B 000";
      this.lbInBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lbOutBt
      // 
      this.lbOutBt.Location = new System.Drawing.Point(337, 1);
      this.lbOutBt.Name = "lbOutBt";
      this.lbOutBt.Size = new System.Drawing.Size(16, 78);
      this.lbOutBt.TabIndex = 0;
      this.lbOutBt.Text = "#B 000";
      this.lbOutBt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Controls.Add(this.btBStart, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.btBStop, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
      this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 478);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 2;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(294, 78);
      this.tableLayoutPanel2.TabIndex = 18;
      // 
      // btBStart
      // 
      this.btBStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btBStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBStart.BackgroundImage")));
      this.btBStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btBStart.Location = new System.Drawing.Point(3, 3);
      this.btBStart.Name = "btBStart";
      this.btBStart.Size = new System.Drawing.Size(141, 38);
      this.btBStart.TabIndex = 17;
      this.btBStart.UseVisualStyleBackColor = true;
      this.btBStart.Click += new System.EventHandler(this.btBStart_Click);
      // 
      // btBStop
      // 
      this.btBStop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btBStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btBStop.BackgroundImage")));
      this.btBStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
      this.btBStop.Location = new System.Drawing.Point(150, 3);
      this.btBStop.Name = "btBStop";
      this.btBStop.Size = new System.Drawing.Size(141, 38);
      this.btBStop.TabIndex = 17;
      this.btBStop.UseVisualStyleBackColor = true;
      this.btBStop.Click += new System.EventHandler(this.btBStop_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 54);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 18;
      this.label3.Text = "Start bridge";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(150, 54);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Stop bridge";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.lblDevReport);
      this.panel3.Controls.Add(this.lblvJoyDriver);
      this.panel3.Controls.Add(this.lblFrom);
      this.panel3.Controls.Add(this.buttonExit);
      this.panel3.Controls.Add(this.label2);
      this.panel3.Controls.Add(this.label6);
      this.panel3.Controls.Add(this.label1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(303, 478);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(399, 78);
      this.panel3.TabIndex = 20;
      // 
      // buttonExit
      // 
      this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.buttonExit.Location = new System.Drawing.Point(332, 51);
      this.buttonExit.Name = "buttonExit";
      this.buttonExit.Size = new System.Drawing.Size(64, 24);
      this.buttonExit.TabIndex = 14;
      this.buttonExit.Text = "Exit";
      this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(7, 38);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(71, 13);
      this.label1.TabIndex = 16;
      this.label1.Text = "Bridge from:";
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // timer2
      // 
      this.timer2.Interval = 20;
      this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
      // 
      // lblFrom
      // 
      this.lblFrom.AutoSize = true;
      this.lblFrom.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblFrom.Location = new System.Drawing.Point(121, 38);
      this.lblFrom.Name = "lblFrom";
      this.lblFrom.Size = new System.Drawing.Size(58, 13);
      this.lblFrom.TabIndex = 17;
      this.lblFrom.Text = "not active";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(7, 60);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(98, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Device reporting :";
      // 
      // lblDevReport
      // 
      this.lblDevReport.AutoSize = true;
      this.lblDevReport.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDevReport.Location = new System.Drawing.Point(121, 60);
      this.lblDevReport.Name = "lblDevReport";
      this.lblDevReport.Size = new System.Drawing.Size(22, 13);
      this.lblDevReport.TabIndex = 17;
      this.lblDevReport.Text = "off";
      // 
      // lblDevice
      // 
      this.lblDevice.AutoSize = true;
      this.lblDevice.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDevice.Location = new System.Drawing.Point(7, 372);
      this.lblDevice.Name = "lblDevice";
      this.lblDevice.Size = new System.Drawing.Size(13, 13);
      this.lblDevice.TabIndex = 17;
      this.lblDevice.Text = "..";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(7, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 13);
      this.label6.TabIndex = 16;
      this.label6.Text = "vJoy Driver:";
      // 
      // lblvJoyDriver
      // 
      this.lblvJoyDriver.AutoSize = true;
      this.lblvJoyDriver.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblvJoyDriver.Location = new System.Drawing.Point(121, 16);
      this.lblvJoyDriver.Name = "lblvJoyDriver";
      this.lblvJoyDriver.Size = new System.Drawing.Size(58, 13);
      this.lblvJoyDriver.TabIndex = 17;
      this.lblvJoyDriver.Text = "not active";
      // 
      // UC_JoyPanel
      // 
      this.UC_JoyPanel.Caption = "Device Capabilities";
      this.UC_JoyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.UC_JoyPanel.H1e = false;
      this.UC_JoyPanel.H2e = false;
      this.UC_JoyPanel.H3e = false;
      this.UC_JoyPanel.H4e = false;
      this.UC_JoyPanel.JsAssignment = 0;
      this.UC_JoyPanel.Location = new System.Drawing.Point(3, 3);
      this.UC_JoyPanel.Name = "UC_JoyPanel";
      this.UC_JoyPanel.S1e = false;
      this.UC_JoyPanel.S2e = false;
      this.UC_JoyPanel.Size = new System.Drawing.Size(275, 310);
      this.UC_JoyPanel.TabIndex = 0;
      this.UC_JoyPanel.Xe = false;
      this.UC_JoyPanel.Xre = false;
      this.UC_JoyPanel.Ye = false;
      this.UC_JoyPanel.Yre = false;
      this.UC_JoyPanel.Ze = false;
      this.UC_JoyPanel.Zre = false;
      // 
      // label7
      // 
      this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(47, 1);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(31, 13);
      this.label7.TabIndex = 17;
      this.label7.Text = "vJoy";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(705, 559);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "MainForm";
      this.Text = "Gamepad - Joystick Bridge";
      this.Activated += new System.EventHandler(this.MainForm_Activated);
      this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.tc1.ResumeLayout(false);
      this.tabJS1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.tlpGrid.ResumeLayout(false);
      this.tlpGrid.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TabControl tc1;
    private System.Windows.Forms.TabPage tabJS1;
    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.LinkLabel linkLblReleases;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ToolTip toolTip1;
    private UC_JoyPanel UC_JoyPanel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Button buttonExit;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tlpGrid;
    private System.Windows.Forms.Label lbInX;
    private System.Windows.Forms.Label lbInY;
    private System.Windows.Forms.Label lbInZ;
    private System.Windows.Forms.Label lbInXr;
    private System.Windows.Forms.Label lbInYr;
    private System.Windows.Forms.Label lbInZr;
    private System.Windows.Forms.Label lbInS1;
    private System.Windows.Forms.Label lbInS2;
    private System.Windows.Forms.Label lbInP1;
    private System.Windows.Forms.Label lbInP2;
    private System.Windows.Forms.Label lbInP3;
    private System.Windows.Forms.Label lbInP4;
    private System.Windows.Forms.Label lbOutX;
    private System.Windows.Forms.Label lbOutY;
    private System.Windows.Forms.Label lbOutZ;
    private System.Windows.Forms.Label lbOutXr;
    private System.Windows.Forms.Label lbOutYr;
    private System.Windows.Forms.Label lbOutZr;
    private System.Windows.Forms.Label lbOutS1;
    private System.Windows.Forms.Label lbOutS2;
    private System.Windows.Forms.Label lbOutP1;
    private System.Windows.Forms.Label lbOutP2;
    private System.Windows.Forms.Label lbOutP3;
    private System.Windows.Forms.Label lbOutP4;
    private System.Windows.Forms.Label lbInBt;
    private System.Windows.Forms.Label lbOutBt;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btBStart;
    private System.Windows.Forms.Button btBStop;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Timer timer2;
    private System.Windows.Forms.Label lblFrom;
    private System.Windows.Forms.Label lblDevReport;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblDevice;
    private System.Windows.Forms.Label lblvJoyDriver;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
  }
}

