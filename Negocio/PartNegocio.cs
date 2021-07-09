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
        private AccesoDatos connection;

        public DataSet getPart()
        {
            DataSet dataSet = new DataSet();

            string filter = "SELECT IDPart, IDMachine, PartName, PartDescription, PartStatus FROM Part";
            ad = new AccesoDatos();
            ad.setQuery(filter);
            SqlDataAdapter dataAdapter = ad.executeDataReader();

            dataAdapter.Fill(dataSet);

            return dataSet;
        }
        public Part getFullPart(string IDPart)
        {
            Part auxpart = new Part();
            connection = new AccesoDatos();

            try
            {
                auxpart.IDPart = 0;
                connection.setQuery("SELECT * FROM  Part WHERE IDPart='" + IDPart+"'");
                connection.executeReader();

                while (connection.DataReader.Read())
                {
                    auxpart.IDPart = (int)connection.DataReader["IDPart"];
                    auxpart.IDMachine = (int)connection.DataReader["IDMachine"];
                    auxpart.PartName = (string)connection.DataReader["PartName"];
                    auxpart.PartDescription = (string)connection.DataReader["PartDescription"].ToString();
                    auxpart.PartStatus = (bool)connection.DataReader["PartStatus"];
                    
                }
                return auxpart;
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
        public List<Part> listParts()
        {
            List<Part> partsList = new List<Part>();
            connection = new AccesoDatos();

            try
            {
                connection.setQuery("SELECT * FROM Part");
                connection.executeReader();
                while (connection.DataReader.Read())
                {
                    Part auxPart = new Part();

                    auxPart.IDPart = (int)connection.DataReader["IDPart"];
                    auxPart.IDMachine = (int)connection.DataReader["IDMachine"];
                    auxPart.PartName = (string)connection.DataReader["PartName"];
                    auxPart.PartDescription = (string)connection.DataReader["PartDescription"].ToString();
                    auxPart.PartStatus = (bool)connection.DataReader["PartStatus"];

                    partsList.Add(auxPart);
                }
                return partsList;
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
        public void modifyPart(Part part)
        {
            connection = new AccesoDatos();
            try
            {
                string query = "UPDATE Part SET IDPart = @idpart, IDMachine = @idmachine, PartName = @partname, PartDescription = @partdescription, PartStatus = @partstatus";
                connection.setQuery(query);
                connection.setQueryParams("@idpart", part.IDPart);
                connection.setQueryParams("@idmachine", part.IDMachine);
                connection.setQueryParams("@partname", part.PartName);
                connection.setQueryParams("@partdescription", part.PartDescription);
                connection.setQueryParams("@partstatus", part.PartStatus);
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
        public void deletePart(Part part)
        {
            connection = new AccesoDatos();
            try
            {
                string query = "DELETE FROM Part WHERE IDPart = @idpart";
                connection.setQuery(query);
                connection.setQueryParams("@idpart", part.IDPart);
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
        public void addPart(Part part)
        {
            connection = new AccesoDatos();
            try
            {
                int newIdMachine = part.IDMachine;
                string newPartName = part.PartName;
                string newPartDescription = part.PartDescription;
                string values = "VALUES ('"+newIdMachine+"', '"+newPartName+"', '"+newPartDescription+"')";
                string query = "INSERT INTO Part(IDMachine, PartName, PartDescription)" + values;
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
    }
}
