using Lab05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab05.Pages
{
    public partial class Formulario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
            InformacionPersonal objInformacionPersonal = new InformacionPersonal();
            objInformacionPersonal.nombre = txtNombreCompleto.Text;
            objInformacionPersonal.email = txtEmail.Text;
            objInformacionPersonal.nacimiento = DateTime.Parse(txtFechaNaci.Text);

            Session["objeto"] = objInformacionPersonal;

            Response.Redirect("~/Pages/Detalle.aspx");
        }

    }
}