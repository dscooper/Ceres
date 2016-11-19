namespace Ceres
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.MainMenu = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.MainStatus = new System.Windows.Forms.StatusStrip();
      this.programStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.serialPortStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.MainToolBar = new System.Windows.Forms.ToolStrip();
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.serialPanel = new System.Windows.Forms.Panel();
      this.serialPortGroupBox = new System.Windows.Forms.GroupBox();
      this.handshakeComboBox = new System.Windows.Forms.ComboBox();
      this.handshakeLabel = new System.Windows.Forms.Label();
      this.parityComboBox = new System.Windows.Forms.ComboBox();
      this.parityLabel = new System.Windows.Forms.Label();
      this.stopBitsComboBox = new System.Windows.Forms.ComboBox();
      this.stopBitsLabel = new System.Windows.Forms.Label();
      this.dataBitsComboBox = new System.Windows.Forms.ComboBox();
      this.dataBitsLabel = new System.Windows.Forms.Label();
      this.baudRateComboBox = new System.Windows.Forms.ComboBox();
      this.baudRateLabel = new System.Windows.Forms.Label();
      this.serialPortComboBox = new System.Windows.Forms.ComboBox();
      this.serialPortLabel = new System.Windows.Forms.Label();
      this.ioPanel = new System.Windows.Forms.Panel();
      this.ioSplitContainer = new System.Windows.Forms.SplitContainer();
      this.sendGroupBox = new System.Windows.Forms.GroupBox();
      this.receiveGroupBox = new System.Windows.Forms.GroupBox();
      this.receiveTextBox = new System.Windows.Forms.TextBox();
      this.MainMenu.SuspendLayout();
      this.MainStatus.SuspendLayout();
      this.MainToolBar.SuspendLayout();
      this.serialPortGroupBox.SuspendLayout();
      this.ioPanel.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.ioSplitContainer)).BeginInit();
      this.ioSplitContainer.Panel1.SuspendLayout();
      this.ioSplitContainer.Panel2.SuspendLayout();
      this.ioSplitContainer.SuspendLayout();
      this.receiveGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // MainMenu
      // 
      this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.MainMenu.Location = new System.Drawing.Point(0, 0);
      this.MainMenu.Name = "MainMenu";
      this.MainMenu.Size = new System.Drawing.Size(884, 24);
      this.MainMenu.TabIndex = 0;
      this.MainMenu.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // newToolStripMenuItem
      // 
      this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.newToolStripMenuItem.Name = "newToolStripMenuItem";
      this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.newToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.newToolStripMenuItem.Text = "&New";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.openToolStripMenuItem.Text = "&Open";
      // 
      // toolStripSeparator
      // 
      this.toolStripSeparator.Name = "toolStripSeparator";
      this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      // 
      // saveAsToolStripMenuItem
      // 
      this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
      this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.saveAsToolStripMenuItem.Text = "Save &As";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
      // 
      // printToolStripMenuItem
      // 
      this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printToolStripMenuItem.Name = "printToolStripMenuItem";
      this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
      this.printToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.printToolStripMenuItem.Text = "&Print";
      // 
      // printPreviewToolStripMenuItem
      // 
      this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
      this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.Exit_OnClick);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
      // 
      // cutToolStripMenuItem
      // 
      this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
      this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
      this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.cutToolStripMenuItem.Text = "Cu&t";
      // 
      // copyToolStripMenuItem
      // 
      this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
      this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
      this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.copyToolStripMenuItem.Text = "&Copy";
      // 
      // pasteToolStripMenuItem
      // 
      this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
      this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
      this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.pasteToolStripMenuItem.Text = "&Paste";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
      // 
      // selectAllToolStripMenuItem
      // 
      this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
      this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
      this.selectAllToolStripMenuItem.Text = "Select &All";
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "&Tools";
      // 
      // customizeToolStripMenuItem
      // 
      this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
      this.customizeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.customizeToolStripMenuItem.Text = "&Customize";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // contentsToolStripMenuItem
      // 
      this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
      this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.contentsToolStripMenuItem.Text = "&Contents";
      // 
      // indexToolStripMenuItem
      // 
      this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
      this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.indexToolStripMenuItem.Text = "&Index";
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.searchToolStripMenuItem.Text = "&Search";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
      this.aboutToolStripMenuItem.Text = "&About...";
      // 
      // MainStatus
      // 
      this.MainStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programStatus,
            this.serialPortStatus});
      this.MainStatus.Location = new System.Drawing.Point(0, 537);
      this.MainStatus.Name = "MainStatus";
      this.MainStatus.Size = new System.Drawing.Size(884, 24);
      this.MainStatus.TabIndex = 1;
      this.MainStatus.Text = "statusStrip1";
      // 
      // programStatus
      // 
      this.programStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.programStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
      this.programStatus.Name = "programStatus";
      this.programStatus.Size = new System.Drawing.Size(679, 19);
      this.programStatus.Spring = true;
      this.programStatus.Text = "status";
      this.programStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // serialPortStatus
      // 
      this.serialPortStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
      this.serialPortStatus.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
      this.serialPortStatus.Name = "serialPortStatus";
      this.serialPortStatus.Size = new System.Drawing.Size(190, 19);
      this.serialPortStatus.Text = "Connected: COM255, 115.2k,N,8,1";
      // 
      // MainToolBar
      // 
      this.MainToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
      this.MainToolBar.Location = new System.Drawing.Point(0, 24);
      this.MainToolBar.Name = "MainToolBar";
      this.MainToolBar.Size = new System.Drawing.Size(884, 25);
      this.MainToolBar.TabIndex = 2;
      this.MainToolBar.Text = "toolStrip1";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
      this.toolStripButton1.Text = "toolStripButton1";
      // 
      // serialPanel
      // 
      this.serialPanel.Dock = System.Windows.Forms.DockStyle.Left;
      this.serialPanel.Location = new System.Drawing.Point(0, 49);
      this.serialPanel.Name = "serialPanel";
      this.serialPanel.Size = new System.Drawing.Size(231, 488);
      this.serialPanel.TabIndex = 3;
      // 
      // serialPortGroupBox
      // 
      this.serialPortGroupBox.Controls.Add(this.handshakeComboBox);
      this.serialPortGroupBox.Controls.Add(this.handshakeLabel);
      this.serialPortGroupBox.Controls.Add(this.parityComboBox);
      this.serialPortGroupBox.Controls.Add(this.parityLabel);
      this.serialPortGroupBox.Controls.Add(this.stopBitsComboBox);
      this.serialPortGroupBox.Controls.Add(this.stopBitsLabel);
      this.serialPortGroupBox.Controls.Add(this.dataBitsComboBox);
      this.serialPortGroupBox.Controls.Add(this.dataBitsLabel);
      this.serialPortGroupBox.Controls.Add(this.baudRateComboBox);
      this.serialPortGroupBox.Controls.Add(this.baudRateLabel);
      this.serialPortGroupBox.Controls.Add(this.serialPortComboBox);
      this.serialPortGroupBox.Controls.Add(this.serialPortLabel);
      this.serialPortGroupBox.Location = new System.Drawing.Point(3, 49);
      this.serialPortGroupBox.Name = "serialPortGroupBox";
      this.serialPortGroupBox.Size = new System.Drawing.Size(225, 188);
      this.serialPortGroupBox.TabIndex = 0;
      this.serialPortGroupBox.TabStop = false;
      this.serialPortGroupBox.Text = "Serial Port Properties";
      // 
      // handshakeComboBox
      // 
      this.handshakeComboBox.FormattingEnabled = true;
      this.handshakeComboBox.Location = new System.Drawing.Point(74, 154);
      this.handshakeComboBox.Name = "handshakeComboBox";
      this.handshakeComboBox.Size = new System.Drawing.Size(141, 21);
      this.handshakeComboBox.TabIndex = 6;
      // 
      // handshakeLabel
      // 
      this.handshakeLabel.AutoSize = true;
      this.handshakeLabel.Location = new System.Drawing.Point(6, 157);
      this.handshakeLabel.Name = "handshakeLabel";
      this.handshakeLabel.Size = new System.Drawing.Size(62, 13);
      this.handshakeLabel.TabIndex = 10;
      this.handshakeLabel.Text = "Handshake";
      // 
      // parityComboBox
      // 
      this.parityComboBox.FormattingEnabled = true;
      this.parityComboBox.Location = new System.Drawing.Point(74, 100);
      this.parityComboBox.Name = "parityComboBox";
      this.parityComboBox.Size = new System.Drawing.Size(141, 21);
      this.parityComboBox.TabIndex = 4;
      // 
      // parityLabel
      // 
      this.parityLabel.AutoSize = true;
      this.parityLabel.Location = new System.Drawing.Point(35, 103);
      this.parityLabel.Name = "parityLabel";
      this.parityLabel.Size = new System.Drawing.Size(33, 13);
      this.parityLabel.TabIndex = 8;
      this.parityLabel.Text = "Parity";
      // 
      // stopBitsComboBox
      // 
      this.stopBitsComboBox.FormattingEnabled = true;
      this.stopBitsComboBox.Location = new System.Drawing.Point(74, 127);
      this.stopBitsComboBox.Name = "stopBitsComboBox";
      this.stopBitsComboBox.Size = new System.Drawing.Size(141, 21);
      this.stopBitsComboBox.TabIndex = 5;
      // 
      // stopBitsLabel
      // 
      this.stopBitsLabel.AutoSize = true;
      this.stopBitsLabel.Location = new System.Drawing.Point(19, 130);
      this.stopBitsLabel.Name = "stopBitsLabel";
      this.stopBitsLabel.Size = new System.Drawing.Size(49, 13);
      this.stopBitsLabel.TabIndex = 6;
      this.stopBitsLabel.Text = "Stop Bits";
      // 
      // dataBitsComboBox
      // 
      this.dataBitsComboBox.FormattingEnabled = true;
      this.dataBitsComboBox.Location = new System.Drawing.Point(74, 73);
      this.dataBitsComboBox.Name = "dataBitsComboBox";
      this.dataBitsComboBox.Size = new System.Drawing.Size(141, 21);
      this.dataBitsComboBox.TabIndex = 3;
      // 
      // dataBitsLabel
      // 
      this.dataBitsLabel.AutoSize = true;
      this.dataBitsLabel.Location = new System.Drawing.Point(18, 76);
      this.dataBitsLabel.Name = "dataBitsLabel";
      this.dataBitsLabel.Size = new System.Drawing.Size(50, 13);
      this.dataBitsLabel.TabIndex = 4;
      this.dataBitsLabel.Text = "Data Bits";
      // 
      // baudRateComboBox
      // 
      this.baudRateComboBox.FormattingEnabled = true;
      this.baudRateComboBox.Location = new System.Drawing.Point(74, 46);
      this.baudRateComboBox.Name = "baudRateComboBox";
      this.baudRateComboBox.Size = new System.Drawing.Size(141, 21);
      this.baudRateComboBox.TabIndex = 2;
      // 
      // baudRateLabel
      // 
      this.baudRateLabel.AutoSize = true;
      this.baudRateLabel.Location = new System.Drawing.Point(10, 49);
      this.baudRateLabel.Name = "baudRateLabel";
      this.baudRateLabel.Size = new System.Drawing.Size(58, 13);
      this.baudRateLabel.TabIndex = 2;
      this.baudRateLabel.Text = "Baud Rate";
      // 
      // serialPortComboBox
      // 
      this.serialPortComboBox.FormattingEnabled = true;
      this.serialPortComboBox.Location = new System.Drawing.Point(74, 19);
      this.serialPortComboBox.Name = "serialPortComboBox";
      this.serialPortComboBox.Size = new System.Drawing.Size(141, 21);
      this.serialPortComboBox.TabIndex = 1;
      // 
      // serialPortLabel
      // 
      this.serialPortLabel.AutoSize = true;
      this.serialPortLabel.Location = new System.Drawing.Point(13, 22);
      this.serialPortLabel.Name = "serialPortLabel";
      this.serialPortLabel.Size = new System.Drawing.Size(55, 13);
      this.serialPortLabel.TabIndex = 0;
      this.serialPortLabel.Text = "Serial Port";
      // 
      // ioPanel
      // 
      this.ioPanel.Controls.Add(this.ioSplitContainer);
      this.ioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ioPanel.Location = new System.Drawing.Point(231, 49);
      this.ioPanel.Name = "ioPanel";
      this.ioPanel.Size = new System.Drawing.Size(653, 488);
      this.ioPanel.TabIndex = 4;
      // 
      // ioSplitContainer
      // 
      this.ioSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ioSplitContainer.Location = new System.Drawing.Point(0, 0);
      this.ioSplitContainer.Name = "ioSplitContainer";
      this.ioSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // ioSplitContainer.Panel1
      // 
      this.ioSplitContainer.Panel1.Controls.Add(this.sendGroupBox);
      // 
      // ioSplitContainer.Panel2
      // 
      this.ioSplitContainer.Panel2.Controls.Add(this.receiveGroupBox);
      this.ioSplitContainer.Size = new System.Drawing.Size(653, 488);
      this.ioSplitContainer.SplitterDistance = 231;
      this.ioSplitContainer.TabIndex = 0;
      // 
      // sendGroupBox
      // 
      this.sendGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.sendGroupBox.Location = new System.Drawing.Point(0, 0);
      this.sendGroupBox.Name = "sendGroupBox";
      this.sendGroupBox.Size = new System.Drawing.Size(653, 231);
      this.sendGroupBox.TabIndex = 0;
      this.sendGroupBox.TabStop = false;
      this.sendGroupBox.Text = "Send";
      // 
      // receiveGroupBox
      // 
      this.receiveGroupBox.Controls.Add(this.receiveTextBox);
      this.receiveGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.receiveGroupBox.Location = new System.Drawing.Point(0, 0);
      this.receiveGroupBox.Name = "receiveGroupBox";
      this.receiveGroupBox.Size = new System.Drawing.Size(653, 253);
      this.receiveGroupBox.TabIndex = 0;
      this.receiveGroupBox.TabStop = false;
      this.receiveGroupBox.Text = "Receive";
      // 
      // receiveTextBox
      // 
      this.receiveTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.receiveTextBox.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.receiveTextBox.ForeColor = System.Drawing.Color.Black;
      this.receiveTextBox.Location = new System.Drawing.Point(3, 16);
      this.receiveTextBox.Multiline = true;
      this.receiveTextBox.Name = "receiveTextBox";
      this.receiveTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.receiveTextBox.Size = new System.Drawing.Size(647, 234);
      this.receiveTextBox.TabIndex = 0;
      this.receiveTextBox.WordWrap = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(884, 561);
      this.Controls.Add(this.serialPortGroupBox);
      this.Controls.Add(this.ioPanel);
      this.Controls.Add(this.serialPanel);
      this.Controls.Add(this.MainToolBar);
      this.Controls.Add(this.MainStatus);
      this.Controls.Add(this.MainMenu);
      this.MinimumSize = new System.Drawing.Size(600, 400);
      this.Name = "MainForm";
      this.Text = "Ceres";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
      this.Load += new System.EventHandler(this.OnFormLoad);
      this.MainMenu.ResumeLayout(false);
      this.MainMenu.PerformLayout();
      this.MainStatus.ResumeLayout(false);
      this.MainStatus.PerformLayout();
      this.MainToolBar.ResumeLayout(false);
      this.MainToolBar.PerformLayout();
      this.serialPortGroupBox.ResumeLayout(false);
      this.serialPortGroupBox.PerformLayout();
      this.ioPanel.ResumeLayout(false);
      this.ioSplitContainer.Panel1.ResumeLayout(false);
      this.ioSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.ioSplitContainer)).EndInit();
      this.ioSplitContainer.ResumeLayout(false);
      this.receiveGroupBox.ResumeLayout(false);
      this.receiveGroupBox.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenu;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
    private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.StatusStrip MainStatus;
    private System.Windows.Forms.ToolStrip MainToolBar;
    private System.Windows.Forms.Panel serialPanel;
    private System.Windows.Forms.ToolStripStatusLabel programStatus;
    private System.Windows.Forms.ToolStripStatusLabel serialPortStatus;
    private System.Windows.Forms.GroupBox serialPortGroupBox;
    private System.Windows.Forms.ComboBox handshakeComboBox;
    private System.Windows.Forms.Label handshakeLabel;
    private System.Windows.Forms.ComboBox parityComboBox;
    private System.Windows.Forms.Label parityLabel;
    private System.Windows.Forms.ComboBox stopBitsComboBox;
    private System.Windows.Forms.Label stopBitsLabel;
    private System.Windows.Forms.ComboBox dataBitsComboBox;
    private System.Windows.Forms.Label dataBitsLabel;
    private System.Windows.Forms.ComboBox baudRateComboBox;
    private System.Windows.Forms.Label baudRateLabel;
    private System.Windows.Forms.ComboBox serialPortComboBox;
    private System.Windows.Forms.Label serialPortLabel;
    private System.Windows.Forms.Panel ioPanel;
    private System.Windows.Forms.SplitContainer ioSplitContainer;
    private System.Windows.Forms.GroupBox sendGroupBox;
    private System.Windows.Forms.GroupBox receiveGroupBox;
    private System.Windows.Forms.TextBox receiveTextBox;
    private System.Windows.Forms.ToolStripButton toolStripButton1;
  }
}

