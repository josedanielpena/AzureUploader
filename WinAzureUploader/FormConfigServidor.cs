using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinAzureUploader
{
    public partial class FormConfigServidor : Form
    {
        Datos.CfgCnx ConexionServidor;

        public FormConfigServidor()
        {
            InitializeComponent();
            ConexionServidor = new Datos.CfgCnx();
            llenarDatos();
        }


        private void llenarDatos()
        {

            try
            {

                ConexionServidor = Datos.ClsUtilesCnx.LeerXMLConexionServidor();
                textBoxAccountName.Text = ConexionServidor.AccountName.ToString();
                textBoxAcoountKey.Text = ConexionServidor.AcoountKey;
                textBoxContainerName.Text = ConexionServidor.ContainerName;
                textBoxIdUsuario.Text = ConexionServidor.IdUsuario;



            }
            catch (Exception error)
            {

                MessageBox.Show("OCURRIO UN ERROR: " + error.Message, "Error leyendo Archivo de Configuracon", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                //MessageBox.Show("No se enc
            }
        
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            guardarConexion();
            this.Close();
        }


        private void guardarConexion()
        {

            ConexionServidor.AccountName = textBoxAccountName.Text;
            ConexionServidor.AcoountKey = textBoxAcoountKey.Text;
            ConexionServidor.ContainerName = textBoxContainerName.Text.ToLower();
            ConexionServidor.IdUsuario = textBoxIdUsuario.Text.ToLower();


            Datos.ClsUtilesCnx.EscribirXMLConexionServidor(ConexionServidor);
        }
    }
}
