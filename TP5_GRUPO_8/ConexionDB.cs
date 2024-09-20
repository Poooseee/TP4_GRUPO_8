using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace TP5_GRUPO_8
{
    public class ConexionDB
    {
        string rutaDB = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True";
        public DataTable ObtenerTablas(string consultaSQL, string nombreTabla)
        {
            SqlConnection conn = new SqlConnection(rutaDB);
            conn.Open();
            SqlDataAdapter adap = new SqlDataAdapter(consultaSQL, conn);
            DataSet ds = new DataSet();
            adap.Fill(ds, "nombreTabla");
            conn.Close();
            return ds.Tables["nombreTabla"];
        }

        public int EjecutarConsulta(string consultaSQL)
        {
            SqlConnection conn = new SqlConnection(rutaDB);
            conn.Open();
            SqlCommand cmd = new SqlCommand(consultaSQL, conn);
            int filas = (int)cmd.ExecuteNonQuery(); // PARA INSERT-UPDATE-DELETE
            conn.Close();
            return filas;
        }
    }
}