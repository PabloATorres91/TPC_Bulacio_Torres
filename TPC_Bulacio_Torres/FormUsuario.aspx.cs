using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Dominio;
using Negocio;

namespace TPC_Bulacio_Torres
{
    public partial class FormUsuario : System.Web.UI.Page
    {
        UsuarioNegocio userNegocio;
        Usuario user;
        PerfilNegocio profileNegocio;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["IDUser"] != null)
                {
                    userNegocio = new UsuarioNegocio();
                    user = new Usuario();
                    user = userNegocio.getFullUser(Request.QueryString["IDUser"]);
                    
                    if(user.UserIDEmployee != 0)
                    {
                        txtEmail.Text = user.UserEmail;
                        txtName.Text = user.UserName;
                        txtIdEmployee.Text = user.UserIDEmployee.ToString();
                        txtIngreso.Text = user.UserDate.ToString();

                        fillAndSetddlProfiles(user.UserIDProfile.ToString());
                    }
                    else
                    {
                        //no se encontró usuario.
                    }

                }
            }

        }

        private void fillAndSetddlProfiles(string profileValue)
        {
            profileNegocio = new PerfilNegocio();

            ddlProfile.DataSource = profileNegocio.getProfiles();
            ddlProfile.DataTextField = "ProfilesName";
            ddlProfile.DataValueField = "IDProfiles";
            ddlProfile.DataBind();

            ddlProfile.SelectedValue = profileValue;
        }
    }
}