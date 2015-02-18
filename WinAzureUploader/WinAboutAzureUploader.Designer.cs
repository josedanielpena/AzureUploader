namespace WinAzureUploader
{
    partial class WinAboutAzureUploader
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSoftwareName = new System.Windows.Forms.Label();
            this.labelSoftwareVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::WinAzureUploader.Properties.Resources.Slide_tecnologia_a_su_alcance;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1036, 390);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labelSoftwareName
            // 
            this.labelSoftwareName.AutoSize = true;
            this.labelSoftwareName.Font = new System.Drawing.Font("Roboto Cn", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoftwareName.Location = new System.Drawing.Point(587, 9);
            this.labelSoftwareName.Name = "labelSoftwareName";
            this.labelSoftwareName.Size = new System.Drawing.Size(277, 38);
            this.labelSoftwareName.TabIndex = 1;
            this.labelSoftwareName.Text = "HTM Azure Uploader";
            // 
            // labelSoftwareVersion
            // 
            this.labelSoftwareVersion.AutoSize = true;
            this.labelSoftwareVersion.Font = new System.Drawing.Font("Roboto Cn", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSoftwareVersion.Location = new System.Drawing.Point(814, 47);
            this.labelSoftwareVersion.Name = "labelSoftwareVersion";
            this.labelSoftwareVersion.Size = new System.Drawing.Size(124, 29);
            this.labelSoftwareVersion.TabIndex = 2;
            this.labelSoftwareVersion.Text = "Version 0.1 ";
            // 
            // WinAboutAzureUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 390);
            this.Controls.Add(this.labelSoftwareVersion);
            this.Controls.Add(this.labelSoftwareName);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WinAboutAzureUploader";
            this.Text = ":: Azure Uploader Version ::";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSoftwareName;
        private System.Windows.Forms.Label labelSoftwareVersion;
    }
}