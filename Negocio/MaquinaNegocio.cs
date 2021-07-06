using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

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
                    auxMachine.IDMachine = (int)connection.DataReader["IDMachine"];
                    auxMachine.IDProductionLine = (int)connection.DataReader["IDProductionLine"];
                    auxMachine.MachineName = (string)connection.DataReader["MachineName"];
                    auxMachine.MachineModel = (string)connection.DataReader["MachineModel"];
                    auxMachine.MachineSerialNumber = (string)connection.DataReader["MachineSerialNumber"];

                    machinesList.Add(auxMachine);
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
        public Maquina getFullMachine(string idMachine)
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
    }
}
