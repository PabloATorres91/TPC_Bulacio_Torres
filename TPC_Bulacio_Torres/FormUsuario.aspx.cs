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
            txtUserID.Enabled = false;
            txtIngreso.Enabled = false;
            if (!IsPostBack)
            {
                if (Request.QueryString["IDUser"] != null)
                {
                    userNegocio = new UsuarioNegocio();
                    user = new Usuario();
                    user = userNegocio.getFullUser(Request.QueryString["IDUser"]);
                    string mode = Request.QueryString["Mode"];
                        

                    if (user.UserIDEmployee != 0)
                    {
                        txtEmail.Text = user.UserEmail;
                        txtName.Text = user.UserName;
                        txtIdEmployee.Text = user.UserIDEmployee.ToString();
                        txtIngreso.Text = user.UserDate.ToString();
                        txtUserID.Text = user.UserID.ToString();

                        fillAndSetddlProfiles();

                        if (mode == "M")
                        {
                            txtEmail.ReadOnly = false;
                            txtName.ReadOnly = false;
                            txtIdEmployee.Enabled = false;
                            btnAceptar.Text = "Modificar";
                        }
                        else if(mode == "D")
                        {
                            txtName.Enabled = false;
                            txtEmail.Enabled = false;
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
                else
                {
                    //Si entra por este else, significa que clickeó en Agregar (ya que no enviamos parámetros en la URL)
                    userNegocio = new UsuarioNegocio();
                    user = new Usuario();

                    try
                    {
                        txtIngreso.Text = DateTime.Now.ToShortDateString();
                        txtIdEmployee.Enabled = false;
                        fillAndSetddlProfiles();
                        btnAceptar.Text = "Agregar";
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }

        }

        private void fillAndSetddlProfiles()
        {
            profileNegocio = new PerfilNegocio();

            ddlProfile.DataSource = profileNegocio.getProfiles();
            ddlProfile.DataTextField = "ProfilesName";
            ddlProfile.DataValueField = "IDProfiles";
            ddlProfile.DataBind();

            if(Convert.ToBoolean(user.UserIDProfile))
            {
                ddlProfile.SelectedValue = user.UserIDProfile.ToString();
            }
            else
            {
                ddlProfile.SelectedValue = "0";
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            userNegocio = new UsuarioNegocio();
            user = new Usuario();
            try
            {
                string mode = Request.QueryString["Mode"];
                if (mode == "M")
                {
                    //Ejecutamos consulta para modificar registro
                    user.UserName = txtName.Text;
                    user.UserEmail = txtEmail.Text;
                    user.UserIDProfile = Convert.ToInt32(ddlProfile.SelectedValue);
                    user.UserID = Convert.ToInt32(txtUserID.Text);
                    if(userNegocio.modifyUser(user)!=0)
                    {
                        string script = @"alert('Registro modificado satisfactoriamente');
                        window.location.href='ABMUsuario.aspx';";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>");
                        Response.Write("alert('El usuario no ha sido modificado.')");
                        Response.Write("</script>");
                    }
                }
                else if (mode == "D")
                {
                    //Ejecutamos consulta para eliminar registro
                    user.UserID = Convert.ToInt32(txtUserID.Text);

                    if (userNegocio.deleteUser(user) != 0)
                    {
                        string script = @"alert('Registro eliminado satisfactoriamente');
                        window.location.href='ABMUsuario.aspx';";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>");
                        Response.Write("alert('El usuario no existe')");
                        Response.Write("</script>");
                    }
                }
                else
                {
                    //Ejecutamos consulta para AGREGAR un registro
                    user.UserName = txtName.Text;
                    user.UserEmail = txtEmail.Text;
                    user.UserIDProfile = Convert.ToInt32(ddlProfile.SelectedValue);
                    if(userNegocio.validateUser(user.UserName) != false) //si un usuario ya existe, se devuelve false
                    {
                        if(userNegocio.addUser(user) != 0)
                        {
                            string script = @"alert('Registro grabado satisfactoriamente');
                            window.location.href='ABMUsuario.aspx';";
                            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                        }
                        else
                        {
                            Response.Write("<script language=javascript>");
                            Response.Write("alert('El usuario no se ha grabado')");
                            Response.Write("</script>");
                        }
                        
                    }
                    else
                    {
                        Response.Write("<script>alert('El Nombre de usuario ya ha sido utilizado. Por favor utilizar otro nombre');</script>");
                    }
                }
            }
            catch (Exception ex)
            {
                //Analizar si hay que agregar un form de error. Por lo pronto reenviamos el error a Index.aspx
                Session.Add("Error", ex.ToString());
                Response.Redirect("Index.aspx");
            }
        }
    }
}