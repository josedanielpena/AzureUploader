using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Datos
{
    [Serializable]
    public class CfgCnx
    {

        public string AccountName { get; set; }
        public string AcoountKey { get; set; }
        public string ContainerName { get; set; }
        public string IdUsuario { get; set; }
        public string KeyUsuario { get; set; }

    }
}
