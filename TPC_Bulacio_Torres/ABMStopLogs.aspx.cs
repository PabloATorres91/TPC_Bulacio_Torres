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
    public partial class ABMStopLogs : System.Web.UI.Page
    {
        public List<StopLog> stopLogList;
        StopLogNegocio stopLogNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int idMachine = Int32.Parse((string)Session["ABMStopLogs.IDMachine"]);
                int idTurn = Int32.Parse((string)Session["ABMStopLogs.IDTurn"]);
                string date = DateTime.Now.ToString("yyyy-MM-dd");
                stopLogNegocio = new StopLogNegocio();
                stopLogList = stopLogNegocio.listStoplog(idMachine, idTurn, date);
            }

        }

        protected void btnNuevaParada_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormStopLog.aspx");
        }
    }
}