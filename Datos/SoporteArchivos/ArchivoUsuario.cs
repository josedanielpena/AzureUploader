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
    public class ArchivoUsuario : Archivo
    {

        private ArchivoUsuario(TableEntryUsuario otableentry)
        {
            this.RutaArchivo = otableentry.RutaArchivo;
            this.Comentarios = otableentry.Comentarios;
            this.NombreRealArchivo = otableentry.NombreRealArchivo;
            this.ArchivoPublico = otableentry.ArchivoPublico;
            this.FileSize = otableentry.FileSize;
            this.FechaCaptura = otableentry.FechaCaptura;
            this.IdUsuario = otableentry.PartitionKey;
            this.LlaveFila = otableentry.RowKey;
            this.CheckMD5 = otableentry.CheckMD5;
            this.Contenedor = otableentry.Contenedor;
        }

        public ArchivoUsuario(string idusuario)
        {
            Datos.SoporteArchivos.TableEntryUsuario otableentry = new Datos.SoporteArchivos.TableEntryUsuario(idusuario);


            this.RutaArchivo = otableentry.RutaArchivo;
            this.Comentarios = otableentry.Comentarios;
            this.NombreRealArchivo = otableentry.NombreRealArchivo;
            this.ArchivoPublico = otableentry.ArchivoPublico;
            this.FileSize = otableentry.FileSize;
            this.FechaCaptura = otableentry.FechaCaptura;
            this.IdUsuario = otableentry.PartitionKey;
            this.LlaveFila = otableentry.RowKey;
            this.CheckMD5 = otableentry.CheckMD5;
            this.Comentarios = "Archivo de Usuario";
            this.FileSize = 0;
            this.NombreRealArchivo = "";
            this.Contenedor = otableentry.Contenedor;
        }


        public static List<ArchivoUsuario> ListarArchivoxidUsuario(string idusuario, string pBusqueda)
        {
            List<Datos.SoporteArchivos.TableEntryUsuario> resultado = null;

            if (pBusqueda == "" || pBusqueda == null)
            {
                resultado = Datos.SoporteArchivos.TableEntryUsuario.ListarTodoxParticionxUsuario(idusuario);
            }
            else
            {
                List<Datos.SoporteArchivos.TableEntryUsuario> resultado2 = Datos.SoporteArchivos.TableEntryUsuario.ListarTodoxParticionxUsuario(idusuario);

                var consulta = from z in resultado2
                               where z.NombreRealArchivo.Contains(pBusqueda)
                               select z;

                List<Datos.SoporteArchivos.TableEntryUsuario> listanueva = consulta.ToList();
                resultado = listanueva;
            }

            List<ArchivoUsuario> lisstado = new List<ArchivoUsuario>();

            foreach (var mensajetable in resultado)
            {
                ArchivoUsuario oarchivo = new ArchivoUsuario(mensajetable);



                //oarchivo.FileSize = CalculoCasting(mensajetable.FileSize);


                //oarchivo.NombreRealArchivo = mensajetable.NombreRealArchivo;

                lisstado.Add(oarchivo);
            }

            List<ArchivoUsuario> listadoarchivosOrdenado = lisstado.OrderByDescending(x => x.FechaCaptura).ToList();

            return listadoarchivosOrdenado;

        }


        public static ArchivoUsuario getArchivo(string idusuario, string llavefila)
        {
            var mensajetable = Datos.SoporteArchivos.TableEntryUsuario.ObtenerRegistroTableEntryUsuario(idusuario, llavefila);

            ArchivoUsuario oarchivo = new ArchivoUsuario(mensajetable);

            return oarchivo;
        }

    }
}
