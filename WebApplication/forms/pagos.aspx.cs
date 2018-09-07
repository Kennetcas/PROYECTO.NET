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
    public partial class pagos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonAceptar_Click(object sender, EventArgs e)
        {
            new ClsNegocio2().GrabarDatos(new mdPagos(TextBoxNombre1.Text, TextBoxMes.Text, TextBoxTotal.Text));
        }
    }
}