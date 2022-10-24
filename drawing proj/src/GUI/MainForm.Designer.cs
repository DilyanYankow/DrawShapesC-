namespace Draw
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.currentStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.speedMenu = new System.Windows.Forms.ToolStrip();
            this.drawSquareSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawRectangleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawLineSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawEllipseSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawCircleSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.drawPracticeSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pickUpSpeedButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PasteButton = new System.Windows.Forms.ToolStripButton();
            this.CopyButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.UngroupShapesButton = new System.Windows.Forms.ToolStripButton();
            this.GroupShapesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllShapesBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteAllShapesButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.BorderColorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FillColorButton = new System.Windows.Forms.ToolStripButton();
            this.shapesPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.transparencyTB = new System.Windows.Forms.TrackBar();
            this.shapeWidthNumberBar = new System.Windows.Forms.NumericUpDown();
            this.shapeHeightNumberBar = new System.Windows.Forms.NumericUpDown();
            this.shapeHeightLabel = new System.Windows.Forms.Label();
            this.shapeWidthLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.shapeYCoordinateNB = new System.Windows.Forms.NumericUpDown();
            this.shapeXCoordinateNB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rotateShapeNumberBar = new System.Windows.Forms.NumericUpDown();
            this.borderWidthNumberBar = new System.Windows.Forms.NumericUpDown();
            this.borderWidthLabel = new System.Windows.Forms.Label();
            this.transparencyNumberBar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.borderColorButtonGB = new System.Windows.Forms.Button();
            this.fillColorButtonGB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.shapeFillColorLabel = new System.Windows.Forms.Label();
            this.shapeNameTextBox = new System.Windows.Forms.TextBox();
            this.shapeNameLabel = new System.Windows.Forms.Label();
            this.applyChangesButton = new System.Windows.Forms.Button();
            this.BorderColorButtonDialog = new System.Windows.Forms.ColorDialog();
            this.FillColorButtonDialog = new System.Windows.Forms.ColorDialog();
            this.OpenImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveShapeDialog = new System.Windows.Forms.SaveFileDialog();
            this.viewPort = new Draw.DoubleBufferedPanel();
            this.drawPractice3SpeedButton = new System.Windows.Forms.ToolStripButton();
            this.mainMenu.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.speedMenu.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.shapesPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidthNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeightNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeYCoordinateNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeXCoordinateNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateShapeNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumberBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyNumberBar)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.imageToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(765, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.openImageToolStripMenuItem.Text = "Open image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            this.imageToolStripMenuItem.Click += new System.EventHandler(this.imageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentStatusLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 476);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(765, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // speedMenu
            // 
            this.speedMenu.AutoSize = false;
            this.speedMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drawSquareSpeedButton,
            this.drawRectangleSpeedButton,
            this.drawLineSpeedButton,
            this.drawEllipseSpeedButton,
            this.drawCircleSpeedButton,
            this.drawPractice3SpeedButton,
            this.drawPracticeSpeedButton,
            this.toolStripSeparator1,
            this.pickUpSpeedButton,
            this.toolStripSeparator2,
            this.PasteButton,
            this.CopyButton,
            this.toolStripSeparator4,
            this.UngroupShapesButton,
            this.GroupShapesButton,
            this.toolStripSeparator5,
            this.deleteAllShapesBtn,
            this.deleteAllShapesButton,
            this.toolStripSeparator6});
            this.speedMenu.Location = new System.Drawing.Point(0, 24);
            this.speedMenu.Name = "speedMenu";
            this.speedMenu.Size = new System.Drawing.Size(765, 44);
            this.speedMenu.TabIndex = 3;
            this.speedMenu.Text = "toolStrip1";
            this.speedMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.speedMenu_ItemClicked);
            // 
            // drawSquareSpeedButton
            // 
            this.drawSquareSpeedButton.CheckOnClick = true;
            this.drawSquareSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawSquareSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawSquareSpeedButton.Image")));
            this.drawSquareSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawSquareSpeedButton.Name = "drawSquareSpeedButton";
            this.drawSquareSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawSquareSpeedButton.Text = "Draw Rectangle";
            this.drawSquareSpeedButton.Click += new System.EventHandler(this.drawSquareSpeedButton_Click);
            // 
            // drawRectangleSpeedButton
            // 
            this.drawRectangleSpeedButton.CheckOnClick = true;
            this.drawRectangleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawRectangleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawRectangleSpeedButton.Image")));
            this.drawRectangleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawRectangleSpeedButton.Name = "drawRectangleSpeedButton";
            this.drawRectangleSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawRectangleSpeedButton.Text = "DrawRectangleButton";
            this.drawRectangleSpeedButton.Click += new System.EventHandler(this.DrawRectangleSpeedButtonClick);
            // 
            // drawLineSpeedButton
            // 
            this.drawLineSpeedButton.CheckOnClick = true;
            this.drawLineSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawLineSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawLineSpeedButton.Image")));
            this.drawLineSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawLineSpeedButton.Name = "drawLineSpeedButton";
            this.drawLineSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawLineSpeedButton.Text = "Draw Line Button";
            this.drawLineSpeedButton.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // drawEllipseSpeedButton
            // 
            this.drawEllipseSpeedButton.CheckOnClick = true;
            this.drawEllipseSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawEllipseSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawEllipseSpeedButton.Image")));
            this.drawEllipseSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawEllipseSpeedButton.Name = "drawEllipseSpeedButton";
            this.drawEllipseSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawEllipseSpeedButton.Text = "Draw Elipse Button";
            this.drawEllipseSpeedButton.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // drawCircleSpeedButton
            // 
            this.drawCircleSpeedButton.CheckOnClick = true;
            this.drawCircleSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawCircleSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawCircleSpeedButton.Image")));
            this.drawCircleSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawCircleSpeedButton.Name = "drawCircleSpeedButton";
            this.drawCircleSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawCircleSpeedButton.Text = "Draw Circle Button";
            this.drawCircleSpeedButton.Click += new System.EventHandler(this.drawCircleSpeedButton_Click);
            // 
            // drawPracticeSpeedButton
            // 
            this.drawPracticeSpeedButton.CheckOnClick = true;
            this.drawPracticeSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPracticeSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPracticeSpeedButton.Image")));
            this.drawPracticeSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPracticeSpeedButton.Name = "drawPracticeSpeedButton";
            this.drawPracticeSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawPracticeSpeedButton.Text = "draw Practice Shape";
            this.drawPracticeSpeedButton.Click += new System.EventHandler(this.drawPracticeSpeedButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 44);
            // 
            // pickUpSpeedButton
            // 
            this.pickUpSpeedButton.CheckOnClick = true;
            this.pickUpSpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pickUpSpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("pickUpSpeedButton.Image")));
            this.pickUpSpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pickUpSpeedButton.Name = "pickUpSpeedButton";
            this.pickUpSpeedButton.Size = new System.Drawing.Size(23, 41);
            this.pickUpSpeedButton.Text = "toolStripButton1";
            this.pickUpSpeedButton.Click += new System.EventHandler(this.pickUpSpeedButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 44);
            // 
            // PasteButton
            // 
            this.PasteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteButton.Image = ((System.Drawing.Image)(resources.GetObject("PasteButton.Image")));
            this.PasteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteButton.Name = "PasteButton";
            this.PasteButton.Size = new System.Drawing.Size(23, 41);
            this.PasteButton.Text = "Paste Shapes(Ctrl+V)";
            this.PasteButton.Click += new System.EventHandler(this.PasteButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyButton.Image = ((System.Drawing.Image)(resources.GetObject("CopyButton.Image")));
            this.CopyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(23, 41);
            this.CopyButton.Text = "Copy Shapes";
            this.CopyButton.ToolTipText = "Copy Shape(Ctrl+C)";
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 44);
            // 
            // UngroupShapesButton
            // 
            this.UngroupShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UngroupShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("UngroupShapesButton.Image")));
            this.UngroupShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UngroupShapesButton.Name = "UngroupShapesButton";
            this.UngroupShapesButton.Size = new System.Drawing.Size(23, 41);
            this.UngroupShapesButton.Text = "Ungroup Shapes";
            this.UngroupShapesButton.Click += new System.EventHandler(this.UngroupShapesButton_Click);
            // 
            // GroupShapesButton
            // 
            this.GroupShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GroupShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("GroupShapesButton.Image")));
            this.GroupShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GroupShapesButton.Name = "GroupShapesButton";
            this.GroupShapesButton.Size = new System.Drawing.Size(23, 41);
            this.GroupShapesButton.Text = "Group Shapes";
            this.GroupShapesButton.Click += new System.EventHandler(this.GroupShapesButton_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 44);
            // 
            // deleteAllShapesBtn
            // 
            this.deleteAllShapesBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteAllShapesBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteAllShapesBtn.Image")));
            this.deleteAllShapesBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAllShapesBtn.Name = "deleteAllShapesBtn";
            this.deleteAllShapesBtn.Size = new System.Drawing.Size(23, 41);
            this.deleteAllShapesBtn.Text = "Delete ALL";
            this.deleteAllShapesBtn.Click += new System.EventHandler(this.deleteAllShapesBtn_Click);
            // 
            // deleteAllShapesButton
            // 
            this.deleteAllShapesButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteAllShapesButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteAllShapesButton.Image")));
            this.deleteAllShapesButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteAllShapesButton.Name = "deleteAllShapesButton";
            this.deleteAllShapesButton.Size = new System.Drawing.Size(23, 41);
            this.deleteAllShapesButton.Text = "Delete Selection";
            this.deleteAllShapesButton.Click += new System.EventHandler(this.deleteShapeButton_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 44);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BorderColorButton,
            this.toolStripSeparator3,
            this.FillColorButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 68);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(765, 28);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // BorderColorButton
            // 
            this.BorderColorButton.AutoSize = false;
            this.BorderColorButton.BackColor = System.Drawing.Color.Black;
            this.BorderColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BorderColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BorderColorButton.Name = "BorderColorButton";
            this.BorderColorButton.Size = new System.Drawing.Size(25, 25);
            this.BorderColorButton.Text = "Border Color";
            this.BorderColorButton.Click += new System.EventHandler(this.BorderColorButton_Click_1);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 28);
            // 
            // FillColorButton
            // 
            this.FillColorButton.AutoSize = false;
            this.FillColorButton.BackColor = System.Drawing.Color.White;
            this.FillColorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorButton.Name = "FillColorButton";
            this.FillColorButton.Size = new System.Drawing.Size(25, 25);
            this.FillColorButton.Text = "Fill Color";
            this.FillColorButton.Click += new System.EventHandler(this.FillColorButton_Click_1);
            // 
            // shapesPropertiesGroupBox
            // 
            this.shapesPropertiesGroupBox.Controls.Add(this.transparencyTB);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeWidthNumberBar);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeHeightNumberBar);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeHeightLabel);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeWidthLabel);
            this.shapesPropertiesGroupBox.Controls.Add(this.label6);
            this.shapesPropertiesGroupBox.Controls.Add(this.label5);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeYCoordinateNB);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeXCoordinateNB);
            this.shapesPropertiesGroupBox.Controls.Add(this.label4);
            this.shapesPropertiesGroupBox.Controls.Add(this.label3);
            this.shapesPropertiesGroupBox.Controls.Add(this.rotateShapeNumberBar);
            this.shapesPropertiesGroupBox.Controls.Add(this.borderWidthNumberBar);
            this.shapesPropertiesGroupBox.Controls.Add(this.borderWidthLabel);
            this.shapesPropertiesGroupBox.Controls.Add(this.transparencyNumberBar);
            this.shapesPropertiesGroupBox.Controls.Add(this.label2);
            this.shapesPropertiesGroupBox.Controls.Add(this.borderColorButtonGB);
            this.shapesPropertiesGroupBox.Controls.Add(this.fillColorButtonGB);
            this.shapesPropertiesGroupBox.Controls.Add(this.label1);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeFillColorLabel);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeNameTextBox);
            this.shapesPropertiesGroupBox.Controls.Add(this.shapeNameLabel);
            this.shapesPropertiesGroupBox.Controls.Add(this.applyChangesButton);
            this.shapesPropertiesGroupBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.shapesPropertiesGroupBox.Location = new System.Drawing.Point(475, 96);
            this.shapesPropertiesGroupBox.Name = "shapesPropertiesGroupBox";
            this.shapesPropertiesGroupBox.Size = new System.Drawing.Size(290, 380);
            this.shapesPropertiesGroupBox.TabIndex = 7;
            this.shapesPropertiesGroupBox.TabStop = false;
            this.shapesPropertiesGroupBox.Text = "Shape Properties";
            this.shapesPropertiesGroupBox.Visible = false;
            this.shapesPropertiesGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // transparencyTB
            // 
            this.transparencyTB.Location = new System.Drawing.Point(192, 48);
            this.transparencyTB.Maximum = 255;
            this.transparencyTB.Name = "transparencyTB";
            this.transparencyTB.Size = new System.Drawing.Size(92, 45);
            this.transparencyTB.TabIndex = 25;
            this.transparencyTB.Scroll += new System.EventHandler(this.transparencyTB_Scroll);
            // 
            // shapeWidthNumberBar
            // 
            this.shapeWidthNumberBar.Location = new System.Drawing.Point(125, 238);
            this.shapeWidthNumberBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.shapeWidthNumberBar.Name = "shapeWidthNumberBar";
            this.shapeWidthNumberBar.Size = new System.Drawing.Size(49, 20);
            this.shapeWidthNumberBar.TabIndex = 22;
            // 
            // shapeHeightNumberBar
            // 
            this.shapeHeightNumberBar.Location = new System.Drawing.Point(125, 212);
            this.shapeHeightNumberBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.shapeHeightNumberBar.Name = "shapeHeightNumberBar";
            this.shapeHeightNumberBar.Size = new System.Drawing.Size(50, 20);
            this.shapeHeightNumberBar.TabIndex = 21;
            this.shapeHeightNumberBar.ValueChanged += new System.EventHandler(this.shapeHeightNumberBar_ValueChanged);
            // 
            // shapeHeightLabel
            // 
            this.shapeHeightLabel.AutoSize = true;
            this.shapeHeightLabel.Location = new System.Drawing.Point(39, 214);
            this.shapeHeightLabel.Name = "shapeHeightLabel";
            this.shapeHeightLabel.Size = new System.Drawing.Size(72, 13);
            this.shapeHeightLabel.TabIndex = 20;
            this.shapeHeightLabel.Text = "Shape Height";
            // 
            // shapeWidthLabel
            // 
            this.shapeWidthLabel.AutoSize = true;
            this.shapeWidthLabel.Location = new System.Drawing.Point(42, 238);
            this.shapeWidthLabel.Name = "shapeWidthLabel";
            this.shapeWidthLabel.Size = new System.Drawing.Size(69, 13);
            this.shapeWidthLabel.TabIndex = 19;
            this.shapeWidthLabel.Text = "Shape Width";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "X";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // shapeYCoordinateNB
            // 
            this.shapeYCoordinateNB.Location = new System.Drawing.Point(172, 306);
            this.shapeYCoordinateNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.shapeYCoordinateNB.Name = "shapeYCoordinateNB";
            this.shapeYCoordinateNB.Size = new System.Drawing.Size(41, 20);
            this.shapeYCoordinateNB.TabIndex = 16;
            this.shapeYCoordinateNB.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // shapeXCoordinateNB
            // 
            this.shapeXCoordinateNB.Location = new System.Drawing.Point(117, 306);
            this.shapeXCoordinateNB.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.shapeXCoordinateNB.Name = "shapeXCoordinateNB";
            this.shapeXCoordinateNB.Size = new System.Drawing.Size(41, 20);
            this.shapeXCoordinateNB.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Shape Coordinates";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Rotate Shape";
            // 
            // rotateShapeNumberBar
            // 
            this.rotateShapeNumberBar.Location = new System.Drawing.Point(125, 176);
            this.rotateShapeNumberBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.rotateShapeNumberBar.Name = "rotateShapeNumberBar";
            this.rotateShapeNumberBar.Size = new System.Drawing.Size(50, 20);
            this.rotateShapeNumberBar.TabIndex = 12;
            this.rotateShapeNumberBar.ValueChanged += new System.EventHandler(this.rotateShapeNumberBar_ValueChanged);
            // 
            // borderWidthNumberBar
            // 
            this.borderWidthNumberBar.Location = new System.Drawing.Point(125, 150);
            this.borderWidthNumberBar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.borderWidthNumberBar.Name = "borderWidthNumberBar";
            this.borderWidthNumberBar.Size = new System.Drawing.Size(50, 20);
            this.borderWidthNumberBar.TabIndex = 11;
            // 
            // borderWidthLabel
            // 
            this.borderWidthLabel.AutoSize = true;
            this.borderWidthLabel.Location = new System.Drawing.Point(42, 152);
            this.borderWidthLabel.Name = "borderWidthLabel";
            this.borderWidthLabel.Size = new System.Drawing.Size(69, 13);
            this.borderWidthLabel.TabIndex = 10;
            this.borderWidthLabel.Text = "Border Width";
            // 
            // transparencyNumberBar
            // 
            this.transparencyNumberBar.Location = new System.Drawing.Point(125, 57);
            this.transparencyNumberBar.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.transparencyNumberBar.Name = "transparencyNumberBar";
            this.transparencyNumberBar.Size = new System.Drawing.Size(49, 20);
            this.transparencyNumberBar.TabIndex = 9;
            this.transparencyNumberBar.ValueChanged += new System.EventHandler(this.transparencyNumberBar_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Shape Alpha Level";
            // 
            // borderColorButtonGB
            // 
            this.borderColorButtonGB.BackColor = System.Drawing.Color.Black;
            this.borderColorButtonGB.Location = new System.Drawing.Point(125, 113);
            this.borderColorButtonGB.Name = "borderColorButtonGB";
            this.borderColorButtonGB.Size = new System.Drawing.Size(24, 23);
            this.borderColorButtonGB.TabIndex = 6;
            this.borderColorButtonGB.UseVisualStyleBackColor = false;
            this.borderColorButtonGB.Click += new System.EventHandler(this.borderColorButtonGB_Click);
            // 
            // fillColorButtonGB
            // 
            this.fillColorButtonGB.BackColor = System.Drawing.Color.White;
            this.fillColorButtonGB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.fillColorButtonGB.Location = new System.Drawing.Point(125, 84);
            this.fillColorButtonGB.Name = "fillColorButtonGB";
            this.fillColorButtonGB.Size = new System.Drawing.Size(23, 23);
            this.fillColorButtonGB.TabIndex = 5;
            this.fillColorButtonGB.UseVisualStyleBackColor = false;
            this.fillColorButtonGB.Click += new System.EventHandler(this.fillColorButtonGB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Border Color";
            // 
            // shapeFillColorLabel
            // 
            this.shapeFillColorLabel.AutoSize = true;
            this.shapeFillColorLabel.Location = new System.Drawing.Point(65, 89);
            this.shapeFillColorLabel.Name = "shapeFillColorLabel";
            this.shapeFillColorLabel.Size = new System.Drawing.Size(46, 13);
            this.shapeFillColorLabel.TabIndex = 3;
            this.shapeFillColorLabel.Text = "Fill Color";
            // 
            // shapeNameTextBox
            // 
            this.shapeNameTextBox.Location = new System.Drawing.Point(125, 22);
            this.shapeNameTextBox.Name = "shapeNameTextBox";
            this.shapeNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.shapeNameTextBox.TabIndex = 2;
            // 
            // shapeNameLabel
            // 
            this.shapeNameLabel.AutoSize = true;
            this.shapeNameLabel.Location = new System.Drawing.Point(39, 25);
            this.shapeNameLabel.Name = "shapeNameLabel";
            this.shapeNameLabel.Size = new System.Drawing.Size(69, 13);
            this.shapeNameLabel.TabIndex = 1;
            this.shapeNameLabel.Text = "Shape Name";
            this.shapeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.Location = new System.Drawing.Point(9, 332);
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.Size = new System.Drawing.Size(102, 23);
            this.applyChangesButton.TabIndex = 0;
            this.applyChangesButton.Text = "Apply Changes";
            this.applyChangesButton.UseVisualStyleBackColor = true;
            this.applyChangesButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // OpenImageDialog
            // 
            this.OpenImageDialog.FileName = "OpenImageDialog";
            // 
            // SaveShapeDialog
            // 
            this.SaveShapeDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveShapeDialog_FileOk);
            // 
            // viewPort
            // 
            this.viewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPort.Location = new System.Drawing.Point(0, 68);
            this.viewPort.Name = "viewPort";
            this.viewPort.Size = new System.Drawing.Size(765, 408);
            this.viewPort.TabIndex = 4;
            this.viewPort.Load += new System.EventHandler(this.viewPort_Load);
            this.viewPort.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPortPaint);
            this.viewPort.KeyDown += new System.Windows.Forms.KeyEventHandler(this.viewPort_KeyDown);
            this.viewPort.MouseDown += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseDown);
            this.viewPort.MouseMove += new System.Windows.Forms.MouseEventHandler(this.viewPort_MouseMove);
            this.viewPort.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ViewPortMouseUp);
            // 
            // drawPractice3SpeedButton
            // 
            this.drawPractice3SpeedButton.CheckOnClick = true;
            this.drawPractice3SpeedButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.drawPractice3SpeedButton.Image = ((System.Drawing.Image)(resources.GetObject("drawPractice3SpeedButton.Image")));
            this.drawPractice3SpeedButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.drawPractice3SpeedButton.Name = "drawPractice3SpeedButton";
            this.drawPractice3SpeedButton.Size = new System.Drawing.Size(23, 41);
            this.drawPractice3SpeedButton.Text = "practice shape 3";
            this.drawPractice3SpeedButton.Click += new System.EventHandler(this.drawPractice3SpeedButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 498);
            this.Controls.Add(this.shapesPropertiesGroupBox);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.viewPort);
            this.Controls.Add(this.speedMenu);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mainMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "MainForm";
            this.Text = "Draw";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.speedMenu.ResumeLayout(false);
            this.speedMenu.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.shapesPropertiesGroupBox.ResumeLayout(false);
            this.shapesPropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeWidthNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeHeightNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeYCoordinateNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shapeXCoordinateNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotateShapeNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.borderWidthNumberBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transparencyNumberBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		
		private System.Windows.Forms.ToolStripStatusLabel currentStatusLabel;
		private Draw.DoubleBufferedPanel viewPort;
		private System.Windows.Forms.ToolStripButton pickUpSpeedButton;
		private System.Windows.Forms.ToolStripButton drawRectangleSpeedButton;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStrip speedMenu;
		private System.Windows.Forms.StatusStrip statusBar;
		private System.Windows.Forms.MenuStrip mainMenu;
		private System.Windows.Forms.ToolStripButton drawEllipseSpeedButton;
        private System.Windows.Forms.ToolStripButton drawLineSpeedButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.GroupBox shapesPropertiesGroupBox;
        private System.Windows.Forms.Button applyChangesButton;
        private System.Windows.Forms.ColorDialog BorderColorButtonDialog;
        private System.Windows.Forms.ColorDialog FillColorButtonDialog;
        private System.Windows.Forms.Label shapeNameLabel;
        private System.Windows.Forms.TextBox shapeNameTextBox;
        private System.Windows.Forms.Button borderColorButtonGB;
        private System.Windows.Forms.Button fillColorButtonGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shapeFillColorLabel;
        private System.Windows.Forms.NumericUpDown transparencyNumberBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown borderWidthNumberBar;
        private System.Windows.Forms.Label borderWidthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rotateShapeNumberBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown shapeYCoordinateNB;
        private System.Windows.Forms.NumericUpDown shapeXCoordinateNB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown shapeWidthNumberBar;
        private System.Windows.Forms.NumericUpDown shapeHeightNumberBar;
        private System.Windows.Forms.Label shapeHeightLabel;
        private System.Windows.Forms.Label shapeWidthLabel;
        private System.Windows.Forms.ToolStripButton drawCircleSpeedButton;
        private System.Windows.Forms.ToolStripButton BorderColorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton FillColorButton;
        private System.Windows.Forms.ToolStripButton drawSquareSpeedButton;
        private System.Windows.Forms.TrackBar transparencyTB;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenImageDialog;
        private System.Windows.Forms.SaveFileDialog SaveShapeDialog;
        private System.Windows.Forms.ToolStripButton CopyButton;
        private System.Windows.Forms.ToolStripButton PasteButton;
        private System.Windows.Forms.ToolStripButton GroupShapesButton;
        private System.Windows.Forms.ToolStripButton UngroupShapesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton deleteAllShapesButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton drawPracticeSpeedButton;
        private System.Windows.Forms.ToolStripButton deleteAllShapesBtn;
        private System.Windows.Forms.ToolStripButton drawPractice3SpeedButton;
    }
}
