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
    public partial class FrmCaja : Form
    {
        public FrmCaja()
        {
            InitializeComponent();
        }

        private void FrmCaja_Load(object sender, EventArgs e)
        {
            this.ListarCaja();
        }
        private void ListarCaja()
        {
            try
            {
                DateTime hoy=DateTime.Today;
                dgvCaja.DataSource = CajaNegocios.Listar();
                txtReserva.Clear();
                txtEgreso.Clear();
                txtIngreso.Clear();
                txtIdCaja.Clear();
                dteFecha.Value = hoy;
                txtComentario.Clear();
                this.TitulosCaja();
                txtEgreso.Text = "0";
                txtIngreso.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosCaja()
        {
            dgvCaja.Columns[0].Visible = false;
            dgvCaja.Columns[1].Width = 80;
            dgvCaja.Columns[2].Width = 100;
            dgvCaja.Columns[3].Width = 100;
            dgvCaja.Columns[4].Width = 100;
            dgvCaja.Columns[5].Width = 150;

            dgvCaja.Columns[0].HeaderText = "ID";
            dgvCaja.Columns[1].HeaderText = "Fecha";
            dgvCaja.Columns[2].HeaderText = "Reserva";
            dgvCaja.Columns[3].HeaderText = "Ingreso";
            dgvCaja.Columns[4].HeaderText = "Egreso";
            dgvCaja.Columns[5].HeaderText = "Comentario";
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarCaja();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCaja.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[0].Value);
                dteFecha.Value = Convert.ToDateTime(dgvCaja.CurrentRow.Cells[1].Value);
                txtReserva.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[2].Value);
                txtIngreso.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[3].Value);
                txtEgreso.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[4].Value);
                txtComentario.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[5].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la caja .");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarCaja();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdCaja.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if ((txtReserva.Text == string.Empty || txtIngreso.Text == string.Empty)|| (txtComentario.Text == string.Empty || dteFecha.Value == null))
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        
                        Rpta = CajaNegocios.Actualizar(Convert.ToInt32(txtIdCaja.Text), dteFecha.Value,Convert.ToDouble(txtReserva.Text), Convert.ToDouble(txtIngreso.Text), Convert.ToDouble(txtEgreso.Text),txtComentario.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Caja actualizada correctamente.");
                            this.ListarCaja();
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
            else
            {

                try
                {
                    string Rpta = "";
                    if ((txtReserva.Text == string.Empty || txtIngreso.Text == string.Empty) || (txtComentario.Text == string.Empty || dteFecha.Value == null))
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        
                        Rpta = CajaNegocios.Insertar(dteFecha.Value, Convert.ToDouble(txtReserva.Text), Convert.ToDouble(txtIngreso.Text), Convert.ToDouble(txtEgreso.Text), txtComentario.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Caja registrada correctamente.");
                            this.ListarCaja();
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
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdCaja.Text != string.Empty)
            {
                string Rpta = "";
                Rpta = CajaNegocios.Eliminar(Convert.ToInt32(txtIdCaja.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Caja eliminada correctamente.");
                    this.ListarCaja();
                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

        private void dgvCaja_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCaja.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[0].Value);
                dteFecha.Value = Convert.ToDateTime(dgvCaja.CurrentRow.Cells[1].Value);
                txtReserva.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[2].Value);
                txtIngreso.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[3].Value);
                txtEgreso.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[4].Value);
                txtComentario.Text = Convert.ToString(dgvCaja.CurrentRow.Cells[5].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la caja .");
            }
        }
    }
}
