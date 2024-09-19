using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace TP5_GRUPO_8
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        private static string rutaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlProvincia.Items.Add("--Seleccionar--");
            
            txtNombreSucursal.Text.Trim();
            txtDescripción.Text.Trim();
            txtDireccion.Text.Trim();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}