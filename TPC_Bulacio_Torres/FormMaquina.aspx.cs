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
        //PartNegocio partNegocio;
        ProductionLineNegocio productionLineNegocio;
        
        
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
                        
                        txtIDMachine.Text = maquina.IDMachine.ToString();
                        txtMachineName.Text = maquina.MachineName;
                        txtMachineModel.Text = maquina.MachineModel;
                        txtMachineSerialNumber.Text = maquina.MachineSerialNumber;
                        txtMachineStatus.Text = maquina.MachineStatus.ToString();

                        fillAndSetddlProductionLine();

                        txtIDMachine.Enabled = false;
                        txtMachineStatus.Enabled = false;

                        if (mode == "M")
                        {
                            txtMachineName.ReadOnly = false;
                            txtMachineModel.ReadOnly = false;
                            txtMachineSerialNumber.ReadOnly = false;
                            btnAceptarMaquina.Text = "Modificar";


                        }
                        else if(mode == "D")
                        {
                            txtMachineName.Enabled = false;
                            txtMachineModel.Enabled = false;
                            txtMachineSerialNumber.Enabled = false;
                            ddlProductionLine.Enabled = false;
                            btnAceptarMaquina.Text = "Eliminar";
                        }                       
                    }
                    else
                    {
                        //No se encontró máquina
                    }

                }
                else
                {
                    //Se agrega nueva máquina
                    maquinaNegocio = new MaquinaNegocio();
                    maquina = new Maquina();
                    
                    txtIDMachine.Enabled = false;
                    txtMachineStatus.Enabled = false;
                    
                    try
                    {
                        fillAndSetddlProductionLine();
                        btnAceptarMaquina.Text = "Agregar";
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    

                }
            }
        }

        //private void fillAndSetddlPart()
        //{
        //    partNegocio = new PartNegocio();

        //    ddlPart.DataSource = partNegocio.getPart();
        //    ddlPart.DataTextField = "PartName";
        //    //ddlPart.DataTextField = "PartDescription";
        //    //ddlPart.DataValueField = "IDPart";
        //    //ddlPart.DataValueField = "IDMachine";
        //    ddlPart.DataBind();

        //    //if (Convert.ToBoolean(maquina.IDMachine))
        //    //{
        //    //    ddlPart.SelectedValue = maquina.IDMachine.ToString();
        //    //}
        //    //else
        //    //{
        //    //    ddlPart.SelectedValue = "0";
        //    //}

        //}

        private void fillAndSetddlProductionLine()
        {
            productionLineNegocio = new ProductionLineNegocio();

            ddlProductionLine.DataSource = productionLineNegocio.getProductionLine();
            ddlProductionLine.DataTextField = "ProductionLineName";
            ddlProductionLine.DataValueField = "IDProductionLine";
            ddlProductionLine.DataBind();

            if (Convert.ToBoolean(maquina.IDProductionLine))
            {
                ddlProductionLine.SelectedValue = maquina.IDProductionLine.ToString();
            }
            else
            {
                ddlProductionLine.SelectedValue = "0";
            }

        }

        protected void btnAceptarMaquina_Click(object sender, EventArgs e)
        {
            maquinaNegocio = new MaquinaNegocio();
            maquina = new Maquina();

            try
            {
                string mode = Request.QueryString["Mode"];
                if(mode == "M")
                {
                    maquina.IDMachine = Convert.ToInt32(txtIDMachine.Text);
                    maquina.MachineName = txtMachineName.Text;
                    maquina.MachineModel = txtMachineModel.Text;
                    maquina.MachineSerialNumber = txtMachineSerialNumber.Text;
                    maquina.IDProductionLine = Convert.ToInt32(ddlProductionLine.SelectedValue);
                    maquinaNegocio.modifyMachine(maquina);
                }else if(mode == "D")
                {
                    //Se elimina el registro con baja logica aplicando trigger
                    maquina.IDMachine = Convert.ToInt32(txtIDMachine.Text);
                    maquinaNegocio.deleteMachine(maquina);
                }
                else
                {
                    //Agregamos nuevo registro
                    //maquina.IDMachine = Convert.ToInt32(txtIDMachine.Text);
                    maquina.MachineName = txtMachineName.Text;
                    maquina.MachineModel = txtMachineModel.Text;
                    maquina.MachineSerialNumber = txtMachineSerialNumber.Text;
                    maquina.IDProductionLine = Convert.ToInt32(ddlProductionLine.SelectedValue);
                    maquinaNegocio.addMachine(maquina);
                }
                Response.Redirect("ABMMaquina.aspx",false);
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
