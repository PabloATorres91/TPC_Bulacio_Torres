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
     public class MaquinaNegocio
    {
        private AccesoDatos connection;
        public List<Maquina> listMachines()
        {
            List<Maquina> machinesList = new List<Maquina>();
            connection = new AccesoDatos();

            try
            {
                connection.setQuery("SELECT * FROM Machine");
                connection.executeReader();
                while (connection.DataReader.Read())
                {
                    Maquina auxMachine = new Maquina();

                    auxMachine.MachineStatus = (bool)connection.DataReader["MachineStatus"];
                    
                    if(auxMachine.MachineStatus == true)
                    {
                        auxMachine.IDMachine = (int)connection.DataReader["IDMachine"];
                        auxMachine.IDProductionLine = (int)connection.DataReader["IDProductionLine"];
                        auxMachine.MachineName = (string)connection.DataReader["MachineName"];
                        auxMachine.MachineModel = (string)connection.DataReader["MachineModel"];
                        auxMachine.MachineSerialNumber = (string)connection.DataReader["MachineSerialNumber"];

                        machinesList.Add(auxMachine);
                    }
                    
                }
                return machinesList;

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

        public DataSet getMaquina()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDMachine, IDProductionLine, MachineName, MachineModel, MachineSerialNumber, MachineStatus FROM Machine";
            connection = new AccesoDatos();
            connection.setQuery(filter);
            SqlDataAdapter dataAdapter = connection.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public Maquina getfullMachine(string idMachine)
        {
            Maquina auxmachine = new Maquina();
            connection = new AccesoDatos();

            try
            {
                auxmachine.IDMachine = 0;
                connection.setQuery("select * from Machine where IDMachine='" + idMachine + "'");
                connection.executeReader();

                while (connection.DataReader.Read())
                {
                    auxmachine.IDMachine = (int)connection.DataReader["IDMachine"];
                    auxmachine.IDProductionLine = (int)connection.DataReader["IDProductionLine"];
                    auxmachine.MachineName = (string)connection.DataReader["MachineName"];
                    auxmachine.MachineModel = (string)connection.DataReader["MachineModel"];
                    auxmachine.MachineSerialNumber = (string)connection.DataReader["MachineSerialNumber"];
                    auxmachine.MachineStatus = (bool)connection.DataReader["MachineStatus"];

                }
                return auxmachine;


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

        public void modifyMachine(Maquina maquina)
        {
            connection = new AccesoDatos();

            try
            {
                string query = "UPDATE Machine SET IDProductionLine = @idproductionline, MachineName = @machinename, MachineModel = @machinemodel, MachineSerialNumber = @machineserialnumber WHERE IDMachine = @idmachine";
                connection.setQuery(query);
                connection.setQueryParams("@idmachine", maquina.IDMachine);
                connection.setQueryParams("@idproductionline", maquina.IDProductionLine);
                connection.setQueryParams("@machinename", maquina.MachineName);
                connection.setQueryParams("@machinemodel", maquina.MachineModel);
                connection.setQueryParams("@machineserialnumber", maquina.MachineSerialNumber);
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

        public void addMachine(Maquina maquina) 
        {
            connection = new AccesoDatos();

            try
            {
                int newIdProductionLine = maquina.IDProductionLine;
                string newMachineName = maquina.MachineName;
                string newMachineModel = maquina.MachineModel;
                string newMachineSerialNumber = maquina.MachineSerialNumber;
                string values = "VALUES ('"+newIdProductionLine+"', '"+newMachineName+"', '"+newMachineModel+"', '"+newMachineSerialNumber+"')";
                string query = "INSERT INTO Machine(IDProductionLine, MachineName, MachineModel, MachineSerialNumber)" + values;
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

        public void deleteMachine(Maquina maquina)
        {
            connection = new AccesoDatos();

            try
            {
                string query = "DELETE FROM Machine WHERE IDMachine = @idmachine";
                connection.setQuery(query);
                connection.setQueryParams("@idmachine", maquina.IDMachine);
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
