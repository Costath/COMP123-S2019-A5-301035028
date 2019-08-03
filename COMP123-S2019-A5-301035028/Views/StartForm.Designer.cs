﻿namespace COMP123_S2019_A5_301035028.Views
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
            this.StartFormNextButton = new System.Windows.Forms.Button();
            this.StartFormPrevButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NewOrderButton
            // 
            this.NewOrderButton.AutoSize = true;
            this.NewOrderButton.Location = new System.Drawing.Point(179, 213);
            this.NewOrderButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.NewOrderButton.Name = "NewOrderButton";
            this.NewOrderButton.Size = new System.Drawing.Size(196, 44);
            this.NewOrderButton.TabIndex = 0;
            this.NewOrderButton.Text = "Start a new order";
            this.NewOrderButton.UseVisualStyleBackColor = true;
            // 
            // LoadOrderButton
            // 
            this.LoadOrderButton.AutoSize = true;
            this.LoadOrderButton.Location = new System.Drawing.Point(448, 213);
            this.LoadOrderButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadOrderButton.Name = "LoadOrderButton";
            this.LoadOrderButton.Size = new System.Drawing.Size(196, 44);
            this.LoadOrderButton.TabIndex = 1;
            this.LoadOrderButton.Text = "load a saved order";
            this.LoadOrderButton.UseVisualStyleBackColor = true;
            // 
            // StartFormNextButton
            // 
            this.StartFormNextButton.AutoSize = true;
            this.StartFormNextButton.Location = new System.Drawing.Point(657, 302);
            this.StartFormNextButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StartFormNextButton.Name = "StartFormNextButton";
            this.StartFormNextButton.Size = new System.Drawing.Size(112, 44);
            this.StartFormNextButton.TabIndex = 2;
            this.StartFormNextButton.Text = "Next Form";
            this.StartFormNextButton.UseVisualStyleBackColor = true;
            this.StartFormNextButton.Click += new System.EventHandler(this.StartFormNextButton_Click);
            // 
            // StartFormPrevButton
            // 
            this.StartFormPrevButton.AutoSize = true;
            this.StartFormPrevButton.Location = new System.Drawing.Point(15, 302);
            this.StartFormPrevButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.StartFormPrevButton.Name = "StartFormPrevButton";
            this.StartFormPrevButton.Size = new System.Drawing.Size(150, 44);
            this.StartFormPrevButton.TabIndex = 3;
            this.StartFormPrevButton.Text = "Previous Form";
            this.StartFormPrevButton.UseVisualStyleBackColor = true;
            this.StartFormPrevButton.Click += new System.EventHandler(this.StartFormPrevButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Location = new System.Drawing.Point(713, 11);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(56, 35);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(292, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 112);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.StartFormPrevButton);
            this.Controls.Add(this.StartFormNextButton);
            this.Controls.Add(this.LoadOrderButton);
            this.Controls.Add(this.NewOrderButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewOrderButton;
        private System.Windows.Forms.Button LoadOrderButton;
        private System.Windows.Forms.Button StartFormNextButton;
        private System.Windows.Forms.Button StartFormPrevButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}