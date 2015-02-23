namespace WinAzureUploader
{
    partial class FormConfigServidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfigServidor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxIdUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxContainerName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAcoountKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAccountName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBoxLogoChoucair = new System.Windows.Forms.PictureBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChoucair)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBoxIdUsuario);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxContainerName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxAcoountKey);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxAccountName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 180);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parámetros de Conexión a Servidor";
            // 
            // textBoxIdUsuario
            // 
            this.textBoxIdUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIdUsuario.Location = new System.Drawing.Point(105, 146);
            this.textBoxIdUsuario.Name = "textBoxIdUsuario";
            this.textBoxIdUsuario.Size = new System.Drawing.Size(242, 20);
            this.textBoxIdUsuario.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "IdUsuario / Indice";
            // 
            // textBoxContainerName
            // 
            this.textBoxContainerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxContainerName.Location = new System.Drawing.Point(105, 120);
            this.textBoxContainerName.Name = "textBoxContainerName";
            this.textBoxContainerName.Size = new System.Drawing.Size(242, 20);
            this.textBoxContainerName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "ContainerName";
            // 
            // textBoxAcoountKey
            // 
            this.textBoxAcoountKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAcoountKey.Location = new System.Drawing.Point(105, 57);
            this.textBoxAcoountKey.Multiline = true;
            this.textBoxAcoountKey.Name = "textBoxAcoountKey";
            this.textBoxAcoountKey.PasswordChar = '*';
            this.textBoxAcoountKey.Size = new System.Drawing.Size(242, 57);
            this.textBoxAcoountKey.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AccountKey";
            // 
            // textBoxAccountName
            // 
            this.textBoxAccountName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAccountName.Location = new System.Drawing.Point(105, 31);
            this.textBoxAccountName.Name = "textBoxAccountName";
            this.textBoxAccountName.Size = new System.Drawing.Size(242, 20);
            this.textBoxAccountName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AccountName";
            // 
            // panelSuperior
            // 
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.label5);
            this.panelSuperior.Controls.Add(this.pictureBoxLogoChoucair);
            this.panelSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(386, 57);
            this.panelSuperior.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Configuración";
            // 
            // pictureBoxLogoChoucair
            // 
            this.pictureBoxLogoChoucair.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogoChoucair.Image = global::WinAzureUploader.Properties.Resources.Logo_EmpresaSmall;
            this.pictureBoxLogoChoucair.Location = new System.Drawing.Point(274, 0);
            this.pictureBoxLogoChoucair.Name = "pictureBoxLogoChoucair";
            this.pictureBoxLogoChoucair.Size = new System.Drawing.Size(112, 57);
            this.pictureBoxLogoChoucair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoChoucair.TabIndex = 1;
            this.pictureBoxLogoChoucair.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Image = global::WinAzureUploader.Properties.Resources.disk;
            this.buttonGuardar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonGuardar.Location = new System.Drawing.Point(12, 259);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(359, 60);
            this.buttonGuardar.TabIndex = 19;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // FormConfigServidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 331);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormConfigServidor";
            this.Text = "Configuracion Servidor";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChoucair)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxIdUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxContainerName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAcoountKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAccountName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.PictureBox pictureBoxLogoChoucair;
        private System.Windows.Forms.Label label5;
    }
}