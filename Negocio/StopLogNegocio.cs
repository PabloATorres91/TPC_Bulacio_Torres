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
    public class StopLogNegocio
    {
        private AccesoDatos connection;
        public List<StopLog> listStoplog(int idMachine, int idTurn, string date)
        {
            List<StopLog> stopLogList = new List<StopLog>();
            connection = new AccesoDatos();
                       
            try
            {
                connection.setQuery("SELECT * FROM StopLog");
                connection.executeReader();
                while (connection.DataReader.Read())
                {
                    StopLog auxStopLog = new StopLog();
                    DateTime dateList = (DateTime)connection.DataReader["StopLogBegin"];
                    if (date == dateList.ToString("dd-MM-yyyy"))
                    {
                        auxStopLog.IDStopLog = (long)connection.DataReader["IDStopLog"];
                        auxStopLog.IDMachine = (int)connection.DataReader["IDMachine"];
                        auxStopLog.IDStopCode = (int)connection.DataReader["IDStopCode"];
                        auxStopLog.IDUsers = (int)connection.DataReader["IDUsers"];
                        auxStopLog.IDTurn = (int)connection.DataReader["IDTurn"];
                        auxStopLog.StopLogBegin = (DateTime)connection.DataReader["StopLogBegin"];
                        auxStopLog.StopLogFinish = (DateTime)connection.DataReader["StopLogFinish"];
                        auxStopLog.StopLogObservation = (string)connection.DataReader["StopLogObservation"];
                        auxStopLog.StopLogStatus = (bool)connection.DataReader["StopLogStatus"];

                        stopLogList.Add(auxStopLog);
                    }                 

                }
                return stopLogList;

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

        public void modifyStopLog(StopLog stopLog)
        {
            connection = new AccesoDatos();
            try
            {

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
    }
}
