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
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using BAE_Restaurante.Entidad.Modelos;

namespace BAE_Restaurante.Presentacion
{

    public partial class FrmEmpleados : Form
    {
        public FrmEmpleados()
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

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            this.ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            try
            {
                cboCargo.Items.Clear();
                dgvEmpleados.DataSource = EmpleadoNegocios.Listar();
                dgvCargos.DataSource = CargoNegocios.Listar();
                txtDNI.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
                txtEmail.Clear();
                txtDireccion.Clear();
                txtCelular.Clear();
                txtIdCargo.Clear();
                txtIdEmpleado.Clear();
                checkBox1.Checked = false;
                this.TitulosEmpleados();
                for (int i = 0; i < dgvCargos.RowCount; i++)
                {
                    cboCargo.Items.Add(Convert.ToString(dgvCargos.Rows[i].Cells[1].Value));
                }
                cboCargo.SelectedIndex = 0;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosEmpleados()
        {
            dgvEmpleados.Columns[0].Visible = false;
            dgvEmpleados.Columns[10].Visible = false;
            dgvEmpleados.Columns[1].Width = 80;
            dgvEmpleados.Columns[2].Width = 150;
            dgvEmpleados.Columns[3].Width = 150;
            dgvEmpleados.Columns[4].Width = 70;
            dgvEmpleados.Columns[5].Width = 200;
            dgvEmpleados.Columns[6].Width = 80;
            dgvEmpleados.Columns[7].Width = 150;
            dgvEmpleados.Columns[8].Width = 60;
            dgvEmpleados.Columns[9].Width = 100;
            dgvEmpleados.Columns[10].Width = 80;
            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[9].HeaderText = "id_cargo";
            dgvEmpleados.Columns[1].HeaderText = "DNI";
            dgvEmpleados.Columns[2].HeaderText = "Nombres";
            dgvEmpleados.Columns[3].HeaderText = "Apellidos";
            dgvEmpleados.Columns[4].HeaderText = "Fecha de Nacimiento";
            dgvEmpleados.Columns[5].HeaderText = "Dirección";
            dgvEmpleados.Columns[6].HeaderText = "Celular";
            dgvEmpleados.Columns[7].HeaderText = "Email";
            dgvEmpleados.Columns[8].HeaderText = "Activo";
            dgvEmpleados.Columns[9].HeaderText = "Cargo";
            dgvEmpleados.Columns[10].HeaderText = "idCargo";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarEmpleados();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                string Estado = "";
                cboCargo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[9].Value);
                txtIdEmpleado.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[0].Value);
                txtDNI.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[1].Value);
                txtNombres.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[2].Value);
                txtApellidos.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[5].Value);
                txtCelular.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[6].Value);
                txtEmail.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[7].Value);
                dteFecha.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[4].Value);
                txtIdCargo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[10].Value);
                if (Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells[8].Value) == true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la mesa.");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarEmpleados();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdEmpleado.Text != string.Empty)
            {
                try
                {
                    for (int i = 0; i < dgvCargos.RowCount; i++)
                    {
                        if (cboCargo.Text == (Convert.ToString(dgvCargos.Rows[i].Cells[1].Value)))
                        {
                            txtIdCargo.Text = (Convert.ToString(dgvCargos.Rows[i].Cells[0].Value));
                        }
                    }
                    string Rpta = "";
                    if (txtNombres.Text == string.Empty || txtApellidos.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "false";
                        bool es = true;
                        if (checkBox1.Checked == true)
                        {
                            estado = "true";
                            es = true;
                        }
                        else
                        {
                            estado = "false";
                            es = false;
                        }

                        // ACTUALIZAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Empleado iCliente = new Empleado();
                            iCliente.id_empleado = Convert.ToInt32(txtIdEmpleado.Text);
                            iCliente.dni = txtDNI.Text;
                            iCliente.nombres = txtNombres.Text;
                            iCliente.apellidos = txtApellidos.Text;
                            iCliente.fecha_nacimiento = dteFecha.Value;
                            iCliente.direccion = txtDireccion.Text;
                            iCliente.celular = txtCelular.Text;
                            iCliente.email = txtEmail.Text;
                            iCliente.estado = es;
                            iCliente.id_cargo = Convert.ToInt32(txtIdCargo.Text);
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = EmpleadoNegocios.Actualizar(Convert.ToInt32(txtIdEmpleado.Text), txtDNI.Text, txtNombres.Text, txtApellidos.Text, dteFecha.Value, txtDireccion.Text, txtCelular.Text, txtEmail.Text, estado, Convert.ToInt32(txtIdCargo.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Empleado actualizado correctamente.");
                            this.ListarEmpleados();
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
                    for (int i = 0; i < dgvCargos.RowCount; i++)
                    {
                        if(cboCargo.Text== (Convert.ToString(dgvCargos.Rows[i].Cells[1].Value)))
                        {
                            txtIdCargo.Text = (Convert.ToString(dgvCargos.Rows[i].Cells[0].Value));
                        }
                    }
                    string Rpta = "";
                    if (txtNombres.Text == string.Empty || txtApellidos.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "false";
                        bool es = true;
                        if (checkBox1.Checked == true)
                        {
                            estado = "true";
                            es = true;
                        }
                        else
                        {
                            estado = "false";
                            es = false;
                        }

                        // INSERTAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Empleado iCliente = new Empleado();
                            iCliente.dni = txtDNI.Text;
                            iCliente.nombres = txtNombres.Text;
                            iCliente.apellidos = txtApellidos.Text;
                            iCliente.fecha_nacimiento = dteFecha.Value;
                            iCliente.direccion = txtDireccion.Text;
                            iCliente.celular = txtCelular.Text;
                            iCliente.email = txtEmail.Text;
                            iCliente.estado = es;
                            iCliente.id_cargo = Convert.ToInt32(txtIdCargo.Text);
                            db.Empleado.Add(iCliente);
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = EmpleadoNegocios.Insertar(txtDNI.Text, txtNombres.Text, txtApellidos.Text, dteFecha.Value, txtDireccion.Text, txtCelular.Text, txtEmail.Text, estado, Convert.ToInt32(txtIdCargo.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Empleado agregado correctamente.");
                            this.ListarEmpleados();
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
            if (txtIdEmpleado.Text != string.Empty)
            {
                // ELIMINAR CON LINQ - ORM
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    Empleado iCliente = db.Empleado.Find(Convert.ToInt32(txtIdEmpleado.Text));
                    db.Empleado.Remove(iCliente);
                    db.SaveChanges();
                }
                this.MensajeCorrecto("Empleado eliminado correctamente.");
                this.ListarEmpleados();

                /*PROCEDIMIENTO SIN ORM
                string Rpta = "";
                Rpta = EmpleadoNegocios.Eliminar(Convert.ToInt32(txtIdEmpleado.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Empleado eliminado correctamente.");
                    this.ListarEmpleados();
                }
                else
                {
                    this.MensajeError(Rpta);
                }*/
            }
        }

        private void btnDNI_Click(object sender, EventArgs e)
        {
            try
            {
                var dni = txtDNI.Text;
                var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImFuY29icmlhbjZAZ21haWwuY29tIn0.PTLq2kMGMK3A5XTbdmRAUMDLRn3f5eS2eMF1TV0CtLM";
                WebClient wc = new WebClient();

                var json = wc.DownloadString("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=" + token);
                var person = JObject.Parse(json);

                zdni ObjPersona = JsonConvert.DeserializeObject<zdni>(json);
                txtDNI.Text = ObjPersona.dni;
                txtNombres.Text = ObjPersona.nombres;
                txtApellidos.Text = ObjPersona.apellidoPaterno + " " + ObjPersona.apellidoMaterno;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
              if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Estado = "";
                cboCargo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[9].Value);
                txtIdEmpleado.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[0].Value);
                txtDNI.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[1].Value);
                txtNombres.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[2].Value);
                txtApellidos.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[3].Value);
                txtDireccion.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[5].Value);
                txtCelular.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[6].Value);
                txtEmail.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[7].Value);
                dteFecha.Value = Convert.ToDateTime(dgvEmpleados.CurrentRow.Cells[4].Value);
                txtIdCargo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[10].Value);
                if (Convert.ToBoolean(dgvEmpleados.CurrentRow.Cells[8].Value) == true)
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la mesa.");
            }
        }

        private void cboCargo_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
