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
    public partial class FormStopLog : System.Web.UI.Page
    {
        StopLogNegocio stopLogNegocio;
        StopLog stopLog;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillAndSetddlStopCode();
                
                

            }

        }

        private void fillAndSetddlStopCode()
        {
            StopCodeNegocio stopCodeNegocio = new StopCodeNegocio();

            ddlStopCode.DataSource = stopCodeNegocio.getStopCode();
            ddlStopCode.DataTextField = "StopCodeName";
            ddlStopCode.DataValueField = "IDStopCode";
            ddlStopCode.DataBind();

        }

        protected void btnAceptarParada_Click(object sender, EventArgs e)
        {
            stopLogNegocio = new StopLogNegocio();
            stopLog = new StopLog();

            try
            {
                string mode = Request.QueryString["Mode"];
                string date = DateTime.Now.ToString("dd-MM-yyyy");
                if (mode == "M")
                {
                    stopLog.IDMachine = Convert.ToInt32(Session["ABMStopLogs.IDMachine"]);
                    stopLog.IDStopCode = Convert.ToInt32(ddlStopCode.SelectedValue);
                    stopLog.IDUsers = Convert.ToInt32(Request.QueryString["IDUser"]);
                    stopLog.IDTurn = Convert.ToInt32(Session["ABMStopLogs.IDTun"]);
                    /// ACA VA LO VALORES DE STOPLOGBEGIN Y STOPLOGFINISH QUE TODAVIA NO PUEDO OBTENERLOS DEL INPUT
                    stopLog.StopLogObservation = txtStopLogObservation.Text;
                    stopLogNegocio.modifyStopLog(stopLog);                   
                } else if(mode == "D"){
                    //se elimina el registro
                }
                else
                {
                    ///nuevo registro
                }
                Response.Redirect("ABMStopLogs.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        protected void btnCancelarParada_Click(object sender, EventArgs e)
        {

        }
    }
}