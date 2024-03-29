﻿namespace COMP123_S2019_A5_301035028.Views
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.OrderFormFinishButton = new System.Windows.Forms.Button();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.OrderFormBackButton = new System.Windows.Forms.Button();
            this.OrderFormCancelButton = new System.Windows.Forms.Button();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ProductPictureBox = new System.Windows.Forms.PictureBox();
            this.SystemComponentsGroupBox = new System.Windows.Forms.GroupBox();
            this.SystemCompoinentsTableLayoutPanelB = new System.Windows.Forms.TableLayoutPanel();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.GPUTypeDataLabel = new System.Windows.Forms.Label();
            this.LCDSizeDataLabel = new System.Windows.Forms.Label();
            this.MemoryDataLabel = new System.Windows.Forms.Label();
            this.CPUBrandDataLabel = new System.Windows.Forms.Label();
            this.CPUTypeDataLabel = new System.Windows.Forms.Label();
            this.CPUNumberDataLabel = new System.Windows.Forms.Label();
            this.CPUSpeedDataLabel = new System.Windows.Forms.Label();
            this.HDDDataLabel = new System.Windows.Forms.Label();
            this.WebcamDataLabel = new System.Windows.Forms.Label();
            this.SystemCompoinentsTableLayoutPanelA = new System.Windows.Forms.TableLayoutPanel();
            this.ModelDataLabel = new System.Windows.Forms.Label();
            this.ManufacturerDataLabel = new System.Windows.Forms.Label();
            this.PlatformDataLabel = new System.Windows.Forms.Label();
            this.ConditionDataLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.SystemComponentsLineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.YourPriceGroupBox = new System.Windows.Forms.GroupBox();
            this.YourPriceTableLayoutPanelB = new System.Windows.Forms.TableLayoutPanel();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.TotalDataLabel = new System.Windows.Forms.Label();
            this.YourPriceTableLayoutPanelA = new System.Windows.Forms.TableLayoutPanel();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.PriceDataLabel = new System.Windows.Forms.Label();
            this.SalesTaxDataLabel = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.YourPriceLineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CancelButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.FinishButton = new System.Windows.Forms.Button();
            this.OrderFormMenuStrip.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).BeginInit();
            this.SystemComponentsGroupBox.SuspendLayout();
            this.SystemCompoinentsTableLayoutPanelB.SuspendLayout();
            this.SystemCompoinentsTableLayoutPanelA.SuspendLayout();
            this.YourPriceGroupBox.SuspendLayout();
            this.YourPriceTableLayoutPanelB.SuspendLayout();
            this.YourPriceTableLayoutPanelA.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderFormFinishButton
            // 
            this.OrderFormFinishButton.AutoSize = true;
            this.OrderFormFinishButton.Location = new System.Drawing.Point(629, 522);
            this.OrderFormFinishButton.Margin = new System.Windows.Forms.Padding(1);
            this.OrderFormFinishButton.Name = "OrderFormFinishButton";
            this.OrderFormFinishButton.Size = new System.Drawing.Size(57, 27);
            this.OrderFormFinishButton.TabIndex = 1;
            this.OrderFormFinishButton.Text = "Finish";
            this.OrderFormFinishButton.UseVisualStyleBackColor = true;
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PrintToolStripMenuItem,
            this.ToolStripSeparator,
            this.ExitToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // PrintToolStripMenuItem
            // 
            this.PrintToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("PrintToolStripMenuItem.Image")));
            this.PrintToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem";
            this.PrintToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.PrintToolStripMenuItem.Text = "&Print";
            this.PrintToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // ToolStripSeparator
            // 
            this.ToolStripSeparator.Name = "ToolStripSeparator";
            this.ToolStripSeparator.Size = new System.Drawing.Size(137, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // OrderFormMenuStrip
            // 
            this.OrderFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.OrderFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.OrderFormMenuStrip.Name = "OrderFormMenuStrip";
            this.OrderFormMenuStrip.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.OrderFormMenuStrip.Size = new System.Drawing.Size(797, 24);
            this.OrderFormMenuStrip.TabIndex = 0;
            this.OrderFormMenuStrip.Text = "menuStrip1";
            // 
            // OrderFormBackButton
            // 
            this.OrderFormBackButton.AutoSize = true;
            this.OrderFormBackButton.Location = new System.Drawing.Point(127, 522);
            this.OrderFormBackButton.Name = "OrderFormBackButton";
            this.OrderFormBackButton.Size = new System.Drawing.Size(109, 27);
            this.OrderFormBackButton.TabIndex = 18;
            this.OrderFormBackButton.Text = "Back";
            this.OrderFormBackButton.UseVisualStyleBackColor = true;
            // 
            // OrderFormCancelButton
            // 
            this.OrderFormCancelButton.AutoSize = true;
            this.OrderFormCancelButton.Location = new System.Drawing.Point(240, 522);
            this.OrderFormCancelButton.Name = "OrderFormCancelButton";
            this.OrderFormCancelButton.Size = new System.Drawing.Size(109, 27);
            this.OrderFormCancelButton.TabIndex = 19;
            this.OrderFormCancelButton.Text = "Cancel";
            this.OrderFormCancelButton.UseVisualStyleBackColor = true;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainTableLayoutPanel.ColumnCount = 7;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.MainTableLayoutPanel.Controls.Add(this.ProductPictureBox, 4, 0);
            this.MainTableLayoutPanel.Controls.Add(this.SystemComponentsGroupBox, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.YourPriceGroupBox, 4, 7);
            this.MainTableLayoutPanel.Controls.Add(this.CancelButton, 4, 13);
            this.MainTableLayoutPanel.Controls.Add(this.BackButton, 5, 13);
            this.MainTableLayoutPanel.Controls.Add(this.FinishButton, 6, 13);
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 37);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 14;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(797, 349);
            this.MainTableLayoutPanel.TabIndex = 20;
            // 
            // ProductPictureBox
            // 
            this.ProductPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainTableLayoutPanel.SetColumnSpan(this.ProductPictureBox, 2);
            this.ProductPictureBox.Image = global::COMP123_S2019_A5_301035028.Properties.Resources.laptop;
            this.ProductPictureBox.Location = new System.Drawing.Point(455, 3);
            this.ProductPictureBox.Name = "ProductPictureBox";
            this.MainTableLayoutPanel.SetRowSpan(this.ProductPictureBox, 6);
            this.ProductPictureBox.Size = new System.Drawing.Size(220, 138);
            this.ProductPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPictureBox.TabIndex = 52;
            this.ProductPictureBox.TabStop = false;
            // 
            // SystemComponentsGroupBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.SystemComponentsGroupBox, 4);
            this.SystemComponentsGroupBox.Controls.Add(this.SystemCompoinentsTableLayoutPanelB);
            this.SystemComponentsGroupBox.Controls.Add(this.SystemCompoinentsTableLayoutPanelA);
            this.SystemComponentsGroupBox.Controls.Add(this.shapeContainer1);
            this.SystemComponentsGroupBox.Location = new System.Drawing.Point(3, 3);
            this.SystemComponentsGroupBox.Name = "SystemComponentsGroupBox";
            this.MainTableLayoutPanel.SetRowSpan(this.SystemComponentsGroupBox, 14);
            this.SystemComponentsGroupBox.Size = new System.Drawing.Size(446, 343);
            this.SystemComponentsGroupBox.TabIndex = 0;
            this.SystemComponentsGroupBox.TabStop = false;
            this.SystemComponentsGroupBox.Text = "System Components";
            // 
            // SystemCompoinentsTableLayoutPanelB
            // 
            this.SystemCompoinentsTableLayoutPanelB.ColumnCount = 4;
            this.SystemCompoinentsTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SystemCompoinentsTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SystemCompoinentsTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SystemCompoinentsTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.LCDSizeLabel, 0, 0);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.MemoryLabel, 0, 1);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUBrandLabel, 0, 2);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUTypeLabel, 0, 3);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUNumberLabel, 0, 4);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUSpeedLabel, 0, 5);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.HDDLabel, 0, 6);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.GPUTypeLabel, 0, 7);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.WebcamLabel, 0, 8);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.GPUTypeDataLabel, 1, 7);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.LCDSizeDataLabel, 1, 0);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.MemoryDataLabel, 1, 1);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUBrandDataLabel, 1, 2);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUTypeDataLabel, 1, 3);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUNumberDataLabel, 1, 4);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.CPUSpeedDataLabel, 1, 5);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.HDDDataLabel, 1, 6);
            this.SystemCompoinentsTableLayoutPanelB.Controls.Add(this.WebcamDataLabel, 1, 8);
            this.SystemCompoinentsTableLayoutPanelB.Location = new System.Drawing.Point(0, 87);
            this.SystemCompoinentsTableLayoutPanelB.Name = "SystemCompoinentsTableLayoutPanelB";
            this.SystemCompoinentsTableLayoutPanelB.RowCount = 9;
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.SystemCompoinentsTableLayoutPanelB.Size = new System.Drawing.Size(446, 251);
            this.SystemCompoinentsTableLayoutPanelB.TabIndex = 54;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeLabel.AutoSize = true;
            this.LCDSizeLabel.Location = new System.Drawing.Point(3, 0);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(105, 27);
            this.LCDSizeLabel.TabIndex = 53;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryLabel.AutoSize = true;
            this.MemoryLabel.Location = new System.Drawing.Point(3, 27);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(105, 27);
            this.MemoryLabel.TabIndex = 53;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandLabel.AutoSize = true;
            this.CPUBrandLabel.Location = new System.Drawing.Point(3, 54);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(105, 27);
            this.CPUBrandLabel.TabIndex = 53;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeLabel.AutoSize = true;
            this.CPUTypeLabel.Location = new System.Drawing.Point(3, 81);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(105, 27);
            this.CPUTypeLabel.TabIndex = 53;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberLabel.AutoSize = true;
            this.CPUNumberLabel.Location = new System.Drawing.Point(3, 108);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(105, 27);
            this.CPUNumberLabel.TabIndex = 53;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedLabel.AutoSize = true;
            this.CPUSpeedLabel.Location = new System.Drawing.Point(3, 135);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(105, 27);
            this.CPUSpeedLabel.TabIndex = 53;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(3, 162);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(105, 27);
            this.HDDLabel.TabIndex = 53;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeLabel.AutoSize = true;
            this.GPUTypeLabel.Location = new System.Drawing.Point(3, 189);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(105, 27);
            this.GPUTypeLabel.TabIndex = 53;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebcamLabel.AutoSize = true;
            this.WebcamLabel.Location = new System.Drawing.Point(3, 216);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(105, 35);
            this.WebcamLabel.TabIndex = 53;
            this.WebcamLabel.Text = "WebCam";
            this.WebcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GPUTypeDataLabel
            // 
            this.GPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.GPUTypeDataLabel, 3);
            this.GPUTypeDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.GPUTypeDataLabel.Location = new System.Drawing.Point(114, 189);
            this.GPUTypeDataLabel.Name = "GPUTypeDataLabel";
            this.GPUTypeDataLabel.Size = new System.Drawing.Size(329, 27);
            this.GPUTypeDataLabel.TabIndex = 56;
            this.GPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LCDSizeDataLabel
            // 
            this.LCDSizeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LCDSizeDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.LCDSizeDataLabel, 3);
            this.LCDSizeDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.LCDSizeDataLabel.Location = new System.Drawing.Point(114, 0);
            this.LCDSizeDataLabel.Name = "LCDSizeDataLabel";
            this.LCDSizeDataLabel.Size = new System.Drawing.Size(329, 27);
            this.LCDSizeDataLabel.TabIndex = 56;
            this.LCDSizeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MemoryDataLabel
            // 
            this.MemoryDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MemoryDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.MemoryDataLabel, 3);
            this.MemoryDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MemoryDataLabel.Location = new System.Drawing.Point(114, 27);
            this.MemoryDataLabel.Name = "MemoryDataLabel";
            this.MemoryDataLabel.Size = new System.Drawing.Size(329, 27);
            this.MemoryDataLabel.TabIndex = 56;
            this.MemoryDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUBrandDataLabel
            // 
            this.CPUBrandDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUBrandDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.CPUBrandDataLabel, 3);
            this.CPUBrandDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUBrandDataLabel.Location = new System.Drawing.Point(114, 54);
            this.CPUBrandDataLabel.Name = "CPUBrandDataLabel";
            this.CPUBrandDataLabel.Size = new System.Drawing.Size(329, 27);
            this.CPUBrandDataLabel.TabIndex = 56;
            this.CPUBrandDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUTypeDataLabel
            // 
            this.CPUTypeDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUTypeDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.CPUTypeDataLabel, 3);
            this.CPUTypeDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUTypeDataLabel.Location = new System.Drawing.Point(114, 81);
            this.CPUTypeDataLabel.Name = "CPUTypeDataLabel";
            this.CPUTypeDataLabel.Size = new System.Drawing.Size(329, 27);
            this.CPUTypeDataLabel.TabIndex = 56;
            this.CPUTypeDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUNumberDataLabel
            // 
            this.CPUNumberDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUNumberDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.CPUNumberDataLabel, 3);
            this.CPUNumberDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUNumberDataLabel.Location = new System.Drawing.Point(114, 108);
            this.CPUNumberDataLabel.Name = "CPUNumberDataLabel";
            this.CPUNumberDataLabel.Size = new System.Drawing.Size(329, 27);
            this.CPUNumberDataLabel.TabIndex = 56;
            this.CPUNumberDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUSpeedDataLabel
            // 
            this.CPUSpeedDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CPUSpeedDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.CPUSpeedDataLabel, 3);
            this.CPUSpeedDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CPUSpeedDataLabel.Location = new System.Drawing.Point(114, 135);
            this.CPUSpeedDataLabel.Name = "CPUSpeedDataLabel";
            this.CPUSpeedDataLabel.Size = new System.Drawing.Size(329, 27);
            this.CPUSpeedDataLabel.TabIndex = 56;
            this.CPUSpeedDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HDDDataLabel
            // 
            this.HDDDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HDDDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.HDDDataLabel, 3);
            this.HDDDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HDDDataLabel.Location = new System.Drawing.Point(114, 162);
            this.HDDDataLabel.Name = "HDDDataLabel";
            this.HDDDataLabel.Size = new System.Drawing.Size(329, 27);
            this.HDDDataLabel.TabIndex = 56;
            this.HDDDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WebcamDataLabel
            // 
            this.WebcamDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebcamDataLabel.BackColor = System.Drawing.Color.White;
            this.SystemCompoinentsTableLayoutPanelB.SetColumnSpan(this.WebcamDataLabel, 3);
            this.WebcamDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WebcamDataLabel.Location = new System.Drawing.Point(114, 216);
            this.WebcamDataLabel.Name = "WebcamDataLabel";
            this.WebcamDataLabel.Size = new System.Drawing.Size(329, 35);
            this.WebcamDataLabel.TabIndex = 56;
            this.WebcamDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SystemCompoinentsTableLayoutPanelA
            // 
            this.SystemCompoinentsTableLayoutPanelA.ColumnCount = 4;
            this.SystemCompoinentsTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SystemCompoinentsTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.SystemCompoinentsTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SystemCompoinentsTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ModelDataLabel, 3, 1);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ManufacturerDataLabel, 1, 1);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.PlatformDataLabel, 3, 0);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ConditionDataLabel, 1, 0);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ConditionLabel, 0, 0);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ManufacturerLabel, 0, 1);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.PlatformLabel, 2, 0);
            this.SystemCompoinentsTableLayoutPanelA.Controls.Add(this.ModelLabel, 2, 1);
            this.SystemCompoinentsTableLayoutPanelA.Location = new System.Drawing.Point(0, 22);
            this.SystemCompoinentsTableLayoutPanelA.Name = "SystemCompoinentsTableLayoutPanelA";
            this.SystemCompoinentsTableLayoutPanelA.RowCount = 2;
            this.SystemCompoinentsTableLayoutPanelA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemCompoinentsTableLayoutPanelA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SystemCompoinentsTableLayoutPanelA.Size = new System.Drawing.Size(446, 54);
            this.SystemCompoinentsTableLayoutPanelA.TabIndex = 0;
            // 
            // ModelDataLabel
            // 
            this.ModelDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelDataLabel.BackColor = System.Drawing.Color.White;
            this.ModelDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ModelDataLabel.Location = new System.Drawing.Point(314, 27);
            this.ModelDataLabel.Name = "ModelDataLabel";
            this.ModelDataLabel.Size = new System.Drawing.Size(129, 27);
            this.ModelDataLabel.TabIndex = 57;
            this.ModelDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ManufacturerDataLabel
            // 
            this.ManufacturerDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerDataLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ManufacturerDataLabel.Location = new System.Drawing.Point(114, 27);
            this.ManufacturerDataLabel.Name = "ManufacturerDataLabel";
            this.ManufacturerDataLabel.Size = new System.Drawing.Size(105, 27);
            this.ManufacturerDataLabel.TabIndex = 56;
            this.ManufacturerDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PlatformDataLabel
            // 
            this.PlatformDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformDataLabel.BackColor = System.Drawing.Color.White;
            this.PlatformDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PlatformDataLabel.Location = new System.Drawing.Point(314, 0);
            this.PlatformDataLabel.Name = "PlatformDataLabel";
            this.PlatformDataLabel.Size = new System.Drawing.Size(129, 27);
            this.PlatformDataLabel.TabIndex = 55;
            this.PlatformDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionDataLabel
            // 
            this.ConditionDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionDataLabel.BackColor = System.Drawing.Color.White;
            this.ConditionDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ConditionDataLabel.Location = new System.Drawing.Point(114, 0);
            this.ConditionDataLabel.Name = "ConditionDataLabel";
            this.ConditionDataLabel.Size = new System.Drawing.Size(105, 27);
            this.ConditionDataLabel.TabIndex = 54;
            this.ConditionDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(3, 0);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(105, 27);
            this.ConditionLabel.TabIndex = 53;
            this.ConditionLabel.Text = "Condition";
            this.ConditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManufacturerLabel.AutoSize = true;
            this.ManufacturerLabel.Location = new System.Drawing.Point(3, 27);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(105, 27);
            this.ManufacturerLabel.TabIndex = 53;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlatformLabel.AutoSize = true;
            this.PlatformLabel.Location = new System.Drawing.Point(225, 0);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(83, 27);
            this.PlatformLabel.TabIndex = 53;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(225, 27);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(83, 27);
            this.ModelLabel.TabIndex = 53;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.SystemComponentsLineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(440, 321);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // SystemComponentsLineShape
            // 
            this.SystemComponentsLineShape.BorderColor = System.Drawing.Color.LightGray;
            this.SystemComponentsLineShape.Name = "SystemComponentsLineShape";
            this.SystemComponentsLineShape.X1 = -1;
            this.SystemComponentsLineShape.X2 = 441;
            this.SystemComponentsLineShape.Y1 = 61;
            this.SystemComponentsLineShape.Y2 = 61;
            // 
            // YourPriceGroupBox
            // 
            this.MainTableLayoutPanel.SetColumnSpan(this.YourPriceGroupBox, 3);
            this.YourPriceGroupBox.Controls.Add(this.YourPriceTableLayoutPanelB);
            this.YourPriceGroupBox.Controls.Add(this.YourPriceTableLayoutPanelA);
            this.YourPriceGroupBox.Controls.Add(this.shapeContainer2);
            this.YourPriceGroupBox.Location = new System.Drawing.Point(455, 171);
            this.YourPriceGroupBox.Name = "YourPriceGroupBox";
            this.MainTableLayoutPanel.SetRowSpan(this.YourPriceGroupBox, 5);
            this.YourPriceGroupBox.Size = new System.Drawing.Size(339, 114);
            this.YourPriceGroupBox.TabIndex = 53;
            this.YourPriceGroupBox.TabStop = false;
            this.YourPriceGroupBox.Text = "Your Price";
            // 
            // YourPriceTableLayoutPanelB
            // 
            this.YourPriceTableLayoutPanelB.ColumnCount = 3;
            this.YourPriceTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelB.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelB.Controls.Add(this.TotalLabel, 0, 0);
            this.YourPriceTableLayoutPanelB.Controls.Add(this.TotalDataLabel, 2, 0);
            this.YourPriceTableLayoutPanelB.Location = new System.Drawing.Point(-3, 82);
            this.YourPriceTableLayoutPanelB.Name = "YourPriceTableLayoutPanelB";
            this.YourPriceTableLayoutPanelB.RowCount = 1;
            this.YourPriceTableLayoutPanelB.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.YourPriceTableLayoutPanelB.Size = new System.Drawing.Size(342, 27);
            this.YourPriceTableLayoutPanelB.TabIndex = 1;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(3, 0);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(108, 27);
            this.TotalLabel.TabIndex = 55;
            this.TotalLabel.Text = "Total";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalDataLabel
            // 
            this.TotalDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalDataLabel.BackColor = System.Drawing.Color.White;
            this.TotalDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.TotalDataLabel.Location = new System.Drawing.Point(231, 0);
            this.TotalDataLabel.Name = "TotalDataLabel";
            this.TotalDataLabel.Size = new System.Drawing.Size(108, 27);
            this.TotalDataLabel.TabIndex = 56;
            this.TotalDataLabel.Text = " ";
            this.TotalDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // YourPriceTableLayoutPanelA
            // 
            this.YourPriceTableLayoutPanelA.ColumnCount = 3;
            this.YourPriceTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelA.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.YourPriceTableLayoutPanelA.Controls.Add(this.PriceLabel, 0, 0);
            this.YourPriceTableLayoutPanelA.Controls.Add(this.SalesTaxLabel, 0, 1);
            this.YourPriceTableLayoutPanelA.Controls.Add(this.PriceDataLabel, 2, 0);
            this.YourPriceTableLayoutPanelA.Controls.Add(this.SalesTaxDataLabel, 2, 1);
            this.YourPriceTableLayoutPanelA.Location = new System.Drawing.Point(-3, 17);
            this.YourPriceTableLayoutPanelA.Name = "YourPriceTableLayoutPanelA";
            this.YourPriceTableLayoutPanelA.RowCount = 2;
            this.YourPriceTableLayoutPanelA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.YourPriceTableLayoutPanelA.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.YourPriceTableLayoutPanelA.Size = new System.Drawing.Size(342, 53);
            this.YourPriceTableLayoutPanelA.TabIndex = 0;
            // 
            // PriceLabel
            // 
            this.PriceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(3, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(108, 26);
            this.PriceLabel.TabIndex = 54;
            this.PriceLabel.Text = "Price";
            this.PriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxLabel.AutoSize = true;
            this.SalesTaxLabel.Location = new System.Drawing.Point(3, 26);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(108, 27);
            this.SalesTaxLabel.TabIndex = 54;
            this.SalesTaxLabel.Text = "Sales Tax (13%)";
            this.SalesTaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceDataLabel
            // 
            this.PriceDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriceDataLabel.BackColor = System.Drawing.Color.White;
            this.PriceDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PriceDataLabel.Location = new System.Drawing.Point(231, 0);
            this.PriceDataLabel.Name = "PriceDataLabel";
            this.PriceDataLabel.Size = new System.Drawing.Size(108, 26);
            this.PriceDataLabel.TabIndex = 56;
            this.PriceDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalesTaxDataLabel
            // 
            this.SalesTaxDataLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SalesTaxDataLabel.BackColor = System.Drawing.Color.White;
            this.SalesTaxDataLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SalesTaxDataLabel.Location = new System.Drawing.Point(231, 26);
            this.SalesTaxDataLabel.Name = "SalesTaxDataLabel";
            this.SalesTaxDataLabel.Size = new System.Drawing.Size(108, 27);
            this.SalesTaxDataLabel.TabIndex = 56;
            this.SalesTaxDataLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(3, 19);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.YourPriceLineShape});
            this.shapeContainer2.Size = new System.Drawing.Size(333, 92);
            this.shapeContainer2.TabIndex = 2;
            this.shapeContainer2.TabStop = false;
            // 
            // YourPriceLineShape
            // 
            this.YourPriceLineShape.BorderColor = System.Drawing.Color.LightGray;
            this.YourPriceLineShape.Name = "YourPriceLineShape";
            this.YourPriceLineShape.X1 = 0;
            this.YourPriceLineShape.X2 = 335;
            this.YourPriceLineShape.Y1 = 56;
            this.YourPriceLineShape.Y2 = 56;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Location = new System.Drawing.Point(458, 318);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 25);
            this.CancelButton.TabIndex = 55;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.Location = new System.Drawing.Point(571, 318);
            this.BackButton.Margin = new System.Windows.Forms.Padding(6);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(101, 25);
            this.BackButton.TabIndex = 54;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackToolStripMenuItem_Click);
            // 
            // FinishButton
            // 
            this.FinishButton.AutoSize = true;
            this.FinishButton.Location = new System.Drawing.Point(684, 318);
            this.FinishButton.Margin = new System.Windows.Forms.Padding(6);
            this.FinishButton.Name = "FinishButton";
            this.FinishButton.Size = new System.Drawing.Size(101, 25);
            this.FinishButton.TabIndex = 54;
            this.FinishButton.Text = "Finish";
            this.FinishButton.UseVisualStyleBackColor = true;
            this.FinishButton.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 398);
            this.ControlBox = false;
            this.Controls.Add(this.MainTableLayoutPanel);
            this.Controls.Add(this.OrderFormCancelButton);
            this.Controls.Add(this.OrderFormBackButton);
            this.Controls.Add(this.OrderFormFinishButton);
            this.Controls.Add(this.OrderFormMenuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.OrderFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderForm";
            this.VisibleChanged += new System.EventHandler(this.OrderForm_VisibleChanged);
            this.OrderFormMenuStrip.ResumeLayout(false);
            this.OrderFormMenuStrip.PerformLayout();
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPictureBox)).EndInit();
            this.SystemComponentsGroupBox.ResumeLayout(false);
            this.SystemCompoinentsTableLayoutPanelB.ResumeLayout(false);
            this.SystemCompoinentsTableLayoutPanelB.PerformLayout();
            this.SystemCompoinentsTableLayoutPanelA.ResumeLayout(false);
            this.SystemCompoinentsTableLayoutPanelA.PerformLayout();
            this.YourPriceGroupBox.ResumeLayout(false);
            this.YourPriceTableLayoutPanelB.ResumeLayout(false);
            this.YourPriceTableLayoutPanelB.PerformLayout();
            this.YourPriceTableLayoutPanelA.ResumeLayout(false);
            this.YourPriceTableLayoutPanelA.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button OrderFormFinishButton;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.MenuStrip OrderFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrintToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button OrderFormCancelButton;
        private System.Windows.Forms.Button OrderFormBackButton;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.GroupBox SystemComponentsGroupBox;
        private System.Windows.Forms.TableLayoutPanel SystemCompoinentsTableLayoutPanelA;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape SystemComponentsLineShape;
        private System.Windows.Forms.TableLayoutPanel SystemCompoinentsTableLayoutPanelB;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Label GPUTypeDataLabel;
        private System.Windows.Forms.Label LCDSizeDataLabel;
        private System.Windows.Forms.Label MemoryDataLabel;
        private System.Windows.Forms.Label CPUBrandDataLabel;
        private System.Windows.Forms.Label CPUTypeDataLabel;
        private System.Windows.Forms.Label CPUNumberDataLabel;
        private System.Windows.Forms.Label CPUSpeedDataLabel;
        private System.Windows.Forms.Label HDDDataLabel;
        private System.Windows.Forms.Label WebcamDataLabel;
        private System.Windows.Forms.Label ModelDataLabel;
        private System.Windows.Forms.Label ManufacturerDataLabel;
        private System.Windows.Forms.Label PlatformDataLabel;
        private System.Windows.Forms.Label ConditionDataLabel;
        private System.Windows.Forms.PictureBox ProductPictureBox;
        private System.Windows.Forms.GroupBox YourPriceGroupBox;
        private System.Windows.Forms.TableLayoutPanel YourPriceTableLayoutPanelB;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label TotalDataLabel;
        private System.Windows.Forms.TableLayoutPanel YourPriceTableLayoutPanelA;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label PriceDataLabel;
        private System.Windows.Forms.Label SalesTaxDataLabel;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape YourPriceLineShape;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button FinishButton;
    }
}

