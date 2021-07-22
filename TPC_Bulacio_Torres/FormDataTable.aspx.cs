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
    public partial class FormDataTable : System.Web.UI.Page
    {
        public List<StopLog> stopLogList, auxstopLogList;
        StopLogNegocio stopLogNegocio;
        protected void Page_Load(object sender, EventArgs e)
        {            
                int idMachine = Int32.Parse((string)Session["FormIndicators.IDMachine"]);
                int idTurn = Int32.Parse((string)Session["FormIndicators.IDTurn"]);
                string date = (string)Session["FormIndicators.Date"];
                stopLogNegocio = new StopLogNegocio();
                stopLogList = new List<StopLog>();
                auxstopLogList = stopLogNegocio.listStoplog(idMachine, idTurn, date);

                foreach (StopLog stopLog in auxstopLogList)
                {
                    TimeSpan timeSpan = stopLog.StopLogFinish - stopLog.StopLogBegin;
                    stopLog.TiempoMinutos = timeSpan;

                    stopLogList.Add(stopLog);
                }

        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormIndicators.aspx", false);
        }
    }
}