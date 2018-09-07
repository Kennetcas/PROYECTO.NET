using Aplicacion.Clases.Conexion;
using Aplicacion.Clases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Negocios
{
    public class ClsNegocio2
    {


        public string GrabarDatos(mdPagos dat)
        {
            String query;
            clsconexion conectar = new clsconexion();
            conectar.abrirconexion();
            query = "insert into Tb_Pagos (Nombre, Mes, Total) values ('" + dat.Nombre + "','" + dat.Mes + "','" + dat.Total + "')";

            //query = "insert into Tb_Pagos (Nombre, Mes, Total) values ('Jose','Agosto','100')";
            conectar.EjecutarSql(query);
            conectar.cerrarconexion();
            return "Informacion Grabada Exitosamente";
        }
    }
}