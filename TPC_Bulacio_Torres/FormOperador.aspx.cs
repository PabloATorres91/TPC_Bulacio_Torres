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
    public partial class FormOperador : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                fillAndSetddlMachine();
                fillAndSetddlProductionLine();
                fillAndSetddlTurn();
            }
                Session["ABMStopLogs.IDProductionLine"] = ddlProductionLine.SelectedValue.ToString();
                Session["ABMStopLogs.IDMachine"] = ddlMachine.SelectedValue.ToString();
                Session["ABMStopLogs.IDTurn"] = ddlTurn.SelectedValue.ToString();
          
           
        }

        private void fillAndSetddlTurn()
        {
            TurnNegocio turnNegocio = new Negocio.TurnNegocio();
            ddlTurn.DataSource = turnNegocio.getTurno();
            ddlTurn.DataTextField = "TurnName";
            ddlTurn.DataValueField = "IDTurn";
            ddlTurn.DataBind();
        }
        private void fillAndSetddlProductionLine()
        {
            ProductionLineNegocio productionLineNegocio = new ProductionLineNegocio();
            
            ddlProductionLine.DataSource = productionLineNegocio.getProductionLine();
            ddlProductionLine.DataTextField = "ProductionLineName";
            ddlProductionLine.DataValueField = "IDProductionLine";
            ddlProductionLine.DataBind();
         
        }
        private void fillAndSetddlMachine()
        {
            MaquinaNegocio maquinaNegocio = new MaquinaNegocio();

            ddlMachine.DataSource = maquinaNegocio.getMaquina();
            ddlMachine.DataTextField = "MachineName";
            ddlMachine.DataValueField = "IDMachine";
            ddlMachine.DataBind();    
        }

        protected void btnRegistrarParadas_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("ABMStopLogs.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
    }
}