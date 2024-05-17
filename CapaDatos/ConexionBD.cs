using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionBD
    {
        #region "PATRON SINGLETON"
        public static ConexionBD conexion = null;

        public ConexionBD() { }

        public static ConexionBD getInstance()
        {
            if (conexion == null)
            {
                conexion = new ConexionBD();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionDB()
        {
            SqlConnection conexion = new SqlConnection();

            //conexion.ConnectionString = @"Data Source=SQL5109.site4now.net;Initial Catalog=db_aa6712_riberalta;User Id=db_aa6712_riberalta_admin;Password=Riber@2024";

            conexion.ConnectionString = "Data Source=.;Initial Catalog=AdminDB;Integrated Security=True";
            return conexion;
        }
    }
}
