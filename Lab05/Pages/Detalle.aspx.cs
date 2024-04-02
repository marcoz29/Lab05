using Lab05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab05.Pages
{
    public partial class Detalle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objeto"] == null)
            {
                Response.Redirect("~/Pages/Inicio.aspx");
            }

            try
            {
                InformacionPersonal objInformacionPersonal = (InformacionPersonal)Session["objeto"];

                txtNombreCompleto.Text = objInformacionPersonal.nombre;
                txtEmail.Text = objInformacionPersonal.email;
                txtFechaNaci.Text = objInformacionPersonal.nacimiento.ToShortDateString().ToString();

                string nombre = (Session["nombre"]).ToString();
                string email = (Session["email"]).ToString();
                string nacimiento = (Session["nacimiento"]).ToString();
            }
            catch
            {
            }
        }
    }
}