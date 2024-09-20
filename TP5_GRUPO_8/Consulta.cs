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

        public int AgregarSucursal(string NombreSucursal, string DescripcionSucursal, int IdProvinciaSucursal, string DireccionSucursal)
        {
            string consultaAgregarSucursal = "INSERT INTO Sucursal (NombreSucursal, DescripcionSucursal, Id_ProvinciaSucursal, DireccionSucursal) " +
               "VALUES ('"+NombreSucursal+"','"+DescripcionSucursal+"',"+IdProvinciaSucursal+",'"+DireccionSucursal+"')";
            return conexion.EjecutarConsulta(consultaAgregarSucursal);
        }

        public DataTable obtenerSucursales()
        {
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE,DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal";
            string nombre_tabla = "grvSucursales";
            return conexion.ObtenerTablas(consulta, nombre_tabla);
        }
        public int EliminarSucursal(string id)
        {
            string consulta = "delete from Sucursal where Id_Sucursal = " + id;
            return conexion.EjecutarConsulta(consulta);
        }

        public DataTable BuscarSucursalesPorId(int idSucursal)
        {
            string consulta = "SELECT Id_Sucursal AS ID, NombreSucursal AS NOMBRE," +
                "DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCIÓN FROM Sucursal INNER JOIN Provincia ON Id_Provincia=Id_ProvinciaSucursal" +
                " WHERE Id_Sucursal = "+idSucursal;
            
            string nombre_tabla = "grvSucursales";
            return conexion.ObtenerTablas(consulta, nombre_tabla);
        }

    }
}