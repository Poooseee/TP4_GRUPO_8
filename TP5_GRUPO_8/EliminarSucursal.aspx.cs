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
            if (txtIdSucursal.Text.Trim().Length > 0)
            {
                string idSucursal = (txtIdSucursal.Text);
                consulta.EliminarSucursal(idSucursal);
                lblEliminado.Text = "La sucursal ha sido eliminada con éxito";
                lblEliminado.ForeColor = Color.Red;
            }
        }
    }
}