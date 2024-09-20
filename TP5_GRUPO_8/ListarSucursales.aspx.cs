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
        ConexionDB conexion = new ConexionDB();
        protected void Page_Load(object sender, EventArgs e)
        {
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";
            string nombre_tabla = "grvSucursales";

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

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            string consulta = "select Id_Sucursal as ID , NombreSucursal as NOMBRE , DescripcionProvincia as PROVINCIA , DireccionSucursal as DIRECCION from Sucursal inner join Provincia on Id_Provincia = Id_ProvinciaSucursal";

            DataTable sucursales = conexion.ObtenerTablas(consulta, "Sucursales");
            grvSucursales.DataSource = sucursales;
            grvSucursales.DataBind();
        }
    }
}