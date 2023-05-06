using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_Universitario_2.Modelo
{
	public class DB_Conn
	{

		public static SqlConnection obtenerConexion() {

			string s = System.Configuration.ConfigurationManager.ConnectionStrings["UHCS"].ConnectionString;
			SqlConnection conn = new SqlConnection(s);
			conn.Open();
			return conn;
				
		}


	}
}