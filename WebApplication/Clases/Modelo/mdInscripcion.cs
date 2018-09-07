using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion.Clases.Modelo
{
    public class mdInscripcion
    {
        public string Nombres;
        public string Apellidos;
        public string FechaNac;
        public string Residencia;
        public string Telefono;
        public string Horario;


        public mdInscripcion(string Nombres, string Apellidos, string FechaNac, string Residencia, string Telefono, string Horario)
        {
            this.Nombres = Nombres;
            this.Apellidos = Apellidos;
            this.FechaNac = FechaNac;
            this.Residencia = Residencia;
            this.Telefono = Telefono;
            this.Horario = Horario;
        }
    }
}