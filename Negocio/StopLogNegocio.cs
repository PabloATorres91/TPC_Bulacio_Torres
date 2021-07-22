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
                    int auxIdMachine = (int)connection.DataReader["IDMachine"];
                    int auxIdTurn = (int)connection.DataReader["IDTurn"];
                    bool status= (bool)connection.DataReader["StopLogStatus"];

                    if(idMachine == auxIdMachine)
                    {
                        if (date == dateList.ToString("yyyy-MM-dd"))
                        {
                            if (auxIdTurn == idTurn)
                            {
                                if (status == true)
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

                        }

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

        public StopLog getFullStopLog(string stopLog)
        {
            StopLog auxStopLog = new StopLog();
            connection = new AccesoDatos();
            try
            {
                auxStopLog.IDStopLog = 0;
                connection.setQuery("Select * from StopLog where IDStopLog = '"+ stopLog +"'");
                connection.executeReader();
                while (connection.DataReader.Read())
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
                }
                return auxStopLog;
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
                string query = "UPDATE StopLog SET IDMachine=@idMachine, IDStopCode=@idStopCode, IDUsers=@idUsers, IDTurn=@idTurn, StopLogBegin=@stopLogBegin, StopLogFinish=@stopLogFinish, StopLogObservation=@stopLogObservation WHERE IDStopLog=@idStopLog";
                connection.setQuery(query);
                connection.setQueryParams("@idStopLog", stopLog.IDStopLog);
                connection.setQueryParams("@idMachine", stopLog.IDMachine);
                connection.setQueryParams("@idStopCode", stopLog.IDStopCode);
                connection.setQueryParams("@idUsers", stopLog.IDUsers);
                connection.setQueryParams("@idTurn", stopLog.IDTurn);
                connection.setQueryParams("@stopLogBegin", stopLog.StopLogBegin);
                connection.setQueryParams("@stopLogFinish", stopLog.StopLogFinish);
                connection.setQueryParams("@stopLogObservation", stopLog.StopLogObservation);
                connection.executeAction();

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

        public void addStopLog(StopLog stopLog)
        {
            connection = new AccesoDatos();

            try
            {
                int newIDMachine = stopLog.IDMachine;
                int newIDStopCode = stopLog.IDStopCode;
                int newIDUsers = stopLog.IDUsers;
                int newIDTurn = stopLog.IDTurn;
                DateTime newStopLogBegin = stopLog.StopLogBegin;
                DateTime newStopLogFinish = stopLog.StopLogFinish;
                string newStopLogObservation = stopLog.StopLogObservation;
                string values = "VALUES ('" + newIDMachine + "', '" + newIDStopCode + "', '" + newIDUsers + "', '" + newIDTurn + "', '" + newStopLogBegin + "', '" + newStopLogFinish + "', '" + newStopLogObservation + "')";
                string query = "INSERT INTO StopLog(IDMachine, IDStopCode, IDUsers, IDTurn, StopLogBegin, StopLogFinish, StopLogObservation)" + values;
                connection.setQuery(query);
                connection.executeAction();
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

        public void deleteStopLog(StopLog stopLog)
        {
            connection = new AccesoDatos();

            try
            {
                string query = "DELETE FROM StopLog WHERE IDStopLog = @idStopLog";
                connection.setQuery(query);
                connection.setQueryParams("@idStopLog", stopLog.IDStopLog);
                connection.executeAction();

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
