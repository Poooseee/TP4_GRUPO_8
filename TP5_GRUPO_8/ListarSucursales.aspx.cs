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
            grvSucursales.DataSource = consulta.obtenerSucursales();
            grvSucursales.DataBind();
            lblTodos.Text = "Estas son todas las sucursales";
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(txtIdSucursal.Text.Trim().Length > 0)
            {
                grvSucursales.DataSource = consulta.BuscarSucursalesPorId(int.Parse(txtIdSucursal.Text));
                grvSucursales.DataBind();
                txtIdSucursal.Text = "";
                lblTodos.Text = "";
            }

        }
    }
}