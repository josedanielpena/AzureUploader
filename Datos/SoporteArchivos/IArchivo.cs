using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos.SoporteArchivos
{
    public interface IArchivo
    {
        

        string RutaArchivo { get; set; }

        string Comentarios { get; set; }

        string NombreRealArchivo { get; set; }

        bool ArchivoPublico { get; set; }

        long FileSize { get; set; }

        DateTime FechaCaptura { get; set; }
    }
}
