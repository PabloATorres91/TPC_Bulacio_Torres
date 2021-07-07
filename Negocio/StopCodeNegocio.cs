using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class StopCodeNegocio
    {
        private AccesoDatos connection;

        public List<StopCode> listStopCodes()
        {
            List<StopCode> list = new List<StopCode>();
            connection = new AccesoDatos();

            try
            {
                connection.setQuery("SELECT * FROM StopCode");
                connection.executeReader();

                while(connection.DataReader.Read())
                {
                    StopCode auxStopCode = new StopCode();
                    auxStopCode.IDStopCode = (int)connection.DataReader["IDStopCode"];
                    auxStopCode.StopCodeName = (string)connection.DataReader["StopCodeName"];

                    list.Add(auxStopCode);
                }

                return list;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.closeConnection();
            }
        }
    }
}
