﻿using System;
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
        
        public Usuario getFullUser(string idUser)
        {
            Usuario auxUser = new Usuario();
            connection = new AccesoDatos();

            try
            {
                //SELECT * FROM Users WHERE IDUsers=1
                auxUser.UserIDEmployee = 0;

                connection.setQuery("SELECT * FROM Users WHERE IDUsers='" + idUser + "'");
                connection.executeReader();

                while(connection.DataReader.Read())
                {
                    auxUser.UserIDEmployee = (int)connection.DataReader["IDUsers"];
                    auxUser.UserName = (string)connection.DataReader["UsersName"];
                    auxUser.UserIDProfile = (int)connection.DataReader["IDProfiles"];
                    auxUser.UserEmail = (string)connection.DataReader["UsersEmail"];
                    auxUser.UserPass = (string)connection.DataReader["UsersPass"];
                    auxUser.UserDate = (DateTime)connection.DataReader["UsersDate"];
                    auxUser.UserID = (int)connection.DataReader["IDUsers"];
                }

                if(auxUser.UserIDEmployee !=0)
                {
                    return auxUser;
                }
                else
                {
                    return auxUser;
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

        public void modifyUser(Usuario user)
        {
            connection = new AccesoDatos();

            try
            {
                //update Users set IDProfiles=1 where IDUsers=1
                string query = "UPDATE Users set IDProfiles = @idprofile, UsersName = @username, UsersEmail = @useremail where IDUsers = @userid";
                connection.setQuery(query);
                connection.setQueryParams("@idprofile", user.UserIDProfile);
                connection.setQueryParams("@username", user.UserName);
                connection.setQueryParams("@useremail", user.UserEmail);
                connection.setQueryParams("@userid", user.UserID);

                connection.executeAction();
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

        public void addUser(Usuario user)
        {
            connection = new AccesoDatos();
            try
            {
                string newName = user.UserName;
                string newEmail = user.UserEmail;
                int newIDProfile = user.UserIDProfile;
                DateTime newInitDate = DateTime.Now;
                string newPass = "1234";//Pass por default

                string values = "VALUES('" + newName + "', '" + newEmail + "', '" + newIDProfile + "', '" + newInitDate + "', '" + newPass + "')";
                string query = "INSERT INTO Users (UsersName, UsersEmail, IDProfiles, UsersDate, UsersPass) " + values;
                connection.setQuery(query);
                connection.executeAction();
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
