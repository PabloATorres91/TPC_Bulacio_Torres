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

        public object getStopCode()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDStopCode, StopCodeName FROM StopCode";
            connection = new AccesoDatos();
            connection.setQuery(filter);
            SqlDataAdapter dataAdapter = connection.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public StopCode getStopCodeById(string idStopCode)
        {
            StopCode auxStopCode = new StopCode();
            connection = new AccesoDatos();

            try
            {
                auxStopCode.IDStopCode = 0;
                string queryToGetStopCode = "SELECT * FROM StopCode WHERE IDStopCode='" + idStopCode  + "'" ;
                connection.setQuery(queryToGetStopCode);
                connection.executeReader();

                while(connection.DataReader.Read())
                {
                    auxStopCode.IDStopCode = (int)connection.DataReader["IDStopCode"];
                    auxStopCode.StopCodeName = (string)connection.DataReader["StopCodeName"];
                }
                if(auxStopCode.IDStopCode != 0)
                {
                    return auxStopCode;
                }
                else
                {
                    return auxStopCode;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.closeConnection();
            }
        }

        public int modifyStopCode(StopCode stopCode)
        {
            connection = new AccesoDatos();

            try
            {
                string query = "UPDATE StopCode set StopCodeName = @stopcodename WHERE IDStopCode = @idstopcode";
                connection.setQuery(query);
                connection.setQueryParams("@stopcodename", stopCode.StopCodeName);
                connection.setQueryParams("@idstopcode", stopCode.IDStopCode);

                return connection.executeActionWithResult();
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

        public int deleteStopCode (StopCode stopCodeToDelete)
        {
            connection = new AccesoDatos();

            try
            {
                string query = "DELETE FROM StopCode WHERE IDStopCode= '" + stopCodeToDelete.IDStopCode + "'";

                connection.setQuery(query);
                return connection.executeActionWithResult();
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

        public int addStopCode (StopCode stopCode)
        {
            connection = new AccesoDatos();

            try
            {
                string newStopCodeName = stopCode.StopCodeName;
                string values = "VALUES('" + newStopCodeName + "'," + true + "')";
                string query = "INSERT INTO StopCode (UsersName, UserState) " + values;
                connection.setQuery(query);
                return connection.executeActionWithResult();
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
