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
    public partial class FormIndicators : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormOperador formOperador = new FormOperador();
            if (!IsPostBack)
            {
                fillAndSetddlMachine();
                fillAndSetddlProductionLine();
                fillAndSetddlTurn();
                
            }
            Session["FormIndicators.IDProductionLine"] = ddlProductionLine.SelectedValue.ToString();
            Session["FormIndicators.IDMachine"] = ddlMachine.SelectedValue.ToString();
            Session["FormIndicators.IDTurn"] = ddlTurn.SelectedValue.ToString();
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



        protected void btnIndicator_Click(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("FormDataTable.aspx", false);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}