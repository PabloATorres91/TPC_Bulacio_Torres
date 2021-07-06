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
    public class PartNegocio
    {
        private AccesoDatos ad;

        public DataSet getPart()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDPart, IDMachine, PartName, PartDescription FROM Part";
            ad = new AccesoDatos();
            ad.setQuery(filter);
            SqlDataAdapter dataAdapter = ad.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
    }
}
