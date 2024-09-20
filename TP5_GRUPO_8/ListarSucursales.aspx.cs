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
        protected void Page_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";
            string nombre_tabla = "grvSucursales";
            ConexionDB conexion = new ConexionDB();
            DataTable sucursales = conexion.ObtenerTablas(consulta, "Sucursales");
            grvSucursales.DataSource = sucursales;
            grvSucursales.DataBind();

            // DataTable ObtenerSucursales()
            //  {
            //    string consultaSQL = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";
            //     string nombreTabla = "Sucursales";
            //    return conexion.ObtenerTablas(consultaSQL, nombreTabla);
            //}
        }
    }
}