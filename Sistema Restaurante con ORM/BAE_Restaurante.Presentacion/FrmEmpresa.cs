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
    public partial class FrmEmpresa : Form
    {
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.ListarEmpresa();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarEmpresa()
        {
            try
            {
                dgvEmpresa.DataSource = EmpresaNegocios.Listar();
                txtCaracteristica.Clear();
                txtDescripcion.Clear();
                txtIdEmpresa.Clear();
                dgvEmpresa.Columns[0].Visible = false;
                dgvEmpresa.Columns[1].Width = 120;
                dgvEmpresa.Columns[2].Width = 200;
                dgvEmpresa.Columns[1].HeaderText = "Característica";
                dgvEmpresa.Columns[2].HeaderText = "Descripción";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarEmpresa();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarEmpresa();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            txtCaracteristica.Text = Convert.ToString(dgvEmpresa.CurrentRow.Cells[1].Value);
            txtDescripcion.Text = Convert.ToString(dgvEmpresa.CurrentRow.Cells[2].Value);
            txtIdEmpresa.Text = Convert.ToString(dgvEmpresa.CurrentRow.Cells[0].Value);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpresa.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtCaracteristica.Text == string.Empty || txtDescripcion.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        Rpta = EmpresaNegocios.Actualizar(Convert.ToInt32(txtIdEmpresa.Text), Convert.ToString(txtCaracteristica.Text), Convert.ToString(txtDescripcion.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Característica actualizada correctamente.");
                            this.ListarEmpresa();
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
                    if (txtCaracteristica.Text == string.Empty || txtDescripcion.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        Rpta = EmpresaNegocios.Insertar(txtCaracteristica.Text.Trim(), Convert.ToString(txtDescripcion.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Catacterística registrada correctamente.");
                            this.ListarEmpresa();
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
            if (txtIdEmpresa.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    Rpta = EmpresaNegocios.Eliminar(Convert.ToInt32(txtIdEmpresa.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Característica eliminada correctamente.");
                        this.ListarEmpresa();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }
    }
}
