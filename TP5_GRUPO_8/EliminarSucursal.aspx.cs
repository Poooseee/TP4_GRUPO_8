using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_GRUPO_8
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        ConexionDB conexion = new ConexionDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtIdSucursal.Text.Trim().Length > 0)
            {
                string consulta = "delete from Sucursal where Id_Sucursal = " + Convert.ToInt32(txtIdSucursal.Text);


            }
        }
    }
}