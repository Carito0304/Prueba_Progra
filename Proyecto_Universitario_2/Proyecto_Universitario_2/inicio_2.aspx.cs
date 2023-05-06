using Proyecto_Universitario_2.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proyecto_Universitario_2
{
	public partial class inicio_2 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			l_mensaje.Text = ClsUsuario.email;
		}


	}
}