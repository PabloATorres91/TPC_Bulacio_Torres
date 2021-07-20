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
    public partial class FormStopCode : System.Web.UI.Page
    {
        StopCodeNegocio stopCodeNegocio;
        StopCode stopCode;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtIDStopCode.Enabled = false;

            if(!IsPostBack)
            {
                if(Request.QueryString["IDStopCode"] != null)
                {
                    stopCodeNegocio = new StopCodeNegocio();
                    stopCode = new StopCode();
                    stopCode = stopCodeNegocio.getStopCodeById(Request.QueryString["IDStopCode"]);
                    string mode = Request.QueryString["Mode"];

                    if(stopCode.IDStopCode != 0)
                    {
                        txtNameStopCode.Text = stopCode.StopCodeName;
                        txtIDStopCode.Text = stopCode.IDStopCode.ToString();

                        if (mode == "M")
                        {
                            btnAceptar.Text = "Modificar";
                        }
                        else if(mode == "D")
                        {
                            txtNameStopCode.Enabled = false;
                            btnAceptar.Text = "Eliminar";
                        }
                    }
                }
                else
                {
                    //Agrego un stopCode
                    stopCodeNegocio = new StopCodeNegocio();
                    stopCode = new StopCode();

                    try
                    {
                        txtIDStopCode.Enabled = false;
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            stopCodeNegocio = new StopCodeNegocio();
            stopCode = new StopCode();

            try
            {
                string mode = Request.QueryString["Mode"];
                if(mode == "M")
                {
                    //Modificar registro
                    stopCode.StopCodeName = txtNameStopCode.Text;
                    stopCode.IDStopCode = Convert.ToInt32(txtIDStopCode.Text);
                    if (stopCodeNegocio.modifyStopCode(stopCode) != 0)
                    {
                        string script = @"alert('Registro modificado satisfactoriamente');
                        window.location.href='ABMStopCodes.aspx';";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>");
                        Response.Write("alert('El código de parada no ha sido modificado.')");
                        Response.Write("</script>");
                    }
                }
                else if(mode == "D")
                {
                    stopCode.IDStopCode = Convert.ToInt32(txtIDStopCode.Text);
                    if (stopCodeNegocio.deleteStopCode(stopCode) != 0)
                    {
                        string script = @"alert('Registro eliminado satisfactoriamente');
                        window.location.href='ABMStopCodes.aspx';";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>");
                        Response.Write("alert('El código de parada no existe. No se puede eliminar')");
                        Response.Write("</script>");
                    }
                }
                else
                {
                    stopCode.StopCodeName = txtNameStopCode.Text;
                    if(stopCodeNegocio.addStopCode(stopCode) != 0)
                    {
                        string script = @"alert('Registro grabado satisfactoriamente');
                        window.location.href='ABMStopCodes.aspx';";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                    else
                    {
                        Response.Write("<script language=javascript>");
                        Response.Write("alert('El código de parada no se ha grabado')");
                        Response.Write("</script>");
                    }
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