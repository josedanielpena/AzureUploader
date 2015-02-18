using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.IO.Compression;
using System.Text;
using System.Data;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace Datos.SoporteArchivos
{
    public abstract class Archivo : IArchivo
    {

        public string IdUsuario { get; set; }

        public string LlaveFila { get; set; }

        public string RutaArchivo { get; set; }

        public string Comentarios { get; set; }

        public string NombreRealArchivo { get; set; }

        public string Contenedor { get; set; }

        public bool ArchivoPublico { get; set; }

        public long FileSize { get; set; }

        public DateTime FechaCaptura { get; set; }

        public string CheckMD5 { get; set; }

        public void WriteData(byte[] datos)
        {
            var container = Datos.SoporteArchivos.UtilesAzure.ObtenerContenedorBlob(ClsUtilesCnx.LeerXMLConexionServidor().ContainerName);

            string NombreReferenciaBlob = LlaveFila;

            var blob = container.GetBlockBlobReference(NombreReferenciaBlob);

            var md5 = MD5.Create();

            byte[] sumamd5 = md5.ComputeHash(datos);

            string sumamd5string = BitConverter.ToString(sumamd5).Replace("-", String.Empty);

            MemoryStream ostream = new MemoryStream(datos);
            blob.UploadFromStream(ostream);

            

            //System.Threading.Tasks.Task otarea = blob.UploadFromStreamAsync(ostream);



            blob.Metadata["nombrearchivo"] = this.LlaveFila;//this.RutaArchivo;
            blob.Metadata["idusuario"] = this.IdUsuario;

            blob.Metadata["nombrereal"] = ClsUtilesCnx.UTF8toASCII(this.NombreRealArchivo);
            blob.Metadata["llavefilaUsuario"] = this.LlaveFila;
            //blob.Metadata["tipoarchivo"] = "";
            blob.Metadata["MD5"] = sumamd5string;
            blob.SetMetadata();

            this.CheckMD5 = sumamd5string;

        }

        public byte[] GetData()
        {
            //throw new NotImplementedException("falta implementar");

            string NombreReferenciaBlob = this.LlaveFila; //CedulaPaciente + "/" + NombreArchivo;

            CloudBlobContainer container = Datos.SoporteArchivos.UtilesAzure.ObtenerContenedorBlob(this.Contenedor);
            CloudBlockBlob blob = container.GetBlockBlobReference(NombreReferenciaBlob);

            blob.FetchAttributes();

            MemoryStream ostream = new MemoryStream();

            blob.DownloadToStream(ostream);

            return ostream.ToArray();
        }

        public string getPublicURL()
        {

            if (this.ArchivoPublico)
            {
                string NombreReferenciaBlob = this.LlaveFila;
                CloudBlobContainer container = Datos.SoporteArchivos.UtilesAzure.ObtenerContenedorBlob(this.Contenedor);
                CloudBlockBlob blob = container.GetBlockBlobReference(NombreReferenciaBlob);

                blob.FetchAttributes();

                Uri ouri = blob.Uri;

                return ouri.ToString();
            }
            else
            {
                return null;
            }


        }

        public void saveArchivo()
        {
            var mensajetable = Datos.SoporteArchivos.TableEntryUsuario.ObtenerRegistroTableEntryUsuario(this.IdUsuario, this.LlaveFila);

            if (mensajetable == null)
            {
                mensajetable = new Datos.SoporteArchivos.TableEntryUsuario();
            }


            mensajetable.RutaArchivo = this.RutaArchivo;//oarchivo.NombreRealArchivo;
            mensajetable.Comentarios = this.Comentarios;
            mensajetable.FechaCaptura = this.FechaCaptura;

            mensajetable.FileSize = this.FileSize;
            mensajetable.NombreRealArchivo = this.NombreRealArchivo;
            mensajetable.Contenedor = this.Contenedor;
            mensajetable.ArchivoPublico = this.ArchivoPublico;
            mensajetable.PartitionKey = this.IdUsuario;
            mensajetable.RowKey = this.LlaveFila;
            mensajetable.CheckMD5 = this.CheckMD5;
            Datos.SoporteArchivos.TableEntryUsuario.GuardarRegistro(mensajetable);
        }




        public bool deleteArchivo()
        {
            var mensajetable = Datos.SoporteArchivos.TableEntryUsuario.ObtenerRegistroTableEntryUsuario(this.IdUsuario, this.LlaveFila);


            Datos.SoporteArchivos.TableEntryUsuario.EliminarRegistroTableEntryUsuario(this.IdUsuario, this.LlaveFila); //aqui tengo dudas...


            var container = Datos.SoporteArchivos.UtilesAzure.ObtenerContenedorBlob(this.Contenedor);

            var blob = container.GetBlockBlobReference(this.LlaveFila);

            blob.FetchAttributes();

            return blob.DeleteIfExists();
        }
    }
}
