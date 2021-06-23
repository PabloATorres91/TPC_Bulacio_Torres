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
    public partial class Login : System.Web.UI.Page
    {

        UsuarioNegocio userNegocio;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            string userID = txtUser.Text;
            string userPassword = txtPassword.Text;
            userNegocio = new UsuarioNegocio();

            if(userNegocio.validateLogin(userID, userPassword))
            {
                Response.Redirect("Test.aspx");
            }
            
        }
    }
}