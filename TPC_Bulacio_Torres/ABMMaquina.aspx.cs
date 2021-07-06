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
    public partial class ABMMaquina : System.Web.UI.Page
    {
        public List<Maquina> machinesList;
        MaquinaNegocio maquinaNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            maquinaNegocio = new MaquinaNegocio();
            machinesList = maquinaNegocio.listMachines();
        }

        protected void btnAgregarMaquina_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormMaquina.aspx");
        }
    }
}