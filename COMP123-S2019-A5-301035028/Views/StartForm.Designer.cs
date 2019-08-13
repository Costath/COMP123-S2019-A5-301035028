namespace COMP123_S2019_A5_301035028.Views
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
            this.NewOrderButton = new System.Windows.Forms.Button();
            this.LoadOrderButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.StartPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.AutoSize = true;
            this.NewOrderButton.Location = new System.Drawing.Point(33, 131);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(6);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(196, 44);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a new order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            this.NewOrderButton.Click += new System.EventHandler(this.NewOrderButton_Click);
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.AutoSize = true;
            this.LoadOrderButton.Location = new System.Drawing.Point(33, 187);
            this.LoadOrderButton.Margin = new System.Windows.Forms.Padding(6);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(196, 44);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "Load a saved order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            this.LoadOrderButton.Click += new System.EventHandler(this.LoadOrderButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(33, 239);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(196, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartPictureBox
            // 
            this.StartPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.StartPictureBox.Image = global::COMP123_S2019_A5_301035028.Properties.Resources.laptop;
            this.StartPictureBox.Location = new System.Drawing.Point(11, 11);
            this.StartPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.StartPictureBox.Name = "StartPictureBox";
            this.StartPictureBox.Size = new System.Drawing.Size(237, 112);
            this.StartPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StartPictureBox.TabIndex = 5;
            this.StartPictureBox.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 295);
            this.ControlBox = false;
            this.Controls.Add(this.StartPictureBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.StartPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox StartPictureBox;
    }
}