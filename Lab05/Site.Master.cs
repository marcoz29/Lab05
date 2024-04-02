using Lab05.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab05
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["objeto"] != null)
            {
                lnkCerrarSesion.Visible = true;
                InformacionPersonal objInformacionPersonal = (InformacionPersonal)Session["objeto"];

                lblNombre.Text = objInformacionPersonal.nombre;
            }
        }

        protected void lnkCerrarSesion_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();

            Response.Redirect("~/Pages/Formulario.aspx");
        }
    }
}