using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocio
{
    class AccesoDatos
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader dataReader;

        public AccesoDatos()
        {
            connection = new SqlConnection("data source=(local)\\SQLEXPRESS; initial catalog=TPC_Bulacio_Torres_DB; integrated security=sspi");
            command = new SqlCommand();
        }

        public void setQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void setQueryParams(string name, object value)
        {
            command.Parameters.AddWithValue(name, value);
        }

        public void executeReader()
        {
            command.Connection = connection;
            connection.Open();
            dataReader = command.ExecuteReader();
        }

        public void closeConnection()
        {
            if(dataReader != null)
            {
                dataReader.Close();
            }
            else
            {
                connection.Close();
            }
        }

        public SqlDataReader DataReader
        {
            get { return dataReader; }
        }

        internal void executeAction()
        {
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
