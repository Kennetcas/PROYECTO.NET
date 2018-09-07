using Aplicacion.Clases.Configuraciones;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Conexion

{
    public class clsconexion
    {
        SqlConnection conexion;
        private string _conexion { get; }

        public clsconexion()
        {
            clsconfiguracion ini = new clsconfiguracion();
            _conexion = ini.baseDatos;

        }

        public void abrirconexion()
        {
            conexion = new SqlConnection(_conexion);
            conexion.Open();
        }

        public void cerrarconexion()
        {
            conexion.Close();
        }

        public void EjecutarSql(string Sql)
        {
            SqlCommand conm = new SqlCommand(Sql, conexion);
            conm.ExecuteReader();
        }

        public DataTable consulta(String Sql)
        {
            abrirconexion();
            SqlDataReader dr;
            SqlCommand com = new SqlCommand(Sql, conexion);
            dr = com.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(dr);
            cerrarconexion();

            return dataTable;

        }

    }
}

