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
    public partial class FormPart : System.Web.UI.Page
    {
        PartNegocio partNegocio;
        MaquinaNegocio maquinaNegocio;
        Maquina maquina;
        Part part;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if(Request.QueryString["IDPart"] != null)
                {
                    partNegocio = new PartNegocio();
                    part = new Part();
                    part = partNegocio.getFullPart(Request.QueryString["IDPart"]);
                    string mode = Request.QueryString["Mode"];
                    
                    if(part.IDPart != 0)
                    {
                        txtIDPart.Text = part.IDPart.ToString();
                        txtIDMachine.Text = part.IDMachine.ToString();
                        txtPartName.Text = part.PartName;
                        txtPartDescription.Text = part.PartDescription;
                        txtPartStatus.Text = part.PartStatus.ToString();
                        
                        fillAndSetddlMachine();

                        txtIDPart.Enabled = false;
                        txtIDMachine.Enabled = false;
                        txtPartStatus.Enabled = false;

                        if (mode == "M")
                        {
                            txtPartName.ReadOnly = false;
                            txtPartDescription.ReadOnly = false;
                            btnAceptarParte.Text = "Modificar";
                        }else if (mode == "D")
                        {
                            txtPartName.Enabled = false;
                            txtPartDescription.Enabled = false;
                            ddlMachine.Enabled = false;
                            btnAceptarParte.Text = "Eliminar";                            
                        }
                    }
                    else
                    {
                        //No se encontró la parte
                    }

                }
                else
                {
                    //Nueva Parte
                    partNegocio = new PartNegocio();
                    part = new Part();

                    txtIDPart.Enabled = false;
                    txtIDMachine.Enabled = false;
                    txtPartStatus.Enabled = false;

                    try
                    {
                        fillAndSetddlMachine();
                        btnAceptarParte.Text = "Agregar";
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                }
            }
        }

        private void fillAndSetddlMachine()
        {
            maquinaNegocio = new MaquinaNegocio();

            ddlMachine.DataSource = maquinaNegocio.getMaquina();
            ddlMachine.DataTextField = "MachineName";
            //ddlMachine.DataTextField = "MachineModel";
            //ddlMachine.DataValueField = "MachineSerialNumber";
            ddlMachine.DataValueField = "IDMachine";
            ddlMachine.DataValueField = "IDProductionLine";
            
            ddlMachine.DataBind();

            if (Convert.ToBoolean(part.IDMachine))
            {
                ddlMachine.SelectedValue = part.IDMachine.ToString();
            }
            else
            {
                ddlMachine.SelectedValue = "0";
            }

        }

        protected void btnAceptarParte_Click(object sender, EventArgs e)
        {
            partNegocio = new PartNegocio();
            part = new Part();

            try
            {
                string mode = Request.QueryString["Mode"];
                if(mode == "M")
                {
                    part.IDPart = Convert.ToInt32(txtIDPart);
                    part.IDMachine = Convert.ToInt32(txtIDMachine);
                    part.PartName = txtPartName.Text;
                    part.PartDescription = txtPartDescription.Text;
                    partNegocio.modifyPart(part);

                }else if (mode == "D")
                {
                    //Se elimina el registro con baja logica aplicando trigger
                    part.IDPart = Convert.ToInt32(txtIDPart);
                    partNegocio.deletePart(part);
                }
                else
                {
                    //Agregamos nuevo registro
                    part.IDMachine = Convert.ToInt32(ddlMachine.SelectedValue);
                    part.PartName = txtPartName.Text;
                    part.PartDescription = txtPartDescription.Text;
                    partNegocio.addPart(part);
                }
                Response.Redirect("ABMPart.aspx", false);

            }
            catch (Exception ex)
            {
                //Reenviamos el error a Index.aspx
                Session.Add("Error", ex.ToString());
                Response.Redirect("Index.aspx");
            }

        }
    }
}