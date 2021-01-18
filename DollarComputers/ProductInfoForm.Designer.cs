namespace DollarComputers
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
            this.Next_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Select_button = new System.Windows.Forms.Button();
            this.Click_label = new System.Windows.Forms.Label();
            this.TechSpecs_groupBox = new System.Windows.Forms.GroupBox();
            this.WebCam_textBox = new System.Windows.Forms.TextBox();
            this.GPUType_textBox = new System.Windows.Forms.TextBox();
            this.HDD_textBox = new System.Windows.Forms.TextBox();
            this.CPUSpeed_textBox = new System.Windows.Forms.TextBox();
            this.CPUNumber_textBox = new System.Windows.Forms.TextBox();
            this.LCDSize_textBox = new System.Windows.Forms.TextBox();
            this.CPUType_textBox = new System.Windows.Forms.TextBox();
            this.CPUBrand_textBox = new System.Windows.Forms.TextBox();
            this.Memory_textBox = new System.Windows.Forms.TextBox();
            this.WebCam_label = new System.Windows.Forms.Label();
            this.GPUType_label = new System.Windows.Forms.Label();
            this.HDD_label = new System.Windows.Forms.Label();
            this.CPUSpeed_label = new System.Windows.Forms.Label();
            this.CPUNumber_label = new System.Windows.Forms.Label();
            this.LCDSIze_label = new System.Windows.Forms.Label();
            this.CPUType_label = new System.Windows.Forms.Label();
            this.CPUBrand_label = new System.Windows.Forms.Label();
            this.Memory_label = new System.Windows.Forms.Label();
            this.ProductInfo_groupBox = new System.Windows.Forms.GroupBox();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.OS_textBox = new System.Windows.Forms.TextBox();
            this.Manufacturer_textBox = new System.Windows.Forms.TextBox();
            this.Platform_textBox = new System.Windows.Forms.TextBox();
            this.Model_label = new System.Windows.Forms.Label();
            this.OS_label = new System.Windows.Forms.Label();
            this.Manufacturer_label = new System.Windows.Forms.Label();
            this.Platform_label = new System.Windows.Forms.Label();
            this.Cost_textBox = new System.Windows.Forms.TextBox();
            this.Condition_textBox = new System.Windows.Forms.TextBox();
            this.ProductID_textBox = new System.Windows.Forms.TextBox();
            this.Cost_label = new System.Windows.Forms.Label();
            this.Condition_label = new System.Windows.Forms.Label();
            this.ProductID_label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAnotherProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DollarSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.DollarOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TechSpecs_groupBox.SuspendLayout();
            this.ProductInfo_groupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(500, 525);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(138, 39);
            this.Next_button.TabIndex = 24;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(644, 525);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(138, 39);
            this.Cancel_button.TabIndex = 23;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Select_button
            // 
            this.Select_button.Location = new System.Drawing.Point(303, 525);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(187, 39);
            this.Select_button.TabIndex = 22;
            this.Select_button.Text = "Select another product";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // Click_label
            // 
            this.Click_label.AutoSize = true;
            this.Click_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Click_label.Location = new System.Drawing.Point(22, 534);
            this.Click_label.Name = "Click_label";
            this.Click_label.Size = new System.Drawing.Size(249, 18);
            this.Click_label.TabIndex = 21;
            this.Click_label.Text = "Click Next to Confirm Your Selection";
            // 
            // TechSpecs_groupBox
            // 
            this.TechSpecs_groupBox.Controls.Add(this.WebCam_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.GPUType_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.HDD_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.CPUSpeed_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.CPUNumber_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.LCDSize_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.CPUType_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.CPUBrand_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.Memory_textBox);
            this.TechSpecs_groupBox.Controls.Add(this.WebCam_label);
            this.TechSpecs_groupBox.Controls.Add(this.GPUType_label);
            this.TechSpecs_groupBox.Controls.Add(this.HDD_label);
            this.TechSpecs_groupBox.Controls.Add(this.CPUSpeed_label);
            this.TechSpecs_groupBox.Controls.Add(this.CPUNumber_label);
            this.TechSpecs_groupBox.Controls.Add(this.LCDSIze_label);
            this.TechSpecs_groupBox.Controls.Add(this.CPUType_label);
            this.TechSpecs_groupBox.Controls.Add(this.CPUBrand_label);
            this.TechSpecs_groupBox.Controls.Add(this.Memory_label);
            this.TechSpecs_groupBox.Location = new System.Drawing.Point(11, 289);
            this.TechSpecs_groupBox.Name = "TechSpecs_groupBox";
            this.TechSpecs_groupBox.Size = new System.Drawing.Size(778, 208);
            this.TechSpecs_groupBox.TabIndex = 20;
            this.TechSpecs_groupBox.TabStop = false;
            this.TechSpecs_groupBox.Text = "Tech Speces";
            // 
            // WebCam_textBox
            // 
            this.WebCam_textBox.Location = new System.Drawing.Point(607, 152);
            this.WebCam_textBox.Name = "WebCam_textBox";
            this.WebCam_textBox.Size = new System.Drawing.Size(127, 22);
            this.WebCam_textBox.TabIndex = 23;
            // 
            // GPUType_textBox
            // 
            this.GPUType_textBox.Location = new System.Drawing.Point(607, 90);
            this.GPUType_textBox.Name = "GPUType_textBox";
            this.GPUType_textBox.Size = new System.Drawing.Size(127, 22);
            this.GPUType_textBox.TabIndex = 22;
            // 
            // HDD_textBox
            // 
            this.HDD_textBox.Location = new System.Drawing.Point(607, 32);
            this.HDD_textBox.Name = "HDD_textBox";
            this.HDD_textBox.Size = new System.Drawing.Size(127, 22);
            this.HDD_textBox.TabIndex = 21;
            // 
            // CPUSpeed_textBox
            // 
            this.CPUSpeed_textBox.Location = new System.Drawing.Point(358, 152);
            this.CPUSpeed_textBox.Name = "CPUSpeed_textBox";
            this.CPUSpeed_textBox.Size = new System.Drawing.Size(127, 22);
            this.CPUSpeed_textBox.TabIndex = 20;
            // 
            // CPUNumber_textBox
            // 
            this.CPUNumber_textBox.Location = new System.Drawing.Point(358, 90);
            this.CPUNumber_textBox.Name = "CPUNumber_textBox";
            this.CPUNumber_textBox.Size = new System.Drawing.Size(127, 22);
            this.CPUNumber_textBox.TabIndex = 19;
            // 
            // LCDSize_textBox
            // 
            this.LCDSize_textBox.Location = new System.Drawing.Point(358, 34);
            this.LCDSize_textBox.Name = "LCDSize_textBox";
            this.LCDSize_textBox.Size = new System.Drawing.Size(127, 22);
            this.LCDSize_textBox.TabIndex = 18;
            // 
            // CPUType_textBox
            // 
            this.CPUType_textBox.Location = new System.Drawing.Point(115, 150);
            this.CPUType_textBox.Name = "CPUType_textBox";
            this.CPUType_textBox.Size = new System.Drawing.Size(127, 22);
            this.CPUType_textBox.TabIndex = 17;
            // 
            // CPUBrand_textBox
            // 
            this.CPUBrand_textBox.Location = new System.Drawing.Point(116, 90);
            this.CPUBrand_textBox.Name = "CPUBrand_textBox";
            this.CPUBrand_textBox.Size = new System.Drawing.Size(127, 22);
            this.CPUBrand_textBox.TabIndex = 16;
            // 
            // Memory_textBox
            // 
            this.Memory_textBox.Location = new System.Drawing.Point(116, 35);
            this.Memory_textBox.Name = "Memory_textBox";
            this.Memory_textBox.Size = new System.Drawing.Size(127, 22);
            this.Memory_textBox.TabIndex = 15;
            // 
            // WebCam_label
            // 
            this.WebCam_label.AutoSize = true;
            this.WebCam_label.Location = new System.Drawing.Point(509, 152);
            this.WebCam_label.Name = "WebCam_label";
            this.WebCam_label.Size = new System.Drawing.Size(69, 17);
            this.WebCam_label.TabIndex = 14;
            this.WebCam_label.Text = "Web Cam";
            // 
            // GPUType_label
            // 
            this.GPUType_label.AutoSize = true;
            this.GPUType_label.Location = new System.Drawing.Point(509, 95);
            this.GPUType_label.Name = "GPUType_label";
            this.GPUType_label.Size = new System.Drawing.Size(74, 17);
            this.GPUType_label.TabIndex = 13;
            this.GPUType_label.Text = "GPU Type";
            // 
            // HDD_label
            // 
            this.HDD_label.AutoSize = true;
            this.HDD_label.Location = new System.Drawing.Point(509, 37);
            this.HDD_label.Name = "HDD_label";
            this.HDD_label.Size = new System.Drawing.Size(38, 17);
            this.HDD_label.TabIndex = 12;
            this.HDD_label.Text = "HDD";
            // 
            // CPUSpeed_label
            // 
            this.CPUSpeed_label.AutoSize = true;
            this.CPUSpeed_label.Location = new System.Drawing.Point(260, 153);
            this.CPUSpeed_label.Name = "CPUSpeed_label";
            this.CPUSpeed_label.Size = new System.Drawing.Size(81, 17);
            this.CPUSpeed_label.TabIndex = 11;
            this.CPUSpeed_label.Text = "CPU Speed";
            // 
            // CPUNumber_label
            // 
            this.CPUNumber_label.AutoSize = true;
            this.CPUNumber_label.Location = new System.Drawing.Point(260, 95);
            this.CPUNumber_label.Name = "CPUNumber_label";
            this.CPUNumber_label.Size = new System.Drawing.Size(90, 17);
            this.CPUNumber_label.TabIndex = 10;
            this.CPUNumber_label.Text = "CPU Number";
            // 
            // LCDSIze_label
            // 
            this.LCDSIze_label.AutoSize = true;
            this.LCDSIze_label.Location = new System.Drawing.Point(260, 37);
            this.LCDSIze_label.Name = "LCDSIze_label";
            this.LCDSIze_label.Size = new System.Drawing.Size(66, 17);
            this.LCDSIze_label.TabIndex = 9;
            this.LCDSIze_label.Text = "LCD Size";
            // 
            // CPUType_label
            // 
            this.CPUType_label.AutoSize = true;
            this.CPUType_label.Location = new System.Drawing.Point(20, 155);
            this.CPUType_label.Name = "CPUType_label";
            this.CPUType_label.Size = new System.Drawing.Size(72, 17);
            this.CPUType_label.TabIndex = 8;
            this.CPUType_label.Text = "CPU Type";
            // 
            // CPUBrand_label
            // 
            this.CPUBrand_label.AutoSize = true;
            this.CPUBrand_label.Location = new System.Drawing.Point(20, 96);
            this.CPUBrand_label.Name = "CPUBrand_label";
            this.CPUBrand_label.Size = new System.Drawing.Size(78, 17);
            this.CPUBrand_label.TabIndex = 7;
            this.CPUBrand_label.Text = "CPU Brand";
            // 
            // Memory_label
            // 
            this.Memory_label.AutoSize = true;
            this.Memory_label.Location = new System.Drawing.Point(20, 37);
            this.Memory_label.Name = "Memory_label";
            this.Memory_label.Size = new System.Drawing.Size(58, 17);
            this.Memory_label.TabIndex = 6;
            this.Memory_label.Text = "Memory";
            // 
            // ProductInfo_groupBox
            // 
            this.ProductInfo_groupBox.Controls.Add(this.Model_textBox);
            this.ProductInfo_groupBox.Controls.Add(this.OS_textBox);
            this.ProductInfo_groupBox.Controls.Add(this.Manufacturer_textBox);
            this.ProductInfo_groupBox.Controls.Add(this.Platform_textBox);
            this.ProductInfo_groupBox.Controls.Add(this.Model_label);
            this.ProductInfo_groupBox.Controls.Add(this.OS_label);
            this.ProductInfo_groupBox.Controls.Add(this.Manufacturer_label);
            this.ProductInfo_groupBox.Controls.Add(this.Platform_label);
            this.ProductInfo_groupBox.Location = new System.Drawing.Point(11, 102);
            this.ProductInfo_groupBox.Name = "ProductInfo_groupBox";
            this.ProductInfo_groupBox.Size = new System.Drawing.Size(778, 157);
            this.ProductInfo_groupBox.TabIndex = 19;
            this.ProductInfo_groupBox.TabStop = false;
            this.ProductInfo_groupBox.Text = "Product Info";
            // 
            // Model_textBox
            // 
            this.Model_textBox.Location = new System.Drawing.Point(353, 96);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(397, 22);
            this.Model_textBox.TabIndex = 12;
            // 
            // OS_textBox
            // 
            this.OS_textBox.Location = new System.Drawing.Point(353, 36);
            this.OS_textBox.Name = "OS_textBox";
            this.OS_textBox.Size = new System.Drawing.Size(397, 22);
            this.OS_textBox.TabIndex = 11;
            // 
            // Manufacturer_textBox
            // 
            this.Manufacturer_textBox.Location = new System.Drawing.Point(116, 90);
            this.Manufacturer_textBox.Name = "Manufacturer_textBox";
            this.Manufacturer_textBox.Size = new System.Drawing.Size(127, 22);
            this.Manufacturer_textBox.TabIndex = 10;
            // 
            // Platform_textBox
            // 
            this.Platform_textBox.Location = new System.Drawing.Point(115, 33);
            this.Platform_textBox.Name = "Platform_textBox";
            this.Platform_textBox.Size = new System.Drawing.Size(127, 22);
            this.Platform_textBox.TabIndex = 9;
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Location = new System.Drawing.Point(289, 95);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(46, 17);
            this.Model_label.TabIndex = 5;
            this.Model_label.Text = "Model";
            // 
            // OS_label
            // 
            this.OS_label.AutoSize = true;
            this.OS_label.Location = new System.Drawing.Point(289, 38);
            this.OS_label.Name = "OS_label";
            this.OS_label.Size = new System.Drawing.Size(28, 17);
            this.OS_label.TabIndex = 4;
            this.OS_label.Text = "OS";
            // 
            // Manufacturer_label
            // 
            this.Manufacturer_label.AutoSize = true;
            this.Manufacturer_label.Location = new System.Drawing.Point(18, 93);
            this.Manufacturer_label.Name = "Manufacturer_label";
            this.Manufacturer_label.Size = new System.Drawing.Size(92, 17);
            this.Manufacturer_label.TabIndex = 3;
            this.Manufacturer_label.Text = "Manufacturer";
            // 
            // Platform_label
            // 
            this.Platform_label.AutoSize = true;
            this.Platform_label.Location = new System.Drawing.Point(18, 36);
            this.Platform_label.Name = "Platform_label";
            this.Platform_label.Size = new System.Drawing.Size(60, 17);
            this.Platform_label.TabIndex = 2;
            this.Platform_label.Text = "Platform";
            // 
            // Cost_textBox
            // 
            this.Cost_textBox.Location = new System.Drawing.Point(593, 48);
            this.Cost_textBox.Name = "Cost_textBox";
            this.Cost_textBox.Size = new System.Drawing.Size(120, 22);
            this.Cost_textBox.TabIndex = 18;
            // 
            // Condition_textBox
            // 
            this.Condition_textBox.Location = new System.Drawing.Point(373, 45);
            this.Condition_textBox.Name = "Condition_textBox";
            this.Condition_textBox.Size = new System.Drawing.Size(132, 22);
            this.Condition_textBox.TabIndex = 17;
            // 
            // ProductID_textBox
            // 
            this.ProductID_textBox.Location = new System.Drawing.Point(126, 48);
            this.ProductID_textBox.Name = "ProductID_textBox";
            this.ProductID_textBox.Size = new System.Drawing.Size(127, 22);
            this.ProductID_textBox.TabIndex = 16;
            // 
            // Cost_label
            // 
            this.Cost_label.AutoSize = true;
            this.Cost_label.Location = new System.Drawing.Point(528, 48);
            this.Cost_label.Name = "Cost_label";
            this.Cost_label.Size = new System.Drawing.Size(36, 17);
            this.Cost_label.TabIndex = 15;
            this.Cost_label.Text = "Cost";
            // 
            // Condition_label
            // 
            this.Condition_label.AutoSize = true;
            this.Condition_label.Location = new System.Drawing.Point(300, 48);
            this.Condition_label.Name = "Condition_label";
            this.Condition_label.Size = new System.Drawing.Size(67, 17);
            this.Condition_label.TabIndex = 14;
            this.Condition_label.Text = "Condition";
            // 
            // ProductID_label
            // 
            this.ProductID_label.AutoSize = true;
            this.ProductID_label.Location = new System.Drawing.Point(31, 48);
            this.ProductID_label.Name = "ProductID_label";
            this.ProductID_label.Size = new System.Drawing.Size(74, 17);
            this.ProductID_label.TabIndex = 13;
            this.ProductID_label.Text = "Product ID";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAnotherProductToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAnotherProductToolStripMenuItem
            // 
            this.selectAnotherProductToolStripMenuItem.Name = "selectAnotherProductToolStripMenuItem";
            this.selectAnotherProductToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.selectAnotherProductToolStripMenuItem.Text = "&Select another product";
            this.selectAnotherProductToolStripMenuItem.Click += new System.EventHandler(this.selectAnotherProductToolStripMenuItem_Click);
            // 
            // DollarOpenFileDialog
            // 
            this.DollarOpenFileDialog.FileName = "openFileDialog1";
            // 
            // ProductInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 609);
            this.ControlBox = false;
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.Click_label);
            this.Controls.Add(this.TechSpecs_groupBox);
            this.Controls.Add(this.ProductInfo_groupBox);
            this.Controls.Add(this.Cost_textBox);
            this.Controls.Add(this.Condition_textBox);
            this.Controls.Add(this.ProductID_textBox);
            this.Controls.Add(this.Cost_label);
            this.Controls.Add(this.Condition_label);
            this.Controls.Add(this.ProductID_label);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ProductInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Information";
            this.Activated += new System.EventHandler(this.ProductInfoForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductInfoForm_FormClosing);
            this.TechSpecs_groupBox.ResumeLayout(false);
            this.TechSpecs_groupBox.PerformLayout();
            this.ProductInfo_groupBox.ResumeLayout(false);
            this.ProductInfo_groupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Select_button;
        private System.Windows.Forms.Label Click_label;
        private System.Windows.Forms.GroupBox TechSpecs_groupBox;
        private System.Windows.Forms.TextBox WebCam_textBox;
        private System.Windows.Forms.TextBox GPUType_textBox;
        private System.Windows.Forms.TextBox HDD_textBox;
        private System.Windows.Forms.TextBox CPUSpeed_textBox;
        private System.Windows.Forms.TextBox CPUNumber_textBox;
        private System.Windows.Forms.TextBox LCDSize_textBox;
        private System.Windows.Forms.TextBox CPUType_textBox;
        private System.Windows.Forms.TextBox CPUBrand_textBox;
        private System.Windows.Forms.TextBox Memory_textBox;
        private System.Windows.Forms.Label WebCam_label;
        private System.Windows.Forms.Label GPUType_label;
        private System.Windows.Forms.Label HDD_label;
        private System.Windows.Forms.Label CPUSpeed_label;
        private System.Windows.Forms.Label CPUNumber_label;
        private System.Windows.Forms.Label LCDSIze_label;
        private System.Windows.Forms.Label CPUType_label;
        private System.Windows.Forms.Label CPUBrand_label;
        private System.Windows.Forms.Label Memory_label;
        private System.Windows.Forms.GroupBox ProductInfo_groupBox;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.TextBox OS_textBox;
        private System.Windows.Forms.TextBox Manufacturer_textBox;
        private System.Windows.Forms.TextBox Platform_textBox;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.Label OS_label;
        private System.Windows.Forms.Label Manufacturer_label;
        private System.Windows.Forms.Label Platform_label;
        private System.Windows.Forms.TextBox Cost_textBox;
        private System.Windows.Forms.TextBox Condition_textBox;
        private System.Windows.Forms.TextBox ProductID_textBox;
        private System.Windows.Forms.Label Cost_label;
        private System.Windows.Forms.Label Condition_label;
        private System.Windows.Forms.Label ProductID_label;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAnotherProductToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog DollarSaveFileDialog;
        private System.Windows.Forms.OpenFileDialog DollarOpenFileDialog;
    }
}