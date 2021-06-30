using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {
        private AccesoDatos connection;

        public bool validateLogin(string userName, string userPassword)
        {
            connection = new AccesoDatos();
            try
            {
                /** User properties 
                 * IDUsers (int)
                 * IDProfiles (int)
                 * IDEmployee (int)
                 * UsersName (varchar(50))
                 * UsersEmail (varchar(100))
                 * UsersPass (varchar(100))
                 * UsersDate (datetime)
                 */
                connection.setQuery("SELECT UsersName, UsersPass FROM Users WHERE UsersName='" + userName + "' AND UsersPass='" + userPassword + "'");
                connection.executeReader();

                while (connection.DataReader.Read())
                {
                    return true;
                }
                return false;
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

        public List<Usuario> listUsers()
        {
            List<Usuario> list = new List<Usuario>();
            connection = new AccesoDatos();

            try
            {
                connection.setQuery("SELECT * FROM Users");
                connection.executeReader();
                
                while(connection.DataReader.Read())
                {
                    Usuario auxUser = new Usuario();
                    auxUser.UserName = (string)connection.DataReader["UsersName"];
                    auxUser.UserIDProfile = (int)connection.DataReader["IDProfiles"];
                    auxUser.UserEmail = (string)connection.DataReader["UsersEmail"];
                    auxUser.UserID = (int)connection.DataReader["IDUsers"];

                    list.Add(auxUser);
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
