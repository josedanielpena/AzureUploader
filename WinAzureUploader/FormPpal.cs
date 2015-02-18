using System;
using System.Collections.Generic;
using System.IO;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAzureUploader
{
    public partial class FormPpal : Form
    {
        int contador = 0;
        List<FileInfo> ListadoArchivos;

        public FormPpal()
        {
            InitializeComponent();
        }

        private void configuracionServidorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormConfigServidor ofrm = new FormConfigServidor();
            ofrm.ShowDialog();
        }

        private void buttonRecargarListaAzure_Click(object sender, EventArgs e)
        {
            RecargarListaAzure();
            

        }

        private void RecargarListaAzure()
        {
            string sBusqueda = textBoxFiltroBusqueda.Text.Trim();
            string idUsuario = Datos.ClsUtilesCnx.LeerXMLConexionServidor().IdUsuario;

            List<Datos.SoporteArchivos.ArchivoUsuario> salida = Logica.ArchivodeUsuario.ListarArchivosUsuario(idUsuario, sBusqueda);
            bindingSourceListadoElementos.DataSource = salida;
            dataGridViewArchivosEnAzure.DataSource = bindingSourceListadoElementos;
            dataGridViewArchivosEnAzure.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
        }

        private void buttonSelectFile_Click(object sender, EventArgs e)
        {
            SeleccionarArchivo();

        }

        private void SeleccionarArchivo()
        {
            OpenFileDialog dlgarchivo = new OpenFileDialog();
            dlgarchivo.Multiselect = true;
            if (dlgarchivo.ShowDialog() == DialogResult.OK)
            {

                foreach (string item in dlgarchivo.FileNames)
                {


                    FileInfo infoarchivo = new FileInfo(item);

                    if (infoarchivo.Exists)
                    {
                        ListViewItem itemParaSubir = new ListViewItem(item);
                        itemParaSubir.SubItems.Add(infoarchivo.Extension);
                        itemParaSubir.SubItems.Add(infoarchivo.Length.ToString());

                        listViewFilesToUpload.Items.Add(itemParaSubir);
                    }
                   
                }


            }
        }

        private void HabilitarElementos(bool estado)
        {
            //groupBoxUploadControls.Enabled = estado;
            buttonSelectFile.Enabled = estado;
            listViewFilesToUpload.Enabled = estado;
            textBoxComentario.Enabled = estado;
            checkBoxPublicFile.Enabled = estado;
            buttonUploadFile.Enabled = estado;
            buttonCancelUpload.Enabled = !estado;
        }
            

        private void buttonUploadFile_Click(object sender, EventArgs e)
        {
            

            if (listViewFilesToUpload.Items.Count >= 1)
            {

                ListadoArchivos = new List<FileInfo>();
                foreach (ListViewItem item in listViewFilesToUpload.Items)
                {
                    FileInfo infoarchivo = new FileInfo(item.Text);

                    if (infoarchivo.Exists)
                    {
                        ListadoArchivos.Add(infoarchivo);
                    }
                }

                toolStripStatusLabelEstadoProgreso.Text = "Iniciando Proceso...";
                toolStripProgressBarEstado.Value = 0;

                backgroundWorkerUploader.RunWorkerAsync();

                //buttonCancelUpload.Enabled = true;

                HabilitarElementos(false);
            }
            else
            {
                MessageBox.Show("Seleccione Archivos a Subir primero", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }



        private void LimpiarCampos()
        {
            listViewFilesToUpload.Items.Clear();
            textBoxComentario.Clear();
            checkBoxPublicFile.Checked = false;
        }

        private void eliminarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                var elementoSeleccionado = bindingSourceListadoElementos.Current;

                Datos.SoporteArchivos.ArchivoUsuario elemento = (Datos.SoporteArchivos.ArchivoUsuario)elementoSeleccionado;

                Logica.ArchivodeUsuario.eliminarArchivoUsuario(elemento);

                RecargarListaAzure();

                MessageBox.Show("Archivo eliminado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {

                MessageBox.Show("Ocurrio el siguiente error Eliminado el Archivo: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void descargarArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DescargarArchivo();

        }

        private void DescargarArchivo()
        {
            try
            {
                var elementoSeleccionado = bindingSourceListadoElementos.Current;

                Datos.SoporteArchivos.ArchivoUsuario elemento = (Datos.SoporteArchivos.ArchivoUsuario)elementoSeleccionado;

                SaveFileDialog savedialog = new SaveFileDialog();

                savedialog.InitialDirectory = Path.GetDirectoryName(Environment.SpecialFolder.MyDocuments.ToString());

                savedialog.FileName = elemento.NombreRealArchivo;

                if (savedialog.ShowDialog() == DialogResult.OK)
                {
                    byte[] archivo = elemento.GetData();

                    File.WriteAllBytes(savedialog.FileName, archivo);

                    MessageBox.Show("Archivo Descargado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception error)
            {

                MessageBox.Show("Ocurrio el siguiente error Descargando el Archivo: " + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void uRLPublicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var elementoSeleccionado = bindingSourceListadoElementos.Current;

            Datos.SoporteArchivos.ArchivoUsuario elemento = (Datos.SoporteArchivos.ArchivoUsuario)elementoSeleccionado;

            

            MessageBox.Show("URL Publica:  " + elemento.getPublicURL() + System.Environment.NewLine + "Ruta Copiada Exitosamente al portapapeles", "Mensaje del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Clipboard.SetText(elemento.getPublicURL());
        }

        private void backgroundWorkerUploader_DoWork(object sender, DoWorkEventArgs e)
        {
            contador = 0;
            int totalArchivos = listViewFilesToUpload.Items.Count;
            foreach (FileInfo item in ListadoArchivos)
            {

                if ((sender as BackgroundWorker).CancellationPending)
                {
                    return;
                }

                Logica.ArchivodeUsuario.UploadItem(item, textBoxComentario.Text, checkBoxPublicFile.Checked);

                contador++;

                (sender as BackgroundWorker).ReportProgress((int)(100 / totalArchivos) * (contador), null);


            }
        }


        private void backgroundWorkerUploader_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            RecargarListaAzure();
            LimpiarCampos();
            ListadoArchivos.Clear();
            HabilitarElementos(true);

            toolStripStatusLabelEstadoProgreso.Text = "";
            toolStripProgressBarEstado.Value = 0;

            MessageBox.Show(contador.ToString() + " Archivos Cargados Exitosamente!", "Aviso de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void backgroundWorkerUploader_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            int progreso = e.ProgressPercentage < 100 ? e.ProgressPercentage : 100;

            toolStripStatusLabelEstadoProgreso.Text = progreso + "%  Realizado";
            toolStripProgressBarEstado.Value = progreso;
        }

        private void buttonCancelUpload_Click(object sender, EventArgs e)
        {
            backgroundWorkerUploader.CancelAsync();

            HabilitarElementos(true);
            RecargarListaAzure();
            LimpiarCampos();

            MessageBox.Show("Proceso Cancelado por Usuario!", "Aviso de Proceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void obtenerArchivosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RecargarListaAzure();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WinAboutAzureUploader ofrm = new WinAboutAzureUploader();

            ofrm.ShowDialog();
        }
    }


}
