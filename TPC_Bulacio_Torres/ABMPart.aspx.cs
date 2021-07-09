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
    public partial class ABMPart : System.Web.UI.Page
    {
        public List<Part> partsList;
        PartNegocio partNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            partNegocio = new PartNegocio();
            partsList = partNegocio.listParts();

        }

        protected void btnAgregarParte_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormPart.aspx");
        }
    }
}