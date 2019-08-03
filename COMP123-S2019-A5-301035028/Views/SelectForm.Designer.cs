namespace COMP123_S2019_A5_301035028.Views
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
            this.ProductDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectFormPrevButton = new System.Windows.Forms.Button();
            this.SelectFormNextButton = new System.Windows.Forms.Button();
            this.SelectHardwareLabel = new System.Windows.Forms.Label();
            this.HardwareSelectedLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductDataGridView
            // 
            this.ProductDataGridView.AllowUserToAddRows = false;
            this.ProductDataGridView.AllowUserToDeleteRows = false;
            this.ProductDataGridView.AllowUserToResizeColumns = false;
            this.ProductDataGridView.AllowUserToResizeRows = false;
            this.ProductDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ProductDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.ProductDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataGridView.Location = new System.Drawing.Point(15, 50);
            this.ProductDataGridView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ProductDataGridView.MultiSelect = false;
            this.ProductDataGridView.Name = "ProductDataGridView";
            this.ProductDataGridView.ReadOnly = true;
            this.ProductDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductDataGridView.Size = new System.Drawing.Size(754, 162);
            this.ProductDataGridView.TabIndex = 0;
            // 
            // SelectFormPrevButton
            // 
            this.SelectFormPrevButton.AutoSize = true;
            this.SelectFormPrevButton.Location = new System.Drawing.Point(15, 302);
            this.SelectFormPrevButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectFormPrevButton.Name = "SelectFormPrevButton";
            this.SelectFormPrevButton.Size = new System.Drawing.Size(150, 44);
            this.SelectFormPrevButton.TabIndex = 5;
            this.SelectFormPrevButton.Text = "Previous Form";
            this.SelectFormPrevButton.UseVisualStyleBackColor = true;
            this.SelectFormPrevButton.Click += new System.EventHandler(this.SelectFormPrevButton_Click);
            // 
            // SelectFormNextButton
            // 
            this.SelectFormNextButton.AutoSize = true;
            this.SelectFormNextButton.Location = new System.Drawing.Point(657, 302);
            this.SelectFormNextButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SelectFormNextButton.Name = "SelectFormNextButton";
            this.SelectFormNextButton.Size = new System.Drawing.Size(112, 44);
            this.SelectFormNextButton.TabIndex = 4;
            this.SelectFormNextButton.Text = "Next Form";
            this.SelectFormNextButton.UseVisualStyleBackColor = true;
            this.SelectFormNextButton.Click += new System.EventHandler(this.SelectFormNextButton_Click);
            // 
            // SelectHardwareLabel
            // 
            this.SelectHardwareLabel.AutoSize = true;
            this.SelectHardwareLabel.Location = new System.Drawing.Point(255, 19);
            this.SelectHardwareLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectHardwareLabel.Name = "SelectHardwareLabel";
            this.SelectHardwareLabel.Size = new System.Drawing.Size(282, 25);
            this.SelectHardwareLabel.TabIndex = 6;
            this.SelectHardwareLabel.Text = "Select your computer hardware";
            // 
            // HardwareSelectedLabel
            // 
            this.HardwareSelectedLabel.AutoSize = true;
            this.HardwareSelectedLabel.Location = new System.Drawing.Point(29, 238);
            this.HardwareSelectedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HardwareSelectedLabel.Name = "HardwareSelectedLabel";
            this.HardwareSelectedLabel.Size = new System.Drawing.Size(180, 25);
            this.HardwareSelectedLabel.TabIndex = 7;
            this.HardwareSelectedLabel.Text = "Hardware selected:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 235);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(487, 30);
            this.textBox1.TabIndex = 8;
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.Location = new System.Drawing.Point(299, 302);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 44);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(407, 302);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 44);
            this.button2.TabIndex = 10;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.HardwareSelectedLabel);
            this.Controls.Add(this.SelectHardwareLabel);
            this.Controls.Add(this.SelectFormPrevButton);
            this.Controls.Add(this.SelectFormNextButton);
            this.Controls.Add(this.ProductDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            this.Load += new System.EventHandler(this.SelectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductDataGridView;
        private System.Windows.Forms.Button SelectFormPrevButton;
        private System.Windows.Forms.Button SelectFormNextButton;
        private System.Windows.Forms.Label SelectHardwareLabel;
        private System.Windows.Forms.Label HardwareSelectedLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button button2;
    }
}