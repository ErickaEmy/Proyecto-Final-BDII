using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAE_Restaurante.Negocios;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using System.IO;
using BAE_Restaurante.Presentacion.Reportes;
using System.Data.SqlClient;

namespace BAE_Restaurante.Presentacion
{

    public partial class FrmReportes : Form
    {
        SqlConnection Conexion = new SqlConnection("Server=DESKTOP-OQUQV45;DataBase=BAE_Restaurante;Integrated Security=true");
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //dgvReportes.DataSource = PedidoNegocios.BuscarPedidosFechas(fechaInicio.Value, fechaFin.Value);
        }

        private void btnFlujoCaja_Click(object sender, EventArgs e)
        {
            FrmFlujoCaja mv = new FrmFlujoCaja();
            mv.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmPedidosFechas mv = new FrmPedidosFechas();
            mv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmComProdFavoritos mv = new FrmComProdFavoritos();
            mv.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FrmPedidoEmpleado mv = new FrmPedidoEmpleado();
            mv.Show();
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            Comidas_por_categorias();
            Productos_por_categorias();
            Consultas();

        }
        public void Comidas_por_categorias()
        {

            ArrayList CantComida = new ArrayList();
            ArrayList Categoria1 = new ArrayList();
            cmd = new SqlCommand("usp_Comidas_por_Categoria", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria1.Add(dr.GetString(0));
                CantComida.Add(dr.GetInt32(1));
            }
            chartComCategoria.Series[0].Points.DataBindXY(Categoria1, CantComida);

            dr.Close();
            Conexion.Close();
        }
        public void Productos_por_categorias()
        {

            ArrayList CantProducto = new ArrayList();
            ArrayList Categoria2 = new ArrayList();
            cmd = new SqlCommand("usp_Producto_por_Categoria", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            Conexion.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Categoria2.Add(dr.GetString(0));
                CantProducto.Add(dr.GetInt32(1));
            }
            chartProdCategoria.Series[0].Points.DataBindXY(Categoria2, CantProducto);

            dr.Close();
            Conexion.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Comidas_por_categorias();
            Productos_por_categorias();
            Consultas();

        }
        public void Consultas()
        {
            cmd = new SqlCommand("usp_Cantidades_totales", Conexion);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter totalVenta = new SqlParameter("@totVenta", 0);
            totalVenta.Direction = ParameterDirection.Output;
            SqlParameter totalCompra = new SqlParameter("@totCompra", 0);
            totalCompra.Direction = ParameterDirection.Output;
            SqlParameter cantCliente = new SqlParameter("@cantCliente", 0);
            cantCliente.Direction = ParameterDirection.Output;
            SqlParameter cantComida = new SqlParameter("@cantComida", 0);
            cantComida.Direction = ParameterDirection.Output;
            SqlParameter cantContacto = new SqlParameter("@cantContactos", 0);
            cantContacto.Direction = ParameterDirection.Output;
            SqlParameter cantEmpleado = new SqlParameter("@cantEmpleado", 0);
            cantEmpleado.Direction = ParameterDirection.Output;
            SqlParameter cantPedido = new SqlParameter("@cantPedido", 0);
            cantPedido.Direction = ParameterDirection.Output;
            SqlParameter cantProducto = new SqlParameter("@cantProducto", 0);
            cantProducto.Direction = ParameterDirection.Output;
            SqlParameter cantReserva = new SqlParameter("@cantReserva", 0);
            cantReserva.Direction = ParameterDirection.Output;

            cmd.Parameters.Add(totalVenta);
            cmd.Parameters.Add(totalCompra);
            cmd.Parameters.Add(cantCliente);
            cmd.Parameters.Add(cantComida);
            cmd.Parameters.Add(cantContacto);
            cmd.Parameters.Add(cantEmpleado);
            cmd.Parameters.Add(cantPedido);
            cmd.Parameters.Add(cantProducto);
            cmd.Parameters.Add(cantReserva);

            Conexion.Open();
            cmd.ExecuteNonQuery();
            lblTotalVenta.Text = cmd.Parameters["@totVenta"].Value.ToString();
            lblTotalCompra.Text = cmd.Parameters["@totCompra"].Value.ToString();
            lblCliente.Text = cmd.Parameters["@cantCliente"].Value.ToString();
            lblComida.Text = cmd.Parameters["@cantComida"].Value.ToString();
            lblContactos.Text = cmd.Parameters["@cantContactos"].Value.ToString();
            lblEmpleados.Text = cmd.Parameters["@cantEmpleado"].Value.ToString();
            lblPedido.Text = cmd.Parameters["@cantPedido"].Value.ToString();
            lblProducto.Text = cmd.Parameters["@cantProducto"].Value.ToString();
            lblReserva.Text = cmd.Parameters["@cantReserva"].Value.ToString();
            Conexion.Close();
        }
    }
}
