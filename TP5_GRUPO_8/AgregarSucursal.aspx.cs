using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace TP5_GRUPO_8
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        ConexionDB conexion = new ConexionDB();
        private static string rutaConexion = @"Data Source=localhost\sqlexpress;Initial Catalog=BDSucursales;Integrated Security=True";
        string consultaProvincias = "select DescripcionProvincia , Id_Provincia from Provincia";
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(rutaConexion);
            cn.Open();
            
            txtNombreSucursal.Text.Trim();
            txtDescripción.Text.Trim();
            txtDireccion.Text.Trim();

            //CARGAR DDL PROVINCIAS
            SqlDataAdapter adapProvincias = new SqlDataAdapter(consultaProvincias, cn);
            DataSet dsProvincias = new DataSet();

            adapProvincias.Fill(dsProvincias , "Provincias");
            ddlProvincia.DataSource = dsProvincias.Tables["Provincias"];
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();

            ListItem defaultItem = new ListItem("--Seleccionar--", "0");
            ddlProvincia.Items.Insert(0, defaultItem);

            cn.Close();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}