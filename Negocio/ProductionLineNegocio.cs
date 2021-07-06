using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class ProductionLineNegocio
    {
        private AccesoDatos ad;

        public DataSet getProductionLine()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDProductionLine, ProductionLineName FROM ProductionLine";
            ad = new AccesoDatos();
            ad.setQuery(filter);
            SqlDataAdapter dataAdapter = ad.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
    }
}
