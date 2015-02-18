using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Datos
{
    public class ClsUtilesCnx
    {
        /// <summary>
        /// Codificar Cadena en Base64
        /// </summary>
        /// <param name="str">Cadena a Codificar</param>
        /// <returns>Cadena Codificada</returns>
        public static string CodificarBase64(string str)
        {
            byte[] encbuff = System.Text.Encoding.UTF8.GetBytes(str);
            return Convert.ToBase64String(encbuff);
        }
        /// <summary>
        /// Decodifica Cadena en Base64
        /// </summary>
        /// <param name="str">Cadena Codificada</param>
        /// <returns>Cadena Decodificada</returns>
        public static string DecodificarBase64(string str)
        {
            byte[] decbuff = Convert.FromBase64String(str);
            return System.Text.Encoding.UTF8.GetString(decbuff);
        }

        public static string UTF8toASCII(string text)
        {
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            Byte[] encodedBytes = utf8.GetBytes(text);
            Byte[] convertedBytes =
                    Encoding.Convert(Encoding.UTF8, Encoding.ASCII, encodedBytes);
            System.Text.Encoding ascii = System.Text.Encoding.ASCII;

            return ascii.GetString(convertedBytes);
        }

        /// <summary>
        /// Metodo para leer archivos
        /// </summary>
        /// <param name="ruta">Ruta y nombre del archivo</param>
        /// <returns>Cadena con contenido del archivo</returns>
        public static string LeerArchivoLocal(string ruta)
        {
            string fileName = ruta;
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            string cadena = "";
            while (reader.Peek() > -1)
            {
                cadena = cadena + reader.ReadLine();
            }
            reader.Close();
            return cadena;
        }

        /// <summary>
        /// Metodo para escribir archivos
        /// </summary>
        /// <param name="ruta">Ruta y Nombre del Archivo</param>
        /// <param name="cadena">Contenido del archivo</param>
        public static void EscribirArchivoLocal(string ruta, string cadena)
        {
            File.Delete(ruta);
            string fileName = ruta;
            FileStream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);

            writer.WriteLine(cadena);
            writer.Close();
        }

        public static void EscribirXMLConexionServidor(CfgCnx ConexionBD)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(CfgCnx));

            StreamWriter w = new StreamWriter("cfgcnx.xml");

            serializador.Serialize(w, ConexionBD);
            w.Close();
        }

        public static CfgCnx LeerXMLConexionServidor()
        {

            XmlSerializer serializador = new XmlSerializer(typeof(CfgCnx));

            StreamReader r = new StreamReader("cfgcnx.xml");

            CfgCnx ConexionBD = (CfgCnx)serializador.Deserialize(r);
            r.Close();
            return ConexionBD;
        }

    }
}
