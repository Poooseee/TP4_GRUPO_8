using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TP5_GRUPO_8
{
    public class Consulta
    {
    ConexionDB conexion = new ConexionDB();

        public DataTable ObtenerProvincias()
        {
            string consultaProvincias = "select DescripcionProvincia , Id_Provincia from Provincia";
            string nombreTabla = "Provincias";
            return conexion.ObtenerTablas(consultaProvincias, nombreTabla);
        }

        public DataTable obtenerSucursales()
        {
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE,DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";
            string nombre_tabla = "grvSucursales";
            return conexion.ObtenerTablas(consulta, nombre_tabla);
        }
        public int EliminarSucursal(int id)
        {
            string consulta = "delete from Sucursal where Id_Sucursal = " + id;
            return conexion.EjecutarConsulta(consulta);
        }
        
    }
}