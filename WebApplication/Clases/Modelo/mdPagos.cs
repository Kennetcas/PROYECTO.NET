using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Modelo
{
    public class mdPagos
    {
        public string Nombre;
        public string Mes;
        public string Total;


        public mdPagos(string Nombre, string Mes, string Total)
        {
            this.Nombre = Nombre;
            this.Mes = Mes;
            this.Total = Total;
        }
    }
}