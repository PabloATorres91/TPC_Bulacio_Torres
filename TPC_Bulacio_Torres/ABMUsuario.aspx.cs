using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Bulacio_Torres
{
    public partial class ABMUsuario : System.Web.UI.Page
    {
        public List<Usuario> list;
        UsuarioNegocio userNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null || Convert.ToBoolean(Application.Get("debugMode")))
            {
                userNegocio = new UsuarioNegocio();
                list = userNegocio.listUsers();
            }
            else
            {
                Session.Add("error", "Primero debes logearte");
                Response.Redirect("Error.aspx", false);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormUsuario.aspx");
        }
    }
}