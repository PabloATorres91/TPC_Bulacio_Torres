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
    public partial class ABMStopCodes : System.Web.UI.Page
    {
        public List<StopCode> list;
        StopCodeNegocio stopCodeNegocio;

        protected void Page_Load(object sender, EventArgs e)
        {
            stopCodeNegocio = new StopCodeNegocio();
            list = stopCodeNegocio.listStopCodes();
        }

        protected void btnAgregarStopCode_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormStopCode.aspx");
        }
    }
}