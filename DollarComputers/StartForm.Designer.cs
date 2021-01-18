namespace DollarComputers
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome_label = new System.Windows.Forms.Label();
            this.NewOrder_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            this.SaveOrder_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_label.Location = new System.Drawing.Point(239, 31);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(251, 25);
            this.welcome_label.TabIndex = 1;
            this.welcome_label.Text = "Welcom to Dollar Computer";
            // 
            // NewOrder_button
            // 
            this.NewOrder_button.Location = new System.Drawing.Point(244, 334);
            this.NewOrder_button.Name = "NewOrder_button";
            this.NewOrder_button.Size = new System.Drawing.Size(237, 46);
            this.NewOrder_button.TabIndex = 2;
            this.NewOrder_button.Text = "Start a new order";
            this.NewOrder_button.UseVisualStyleBackColor = true;
            this.NewOrder_button.Click += new System.EventHandler(this.NewOrder_button_Click);
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(244, 560);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(237, 46);
            this.Exit_button.TabIndex = 3;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // SaveOrder_button
            // 
            this.SaveOrder_button.Location = new System.Drawing.Point(244, 447);
            this.SaveOrder_button.Name = "SaveOrder_button";
            this.SaveOrder_button.Size = new System.Drawing.Size(237, 46);
            this.SaveOrder_button.TabIndex = 4;
            this.SaveOrder_button.Text = "Open a saved order";
            this.SaveOrder_button.UseVisualStyleBackColor = true;
            this.SaveOrder_button.Click += new System.EventHandler(this.SaveOrder_button_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 684);
            this.ControlBox = false;
            this.Controls.Add(this.SaveOrder_button);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.NewOrder_button);
            this.Controls.Add(this.welcome_label);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcom to Dollar Computer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button NewOrder_button;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Button SaveOrder_button;
    }
}