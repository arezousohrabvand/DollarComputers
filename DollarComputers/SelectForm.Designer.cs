namespace DollarComputers
{
    partial class SelectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SelectiontextBox = new System.Windows.Forms.TextBox();
            this.Next_button = new System.Windows.Forms.Button();
            this.Cancel_button = new System.Windows.Forms.Button();
            this.SelectOrder_dataGridView = new System.Windows.Forms.DataGridView();
            this.Save_button = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mFGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lCDSizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUBrandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUSpeedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPUTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webCamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SelectOrder_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dollar Computer HardWare List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Here is Your Selection";
            // 
            // SelectiontextBox
            // 
            this.SelectiontextBox.Location = new System.Drawing.Point(159, 394);
            this.SelectiontextBox.Name = "SelectiontextBox";
            this.SelectiontextBox.ReadOnly = true;
            this.SelectiontextBox.Size = new System.Drawing.Size(374, 22);
            this.SelectiontextBox.TabIndex = 3;
            // 
            // Next_button
            // 
            this.Next_button.Location = new System.Drawing.Point(620, 394);
            this.Next_button.Name = "Next_button";
            this.Next_button.Size = new System.Drawing.Size(79, 23);
            this.Next_button.TabIndex = 4;
            this.Next_button.Text = "Next";
            this.Next_button.UseVisualStyleBackColor = true;
            this.Next_button.Click += new System.EventHandler(this.Next_button_Click);
            // 
            // Cancel_button
            // 
            this.Cancel_button.Location = new System.Drawing.Point(701, 394);
            this.Cancel_button.Name = "Cancel_button";
            this.Cancel_button.Size = new System.Drawing.Size(79, 23);
            this.Cancel_button.TabIndex = 5;
            this.Cancel_button.Text = "Cancel";
            this.Cancel_button.UseVisualStyleBackColor = true;
            this.Cancel_button.Click += new System.EventHandler(this.Cancel_button_Click);
            // 
            // SelectOrder_dataGridView
            // 
            this.SelectOrder_dataGridView.AllowUserToAddRows = false;
            this.SelectOrder_dataGridView.AllowUserToDeleteRows = false;
            this.SelectOrder_dataGridView.AutoGenerateColumns = false;
            this.SelectOrder_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectOrder_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.mFGDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.memoryDataGridViewTextBoxColumn,
            this.lCDSizeDataGridViewTextBoxColumn,
            this.cPUBrandDataGridViewTextBoxColumn,
            this.cPUTypeDataGridViewTextBoxColumn,
            this.cPUNumberDataGridViewTextBoxColumn,
            this.cPUSpeedDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.platformDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.hDDDataGridViewTextBoxColumn,
            this.gPUTypeDataGridViewTextBoxColumn,
            this.webCamDataGridViewTextBoxColumn});
            this.SelectOrder_dataGridView.DataSource = this.productBindingSource;
            this.SelectOrder_dataGridView.Location = new System.Drawing.Point(16, 32);
            this.SelectOrder_dataGridView.Name = "SelectOrder_dataGridView";
            this.SelectOrder_dataGridView.ReadOnly = true;
            this.SelectOrder_dataGridView.RowTemplate.Height = 24;
            this.SelectOrder_dataGridView.Size = new System.Drawing.Size(772, 331);
            this.SelectOrder_dataGridView.TabIndex = 6;
            this.SelectOrder_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectOrder_dataGridView_CellClick);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(539, 394);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(79, 23);
            this.Save_button.TabIndex = 7;
            this.Save_button.Text = "Save";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mFGDataGridViewTextBoxColumn
            // 
            this.mFGDataGridViewTextBoxColumn.DataPropertyName = "MFG";
            this.mFGDataGridViewTextBoxColumn.HeaderText = "MFG";
            this.mFGDataGridViewTextBoxColumn.Name = "mFGDataGridViewTextBoxColumn";
            this.mFGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // memoryDataGridViewTextBoxColumn
            // 
            this.memoryDataGridViewTextBoxColumn.DataPropertyName = "Memory";
            this.memoryDataGridViewTextBoxColumn.HeaderText = "Memory";
            this.memoryDataGridViewTextBoxColumn.Name = "memoryDataGridViewTextBoxColumn";
            this.memoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lCDSizeDataGridViewTextBoxColumn
            // 
            this.lCDSizeDataGridViewTextBoxColumn.DataPropertyName = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.HeaderText = "LCDSize";
            this.lCDSizeDataGridViewTextBoxColumn.Name = "lCDSizeDataGridViewTextBoxColumn";
            this.lCDSizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUBrandDataGridViewTextBoxColumn
            // 
            this.cPUBrandDataGridViewTextBoxColumn.DataPropertyName = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.HeaderText = "CPUBrand";
            this.cPUBrandDataGridViewTextBoxColumn.Name = "cPUBrandDataGridViewTextBoxColumn";
            this.cPUBrandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUTypeDataGridViewTextBoxColumn
            // 
            this.cPUTypeDataGridViewTextBoxColumn.DataPropertyName = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.HeaderText = "CPUType";
            this.cPUTypeDataGridViewTextBoxColumn.Name = "cPUTypeDataGridViewTextBoxColumn";
            this.cPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUNumberDataGridViewTextBoxColumn
            // 
            this.cPUNumberDataGridViewTextBoxColumn.DataPropertyName = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.HeaderText = "CPUNumber";
            this.cPUNumberDataGridViewTextBoxColumn.Name = "cPUNumberDataGridViewTextBoxColumn";
            this.cPUNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUSpeedDataGridViewTextBoxColumn
            // 
            this.cPUSpeedDataGridViewTextBoxColumn.DataPropertyName = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.HeaderText = "CPUSpeed";
            this.cPUSpeedDataGridViewTextBoxColumn.Name = "cPUSpeedDataGridViewTextBoxColumn";
            this.cPUSpeedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // platformDataGridViewTextBoxColumn
            // 
            this.platformDataGridViewTextBoxColumn.DataPropertyName = "Platform";
            this.platformDataGridViewTextBoxColumn.HeaderText = "Platform";
            this.platformDataGridViewTextBoxColumn.Name = "platformDataGridViewTextBoxColumn";
            this.platformDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hDDDataGridViewTextBoxColumn
            // 
            this.hDDDataGridViewTextBoxColumn.DataPropertyName = "HDD";
            this.hDDDataGridViewTextBoxColumn.HeaderText = "HDD";
            this.hDDDataGridViewTextBoxColumn.Name = "hDDDataGridViewTextBoxColumn";
            this.hDDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gPUTypeDataGridViewTextBoxColumn
            // 
            this.gPUTypeDataGridViewTextBoxColumn.DataPropertyName = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.HeaderText = "GPUType";
            this.gPUTypeDataGridViewTextBoxColumn.Name = "gPUTypeDataGridViewTextBoxColumn";
            this.gPUTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // webCamDataGridViewTextBoxColumn
            // 
            this.webCamDataGridViewTextBoxColumn.DataPropertyName = "WebCam";
            this.webCamDataGridViewTextBoxColumn.HeaderText = "WebCam";
            this.webCamDataGridViewTextBoxColumn.Name = "webCamDataGridViewTextBoxColumn";
            this.webCamDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DollarComputers.Models.Product);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.SelectOrder_dataGridView);
            this.Controls.Add(this.Cancel_button);
            this.Controls.Add(this.Next_button);
            this.Controls.Add(this.SelectiontextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Your Computer";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectOrder_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SelectiontextBox;
        private System.Windows.Forms.Button Next_button;
        private System.Windows.Forms.Button Cancel_button;
        private System.Windows.Forms.DataGridView SelectOrder_dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mFGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lCDSizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUBrandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUSpeedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPUTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn webCamDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.Button Save_button;
    }
}