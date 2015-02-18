namespace WinAzureUploader
{
    partial class FormPpal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obtenerArchivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripPpal = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBarEstado = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabelEstadoProgreso = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainerPpal = new System.Windows.Forms.SplitContainer();
            this.groupBoxUploadControls = new System.Windows.Forms.GroupBox();
            this.buttonCancelUpload = new System.Windows.Forms.Button();
            this.checkBoxPublicFile = new System.Windows.Forms.CheckBox();
            this.listViewFilesToUpload = new System.Windows.Forms.ListView();
            this.columnHeaderNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonSelectFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.groupBoxArchivoAzure = new System.Windows.Forms.GroupBox();
            this.dataGridViewArchivosEnAzure = new System.Windows.Forms.DataGridView();
            this.contextMenuStripActionFileAzure = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.descargarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLPublicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarArchivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxFiltroBusqueda = new System.Windows.Forms.TextBox();
            this.buttonRecargarListaAzure = new System.Windows.Forms.Button();
            this.panelSuperior = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxLogoChoucair = new System.Windows.Forms.PictureBox();
            this.backgroundWorkerUploader = new System.ComponentModel.BackgroundWorker();
            this.bindingSourceListadoElementos = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStripPpal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPpal)).BeginInit();
            this.splitContainerPpal.Panel1.SuspendLayout();
            this.splitContainerPpal.Panel2.SuspendLayout();
            this.splitContainerPpal.SuspendLayout();
            this.groupBoxUploadControls.SuspendLayout();
            this.groupBoxArchivoAzure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchivosEnAzure)).BeginInit();
            this.contextMenuStripActionFileAzure.SuspendLayout();
            this.panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChoucair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListadoElementos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(924, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::WinAzureUploader.Properties.Resources.door_out;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionServidorToolStripMenuItem});
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // configuracionServidorToolStripMenuItem
            // 
            this.configuracionServidorToolStripMenuItem.Image = global::WinAzureUploader.Properties.Resources.connect;
            this.configuracionServidorToolStripMenuItem.Name = "configuracionServidorToolStripMenuItem";
            this.configuracionServidorToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.configuracionServidorToolStripMenuItem.Text = "Configuracion Servidor";
            this.configuracionServidorToolStripMenuItem.Click += new System.EventHandler(this.configuracionServidorToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obtenerArchivosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // obtenerArchivosToolStripMenuItem
            // 
            this.obtenerArchivosToolStripMenuItem.Image = global::WinAzureUploader.Properties.Resources.download;
            this.obtenerArchivosToolStripMenuItem.Name = "obtenerArchivosToolStripMenuItem";
            this.obtenerArchivosToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.obtenerArchivosToolStripMenuItem.Text = "Obtener Archivos";
            this.obtenerArchivosToolStripMenuItem.Click += new System.EventHandler(this.obtenerArchivosToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // statusStripPpal
            // 
            this.statusStripPpal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBarEstado,
            this.toolStripStatusLabelEstadoProgreso});
            this.statusStripPpal.Location = new System.Drawing.Point(0, 673);
            this.statusStripPpal.Name = "statusStripPpal";
            this.statusStripPpal.Size = new System.Drawing.Size(924, 22);
            this.statusStripPpal.TabIndex = 1;
            this.statusStripPpal.Text = "statusStrip1";
            // 
            // toolStripProgressBarEstado
            // 
            this.toolStripProgressBarEstado.Name = "toolStripProgressBarEstado";
            this.toolStripProgressBarEstado.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabelEstadoProgreso
            // 
            this.toolStripStatusLabelEstadoProgreso.Name = "toolStripStatusLabelEstadoProgreso";
            this.toolStripStatusLabelEstadoProgreso.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabelEstadoProgreso.Text = "Estado";
            // 
            // splitContainerPpal
            // 
            this.splitContainerPpal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerPpal.Location = new System.Drawing.Point(12, 79);
            this.splitContainerPpal.Name = "splitContainerPpal";
            // 
            // splitContainerPpal.Panel1
            // 
            this.splitContainerPpal.Panel1.Controls.Add(this.groupBoxUploadControls);
            // 
            // splitContainerPpal.Panel2
            // 
            this.splitContainerPpal.Panel2.Controls.Add(this.groupBoxArchivoAzure);
            this.splitContainerPpal.Size = new System.Drawing.Size(900, 591);
            this.splitContainerPpal.SplitterDistance = 413;
            this.splitContainerPpal.TabIndex = 2;
            // 
            // groupBoxUploadControls
            // 
            this.groupBoxUploadControls.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxUploadControls.Controls.Add(this.buttonCancelUpload);
            this.groupBoxUploadControls.Controls.Add(this.checkBoxPublicFile);
            this.groupBoxUploadControls.Controls.Add(this.listViewFilesToUpload);
            this.groupBoxUploadControls.Controls.Add(this.buttonSelectFile);
            this.groupBoxUploadControls.Controls.Add(this.label2);
            this.groupBoxUploadControls.Controls.Add(this.textBoxComentario);
            this.groupBoxUploadControls.Controls.Add(this.label1);
            this.groupBoxUploadControls.Controls.Add(this.buttonUploadFile);
            this.groupBoxUploadControls.Location = new System.Drawing.Point(12, 3);
            this.groupBoxUploadControls.Name = "groupBoxUploadControls";
            this.groupBoxUploadControls.Size = new System.Drawing.Size(391, 579);
            this.groupBoxUploadControls.TabIndex = 2;
            this.groupBoxUploadControls.TabStop = false;
            this.groupBoxUploadControls.Text = "Subir Archivo";
            // 
            // buttonCancelUpload
            // 
            this.buttonCancelUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCancelUpload.Enabled = false;
            this.buttonCancelUpload.Image = global::WinAzureUploader.Properties.Resources.cancel;
            this.buttonCancelUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelUpload.Location = new System.Drawing.Point(278, 536);
            this.buttonCancelUpload.Name = "buttonCancelUpload";
            this.buttonCancelUpload.Size = new System.Drawing.Size(98, 37);
            this.buttonCancelUpload.TabIndex = 7;
            this.buttonCancelUpload.Text = "Cancelar";
            this.buttonCancelUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelUpload.UseVisualStyleBackColor = true;
            this.buttonCancelUpload.Click += new System.EventHandler(this.buttonCancelUpload_Click);
            // 
            // checkBoxPublicFile
            // 
            this.checkBoxPublicFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxPublicFile.AutoSize = true;
            this.checkBoxPublicFile.Location = new System.Drawing.Point(14, 513);
            this.checkBoxPublicFile.Name = "checkBoxPublicFile";
            this.checkBoxPublicFile.Size = new System.Drawing.Size(110, 17);
            this.checkBoxPublicFile.TabIndex = 6;
            this.checkBoxPublicFile.Text = "Archivos Publicos";
            this.checkBoxPublicFile.UseVisualStyleBackColor = true;
            // 
            // listViewFilesToUpload
            // 
            this.listViewFilesToUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewFilesToUpload.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNombre,
            this.columnHeaderExtension,
            this.columnHeaderSize});
            this.listViewFilesToUpload.Location = new System.Drawing.Point(14, 65);
            this.listViewFilesToUpload.Name = "listViewFilesToUpload";
            this.listViewFilesToUpload.Size = new System.Drawing.Size(363, 340);
            this.listViewFilesToUpload.TabIndex = 0;
            this.listViewFilesToUpload.UseCompatibleStateImageBehavior = false;
            this.listViewFilesToUpload.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNombre
            // 
            this.columnHeaderNombre.Text = "Nombre";
            this.columnHeaderNombre.Width = 212;
            // 
            // columnHeaderExtension
            // 
            this.columnHeaderExtension.Text = "Extension";
            // 
            // columnHeaderSize
            // 
            this.columnHeaderSize.Text = "Tamaño";
            this.columnHeaderSize.Width = 82;
            // 
            // buttonSelectFile
            // 
            this.buttonSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelectFile.Image = global::WinAzureUploader.Properties.Resources.page_white_magnify;
            this.buttonSelectFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSelectFile.Location = new System.Drawing.Point(283, 14);
            this.buttonSelectFile.Name = "buttonSelectFile";
            this.buttonSelectFile.Size = new System.Drawing.Size(93, 40);
            this.buttonSelectFile.TabIndex = 5;
            this.buttonSelectFile.Text = "Explorar";
            this.buttonSelectFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSelectFile.UseVisualStyleBackColor = true;
            this.buttonSelectFile.Click += new System.EventHandler(this.buttonSelectFile_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 418);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Comentarios:";
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxComentario.Location = new System.Drawing.Point(14, 435);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(362, 72);
            this.textBoxComentario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivos a Subir: ";
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonUploadFile.Image = global::WinAzureUploader.Properties.Resources.application_get;
            this.buttonUploadFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUploadFile.Location = new System.Drawing.Point(145, 536);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(127, 37);
            this.buttonUploadFile.TabIndex = 1;
            this.buttonUploadFile.Text = "Subir Archivos";
            this.buttonUploadFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUploadFile.UseVisualStyleBackColor = true;
            this.buttonUploadFile.Click += new System.EventHandler(this.buttonUploadFile_Click);
            // 
            // groupBoxArchivoAzure
            // 
            this.groupBoxArchivoAzure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxArchivoAzure.Controls.Add(this.dataGridViewArchivosEnAzure);
            this.groupBoxArchivoAzure.Controls.Add(this.textBoxFiltroBusqueda);
            this.groupBoxArchivoAzure.Controls.Add(this.buttonRecargarListaAzure);
            this.groupBoxArchivoAzure.Location = new System.Drawing.Point(3, 3);
            this.groupBoxArchivoAzure.Name = "groupBoxArchivoAzure";
            this.groupBoxArchivoAzure.Size = new System.Drawing.Size(477, 585);
            this.groupBoxArchivoAzure.TabIndex = 0;
            this.groupBoxArchivoAzure.TabStop = false;
            this.groupBoxArchivoAzure.Text = "Archivos en Servidor";
            // 
            // dataGridViewArchivosEnAzure
            // 
            this.dataGridViewArchivosEnAzure.AllowUserToAddRows = false;
            this.dataGridViewArchivosEnAzure.AllowUserToDeleteRows = false;
            this.dataGridViewArchivosEnAzure.AllowUserToOrderColumns = true;
            this.dataGridViewArchivosEnAzure.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewArchivosEnAzure.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArchivosEnAzure.ContextMenuStrip = this.contextMenuStripActionFileAzure;
            this.dataGridViewArchivosEnAzure.Location = new System.Drawing.Point(6, 58);
            this.dataGridViewArchivosEnAzure.MultiSelect = false;
            this.dataGridViewArchivosEnAzure.Name = "dataGridViewArchivosEnAzure";
            this.dataGridViewArchivosEnAzure.ReadOnly = true;
            this.dataGridViewArchivosEnAzure.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewArchivosEnAzure.Size = new System.Drawing.Size(467, 521);
            this.dataGridViewArchivosEnAzure.TabIndex = 3;
            // 
            // contextMenuStripActionFileAzure
            // 
            this.contextMenuStripActionFileAzure.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.descargarArchivoToolStripMenuItem,
            this.uRLPublicaToolStripMenuItem,
            this.eliminarArchivoToolStripMenuItem});
            this.contextMenuStripActionFileAzure.Name = "contextMenuStripActionFileAzure";
            this.contextMenuStripActionFileAzure.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStripActionFileAzure.Size = new System.Drawing.Size(171, 70);
            // 
            // descargarArchivoToolStripMenuItem
            // 
            this.descargarArchivoToolStripMenuItem.Name = "descargarArchivoToolStripMenuItem";
            this.descargarArchivoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.descargarArchivoToolStripMenuItem.Text = "Descargar Archivo";
            this.descargarArchivoToolStripMenuItem.Click += new System.EventHandler(this.descargarArchivoToolStripMenuItem_Click);
            // 
            // uRLPublicaToolStripMenuItem
            // 
            this.uRLPublicaToolStripMenuItem.Name = "uRLPublicaToolStripMenuItem";
            this.uRLPublicaToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.uRLPublicaToolStripMenuItem.Text = "URL Publica";
            this.uRLPublicaToolStripMenuItem.Click += new System.EventHandler(this.uRLPublicaToolStripMenuItem_Click);
            // 
            // eliminarArchivoToolStripMenuItem
            // 
            this.eliminarArchivoToolStripMenuItem.Name = "eliminarArchivoToolStripMenuItem";
            this.eliminarArchivoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.eliminarArchivoToolStripMenuItem.Text = "Eliminar Archivo";
            this.eliminarArchivoToolStripMenuItem.Click += new System.EventHandler(this.eliminarArchivoToolStripMenuItem_Click);
            // 
            // textBoxFiltroBusqueda
            // 
            this.textBoxFiltroBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFiltroBusqueda.Location = new System.Drawing.Point(6, 25);
            this.textBoxFiltroBusqueda.Name = "textBoxFiltroBusqueda";
            this.textBoxFiltroBusqueda.Size = new System.Drawing.Size(342, 20);
            this.textBoxFiltroBusqueda.TabIndex = 2;
            // 
            // buttonRecargarListaAzure
            // 
            this.buttonRecargarListaAzure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRecargarListaAzure.Image = global::WinAzureUploader.Properties.Resources.zoom_refresh;
            this.buttonRecargarListaAzure.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRecargarListaAzure.Location = new System.Drawing.Point(365, 16);
            this.buttonRecargarListaAzure.Name = "buttonRecargarListaAzure";
            this.buttonRecargarListaAzure.Size = new System.Drawing.Size(97, 36);
            this.buttonRecargarListaAzure.TabIndex = 1;
            this.buttonRecargarListaAzure.Text = "Recargar";
            this.buttonRecargarListaAzure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRecargarListaAzure.UseVisualStyleBackColor = true;
            this.buttonRecargarListaAzure.Click += new System.EventHandler(this.buttonRecargarListaAzure_Click);
            // 
            // panelSuperior
            // 
            this.panelSuperior.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSuperior.BackColor = System.Drawing.Color.White;
            this.panelSuperior.Controls.Add(this.label3);
            this.panelSuperior.Controls.Add(this.pictureBoxLogoChoucair);
            this.panelSuperior.Location = new System.Drawing.Point(0, 24);
            this.panelSuperior.Name = "panelSuperior";
            this.panelSuperior.Size = new System.Drawing.Size(924, 52);
            this.panelSuperior.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "HTM Azure Uploader";
            // 
            // pictureBoxLogoChoucair
            // 
            this.pictureBoxLogoChoucair.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxLogoChoucair.Image = global::WinAzureUploader.Properties.Resources.Logo_EmpresaSmall;
            this.pictureBoxLogoChoucair.Location = new System.Drawing.Point(812, 0);
            this.pictureBoxLogoChoucair.Name = "pictureBoxLogoChoucair";
            this.pictureBoxLogoChoucair.Size = new System.Drawing.Size(112, 52);
            this.pictureBoxLogoChoucair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogoChoucair.TabIndex = 1;
            this.pictureBoxLogoChoucair.TabStop = false;
            // 
            // backgroundWorkerUploader
            // 
            this.backgroundWorkerUploader.WorkerReportsProgress = true;
            this.backgroundWorkerUploader.WorkerSupportsCancellation = true;
            this.backgroundWorkerUploader.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerUploader_DoWork);
            this.backgroundWorkerUploader.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerUploader_ProgressChanged);
            this.backgroundWorkerUploader.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerUploader_RunWorkerCompleted);
            // 
            // FormPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 695);
            this.Controls.Add(this.panelSuperior);
            this.Controls.Add(this.splitContainerPpal);
            this.Controls.Add(this.statusStripPpal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPpal";
            this.Text = "Azure Uploader";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStripPpal.ResumeLayout(false);
            this.statusStripPpal.PerformLayout();
            this.splitContainerPpal.Panel1.ResumeLayout(false);
            this.splitContainerPpal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPpal)).EndInit();
            this.splitContainerPpal.ResumeLayout(false);
            this.groupBoxUploadControls.ResumeLayout(false);
            this.groupBoxUploadControls.PerformLayout();
            this.groupBoxArchivoAzure.ResumeLayout(false);
            this.groupBoxArchivoAzure.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArchivosEnAzure)).EndInit();
            this.contextMenuStripActionFileAzure.ResumeLayout(false);
            this.panelSuperior.ResumeLayout(false);
            this.panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChoucair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceListadoElementos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionServidorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obtenerArchivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripPpal;
        private System.Windows.Forms.SplitContainer splitContainerPpal;
        private System.Windows.Forms.GroupBox groupBoxArchivoAzure;
        private System.Windows.Forms.Button buttonRecargarListaAzure;
        private System.Windows.Forms.ListView listViewFilesToUpload;
        private System.Windows.Forms.ColumnHeader columnHeaderNombre;
        private System.Windows.Forms.ColumnHeader columnHeaderSize;
        private System.Windows.Forms.GroupBox groupBoxUploadControls;
        private System.Windows.Forms.Button buttonUploadFile;
        private System.Windows.Forms.TextBox textBoxFiltroBusqueda;
        private System.Windows.Forms.DataGridView dataGridViewArchivosEnAzure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxComentario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSelectFile;
        private System.Windows.Forms.CheckBox checkBoxPublicFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripActionFileAzure;
        private System.Windows.Forms.ToolStripMenuItem descargarArchivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarArchivoToolStripMenuItem;
        private System.Windows.Forms.BindingSource bindingSourceListadoElementos;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.ColumnHeader columnHeaderExtension;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBarEstado;
        private System.Windows.Forms.ToolStripMenuItem uRLPublicaToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorkerUploader;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelEstadoProgreso;
        private System.Windows.Forms.Button buttonCancelUpload;
        private System.Windows.Forms.PictureBox pictureBoxLogoChoucair;
        private System.Windows.Forms.Label label3;
    }
}

