using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Proyecto_Universitario_2.Modelo
{
	public class ClsUsuario
	{
		public static string email { get; set; }
		public static string clave { get; set; }


		public static int validarUsuario(string p_email, string p_clave) 
		{
			int retorno = 0;
			int tipo = 0;
			SqlConnection conn = new SqlConnection();
			try
			{
				using (conn = DB_Conn.obtenerConexion())
				{
					SqlCommand cmd = new SqlCommand("validarLogin", conn)
					{
						CommandType = CommandType.StoredProcedure
					};
					cmd.Parameters.Add(new SqlParameter("@email", p_email));
					cmd.Parameters.Add(new SqlParameter("@clave", p_clave));


					using (SqlDataReader rdr = cmd.ExecuteReader())
					{

						if (rdr.Read())
						{
							retorno = 1;
							email = p_email;
							clave = p_clave;
						}
					}

				}
			}
			catch (System.Data.SqlClient.SqlException e)
			{
				retorno = -1;
			}
			finally
			{
				conn.Close();
				conn.Dispose();
			}
			return retorno;
		}



	}
}