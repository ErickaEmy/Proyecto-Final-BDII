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

namespace BAE_Restaurante.Presentacion
{
    public partial class FrmDocVenta : Form
    {
        public FrmDocVenta()
        {
            InitializeComponent();
        }

        private void pnlFactura_Paint(object sender, PaintEventArgs e)
        {
            dgvFactura.DataSource = PedidoNegocios.ListarVentas(Convert.ToInt32(lblPedidoID.Text));
            dgvFactura.Columns[0].Width=77;
            dgvFactura.Columns[1].Width=217;
            dgvFactura.Columns[2].Width=80;
            dgvFactura.Columns[3].Width=100;
            dgvFactura.Columns[0].HeaderText = "Cantidad";
            dgvFactura.Columns[1].HeaderText = "Nombre";
            dgvFactura.Columns[2].HeaderText = "Precio U.";
            dgvFactura.Columns[3].HeaderText = "Valor Venta";

            Double sumatoria = 0;

            foreach (DataGridViewRow row in dgvFactura.Rows)
            {
                sumatoria += Convert.ToDouble(row.Cells[3].Value);
            }

            txtSubtotal.Text = Convert.ToString(sumatoria);

            Double igv = Math.Round(sumatoria * 0.18, 2);
            txtIGV.Text = Convert.ToString(igv);
            txtTotal.Text = Convert.ToString(igv + sumatoria);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";


                Rpta = Doc_ventaNegocios.Insertar(lblTipo.Text, Convert.ToInt32(lblPedidoID.Text), Convert.ToDouble(txtTotal.Text), Convert.ToDateTime(lblFechaf.Text),txtComentario.Text+".", Convert.ToInt32(lblPedidoID.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Documento de venta registrado correctamente.");
                    Rpta = CajaNegocios.Actualizar2(Convert.ToDateTime(lblFechaf.Text), Convert.ToDouble(txtTotal.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Caja actualizada correctamente.");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                }
                else
                {
                    //this.MensajeError(Rpta);
                    Rpta = Doc_ventaNegocios.Actualizar(Convert.ToInt32(lblPedidoID.Text), lblTipo.Text, Convert.ToInt32(lblPedidoID.Text), Convert.ToDouble(txtTotal.Text), Convert.ToDateTime(lblFechaf.Text).Date, txtComentario.Text + ".", Convert.ToInt32(lblPedidoID.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Documento de venta actualizado correctamente.");
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }



                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
