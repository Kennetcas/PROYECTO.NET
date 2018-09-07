using Aplicacion.Clases.Modelo;
using Aplicacion.Clases.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication.forms
{
    public partial class inscripciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonGrabar_Click(object sender, EventArgs e)
        {
            new ClsNegocio().GrabarDatos(new mdInscripcion(TextBoxNombres.Text, TextBoxApellidos.Text, TextBoxNacimiento.Text, TextBoxResidencia.Text, TextBoxTelefono.Text, TextBoxHorario.Text));
        }
    }
}