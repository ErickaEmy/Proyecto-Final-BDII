using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAE_Restaurante.Presentacion.Reportes
{
    public partial class FrmPedidoEmpleado : Form
    {
        public FrmPedidoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmPedidoEmpleado_Load(object sender, EventArgs e)
        {
            DateTime fecha_inicio, fecha_fin;
            fecha_inicio = fechaInicio.Value;
            string auxfecha1 = Convert.ToString(fecha_inicio.ToShortDateString());

            fecha_fin = fechaFin.Value;
            string auxfecha2 = Convert.ToString(fecha_fin.ToShortDateString());

            // TODO: esta línea de código carga datos en la tabla 'DsBAE_Restaurante.usp_Pedidos_Empleados' Puede moverla o quitarla según sea necesario.
            this.usp_Pedidos_EmpleadosTableAdapter.Fill(this.DsBAE_Restaurante.usp_Pedidos_Empleados, Convert.ToDateTime(auxfecha1).Date, Convert.ToDateTime(auxfecha2).Date);

            this.reportViewer1.RefreshReport();
        }

        private void btnFlujoCaja_Click(object sender, EventArgs e)
        {
            DateTime fecha_inicio, fecha_fin;
            fecha_inicio = fechaInicio.Value;
            string auxfecha1 = Convert.ToString(fecha_inicio.ToShortDateString());

            fecha_fin = fechaFin.Value;
            string auxfecha2 = Convert.ToString(fecha_fin.ToShortDateString());

            // TODO: esta línea de código carga datos en la tabla 'DsBAE_Restaurante.usp_Pedidos_Empleados' Puede moverla o quitarla según sea necesario.
            this.usp_Pedidos_EmpleadosTableAdapter.Fill(this.DsBAE_Restaurante.usp_Pedidos_Empleados, Convert.ToDateTime(auxfecha1).Date, Convert.ToDateTime(auxfecha2).Date);

            this.reportViewer1.RefreshReport();
        }
    }
}
