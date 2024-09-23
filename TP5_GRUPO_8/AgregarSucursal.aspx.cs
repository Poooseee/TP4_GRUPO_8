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
        Consulta consulta = new Consulta();
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //CARGAR DDL PROVINCIAS
            if (!IsPostBack)
            {
                cargarProvincias();
            }
           
        }
        public void cargarProvincias()
        {
            ddlProvincia.DataSource = consulta.ObtenerProvincias();
            ddlProvincia.DataTextField = "DescripcionProvincia";
            ddlProvincia.DataValueField = "Id_Provincia";
            ddlProvincia.DataBind();

            ddlProvincia.Items.Insert(0, "--Seleccionar--");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int IdProvincia = int.Parse(ddlProvincia.SelectedValue);
            int filasAfectadas = consulta.AgregarSucursal(txtNombreSucursal.Text, txtDescripción.Text, IdProvincia, txtDireccion.Text);

            if(filasAfectadas > 0)
            {
            txtNombreSucursal.Text = "";
            txtDescripción.Text = "";
            ddlProvincia.SelectedIndex = 0;
            txtDireccion.Text = "";
            lblAgregado.Text = "La sucursal se ha agregado con éxito";

            }
            else
            {
                lblAgregado.Text = "La sucursal no se agrego";
            }
        }
    }
}