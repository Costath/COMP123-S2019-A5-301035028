namespace COMP123_S2019_A5_301035028.Views
{
    partial class ProductInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoForm));
            this.ProductInfoFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductInfoFormPrevButton = new System.Windows.Forms.Button();
            this.ProductInfoFormNextButton = new System.Windows.Forms.Button();
            this.ProductInfoFormOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TechSpecsGroupBox = new System.Windows.Forms.GroupBox();
            this.WebcamValueLabel = new System.Windows.Forms.Label();
            this.GPUTypeValueLabel = new System.Windows.Forms.Label();
            this.LCDSizeValueLabel = new System.Windows.Forms.Label();
            this.GPUTypeLabel = new System.Windows.Forms.Label();
            this.HDDValueLabel = new System.Windows.Forms.Label();
            this.MemoryLabel = new System.Windows.Forms.Label();
            this.CPUNumberValueLabel = new System.Windows.Forms.Label();
            this.CPUBrandLabel = new System.Windows.Forms.Label();
            this.LCDSizeLabel = new System.Windows.Forms.Label();
            this.CPUSpeedValueLabel = new System.Windows.Forms.Label();
            this.CPUTypeLabel = new System.Windows.Forms.Label();
            this.CPUTypeValueLabel = new System.Windows.Forms.Label();
            this.WebcamLabel = new System.Windows.Forms.Label();
            this.CPUBrandValueLabel = new System.Windows.Forms.Label();
            this.CPUSpeedLabel = new System.Windows.Forms.Label();
            this.MemoryValueLabel = new System.Windows.Forms.Label();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.CPUNumberLabel = new System.Windows.Forms.Label();
            this.ProductIDLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.PlatformLabel = new System.Windows.Forms.Label();
            this.ManufacturerLabel = new System.Windows.Forms.Label();
            this.ProductIDValueLabel = new System.Windows.Forms.Label();
            this.ConditionLabel = new System.Windows.Forms.Label();
            this.OSlabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.ProductInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ModelValueLabel = new System.Windows.Forms.Label();
            this.OSValueLabel = new System.Windows.Forms.Label();
            this.ManufacturerValueLabel = new System.Windows.Forms.Label();
            this.PlatformValueLabel = new System.Windows.Forms.Label();
            this.ConditionValueLabel = new System.Windows.Forms.Label();
            this.CostValueLabel = new System.Windows.Forms.Label();
            this.ProductInfoSelectAnotherProductbutton = new System.Windows.Forms.Button();
            this.ProductInfoCancelButton = new System.Windows.Forms.Button();
            this.ProductInfoNextButton = new System.Windows.Forms.Button();
            this.ProductInfoFormSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ProductInfoFormMenuStrip.SuspendLayout();
            this.TechSpecsGroupBox.SuspendLayout();
            this.ProductInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductInfoFormMenuStrip
            // 
            this.ProductInfoFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.ProductInfoFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ProductInfoFormMenuStrip.Name = "ProductInfoFormMenuStrip";
            this.ProductInfoFormMenuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.ProductInfoFormMenuStrip.Size = new System.Drawing.Size(715, 25);
            this.ProductInfoFormMenuStrip.TabIndex = 0;
            this.ProductInfoFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.toolStripSeparator1,
            this.ExitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStripMenuItem.Image")));
            this.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "&Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStripMenuItem.Image")));
            this.SaveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "&Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ExitToolStripMenuItem.Text = "E&xit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.selectAnotherProductToolStripMenuItem.Text = "Select Another Product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.ProductInfoSelectAnotherProductbutton_Click);
            // 
            // ProductInfoFormPrevButton
            // 
            this.ProductInfoFormPrevButton.AutoSize = true;
            this.ProductInfoFormPrevButton.Location = new System.Drawing.Point(16, 364);
            this.ProductInfoFormPrevButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProductInfoFormPrevButton.Name = "ProductInfoFormPrevButton";
            this.ProductInfoFormPrevButton.Size = new System.Drawing.Size(109, 28);
            this.ProductInfoFormPrevButton.TabIndex = 7;
            this.ProductInfoFormPrevButton.Text = "Previous Form";
            this.ProductInfoFormPrevButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ProductInfoFormPrevButton.UseVisualStyleBackColor = true;
            this.ProductInfoFormPrevButton.Click += new System.EventHandler(this.ProductInfoFormPrevButton_Click);
            // 
            // ProductInfoFormNextButton
            // 
            this.ProductInfoFormNextButton.AutoSize = true;
            this.ProductInfoFormNextButton.Location = new System.Drawing.Point(133, 364);
            this.ProductInfoFormNextButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProductInfoFormNextButton.Name = "ProductInfoFormNextButton";
            this.ProductInfoFormNextButton.Size = new System.Drawing.Size(82, 28);
            this.ProductInfoFormNextButton.TabIndex = 6;
            this.ProductInfoFormNextButton.Text = "Next Form";
            this.ProductInfoFormNextButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ProductInfoFormNextButton.UseVisualStyleBackColor = true;
            this.ProductInfoFormNextButton.Click += new System.EventHandler(this.ProductInfoFormNextButton_Click);
            // 
            // ProductInfoFormOpenFileDialog
            // 
            this.ProductInfoFormOpenFileDialog.FileName = "openFileDialog1";
            // 
            // TechSpecsGroupBox
            // 
            this.TechSpecsGroupBox.Controls.Add(this.WebcamValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.GPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandLabel);
            this.TechSpecsGroupBox.Controls.Add(this.LCDSizeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUTypeValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.WebcamLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUBrandValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUSpeedLabel);
            this.TechSpecsGroupBox.Controls.Add(this.MemoryValueLabel);
            this.TechSpecsGroupBox.Controls.Add(this.HDDLabel);
            this.TechSpecsGroupBox.Controls.Add(this.CPUNumberLabel);
            this.TechSpecsGroupBox.Location = new System.Drawing.Point(12, 215);
            this.TechSpecsGroupBox.Name = "TechSpecsGroupBox";
            this.TechSpecsGroupBox.Size = new System.Drawing.Size(691, 129);
            this.TechSpecsGroupBox.TabIndex = 9;
            this.TechSpecsGroupBox.TabStop = false;
            this.TechSpecsGroupBox.Text = "Tech Specs";
            // 
            // WebcamValueLabel
            // 
            this.WebcamValueLabel.BackColor = System.Drawing.Color.White;
            this.WebcamValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WebcamValueLabel.Location = new System.Drawing.Point(576, 68);
            this.WebcamValueLabel.Name = "WebcamValueLabel";
            this.WebcamValueLabel.Size = new System.Drawing.Size(95, 19);
            this.WebcamValueLabel.TabIndex = 30;
            // 
            // GPUTypeValueLabel
            // 
            this.GPUTypeValueLabel.BackColor = System.Drawing.Color.White;
            this.GPUTypeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GPUTypeValueLabel.Location = new System.Drawing.Point(576, 50);
            this.GPUTypeValueLabel.Name = "GPUTypeValueLabel";
            this.GPUTypeValueLabel.Size = new System.Drawing.Size(95, 19);
            this.GPUTypeValueLabel.TabIndex = 29;
            // 
            // LCDSizeValueLabel
            // 
            this.LCDSizeValueLabel.BackColor = System.Drawing.Color.White;
            this.LCDSizeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LCDSizeValueLabel.Location = new System.Drawing.Point(337, 32);
            this.LCDSizeValueLabel.Name = "LCDSizeValueLabel";
            this.LCDSizeValueLabel.Size = new System.Drawing.Size(95, 19);
            this.LCDSizeValueLabel.TabIndex = 20;
            // 
            // GPUTypeLabel
            // 
            this.GPUTypeLabel.Location = new System.Drawing.Point(498, 50);
            this.GPUTypeLabel.Name = "GPUTypeLabel";
            this.GPUTypeLabel.Size = new System.Drawing.Size(78, 17);
            this.GPUTypeLabel.TabIndex = 30;
            this.GPUTypeLabel.Text = "GPU Type";
            this.GPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HDDValueLabel
            // 
            this.HDDValueLabel.BackColor = System.Drawing.Color.White;
            this.HDDValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HDDValueLabel.Location = new System.Drawing.Point(576, 32);
            this.HDDValueLabel.Name = "HDDValueLabel";
            this.HDDValueLabel.Size = new System.Drawing.Size(95, 19);
            this.HDDValueLabel.TabIndex = 28;
            // 
            // MemoryLabel
            // 
            this.MemoryLabel.Location = new System.Drawing.Point(46, 31);
            this.MemoryLabel.Name = "MemoryLabel";
            this.MemoryLabel.Size = new System.Drawing.Size(78, 17);
            this.MemoryLabel.TabIndex = 20;
            this.MemoryLabel.Text = "Memory";
            this.MemoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberValueLabel
            // 
            this.CPUNumberValueLabel.BackColor = System.Drawing.Color.White;
            this.CPUNumberValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUNumberValueLabel.Location = new System.Drawing.Point(337, 50);
            this.CPUNumberValueLabel.Name = "CPUNumberValueLabel";
            this.CPUNumberValueLabel.Size = new System.Drawing.Size(95, 19);
            this.CPUNumberValueLabel.TabIndex = 27;
            // 
            // CPUBrandLabel
            // 
            this.CPUBrandLabel.Location = new System.Drawing.Point(46, 50);
            this.CPUBrandLabel.Name = "CPUBrandLabel";
            this.CPUBrandLabel.Size = new System.Drawing.Size(78, 17);
            this.CPUBrandLabel.TabIndex = 21;
            this.CPUBrandLabel.Text = "CPU Brand";
            this.CPUBrandLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LCDSizeLabel
            // 
            this.LCDSizeLabel.Location = new System.Drawing.Point(246, 31);
            this.LCDSizeLabel.Name = "LCDSizeLabel";
            this.LCDSizeLabel.Size = new System.Drawing.Size(90, 17);
            this.LCDSizeLabel.TabIndex = 13;
            this.LCDSizeLabel.Text = "LCD Size";
            this.LCDSizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUSpeedValueLabel
            // 
            this.CPUSpeedValueLabel.BackColor = System.Drawing.Color.White;
            this.CPUSpeedValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUSpeedValueLabel.Location = new System.Drawing.Point(337, 68);
            this.CPUSpeedValueLabel.Name = "CPUSpeedValueLabel";
            this.CPUSpeedValueLabel.Size = new System.Drawing.Size(95, 19);
            this.CPUSpeedValueLabel.TabIndex = 26;
            // 
            // CPUTypeLabel
            // 
            this.CPUTypeLabel.Location = new System.Drawing.Point(46, 69);
            this.CPUTypeLabel.Name = "CPUTypeLabel";
            this.CPUTypeLabel.Size = new System.Drawing.Size(78, 17);
            this.CPUTypeLabel.TabIndex = 22;
            this.CPUTypeLabel.Text = "CPU Type";
            this.CPUTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUTypeValueLabel
            // 
            this.CPUTypeValueLabel.BackColor = System.Drawing.Color.White;
            this.CPUTypeValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUTypeValueLabel.Location = new System.Drawing.Point(130, 68);
            this.CPUTypeValueLabel.Name = "CPUTypeValueLabel";
            this.CPUTypeValueLabel.Size = new System.Drawing.Size(95, 19);
            this.CPUTypeValueLabel.TabIndex = 25;
            // 
            // WebcamLabel
            // 
            this.WebcamLabel.Location = new System.Drawing.Point(498, 69);
            this.WebcamLabel.Name = "WebcamLabel";
            this.WebcamLabel.Size = new System.Drawing.Size(78, 17);
            this.WebcamLabel.TabIndex = 31;
            this.WebcamLabel.Text = "WebCam";
            this.WebcamLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUBrandValueLabel
            // 
            this.CPUBrandValueLabel.BackColor = System.Drawing.Color.White;
            this.CPUBrandValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPUBrandValueLabel.Location = new System.Drawing.Point(130, 50);
            this.CPUBrandValueLabel.Name = "CPUBrandValueLabel";
            this.CPUBrandValueLabel.Size = new System.Drawing.Size(95, 19);
            this.CPUBrandValueLabel.TabIndex = 24;
            // 
            // CPUSpeedLabel
            // 
            this.CPUSpeedLabel.Location = new System.Drawing.Point(246, 69);
            this.CPUSpeedLabel.Name = "CPUSpeedLabel";
            this.CPUSpeedLabel.Size = new System.Drawing.Size(90, 17);
            this.CPUSpeedLabel.TabIndex = 23;
            this.CPUSpeedLabel.Text = "CPU Speed";
            this.CPUSpeedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MemoryValueLabel
            // 
            this.MemoryValueLabel.BackColor = System.Drawing.Color.White;
            this.MemoryValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemoryValueLabel.Location = new System.Drawing.Point(130, 32);
            this.MemoryValueLabel.Name = "MemoryValueLabel";
            this.MemoryValueLabel.Size = new System.Drawing.Size(95, 19);
            this.MemoryValueLabel.TabIndex = 23;
            // 
            // HDDLabel
            // 
            this.HDDLabel.Location = new System.Drawing.Point(498, 31);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(78, 17);
            this.HDDLabel.TabIndex = 29;
            this.HDDLabel.Text = "HDD";
            this.HDDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CPUNumberLabel
            // 
            this.CPUNumberLabel.Location = new System.Drawing.Point(246, 50);
            this.CPUNumberLabel.Name = "CPUNumberLabel";
            this.CPUNumberLabel.Size = new System.Drawing.Size(90, 17);
            this.CPUNumberLabel.TabIndex = 28;
            this.CPUNumberLabel.Text = "CPU Number";
            this.CPUNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIDLabel
            // 
            this.ProductIDLabel.AutoSize = true;
            this.ProductIDLabel.Location = new System.Drawing.Point(63, 40);
            this.ProductIDLabel.Name = "ProductIDLabel";
            this.ProductIDLabel.Size = new System.Drawing.Size(74, 17);
            this.ProductIDLabel.TabIndex = 0;
            this.ProductIDLabel.Text = "Product ID";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(491, 40);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(36, 17);
            this.CostLabel.TabIndex = 1;
            this.CostLabel.Text = "Cost";
            // 
            // PlatformLabel
            // 
            this.PlatformLabel.Location = new System.Drawing.Point(27, 40);
            this.PlatformLabel.Name = "PlatformLabel";
            this.PlatformLabel.Size = new System.Drawing.Size(92, 17);
            this.PlatformLabel.TabIndex = 2;
            this.PlatformLabel.Text = "Platform";
            this.PlatformLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ManufacturerLabel
            // 
            this.ManufacturerLabel.Location = new System.Drawing.Point(27, 76);
            this.ManufacturerLabel.Name = "ManufacturerLabel";
            this.ManufacturerLabel.Size = new System.Drawing.Size(92, 17);
            this.ManufacturerLabel.TabIndex = 3;
            this.ManufacturerLabel.Text = "Manufacturer";
            this.ManufacturerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductIDValueLabel
            // 
            this.ProductIDValueLabel.BackColor = System.Drawing.Color.White;
            this.ProductIDValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductIDValueLabel.Location = new System.Drawing.Point(142, 38);
            this.ProductIDValueLabel.Name = "ProductIDValueLabel";
            this.ProductIDValueLabel.Size = new System.Drawing.Size(95, 19);
            this.ProductIDValueLabel.TabIndex = 8;
            // 
            // ConditionLabel
            // 
            this.ConditionLabel.AutoSize = true;
            this.ConditionLabel.Location = new System.Drawing.Point(272, 40);
            this.ConditionLabel.Name = "ConditionLabel";
            this.ConditionLabel.Size = new System.Drawing.Size(67, 17);
            this.ConditionLabel.TabIndex = 12;
            this.ConditionLabel.Text = "Condition";
            // 
            // OSlabel
            // 
            this.OSlabel.Location = new System.Drawing.Point(233, 38);
            this.OSlabel.Name = "OSlabel";
            this.OSlabel.Size = new System.Drawing.Size(92, 17);
            this.OSlabel.TabIndex = 14;
            this.OSlabel.Text = "OS";
            this.OSlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Location = new System.Drawing.Point(233, 74);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(92, 17);
            this.ModelLabel.TabIndex = 15;
            this.ModelLabel.Text = "Model";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ProductInfoGroupBox
            // 
            this.ProductInfoGroupBox.Controls.Add(this.ModelValueLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSValueLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerValueLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformValueLabel);
            this.ProductInfoGroupBox.Controls.Add(this.ModelLabel);
            this.ProductInfoGroupBox.Controls.Add(this.OSlabel);
            this.ProductInfoGroupBox.Controls.Add(this.ManufacturerLabel);
            this.ProductInfoGroupBox.Controls.Add(this.PlatformLabel);
            this.ProductInfoGroupBox.Location = new System.Drawing.Point(21, 80);
            this.ProductInfoGroupBox.Name = "ProductInfoGroupBox";
            this.ProductInfoGroupBox.Size = new System.Drawing.Size(682, 129);
            this.ProductInfoGroupBox.TabIndex = 8;
            this.ProductInfoGroupBox.TabStop = false;
            this.ProductInfoGroupBox.Text = "Product Info";
            // 
            // ModelValueLabel
            // 
            this.ModelValueLabel.BackColor = System.Drawing.Color.White;
            this.ModelValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModelValueLabel.Location = new System.Drawing.Point(328, 74);
            this.ModelValueLabel.Name = "ModelValueLabel";
            this.ModelValueLabel.Size = new System.Drawing.Size(298, 19);
            this.ModelValueLabel.TabIndex = 22;
            // 
            // OSValueLabel
            // 
            this.OSValueLabel.BackColor = System.Drawing.Color.White;
            this.OSValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OSValueLabel.Location = new System.Drawing.Point(328, 36);
            this.OSValueLabel.Name = "OSValueLabel";
            this.OSValueLabel.Size = new System.Drawing.Size(298, 19);
            this.OSValueLabel.TabIndex = 21;
            // 
            // ManufacturerValueLabel
            // 
            this.ManufacturerValueLabel.BackColor = System.Drawing.Color.White;
            this.ManufacturerValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManufacturerValueLabel.Location = new System.Drawing.Point(121, 76);
            this.ManufacturerValueLabel.Name = "ManufacturerValueLabel";
            this.ManufacturerValueLabel.Size = new System.Drawing.Size(95, 19);
            this.ManufacturerValueLabel.TabIndex = 18;
            // 
            // PlatformValueLabel
            // 
            this.PlatformValueLabel.BackColor = System.Drawing.Color.White;
            this.PlatformValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlatformValueLabel.Location = new System.Drawing.Point(121, 38);
            this.PlatformValueLabel.Name = "PlatformValueLabel";
            this.PlatformValueLabel.Size = new System.Drawing.Size(95, 19);
            this.PlatformValueLabel.TabIndex = 17;
            // 
            // ConditionValueLabel
            // 
            this.ConditionValueLabel.BackColor = System.Drawing.Color.White;
            this.ConditionValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConditionValueLabel.Location = new System.Drawing.Point(349, 40);
            this.ConditionValueLabel.Name = "ConditionValueLabel";
            this.ConditionValueLabel.Size = new System.Drawing.Size(95, 19);
            this.ConditionValueLabel.TabIndex = 19;
            // 
            // CostValueLabel
            // 
            this.CostValueLabel.BackColor = System.Drawing.Color.White;
            this.CostValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostValueLabel.Location = new System.Drawing.Point(531, 39);
            this.CostValueLabel.Name = "CostValueLabel";
            this.CostValueLabel.Size = new System.Drawing.Size(95, 19);
            this.CostValueLabel.TabIndex = 16;
            // 
            // ProductInfoSelectAnotherProductbutton
            // 
            this.ProductInfoSelectAnotherProductbutton.AutoSize = true;
            this.ProductInfoSelectAnotherProductbutton.Location = new System.Drawing.Point(334, 364);
            this.ProductInfoSelectAnotherProductbutton.Margin = new System.Windows.Forms.Padding(4);
            this.ProductInfoSelectAnotherProductbutton.Name = "ProductInfoSelectAnotherProductbutton";
            this.ProductInfoSelectAnotherProductbutton.Size = new System.Drawing.Size(164, 28);
            this.ProductInfoSelectAnotherProductbutton.TabIndex = 12;
            this.ProductInfoSelectAnotherProductbutton.Text = "Select Another Product";
            this.ProductInfoSelectAnotherProductbutton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ProductInfoSelectAnotherProductbutton.UseVisualStyleBackColor = true;
            this.ProductInfoSelectAnotherProductbutton.Click += new System.EventHandler(this.ProductInfoSelectAnotherProductbutton_Click);
            // 
            // ProductInfoCancelButton
            // 
            this.ProductInfoCancelButton.AutoSize = true;
            this.ProductInfoCancelButton.Location = new System.Drawing.Point(531, 364);
            this.ProductInfoCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.ProductInfoCancelButton.Name = "ProductInfoCancelButton";
            this.ProductInfoCancelButton.Size = new System.Drawing.Size(61, 28);
            this.ProductInfoCancelButton.TabIndex = 13;
            this.ProductInfoCancelButton.Text = "Cancel";
            this.ProductInfoCancelButton.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.ProductInfoCancelButton.UseVisualStyleBackColor = true;
            this.ProductInfoCancelButton.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // ProductInfoNextButton
            // 
            this.ProductInfoNextButton.Location = new System.Drawing.Point(624, 364);
            this.ProductInfoNextButton.Name = "ProductInfoNextButton";
            this.ProductInfoNextButton.Size = new System.Drawing.Size(75, 28);
            this.ProductInfoNextButton.TabIndex = 14;
            this.ProductInfoNextButton.Text = "Next";
            this.ProductInfoNextButton.UseVisualStyleBackColor = true;
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 400);
            this.ControlBox = false;
            this.Controls.Add(this.ProductInfoNextButton);
            this.Controls.Add(this.ProductInfoCancelButton);
            this.Controls.Add(this.ProductInfoSelectAnotherProductbutton);
            this.Controls.Add(this.ConditionValueLabel);
            this.Controls.Add(this.CostValueLabel);
            this.Controls.Add(this.TechSpecsGroupBox);
            this.Controls.Add(this.ProductInfoGroupBox);
            this.Controls.Add(this.ProductInfoFormPrevButton);
            this.Controls.Add(this.ProductInfoFormNextButton);
            this.Controls.Add(this.ProductInfoFormMenuStrip);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.ConditionLabel);
            this.Controls.Add(this.ProductIDLabel);
            this.Controls.Add(this.ProductIDValueLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MainMenuStrip = this.ProductInfoFormMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoFormcs";
            this.VisibleChanged += new System.EventHandler(this.ProductInfoForm_VisibleChanged);
            this.ProductInfoFormMenuStrip.ResumeLayout(false);
            this.ProductInfoFormMenuStrip.PerformLayout();
            this.TechSpecsGroupBox.ResumeLayout(false);
            this.ProductInfoGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ProductInfoFormMenuStrip;
        private System.Windows.Forms.Button ProductInfoFormPrevButton;
        private System.Windows.Forms.Button ProductInfoFormNextButton;
        public System.Windows.Forms.OpenFileDialog ProductInfoFormOpenFileDialog;
        private System.Windows.Forms.GroupBox TechSpecsGroupBox;
        private System.Windows.Forms.Label GPUTypeLabel;
        private System.Windows.Forms.Label MemoryLabel;
        private System.Windows.Forms.Label CPUBrandLabel;
        private System.Windows.Forms.Label CPUTypeLabel;
        private System.Windows.Forms.Label WebcamLabel;
        private System.Windows.Forms.Label CPUSpeedLabel;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.Label CPUNumberLabel;
        private System.Windows.Forms.Label WebcamValueLabel;
        private System.Windows.Forms.Label GPUTypeValueLabel;
        private System.Windows.Forms.Label HDDValueLabel;
        private System.Windows.Forms.Label CPUNumberValueLabel;
        private System.Windows.Forms.Label CPUSpeedValueLabel;
        private System.Windows.Forms.Label CPUTypeValueLabel;
        private System.Windows.Forms.Label CPUBrandValueLabel;
        private System.Windows.Forms.Label MemoryValueLabel;
        private System.Windows.Forms.Label ProductIDLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label PlatformLabel;
        private System.Windows.Forms.Label ManufacturerLabel;
        private System.Windows.Forms.Label ProductIDValueLabel;
        private System.Windows.Forms.Label ConditionLabel;
        private System.Windows.Forms.Label LCDSizeLabel;
        private System.Windows.Forms.Label OSlabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.GroupBox ProductInfoGroupBox;
        private System.Windows.Forms.Label ModelValueLabel;
        private System.Windows.Forms.Label OSValueLabel;
        private System.Windows.Forms.Label LCDSizeValueLabel;
        private System.Windows.Forms.Label ConditionValueLabel;
        private System.Windows.Forms.Label ManufacturerValueLabel;
        private System.Windows.Forms.Label PlatformValueLabel;
        private System.Windows.Forms.Label CostValueLabel;
        private System.Windows.Forms.Button ProductInfoSelectAnotherProductbutton;
        private System.Windows.Forms.Button ProductInfoCancelButton;
        private System.Windows.Forms.Button ProductInfoNextButton;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog ProductInfoFormSaveFileDialog;
    }
}