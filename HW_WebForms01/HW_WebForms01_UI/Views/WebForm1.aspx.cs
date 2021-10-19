using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using HW_WebForms01_Entities;
using System.Web.UI.WebControls;

namespace HW_WebForms01_UI.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            Label message = lblMensaje;
            Label labelError = lblError;

            if (!String.IsNullOrEmpty(textBox1.Text)) //  En este caso, con esta solucion
            {
                clsPersona person = new clsPersona();
                person.Nombre = textBox1.Text;
                lblMensaje.Text = $" Hola {person.Nombre}";
            }
            else
                lblError.Text = "Are you kidding me PENDEJO?";

        }
    }
}