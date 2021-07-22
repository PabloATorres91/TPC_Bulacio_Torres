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
                if(Request.QueryString["IDStopLog"] != null)
                {
                    stopLogNegocio = new StopLogNegocio();
                    stopLog = new StopLog();
                    stopLog = stopLogNegocio.getFullStopLog(Request.QueryString["IDStopLog"]);
                    string mode = Request.QueryString["Mode"];

                    if(stopLog.IDStopLog != 0)
                    {
                        fillAndSetddlStopCode();
                        txtStopLogObservation.Text = stopLog.StopLogObservation.ToString();

                        if (mode == "M")
                        {
                            btnAceptarParada.Text = "Modificar";
                        }
                        else if (mode == "D")
                        {
                            ddlStopCode.Enabled = false;
                            //ACA SE DEBERIA DESSHBILITAR LOS INPUT DE STOPLOGBEGIN Y STOPLOGFINISH
                            btnAceptarParada.Text = "Eliminar";
                            
                        }
                       
                    }
                    else
                    {
                        //No existe registro StopLog
                    }
                }
                else
                {
                    //Nuevo Registro StopLog
                    try
                    {
                        fillAndSetddlStopCode();
                        btnAceptarParada.Text = "Registrar Parada";
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }                  

                }              
                                     
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
                    stopLog.IDStopLog = Convert.ToInt32(Request.QueryString["IDStopLog"]);
                    stopLog.IDMachine = Convert.ToInt32(Session["ABMStopLogs.IDMachine"]);
                    stopLog.IDStopCode = Convert.ToInt32(ddlStopCode.SelectedValue);
                    stopLog.IDUsers = (int)Session["IDUser"];
                    stopLog.IDTurn = Convert.ToInt32(Session["ABMStopLogs.IDTurn"]);
                    stopLog.StopLogBegin = Convert.ToDateTime(inputStopLogBegin.Value);
                    stopLog.StopLogFinish = Convert.ToDateTime(inputStopLogFinish.Value);
                    stopLog.StopLogObservation = txtStopLogObservation.Text;
                    stopLogNegocio.modifyStopLog(stopLog);                   
                } else if(mode == "D"){
                    //se elimina el registro
                    stopLog.IDStopLog = Convert.ToInt32(Request.QueryString["IDStopLog"]);
                    stopLogNegocio.deleteStopLog(stopLog);

                }
                else
                {
                    ///nuevo registro
                    stopLog.IDMachine = Convert.ToInt32(Session["ABMStopLogs.IDMachine"]);
                    stopLog.IDStopCode = Convert.ToInt32(ddlStopCode.SelectedValue);
                    stopLog.IDUsers = (int)Session["IDUser"];
                    stopLog.IDTurn = Convert.ToInt32(Session["ABMStopLogs.IDTurn"]);
                    stopLog.StopLogBegin = Convert.ToDateTime(inputStopLogBegin.Value);
                    stopLog.StopLogFinish = Convert.ToDateTime(inputStopLogFinish.Value);
                    stopLog.StopLogObservation = txtStopLogObservation.Text;
                    stopLogNegocio.addStopLog(stopLog);
                }
                Response.Redirect("ABMStopLogs.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("Error", ex.ToString());
                Response.Redirect("Error.aspx");
            }

        }

        protected void btnCancelarParada_Click(object sender, EventArgs e)
        {
            Response.Redirect("ABMStopLogs.aspx");
        }
    }
}