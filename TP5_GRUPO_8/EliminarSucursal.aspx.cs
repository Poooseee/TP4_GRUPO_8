using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Drawing;

namespace TP5_GRUPO_8
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        Consulta consulta = new Consulta();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
                string idSucursal = (txtIdSucursal.Text);
          int filasAfectadas = consulta.EliminarSucursal(idSucursal);
            
            if(filasAfectadas > 0)
            {
                lblEliminado.Text = "La sucursal ha sido eliminada con éxito";
                lblEliminado.ForeColor = Color.Red;
                txtIdSucursal.Text=string.Empty;

            }
            else { lblEliminado.Text = "No se pudo eliminar o el registro no existe";
                lblEliminado.ForeColor = Color.Red;
            }

            
            
        }
    }
}