using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using System.IO;

namespace Logica
{
    public class ArchivodeUsuario
    {
        public static List<Datos.SoporteArchivos.ArchivoUsuario> ListarArchivosUsuario(string idusuario, string pbusqueda)
        {
            return Datos.SoporteArchivos.ArchivoUsuario.ListarArchivoxidUsuario(idusuario, pbusqueda);
        }

        public static Datos.SoporteArchivos.ArchivoUsuario obtenerArchivoUsuario(string idusuario, string llavefila)
        {
            return Datos.SoporteArchivos.ArchivoUsuario.getArchivo(idusuario, llavefila);
        }

        public static void guardarArchivoUsuario(Datos.SoporteArchivos.ArchivoUsuario oarchivousuario)
        {
            oarchivousuario.saveArchivo();
            
        }

        public static void eliminarArchivoUsuario(Datos.SoporteArchivos.ArchivoUsuario oarchivousuario)
        {
            oarchivousuario.deleteArchivo();
        }

        public static void UploadItem(FileInfo item, string comentario, bool publicFile)
        {
            string idUsuario = Datos.ClsUtilesCnx.LeerXMLConexionServidor().IdUsuario;

            Datos.SoporteArchivos.ArchivoUsuario oarchivousuario = new Datos.SoporteArchivos.ArchivoUsuario(idUsuario);

            oarchivousuario.NombreRealArchivo = item.Name.Replace(" ", "_");
            oarchivousuario.Comentarios = comentario;
            oarchivousuario.ArchivoPublico = publicFile;

            byte[] datos = File.ReadAllBytes(item.FullName);

            oarchivousuario.FileSize = datos.LongLength;
            oarchivousuario.saveArchivo();

            oarchivousuario.WriteData(datos);

            oarchivousuario.saveArchivo();
        }
            
    }
}
