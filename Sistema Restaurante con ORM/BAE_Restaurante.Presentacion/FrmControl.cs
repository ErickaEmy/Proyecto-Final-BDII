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
    public partial class FrmControl : Form
    {
        public FrmControl()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ListarControl()
        {
            try
            {
                DateTime hoy = DateTime.Today;
                dgvControl.DataSource = ControlNegocios.Listar();
                txtInicio.Clear();
                txtFin.Clear();
                txtIdControl.Clear();
                txtIdEmpleado.Clear();
                dteFecha.Value = hoy;
                chkFalta.Checked = false;
                this.TitulosControl();
                this.ListarEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosControl()
        {
            dgvControl.Columns[0].Visible = false;
            dgvControl.Columns[7].Visible = false;
            dgvControl.Columns[1].Width = 80;
            dgvControl.Columns[2].Width = 100;
            dgvControl.Columns[3].Width = 100;
            dgvControl.Columns[4].Width = 100;
            dgvControl.Columns[5].Width = 150;

            dgvControl.Columns[0].HeaderText = "ID";
            dgvControl.Columns[1].HeaderText = "Fecha";
            dgvControl.Columns[2].HeaderText = "Hora inicio";
            dgvControl.Columns[3].HeaderText = "Hora fin";
            dgvControl.Columns[4].HeaderText = "Falta";
            dgvControl.Columns[5].HeaderText = "Nombres";
            dgvControl.Columns[6].HeaderText = "Apellidos";
            dgvControl.Columns[7].HeaderText = "ID Empleado";
        }

        private void FrmControl_Load(object sender, EventArgs e)
        {
            this.ListarControl();
        }

        private void ListarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = EmpleadoNegocios.Listar();
                cboEmpleado.Items.Clear();
                for (int i = 0; i < dgvEmpleados.RowCount; i++)
                {
                    cboEmpleado.Items.Add(Convert.ToString(dgvEmpleados.Rows[i].Cells[2].Value) + " " + Convert.ToString(dgvEmpleados.Rows[i].Cells[3].Value));
                }
                cboEmpleado.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvEmpleados.RowCount; i++)
                {
                    if (cboEmpleado.Text == Convert.ToString(dgvEmpleados.Rows[i].Cells[2].Value) + " " + Convert.ToString(dgvEmpleados.Rows[i].Cells[3].Value))
                    {
                        txtIdEmpleado.Text = Convert.ToString(dgvEmpleados.Rows[i].Cells[0].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdControl.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (((txtInicio.Text == string.Empty || txtFin.Text == string.Empty) || (dteFecha.Value == null)) || txtIdEmpleado.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "false";
                        if (chkFalta.Checked == true)
                        {
                            estado = "true";
                        }
                        else
                        {
                            estado = "false";
                        }
                        Rpta = ControlNegocios.Actualizar(Convert.ToInt32(txtIdControl.Text), dteFecha.Value, TimeSpan.Parse(txtInicio.Text), TimeSpan.Parse(txtFin.Text), estado, Convert.ToInt32(txtIdEmpleado.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Control actualizado correctamente.");
                            this.ListarControl();
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
                    if (((txtInicio.Text == string.Empty || txtFin.Text == string.Empty) || (dteFecha.Value == null)) || txtIdEmpleado.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "false";
                        if (chkFalta.Checked == true)
                        {
                            estado = "true";
                        }
                        else
                        {
                            estado = "false";
                        }

                        Rpta = ControlNegocios.Insertar(dteFecha.Value, TimeSpan.Parse(txtInicio.Text), TimeSpan.Parse(txtFin.Text), estado, Convert.ToInt32(txtIdEmpleado.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Control registrado correctamente.");
                            this.ListarControl();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarControl();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdControl.Text = Convert.ToString(dgvControl.CurrentRow.Cells[0].Value);
                txtInicio.Text = Convert.ToString(dgvControl.CurrentRow.Cells[2].Value);
                txtFin.Text = Convert.ToString(dgvControl.CurrentRow.Cells[3].Value);
                dteFecha.Value = Convert.ToDateTime(dgvControl.CurrentRow.Cells[1].Value);
                string Estado = "";

                if (Convert.ToBoolean(dgvControl.CurrentRow.Cells[4].Value) == true)
                {
                    chkFalta.Checked = true;
                }
                else
                {
                    chkFalta.Checked = false;
                }
                cboEmpleado.Text = Convert.ToString(dgvControl.CurrentRow.Cells[5].Value) + " " + Convert.ToString(dgvControl.CurrentRow.Cells[6].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el control.");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarControl();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdControl.Text != string.Empty)
            {
                string Rpta = "";
                Rpta = ControlNegocios.Eliminar(Convert.ToInt32(txtIdControl.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Control eliminado correctamente.");
                    this.ListarControl();
                }
                else
                {
                    this.MensajeError(Rpta);
                }
            }
        }

    }
}
