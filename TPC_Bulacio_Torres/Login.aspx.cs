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

            try
            {
                string userID = txtUser.Text;
                string userPassword = txtPassword.Text;
                userNegocio = new UsuarioNegocio();
                Usuario user = new Usuario();

                if (userNegocio.validateLogin(userID, userPassword))
                {
                    user.UserID = userNegocio.getIDUser(userID);
                    Session["IDUser"] = user.UserID;
                    user = userNegocio.getFullUserByUserName(userID);
                    Session["usuario"] = user;
                    //Response.Redirect("ABMStopLogs.aspx", false);
                    Response.Redirect("FormOperador.aspx", false);
                }
                else
                {
                    Session.Add("error", "User o Pass Incorrectos");
                    Response.Redirect("Error.aspx", false);
                }

            }
            catch(Exception ex)
            {
                Session.Add("error", ex.ToString());
                Response.Redirect("Error.aspx");
            }
            
        }
    }
}