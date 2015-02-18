using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Queue;

namespace Datos.SoporteArchivos
{
    public class UtilesAzure
    {

        /// <summary>
        /// Obtiene la cuenta de la nube de Azure para los Blobs
        /// </summary>
        /// <returns>CloudStorageAccount para blobs</returns>
        private static CloudStorageAccount ObtenerCuentaCloudBlob()
        {
            //CREDENCIALES PARA EL STORAGE
            //StorageCredentialsAccountAndKey ostoragecredentials = new StorageCredentialsAccountAndKey("webhistorialblob", "6z/hrvSDv+tKHAPzk30e4ELKB9e1OwLLMGThQZLN7fs0gPUzD89X2ZObWpEKdl/DYjFBni4wXeyucz2ZsGc6JQ==");
            string accountname = ClsUtilesCnx.LeerXMLConexionServidor().AccountName;
            string accountkey = ClsUtilesCnx.LeerXMLConexionServidor().AcoountKey;
            var ostoragecredentials = new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(accountname, accountkey);
            CloudStorageAccount csa = new CloudStorageAccount(ostoragecredentials, true);
            //CloudStorageAccount csa = new CloudStorageAccount(ostoragecredentials, true);
            return csa;
        }


        /// <summary>
        /// Obtiene la cuenta de la nube de Azure para los Queues
        /// </summary>
        /// <returns>CloudStorageAccount para queues</returns>
        private static CloudStorageAccount ObtenerCuentaCloudQueue()
        {
            //CREDENCIALES PARA EL STORAGE DE TABLAS

            string accountname = ClsUtilesCnx.LeerXMLConexionServidor().AccountName;
            string accountkey = ClsUtilesCnx.LeerXMLConexionServidor().AcoountKey;
            //StorageCredentialsAccountAndKey ostoragecredentials = new StorageCredentialsAccountAndKey(accountname, accountkey);
            var ostoragecredentials = new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials(accountname, accountkey);
            //CloudStorageAccount csa = new CloudStorageAccount(ostoragecredentials, true);
            CloudStorageAccount csa = new CloudStorageAccount(ostoragecredentials, true);

            return csa;
        }



        public static Microsoft.WindowsAzure.Storage.Blob.CloudBlobContainer ObtenerContenedorBlob(string containerName)
        {
            CloudStorageAccount csa = Datos.SoporteArchivos.UtilesAzure.ObtenerCuentaCloudBlob();
            var blobclient = csa.CreateCloudBlobClient();
            var container = blobclient.GetContainerReference(containerName);
            container.CreateIfNotExists(null);
            return container;
        }

        public static Microsoft.WindowsAzure.Storage.Queue.CloudQueue ObtenerContenedorQueue(string containerName)
        {

            CloudStorageAccount storageAccount = ObtenerCuentaCloudQueue();

            // Create the queue client.
            CloudQueueClient queueClient = storageAccount.CreateCloudQueueClient();

            // Retrieve a reference to a queue.
            CloudQueue queue = queueClient.GetQueueReference(containerName);

            // Create the queue if it doesn't already exist.
            queue.CreateIfNotExists();

            return queue;
        }

        public static Microsoft.WindowsAzure.Storage.Table.CloudTable ObtenerCloudTable(string containerName)
        {

            // Retrieve the storage account from the connection string.
            //CloudStorageAccount storageAccount = Datos.SoporteArchivos.UtilesAzure.ObtenerCuentaCloudTable();
            CloudStorageAccount storageAccount = ObtenerCuentaCloudQueue();


            // Create the table client.
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient();

            // Create the CloudTable object that represents the "people" table.
            CloudTable table = tableClient.GetTableReference(containerName);
            table.CreateIfNotExists();


            return table;
        }

    }
}
