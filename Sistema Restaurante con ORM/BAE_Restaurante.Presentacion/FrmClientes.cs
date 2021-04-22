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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            this.ListarClientes();
            cboTipo.SelectedIndex = 0;
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarClientes()
        {
            // LISTAR CON LINQ - ORM
            using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
            {
                var lst = from d in db.Cliente
                          select new {d.id_cliente, d.num_documento, d.tipo_documento, d.nombres, d.apellidos, d.direccion, d.celular };
                
                dgvEmpleados.DataSource = lst.ToList();
            }
            txtDNI.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtTipo.Clear();
            txtDireccion.Clear();
            txtCelular.Clear();
            txtIdCliente.Clear();
            this.TitulosClientes();

            /* PROCEDIMIENTO SIN ORM
            try
            {
                dgvEmpleados.DataSource = ClienteNegocios.Listar();             
                txtDNI.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
                txtTipo.Clear();
                txtDireccion.Clear();
                txtCelular.Clear();
                txtIdCliente.Clear();
                this.TitulosClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            */
        }

        private void TitulosClientes()
        {
            
            dgvEmpleados.Columns[0].Visible = false;
            dgvEmpleados.Columns[1].Width = 100;
            dgvEmpleados.Columns[2].Width = 100;
            dgvEmpleados.Columns[3].Width = 100;
            dgvEmpleados.Columns[3].Width = 200;
            dgvEmpleados.Columns[4].Width = 150;
            dgvEmpleados.Columns[5].Width = 250;
            dgvEmpleados.Columns[6].Width = 80;

            dgvEmpleados.Columns[0].HeaderText = "ID";
            dgvEmpleados.Columns[1].HeaderText = "Nro. Doc.";
            dgvEmpleados.Columns[2].HeaderText = "Tipo Doc.";
            dgvEmpleados.Columns[3].HeaderText = "Nombres";
            dgvEmpleados.Columns[4].HeaderText = "Apellidos";
            dgvEmpleados.Columns[5].HeaderText = "Direccion";
            dgvEmpleados.Columns[6].HeaderText = "Celular";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarClientes();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            txtIdCliente.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[0].Value);
            txtDNI.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[1].Value);
            txtTipo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[2].Value);
            txtNombres.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[3].Value);
            txtApellidos.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[5].Value);
            txtCelular.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[6].Value);
            if (txtTipo.Text == "DNI")
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
                txtDireccion.ReadOnly = false;

            }
            else
            {
                lblNombres.Text = "Razón Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
                txtDireccion.ReadOnly = true;
            }
            cboTipo.Text = txtTipo.Text;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdCliente.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombres.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        txtTipo.Text = cboTipo.Text;

                        // ACTUALIZAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Cliente iCliente = new Cliente();
                            iCliente.id_cliente = Convert.ToInt32(txtIdCliente.Text);
                            iCliente.num_documento = txtDNI.Text;
                            iCliente.tipo_documento = txtTipo.Text;
                            iCliente.nombres = txtNombres.Text;
                            iCliente.apellidos = txtApellidos.Text;
                            iCliente.direccion = txtDireccion.Text;
                            iCliente.celular = txtCelular.Text;
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        this.MensajeCorrecto("Cliente modificado correctamente.");
                        this.ListarClientes();

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = ClienteNegocios.Actualizar(Convert.ToInt32(txtIdCliente.Text),txtDNI.Text,txtTipo.Text,txtNombres.Text,txtApellidos.Text,txtDireccion.Text,txtCelular.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Cliente actualizado correctamente.");
                            this.ListarClientes();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }*/

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
                    if (txtNombres.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        if (txtApellidos.Text == "")
                        {
                            txtApellidos.Text = "-";
                        }
                        txtTipo.Text = cboTipo.Text;

                        // INSERTAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Cliente iCliente = new Cliente();
                            iCliente.num_documento = txtDNI.Text;
                            iCliente.tipo_documento = txtTipo.Text;
                            iCliente.nombres = txtNombres.Text;
                            iCliente.apellidos = txtApellidos.Text;
                            iCliente.direccion = txtDireccion.Text;
                            iCliente.celular = txtCelular.Text;
                            db.Cliente.Add(iCliente);
                            db.SaveChanges();

                        }
                        this.MensajeCorrecto("Cliente agregado correctamente.");
                        this.ListarClientes();

                        /* PROCEDIMIENTO SIN ORM
                         * 
                         * Rpta = ClienteNegocios.Insertar(txtDNI.Text, txtTipo.Text, txtNombres.Text, txtApellidos.Text, txtDireccion.Text, txtCelular.Text);
                        
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Cliente agregado correctamente.");
                            this.ListarClientes();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }*/

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
            if (txtIdCliente.Text != string.Empty)
            {
                // ELIMINAR CON LINQ - ORM
                using(BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    Cliente iCliente = db.Cliente.Find(Convert.ToInt32(txtIdCliente.Text));
                    db.Cliente.Remove(iCliente);
                    db.SaveChanges();
                }

                this.MensajeCorrecto("Cliente eliminado correctamente.");
                this.ListarClientes();
                /* PROCEDIMIENTO SIN ORM
                string Rpta = "";
                Rpta = ClienteNegocios.Eliminar(Convert.ToInt32(txtIdCliente.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Cliente eliminado correctamente.");
                    this.ListarClientes();
                }
                else
                {
                    this.MensajeError(Rpta);
                }*/
            }
        }

        private void lblApellidos_Click(object sender, EventArgs e)
        {

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
                txtDireccion.ReadOnly = false;
                txtNombres.ReadOnly = true;

            }
            else if (cboTipo.SelectedIndex == 1) 
            {
                lblNombres.Text = "Razón Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
                txtDireccion.ReadOnly = true;
                txtNombres.ReadOnly = true;
                txtDireccion.ReadOnly = true;
            }
            else if (cboTipo.SelectedIndex == 2)
            {
                txtNombres.ReadOnly = false;
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
                txtDireccion.ReadOnly = false;
                lblNombres.Text = "Razón Social";
            }
            txtTipo.Text = cboTipo.Text;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
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
            else
            {
                try
                {
                    var ruc = txtDNI.Text;
                    var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImFuY29icmlhbjZAZ21haWwuY29tIn0.PTLq2kMGMK3A5XTbdmRAUMDLRn3f5eS2eMF1TV0CtLM";
                    WebClient wc = new WebClient();

                    var json = wc.DownloadString("https://dniruc.apisperu.com/api/v1/ruc/" + ruc + "?token=" + token);
                    var person = JObject.Parse(json);

                    zruc ObjPersona = JsonConvert.DeserializeObject<zruc>(json);
                    txtDNI.Text = ObjPersona.ruc;
                    txtNombres.Text = ObjPersona.razonSocial;
                    txtDireccion.Text = ObjPersona.direccion + " - " + ObjPersona.departamento + ", " + ObjPersona.provincia + ", " + ObjPersona.distrito;
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
        }
        }

        private void dgvEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdCliente.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[0].Value);
            txtDNI.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[1].Value);
            txtTipo.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[2].Value);
            txtNombres.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[3].Value);
            txtApellidos.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[4].Value);
            txtDireccion.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[5].Value);
            txtCelular.Text = Convert.ToString(dgvEmpleados.CurrentRow.Cells[6].Value);
            if (txtTipo.Text == "DNI")
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;
                txtDireccion.ReadOnly = false;

            }
            else
            {
                lblNombres.Text = "Razón Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
                txtDireccion.ReadOnly = true;
            }
            cboTipo.Text = txtTipo.Text;
        }
    }
}
