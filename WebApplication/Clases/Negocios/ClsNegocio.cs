using Aplicacion.Clases.Conexion;
using Aplicacion.Clases.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Negocios
{
    public class ClsNegocio
    {

        public string GrabarDatos(mdInscripcion dat)
        {
            String query;
            clsconexion conectar = new clsconexion();
            conectar.abrirconexion();
            query = "insert into Tb_Alumnos (Nombres, Apellidos, FechaNac, Residencia, Telefono, Horario) values ('" + dat.Nombres + "','" + dat.Apellidos + "','" + dat.FechaNac + "','" + dat.Residencia + "','" + dat.Telefono + "','" + dat.Horario + "')";

            //query = "insert into Tb_Alumnos (Nombres, Apellidos, FechaNac, Residencia, Telefono, Horario) values ('JUAN','PEREZ','25/07/1994','JUTIAPA','78441044','DOMINGOS')";
            conectar.EjecutarSql(query);
            conectar.cerrarconexion();
            return "Informacion Grabada Exitosamente";
        }
    }
}
