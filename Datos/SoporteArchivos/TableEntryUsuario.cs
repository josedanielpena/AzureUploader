using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Table;

namespace Datos.SoporteArchivos
{
    public class TableEntryUsuario : TableEntity
    {
        public static readonly string TableAddressUsuarios = "usuarios";

        public string RutaArchivo { get; set; }

        public string Contenedor { get; set; }

        public string Comentarios { get; set; }

        public string NombreRealArchivo { get; set; }

        public bool ArchivoPublico { get; set; }

        public long FileSize { get; set; }

        public DateTime FechaCaptura { get; set; }

        public string CheckMD5 { get; set; }

        public TableEntryUsuario(string idUsuario)
        {
            this.PartitionKey = idUsuario;
            this.RowKey = string.Format("{0:10}_{1}", DateTime.MaxValue.Ticks - DateTime.Now.Ticks, Guid.NewGuid());

            //        // Row key allows sorting, so we make sure the rows come back in time order
            //        RowKey = string.Format("{0:10}_{1}", DateTime.MaxValue.Ticks - DateTime.Now.Ticks, Guid.NewGuid());

            this.FechaCaptura = DateTime.Now;
            this.NombreRealArchivo = "";
            this.FileSize = 0;
            this.ArchivoPublico = false;
            this.CheckMD5 = "";
            this.Contenedor = ClsUtilesCnx.LeerXMLConexionServidor().ContainerName;
        }


        public TableEntryUsuario()
        {
        }

        public static TableEntryUsuario ObtenerRegistroTableEntryUsuario(string idUsuario, string llavefila)
        {


            // Create the CloudTable ojbect that represents the "people" table.
            CloudTable table = Datos.SoporteArchivos.UtilesAzure.ObtenerCloudTable(TableAddressUsuarios);

            // Create a retrieve operation that takes a customer entity.
            TableOperation retrieveOperation = TableOperation.Retrieve<TableEntryUsuario>(idUsuario, llavefila);

            // Execute the retrieve operation.
            TableResult retrievedResult = table.Execute(retrieveOperation);


            var resultado = (TableEntryUsuario)retrievedResult.Result;

            return resultado;

        }

        public static bool EliminarRegistroTableEntryUsuario(string idUsuario, string llavefila)
        {

            CloudTable table = Datos.SoporteArchivos.UtilesAzure.ObtenerCloudTable(TableAddressUsuarios);

            var registro = ObtenerRegistroTableEntryUsuario(idUsuario, llavefila);

            if (registro != null)
            {
                TableOperation deleteOperation = TableOperation.Delete(registro);

                table.Execute(deleteOperation);

                return true;
            }
            else
            {
                return false;
            }
        }


        public static void GuardarRegistro(TableEntryUsuario oregistro)
        {

            CloudTable table = Datos.SoporteArchivos.UtilesAzure.ObtenerCloudTable(TableAddressUsuarios);


            TableOperation insertOrReplaceOperation = TableOperation.InsertOrReplace(oregistro);

            //TableOperation.InsertOrReplace

            // Execute the insert operation.
            table.Execute(insertOrReplaceOperation);
        }




        public static List<TableEntryUsuario> ListarTodoxParticionxUsuario(string usuario)
        {
            // Create the CloudTable object that represents the "people" table.
            CloudTable table = Datos.SoporteArchivos.UtilesAzure.ObtenerCloudTable(TableAddressUsuarios);

            // Construct the query operation for all customer entities where PartitionKey="Smith".
            TableQuery<TableEntryUsuario> query = new TableQuery<TableEntryUsuario>().Where(TableQuery.GenerateFilterCondition("PartitionKey", QueryComparisons.Equal, usuario));

            // Print the fields for each customer.
            var salida = table.ExecuteQuery(query).ToList();


            return salida;
        }


    }
}
