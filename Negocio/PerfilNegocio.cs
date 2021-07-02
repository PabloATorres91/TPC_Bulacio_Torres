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
    public class PerfilNegocio
    {
        private AccesoDatos cn;

        public DataSet getProfiles()
        {
            DataSet ds = new DataSet();

            string filter = "SELECT IDProfiles, ProfilesName FROM Profiles";
            cn = new AccesoDatos();
            cn.setQuery(filter);
            SqlDataAdapter dataAdapter = cn.executeDataReader();

            dataAdapter.Fill(ds);

            return ds;            
        }
    }
}
