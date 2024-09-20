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
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        Consulta consulta = new Consulta();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
            grvSucursales.DataSource = consulta.obtenerSucursales();
            grvSucursales.DataBind();

            }
            

           
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            string consulta = "select Id_Sucursal as ID , NombreSucursal as NOMBRE , DescripcionProvincia as PROVINCIA , DireccionSucursal as DIRECCION from Sucursal inner join Provincia on Id_Provincia = Id_ProvinciaSucursal";

           // DataTable sucursales = conexion.ObtenerTablas(consulta, "Sucursales");
          //  grvSucursales.DataSource = sucursales;
            grvSucursales.DataBind();
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(txtIdSucursal.Text.Trim().Length > 0) {
            {
                    //Funcionamiento de Filtro
            }
        }
    }
}