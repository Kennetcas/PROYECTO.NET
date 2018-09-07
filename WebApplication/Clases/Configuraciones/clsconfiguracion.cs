using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Configuraciones
{

    public class clsconfiguracion
    {

        public string baseDatos { get; }
        public clsconfiguracion()
        {
            baseDatos = System.Configuration.ConfigurationManager.ConnectionStrings["Conectar"].ConnectionString;
        }

    }
}