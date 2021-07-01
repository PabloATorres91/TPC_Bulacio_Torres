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
            userNegocio = new UsuarioNegocio();
            list = userNegocio.listUsers();
        }
    }
}