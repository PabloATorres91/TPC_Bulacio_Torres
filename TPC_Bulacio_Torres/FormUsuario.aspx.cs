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
                    string mode = Request.QueryString["Mode"];

                    if(user.UserIDEmployee != 0)
                    {
                        txtEmail.Text = user.UserEmail;
                        txtName.Text = user.UserName;
                        txtIdEmployee.Text = user.UserIDEmployee.ToString();
                        txtIngreso.Text = user.UserDate.ToString();

                        fillAndSetddlProfiles(user.UserIDProfile.ToString());

                        if (mode == "M")
                        {
                            txtEmail.ReadOnly = false;
                            txtName.ReadOnly = false;
                            txtIngreso.Enabled = false;
                            txtIdEmployee.Enabled = false;
                            btnAceptar.Text = "Modificar";
                        }
                        else if(mode == "D")
                        {
                            txtName.Enabled = false;
                            txtEmail.Enabled = false;
                            txtIngreso.Enabled = false;
                            txtIdEmployee.Enabled = false;
                            ddlProfile.Enabled = false;
                            btnAceptar.Text = "Eliminar";
                        }
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            userNegocio = new UsuarioNegocio();
            user = new Usuario();
            try
            {
                string mode = Request.QueryString["Mode"];
                if(mode == "M")
                {
                    //Ejecutamos consulta para modificar registro
                    user.UserName = txtName.Text;
                    user.UserEmail = txtEmail.Text;
                    user.UserIDProfile = Convert.ToInt32(ddlProfile.SelectedValue);
                    //Hasta aca esta todo bien. Falta avanzar en la ejecucion de la consulta. Tomar de referencia el Solution_TP2 (FormAgregar)
                }
                else if(mode == "D")
                {
                    //Ejecutamos consulta para ¿eliminar? registro
                }
            }
            catch(Exception ex)
            {
                //Analizar si hay que agregar un form de error. Por lo pronto reenviamos el error a Index.aspx
                Session.Add("Error", ex.ToString());
                Response.Redirect("Index.aspx");
            }
        }
    }
}