namespace COMP123_S2019_A5_301035028.Views
{
    partial class SplashForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashForm));
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SplashScreenBottomLabel = new System.Windows.Forms.Label();
            this.SplashScreenTopLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashScreenBottomLabel
            // 
            this.SplashScreenBottomLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplashScreenBottomLabel.BackColor = System.Drawing.Color.DimGray;
            this.SplashScreenBottomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenBottomLabel.Location = new System.Drawing.Point(0, 475);
            this.SplashScreenBottomLabel.Name = "SplashScreenBottomLabel";
            this.SplashScreenBottomLabel.Size = new System.Drawing.Size(600, 31);
            this.SplashScreenBottomLabel.TabIndex = 1;
            this.SplashScreenBottomLabel.Text = "We Sell for Less!";
            this.SplashScreenBottomLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashScreenTopLabel
            // 
            this.SplashScreenTopLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplashScreenTopLabel.BackColor = System.Drawing.Color.DimGray;
            this.SplashScreenTopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashScreenTopLabel.Location = new System.Drawing.Point(0, 0);
            this.SplashScreenTopLabel.Name = "SplashScreenTopLabel";
            this.SplashScreenTopLabel.Size = new System.Drawing.Size(600, 31);
            this.SplashScreenTopLabel.TabIndex = 1;
            this.SplashScreenTopLabel.Text = "Welcome to Dollar Computers";
            this.SplashScreenTopLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = global::COMP123_S2019_A5_301035028.Properties.Resources.Computer_money;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 506);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenTopLabel);
            this.Controls.Add(this.SplashScreenBottomLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SplashForm";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer SplashTimer;
        private System.Windows.Forms.Label SplashScreenBottomLabel;
        private System.Windows.Forms.Label SplashScreenTopLabel;
    }
}