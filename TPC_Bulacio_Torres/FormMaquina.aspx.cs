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
    public partial class FormMaquina : System.Web.UI.Page
    {
        MaquinaNegocio maquinaNegocio;
        Maquina maquina;
        PartNegocio partNegocio;
        ProductionLineNegocio productionLineNegocio;
        LineaProduccion productionLine;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString ["IDMachine"] != null)
                    {
                    maquinaNegocio = new MaquinaNegocio();
                    maquina = new Maquina();
                    maquina = maquinaNegocio.getFullMachine(Request.QueryString["IDMachine"]);
                    string mode = Request.QueryString["Mode"];

                    if(maquina.IDMachine != 0)
                    {
                        txtMachineName.Text = maquina.MachineName;
                        txtMachineModel.Text = maquina.MachineModel;
                        txtMachineSerialNumber.Text = maquina.MachineSerialNumber;

                        fillAndSetddlPart();
                        fillAndSetddlProductionLine();

                    }

                }
            }
        }

        private void fillAndSetddlPart()
        {
            partNegocio = new PartNegocio();

            ddlPart.DataSource = partNegocio.getPart();
            ddlPart.DataTextField = "PartName";
            ddlPart.DataTextField = "PartDescription";
            ddlPart.DataValueField = "IDPart";
            ddlPart.DataValueField = "IDMachine";
            ddlPart.DataBind();

            //if (Convert.ToBoolean(maquina.IDMachine))
            //{
            //    ddlPart.SelectedValue = maquina.IDMachine.ToString();
            //}
            //else
            //{
            //    ddlPart.SelectedValue = "0";
            //}

        }

        private void fillAndSetddlProductionLine()
        {
            productionLineNegocio = new ProductionLineNegocio();

            ddlProductionLine.DataSource = productionLineNegocio.getProductionLine();
            ddlProductionLine.DataTextField = "ProductionLineName";
            ddlProductionLine.DataValueField = "IDProductionLine";
            ddlProductionLine.DataBind();

            //if (Convert.ToBoolean(productionLine.IDProductionLine))
            //{
            //    ddlProductionLine.SelectedValue = productionLine.IDProductionLine.ToString();
            //}
            //else
            //{
            //    ddlProductionLine.SelectedValue = "0";
            //}

        }

    }
}
