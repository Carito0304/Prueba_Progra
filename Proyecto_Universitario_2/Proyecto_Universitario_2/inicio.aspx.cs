using Proyecto_Universitario_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Universitario_2
{
	public partial class inicio : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{

		}

		protected void bIngresar_Click(object sender, EventArgs e)
		{
			if (ClsUsuario.validarUsuario(tUsuario.Text, tclave.Text) > 0)
			{
				Response.Redirect("inicio_2.aspx");

			}
			else
			{
				lmensaje.Text = "usuario inexistente";
			}


		}
	}
}