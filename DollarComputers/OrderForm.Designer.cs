namespace DollarComputers
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPriviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Price_label = new System.Windows.Forms.Label();
            this.SystemComponents_groupBox = new System.Windows.Forms.GroupBox();
            this.OrderlistBox = new System.Windows.Forms.ListBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.Platform_textBox = new System.Windows.Forms.TextBox();
            this.Manfacturer_textBox = new System.Windows.Forms.TextBox();
            this.Condition_textBox = new System.Windows.Forms.TextBox();
            this.LCDSize_label = new System.Windows.Forms.Label();
            this.Memory_label = new System.Windows.Forms.Label();
            this.WebCam_label = new System.Windows.Forms.Label();
            this.OS_label = new System.Windows.Forms.Label();
            this.HDD_label = new System.Windows.Forms.Label();
            this.GPUType_label = new System.Windows.Forms.Label();
            this.CPUNumber_label = new System.Windows.Forms.Label();
            this.CPUSpeed_label = new System.Windows.Forms.Label();
            this.CPUBrand_label = new System.Windows.Forms.Label();
            this.CPUType_label = new System.Windows.Forms.Label();
            this.Model_label = new System.Windows.Forms.Label();
            this.Platform_label = new System.Windows.Forms.Label();
            this.Condition_label = new System.Windows.Forms.Label();
            this.Manfacturer_label = new System.Windows.Forms.Label();
            this.YourPrice_groupBox = new System.Windows.Forms.GroupBox();
            this.Total_textBox = new System.Windows.Forms.TextBox();
            this.SalesTax_textBox = new System.Windows.Forms.TextBox();
            this.Price_textBox = new System.Windows.Forms.TextBox();
            this.Total_label = new System.Windows.Forms.Label();
            this.SalesTax_label = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Back_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.Finish_button = new System.Windows.Forms.Button();
            this.ProductPrintForm = new Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(this.components);
            this.menuStrip1.SuspendLayout();
            this.SystemComponents_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.YourPrice_groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.printPriviewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPriviewToolStripMenuItem
            // 
            this.printPriviewToolStripMenuItem.Name = "printPriviewToolStripMenuItem";
            this.printPriviewToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.printPriviewToolStripMenuItem.Text = "&Print Preview";
            this.printPriviewToolStripMenuItem.Click += new System.EventHandler(this.printPriviewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.backToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.backToolStripMenuItem.Text = "&Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Price_label
            // 
            this.Price_label.AutoSize = true;
            this.Price_label.Location = new System.Drawing.Point(40, 52);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(40, 17);
            this.Price_label.TabIndex = 1;
            this.Price_label.Text = "Price";
            // 
            // SystemComponents_groupBox
            // 
            this.SystemComponents_groupBox.Controls.Add(this.OrderlistBox);
            this.SystemComponents_groupBox.Controls.Add(this.Model_textBox);
            this.SystemComponents_groupBox.Controls.Add(this.Platform_textBox);
            this.SystemComponents_groupBox.Controls.Add(this.Manfacturer_textBox);
            this.SystemComponents_groupBox.Controls.Add(this.Condition_textBox);
            this.SystemComponents_groupBox.Controls.Add(this.LCDSize_label);
            this.SystemComponents_groupBox.Controls.Add(this.Memory_label);
            this.SystemComponents_groupBox.Controls.Add(this.WebCam_label);
            this.SystemComponents_groupBox.Controls.Add(this.OS_label);
            this.SystemComponents_groupBox.Controls.Add(this.HDD_label);
            this.SystemComponents_groupBox.Controls.Add(this.GPUType_label);
            this.SystemComponents_groupBox.Controls.Add(this.CPUNumber_label);
            this.SystemComponents_groupBox.Controls.Add(this.CPUSpeed_label);
            this.SystemComponents_groupBox.Controls.Add(this.CPUBrand_label);
            this.SystemComponents_groupBox.Controls.Add(this.CPUType_label);
            this.SystemComponents_groupBox.Controls.Add(this.Model_label);
            this.SystemComponents_groupBox.Controls.Add(this.Platform_label);
            this.SystemComponents_groupBox.Controls.Add(this.Condition_label);
            this.SystemComponents_groupBox.Controls.Add(this.Manfacturer_label);
            this.SystemComponents_groupBox.Location = new System.Drawing.Point(12, 43);
            this.SystemComponents_groupBox.Name = "SystemComponents_groupBox";
            this.SystemComponents_groupBox.Size = new System.Drawing.Size(410, 539);
            this.SystemComponents_groupBox.TabIndex = 2;
            this.SystemComponents_groupBox.TabStop = false;
            this.SystemComponents_groupBox.Text = "System Components";
            // 
            // OrderlistBox
            // 
            this.OrderlistBox.DataSource = this.productBindingSource;
            this.OrderlistBox.DisplayMember = "WebCam";
            this.OrderlistBox.FormattingEnabled = true;
            this.OrderlistBox.ItemHeight = 16;
            this.OrderlistBox.Location = new System.Drawing.Point(122, 129);
            this.OrderlistBox.Name = "OrderlistBox";
            this.OrderlistBox.Size = new System.Drawing.Size(267, 404);
            this.OrderlistBox.TabIndex = 21;
            this.OrderlistBox.ValueMember = "Memory";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DollarComputers.Models.Product);
            // 
            // Model_textBox
            // 
            this.Model_textBox.Location = new System.Drawing.Point(278, 80);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(100, 22);
            this.Model_textBox.TabIndex = 20;
            // 
            // Platform_textBox
            // 
            this.Platform_textBox.Location = new System.Drawing.Point(278, 45);
            this.Platform_textBox.Name = "Platform_textBox";
            this.Platform_textBox.Size = new System.Drawing.Size(100, 22);
            this.Platform_textBox.TabIndex = 19;
            // 
            // Manfacturer_textBox
            // 
            this.Manfacturer_textBox.Location = new System.Drawing.Point(113, 83);
            this.Manfacturer_textBox.Name = "Manfacturer_textBox";
            this.Manfacturer_textBox.Size = new System.Drawing.Size(100, 22);
            this.Manfacturer_textBox.TabIndex = 18;
            // 
            // Condition_textBox
            // 
            this.Condition_textBox.Location = new System.Drawing.Point(113, 45);
            this.Condition_textBox.Name = "Condition_textBox";
            this.Condition_textBox.Size = new System.Drawing.Size(100, 22);
            this.Condition_textBox.TabIndex = 17;
            // 
            // LCDSize_label
            // 
            this.LCDSize_label.AutoSize = true;
            this.LCDSize_label.Location = new System.Drawing.Point(26, 138);
            this.LCDSize_label.Name = "LCDSize_label";
            this.LCDSize_label.Size = new System.Drawing.Size(66, 17);
            this.LCDSize_label.TabIndex = 15;
            this.LCDSize_label.Text = "LCD Size";
            // 
            // Memory_label
            // 
            this.Memory_label.AutoSize = true;
            this.Memory_label.Location = new System.Drawing.Point(26, 179);
            this.Memory_label.Name = "Memory_label";
            this.Memory_label.Size = new System.Drawing.Size(58, 17);
            this.Memory_label.TabIndex = 14;
            this.Memory_label.Text = "Memory";
            // 
            // WebCam_label
            // 
            this.WebCam_label.AutoSize = true;
            this.WebCam_label.Location = new System.Drawing.Point(26, 466);
            this.WebCam_label.Name = "WebCam_label";
            this.WebCam_label.Size = new System.Drawing.Size(65, 17);
            this.WebCam_label.TabIndex = 13;
            this.WebCam_label.Text = "WebCam";
            // 
            // OS_label
            // 
            this.OS_label.AutoSize = true;
            this.OS_label.Location = new System.Drawing.Point(26, 507);
            this.OS_label.Name = "OS_label";
            this.OS_label.Size = new System.Drawing.Size(28, 17);
            this.OS_label.TabIndex = 12;
            this.OS_label.Text = "OS";
            // 
            // HDD_label
            // 
            this.HDD_label.AutoSize = true;
            this.HDD_label.Location = new System.Drawing.Point(26, 384);
            this.HDD_label.Name = "HDD_label";
            this.HDD_label.Size = new System.Drawing.Size(38, 17);
            this.HDD_label.TabIndex = 11;
            this.HDD_label.Text = "HDD";
            // 
            // GPUType_label
            // 
            this.GPUType_label.AutoSize = true;
            this.GPUType_label.Location = new System.Drawing.Point(26, 425);
            this.GPUType_label.Name = "GPUType_label";
            this.GPUType_label.Size = new System.Drawing.Size(74, 17);
            this.GPUType_label.TabIndex = 10;
            this.GPUType_label.Text = "GPU Type";
            // 
            // CPUNumber_label
            // 
            this.CPUNumber_label.AutoSize = true;
            this.CPUNumber_label.Location = new System.Drawing.Point(26, 302);
            this.CPUNumber_label.Name = "CPUNumber_label";
            this.CPUNumber_label.Size = new System.Drawing.Size(90, 17);
            this.CPUNumber_label.TabIndex = 9;
            this.CPUNumber_label.Text = "CPU Number";
            // 
            // CPUSpeed_label
            // 
            this.CPUSpeed_label.AutoSize = true;
            this.CPUSpeed_label.Location = new System.Drawing.Point(26, 343);
            this.CPUSpeed_label.Name = "CPUSpeed_label";
            this.CPUSpeed_label.Size = new System.Drawing.Size(81, 17);
            this.CPUSpeed_label.TabIndex = 8;
            this.CPUSpeed_label.Text = "CPU Speed";
            // 
            // CPUBrand_label
            // 
            this.CPUBrand_label.AutoSize = true;
            this.CPUBrand_label.Location = new System.Drawing.Point(26, 220);
            this.CPUBrand_label.Name = "CPUBrand_label";
            this.CPUBrand_label.Size = new System.Drawing.Size(74, 17);
            this.CPUBrand_label.TabIndex = 7;
            this.CPUBrand_label.Text = "CPUBrand";
            // 
            // CPUType_label
            // 
            this.CPUType_label.AutoSize = true;
            this.CPUType_label.Location = new System.Drawing.Point(26, 261);
            this.CPUType_label.Name = "CPUType_label";
            this.CPUType_label.Size = new System.Drawing.Size(72, 17);
            this.CPUType_label.TabIndex = 6;
            this.CPUType_label.Text = "CPU Type";
            // 
            // Model_label
            // 
            this.Model_label.AutoSize = true;
            this.Model_label.Location = new System.Drawing.Point(216, 83);
            this.Model_label.Name = "Model_label";
            this.Model_label.Size = new System.Drawing.Size(46, 17);
            this.Model_label.TabIndex = 5;
            this.Model_label.Text = "Model";
            // 
            // Platform_label
            // 
            this.Platform_label.AutoSize = true;
            this.Platform_label.Location = new System.Drawing.Point(216, 45);
            this.Platform_label.Name = "Platform_label";
            this.Platform_label.Size = new System.Drawing.Size(60, 17);
            this.Platform_label.TabIndex = 4;
            this.Platform_label.Text = "Platform";
            // 
            // Condition_label
            // 
            this.Condition_label.AutoSize = true;
            this.Condition_label.Location = new System.Drawing.Point(26, 45);
            this.Condition_label.Name = "Condition_label";
            this.Condition_label.Size = new System.Drawing.Size(67, 17);
            this.Condition_label.TabIndex = 3;
            this.Condition_label.Text = "Condition";
            // 
            // Manfacturer_label
            // 
            this.Manfacturer_label.AutoSize = true;
            this.Manfacturer_label.Location = new System.Drawing.Point(26, 83);
            this.Manfacturer_label.Name = "Manfacturer_label";
            this.Manfacturer_label.Size = new System.Drawing.Size(84, 17);
            this.Manfacturer_label.TabIndex = 2;
            this.Manfacturer_label.Text = "Manfacturer";
            // 
            // YourPrice_groupBox
            // 
            this.YourPrice_groupBox.Controls.Add(this.Total_textBox);
            this.YourPrice_groupBox.Controls.Add(this.SalesTax_textBox);
            this.YourPrice_groupBox.Controls.Add(this.Price_textBox);
            this.YourPrice_groupBox.Controls.Add(this.Total_label);
            this.YourPrice_groupBox.Controls.Add(this.SalesTax_label);
            this.YourPrice_groupBox.Controls.Add(this.Price_label);
            this.YourPrice_groupBox.Controls.Add(this.shapeContainer1);
            this.YourPrice_groupBox.Location = new System.Drawing.Point(450, 245);
            this.YourPrice_groupBox.Name = "YourPrice_groupBox";
            this.YourPrice_groupBox.Size = new System.Drawing.Size(323, 269);
            this.YourPrice_groupBox.TabIndex = 3;
            this.YourPrice_groupBox.TabStop = false;
            this.YourPrice_groupBox.Text = "Your Price";
            // 
            // Total_textBox
            // 
            this.Total_textBox.Location = new System.Drawing.Point(115, 182);
            this.Total_textBox.Name = "Total_textBox";
            this.Total_textBox.Size = new System.Drawing.Size(159, 22);
            this.Total_textBox.TabIndex = 23;
            // 
            // SalesTax_textBox
            // 
            this.SalesTax_textBox.Location = new System.Drawing.Point(114, 89);
            this.SalesTax_textBox.Name = "SalesTax_textBox";
            this.SalesTax_textBox.Size = new System.Drawing.Size(159, 22);
            this.SalesTax_textBox.TabIndex = 22;
            // 
            // Price_textBox
            // 
            this.Price_textBox.Location = new System.Drawing.Point(114, 49);
            this.Price_textBox.Name = "Price_textBox";
            this.Price_textBox.Size = new System.Drawing.Size(159, 22);
            this.Price_textBox.TabIndex = 21;
            // 
            // Total_label
            // 
            this.Total_label.AutoSize = true;
            this.Total_label.Location = new System.Drawing.Point(40, 187);
            this.Total_label.Name = "Total_label";
            this.Total_label.Size = new System.Drawing.Size(40, 17);
            this.Total_label.TabIndex = 3;
            this.Total_label.Text = "Total";
            // 
            // SalesTax_label
            // 
            this.SalesTax_label.AutoSize = true;
            this.SalesTax_label.Location = new System.Drawing.Point(40, 92);
            this.SalesTax_label.Name = "SalesTax_label";
            this.SalesTax_label.Size = new System.Drawing.Size(70, 17);
            this.SalesTax_label.TabIndex = 2;
            this.SalesTax_label.Text = "Sales Tax";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 18);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape});
            this.shapeContainer1.Size = new System.Drawing.Size(317, 248);
            this.shapeContainer1.TabIndex = 24;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape
            // 
            this.lineShape.BorderWidth = 2;
            this.lineShape.Name = "lineShape";
            this.lineShape.X1 = 11;
            this.lineShape.X2 = 289;
            this.lineShape.Y1 = 117;
            this.lineShape.Y2 = 117;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 196);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Back_button
            // 
            this.Back_button.Location = new System.Drawing.Point(450, 531);
            this.Back_button.Name = "Back_button";
            this.Back_button.Size = new System.Drawing.Size(93, 35);
            this.Back_button.TabIndex = 5;
            this.Back_button.Text = "Back";
            this.Back_button.UseVisualStyleBackColor = true;
            this.Back_button.Click += new System.EventHandler(this.Back_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(565, 531);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(93, 35);
            this.Cancel_button.TabIndex = 6;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // Finish_button
            // 
            this.Finish_button.Location = new System.Drawing.Point(680, 531);
            this.Finish_button.Name = "Finish_button";
            this.Finish_button.Size = new System.Drawing.Size(93, 35);
            this.Finish_button.TabIndex = 7;
            this.Finish_button.Text = "Finish";
            this.Finish_button.UseVisualStyleBackColor = true;
            this.Finish_button.Click += new System.EventHandler(this.Finish_button_Click);
            // 
            // ProductPrintForm
            // 
            this.ProductPrintForm.DocumentName = "document";
            this.ProductPrintForm.Form = this;
            this.ProductPrintForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter;
            this.ProductPrintForm.PrinterSettings = ((System.Drawing.Printing.PrinterSettings)(resources.GetObject("ProductPrintForm.PrinterSettings")));
            this.ProductPrintForm.PrintFileName = null;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 606);
            this.ControlBox = false;
            this.Controls.Add(this.Finish_button);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Back_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.YourPrice_groupBox);
            this.Controls.Add(this.SystemComponents_groupBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Form Information\'";
            this.Activated += new System.EventHandler(this.OrderForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrderForm_FormClosing);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.SystemComponents_groupBox.ResumeLayout(false);
            this.SystemComponents_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.YourPrice_groupBox.ResumeLayout(false);
            this.YourPrice_groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.GroupBox SystemComponents_groupBox;
        private System.Windows.Forms.Label LCDSize_label;
        private System.Windows.Forms.Label Memory_label;
        private System.Windows.Forms.Label WebCam_label;
        private System.Windows.Forms.Label OS_label;
        private System.Windows.Forms.Label HDD_label;
        private System.Windows.Forms.Label GPUType_label;
        private System.Windows.Forms.Label CPUNumber_label;
        private System.Windows.Forms.Label CPUSpeed_label;
        private System.Windows.Forms.Label CPUBrand_label;
        private System.Windows.Forms.Label CPUType_label;
        private System.Windows.Forms.Label Model_label;
        private System.Windows.Forms.Label Platform_label;
        private System.Windows.Forms.Label Condition_label;
        private System.Windows.Forms.Label Manfacturer_label;
        private System.Windows.Forms.GroupBox YourPrice_groupBox;
        private System.Windows.Forms.Label Total_label;
        private System.Windows.Forms.Label SalesTax_label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.TextBox Platform_textBox;
        private System.Windows.Forms.TextBox Manfacturer_textBox;
        private System.Windows.Forms.TextBox Condition_textBox;
        private System.Windows.Forms.TextBox Total_textBox;
        private System.Windows.Forms.TextBox SalesTax_textBox;
        private System.Windows.Forms.TextBox Price_textBox;
        private System.Windows.Forms.Button Back_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.Button Finish_button;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape;
        private System.Windows.Forms.ToolStripMenuItem printPriviewToolStripMenuItem;
        private Microsoft.VisualBasic.PowerPacks.Printing.PrintForm ProductPrintForm;
        private System.Windows.Forms.ListBox OrderlistBox;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}