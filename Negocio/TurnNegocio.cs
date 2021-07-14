using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class TurnNegocio
    {
        private AccesoDatos connection;
        public DataSet getTurno()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDTurn, TurnName FROM Turn";
            connection = new AccesoDatos();
            connection.setQuery(filter);
            SqlDataAdapter dataAdapter = connection.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
    }
}
