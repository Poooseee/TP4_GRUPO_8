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
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreSucursal.Text.Length > 0 && txtDireccion.Text.Length > 0 && txtDescripción.Text.Length > 0)
            {
                //Funcion del boton guardar
            }
        }
    }
}