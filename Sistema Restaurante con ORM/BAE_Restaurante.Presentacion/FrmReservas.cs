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

namespace BAE_Restaurante.Presentacion
{
    public partial class FrmReservas : Form
    {
        public FrmReservas()
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

        private void FrmReservas_Load(object sender, EventArgs e)
        {
            this.ListarReservas();
            this.TitulosReserva();
            this.ListarMesas();
            
        }

        private void ListarMesas()
        {
            try
            {
                dgvMesas.DataSource = MesaNegocios.Listar();
                this.TitulosMesa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosMesa()
        {
            dgvMesas.Columns[0].Visible = false;
            dgvMesas.Columns[1].Width = 100;
            dgvMesas.Columns[2].Width = 90;
            dgvMesas.Columns[3].Width = 74;
            dgvMesas.Columns[0].HeaderText = "ID";
            dgvMesas.Columns[1].HeaderText = "Código";
            dgvMesas.Columns[2].HeaderText = "En uso";
            dgvMesas.Columns[3].HeaderText = "Asientos";
        }

        private void ListarPedido_Comida()
        {
            try
            {
                dgvMesas.DataSource = MesaNegocios.Listar();
                this.TitulosMesa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarReserva_Mesa()
        {
            try
            {
                dgvReserva_Mesa.DataSource = Reserva_MesaNegocios.Listar();
                this.TitulosReserva_Mesa();
                this.MesasPorReserva();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MesasPorReserva()
        {
            try
            {
                dgvRM.Rows.Clear();
                string mesa = "", reserva = "";
                for (int i = 0; i < dgvReserva_Mesa.RowCount; i++)
                {
                    if (Convert.ToString(dgvReserva_Mesa.Rows[i].Cells[1].Value) == txtIDReserva.Text)
                    {
                        for (int j = 0; j < dgvMesas.RowCount; j++)
                        {
                            if (Convert.ToString(dgvMesas.Rows[j].Cells[0].Value) == Convert.ToString(dgvReserva_Mesa.Rows[i].Cells[0].Value))
                            {
                                mesa = Convert.ToString(dgvMesas.Rows[j].Cells[3].Value);
                                reserva = Convert.ToString(dgvMesas.Rows[j].Cells[1].Value);
                            }
                        }

                        dgvRM.Rows.Add(reserva, mesa);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosReserva_Mesa()
        {
            dgvReserva_Mesa.Columns[0].Visible = false;
            dgvReserva_Mesa.Columns[1].Width = 100;
            dgvReserva_Mesa.Columns[0].HeaderText = "id_reserva";
            dgvReserva_Mesa.Columns[1].HeaderText = "id_mesa";

        }

        private void ListarReservas()
        {
            try
            {
                txtIdCliente.Clear();
                txtCodMesa.Clear();
                txtIDReserva.Clear();
                dgvReservas.DataSource = ReservaNegocios.Listar();
                txtDocumento.Clear();
                txtNombres.Clear();
                txtApellidos.Clear();
                txtInicio.Clear();
                txtFin.Clear();
                dteFecha.Value = Convert.ToDateTime(DateTime.Now.ToShortDateString());
                this.ListarMesas();
                this.ListarReserva_Mesa();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void TitulosReserva()
        {
            dgvReservas.Columns[0].Visible = false;
            dgvReservas.Columns[4].Visible = true;
            dgvReservas.Columns[7].Visible = false;
            dgvReservas.Columns[1].Width = 90;
            dgvReservas.Columns[2].Width = 70;
            dgvReservas.Columns[3].Width = 70;
            dgvReservas.Columns[4].Width = 100;
            dgvReservas.Columns[5].Width = 115;
            dgvReservas.Columns[6].Width = 115;

            dgvReservas.Columns[0].HeaderText = "ID";
            dgvReservas.Columns[1].HeaderText = "Fecha";
            dgvReservas.Columns[2].HeaderText = "Hora Inicio";
            dgvReservas.Columns[3].HeaderText = "Hora Fin";
            dgvReservas.Columns[4].HeaderText = "Documento";
            dgvReservas.Columns[5].HeaderText = "Nombres";
            dgvReservas.Columns[6].HeaderText = "Apellidos";
            dgvReservas.Columns[7].HeaderText = "ID_CLIENTE";
        }

        private void dgvReservas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIdCliente.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[7].Value);
                txtIDReserva.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[0].Value);
                txtDocumento.Text= Convert.ToString(dgvReservas.CurrentRow.Cells[4].Value);
                txtNombres.Text= Convert.ToString(dgvReservas.CurrentRow.Cells[5].Value);
                txtApellidos.Text= Convert.ToString(dgvReservas.CurrentRow.Cells[6].Value);
                dteFecha.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[1].Value);
                txtInicio.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[2].Value);
                txtFin.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[3].Value);
                this.ListarMesas();
                this.ListarReserva_Mesa();


            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la mesa.");
            }
        }

        private void btnDetalleMesa_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdCliente.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[7].Value);
                txtIDReserva.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[0].Value);
                txtDocumento.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[4].Value);
                txtNombres.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[5].Value);
                txtApellidos.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[6].Value);
                dteFecha.Value = Convert.ToDateTime(dgvReservas.CurrentRow.Cells[1].Value);
                txtInicio.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[2].Value);
                txtFin.Text = Convert.ToString(dgvReservas.CurrentRow.Cells[3].Value);
                if (Convert.ToString(dgvReservas.CurrentRow.Cells[6].Value) == "-")
                {
                    cboTipo.SelectedIndex = 1;
                }
                else
                {
                    cboTipo.SelectedIndex = 0;
                }
                this.ListarMesas();
                this.ListarReserva_Mesa();
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione la mesa.");
            }
        }

        private void btnActualizarMesas_Click(object sender, EventArgs e)
        {
            this.ListarReservas();
        }

        private void btnLimpiarMesa_Click(object sender, EventArgs e)
        {
            this.ListarReservas();
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)   //Agregar RESERVA
        {
            if (txtIDReserva.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtInicio.Text == string.Empty || txtFin.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {

                        Rpta = ReservaNegocios.Actualizar(Convert.ToInt32(txtIDReserva.Text), dteFecha.Value,TimeSpan.Parse(txtInicio.Text),TimeSpan.Parse(txtFin.Text),Convert.ToInt32(txtIdCliente.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Reserva actualizada correctamente.");
                            this.ListarMesas();
                            this.ListarReservas();
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
                    if (txtInicio.Text == string.Empty || txtFin.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {

                        Rpta = ReservaNegocios.Insertar(dteFecha.Value, TimeSpan.Parse(txtInicio.Text), TimeSpan.Parse(txtFin.Text), Convert.ToInt32(txtIdCliente.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Reserva registrada correctamente.");
                            this.ListarMesas();
                            this.ListarReservas();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)  //Agregar MESA A RESERVA
        {
            try
            {
                string Rpta = "";
                if (txtCodMesa.Text == string.Empty || txtIdCliente.Text == string.Empty || txtIDReserva.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                }
                else
                {
                    for (int j = 0; j < dgvMesas.RowCount; j++)
                    {
                        if (txtCodMesa.Text == Convert.ToString(dgvMesas.Rows[j].Cells[1].Value))
                        {
                            Rpta = Reserva_MesaNegocios.Insertar(Convert.ToInt32(dgvMesas.Rows[j].Cells[0].Value), Convert.ToInt32(txtIDReserva.Text));
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Mesa agregada correctamente.");
                        this.ListarMesas();
                        this.ListarReservas();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtCodMesa.Text == string.Empty || txtIdCliente.Text == string.Empty || txtIDReserva.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                }
                else
                {
                    for (int j = 0; j < dgvMesas.RowCount; j++)
                    {
                        if (txtCodMesa.Text == Convert.ToString(dgvMesas.Rows[j].Cells[1].Value))
                        {
                            Rpta = Reserva_MesaNegocios.Eliminar(Convert.ToInt32(dgvMesas.Rows[j].Cells[0].Value), Convert.ToInt32(txtIDReserva.Text));
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Mesa eliminada correctamente.");
                        this.ListarMesas();
                        this.ListarReservas();
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

        private void button1_Click(object sender, EventArgs e)
        {
            string Rpta = "";
            Rpta = ReservaNegocios.Eliminar(Convert.ToInt32(txtIDReserva.Text));

            if (Rpta.Equals("OK"))
            {
                this.MensajeCorrecto("Mesa eliminada correctamente.");
                this.ListarMesas();
                this.ListarReservas();
            }
            else
            {
                this.MensajeError(Rpta);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                lblNombres.Text = "Nombres";
                lblApellidos.Visible = true;
                txtApellidos.Visible = true;

            }
            else
            {
                lblNombres.Text = "Razón Social";
                lblApellidos.Visible = false;
                txtApellidos.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cboTipo.SelectedIndex == 0)
            {
                try
                {
                    var dni = txtDocumento.Text;
                    var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImFuY29icmlhbjZAZ21haWwuY29tIn0.PTLq2kMGMK3A5XTbdmRAUMDLRn3f5eS2eMF1TV0CtLM";
                    WebClient wc = new WebClient();

                    var json = wc.DownloadString("https://dniruc.apisperu.com/api/v1/dni/" + dni + "?token=" + token);
                    var person = JObject.Parse(json);

                    zdni ObjPersona = JsonConvert.DeserializeObject<zdni>(json);
                    txtDocumento.Text = ObjPersona.dni;
                    txtNombres.Text = ObjPersona.nombres;
                    txtApellidos.Text = ObjPersona.apellidoPaterno + " " + ObjPersona.apellidoMaterno;

                    //dgvClientes.Rows.Clear();
                    dgvClientes.DataSource = ClienteNegocios.Listar();

                    for (int j = 0; j < dgvClientes.RowCount; j++)
                    {
                        if (txtDocumento.Text == Convert.ToString(dgvClientes.Rows[j].Cells[1].Value))
                        {
                            txtIdCliente.Text = Convert.ToString(dgvClientes.Rows[j].Cells[0].Value);
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
                    var ruc = txtDocumento.Text;
                    var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJlbWFpbCI6ImFuY29icmlhbjZAZ21haWwuY29tIn0.PTLq2kMGMK3A5XTbdmRAUMDLRn3f5eS2eMF1TV0CtLM";
                    WebClient wc = new WebClient();

                    var json = wc.DownloadString("https://dniruc.apisperu.com/api/v1/ruc/" + ruc + "?token=" + token);
                    var person = JObject.Parse(json);

                    zruc ObjPersona = JsonConvert.DeserializeObject<zruc>(json);
                    txtDocumento.Text = ObjPersona.ruc;
                    txtNombres.Text = ObjPersona.razonSocial;

                    //dgvClientes.Rows.Clear();
                    dgvClientes.DataSource = ClienteNegocios.Listar();

                    for (int j = 0; j < dgvClientes.RowCount; j++)
                    {
                        if (txtDocumento.Text == Convert.ToString(dgvClientes.Rows[j].Cells[1].Value))
                        {
                            txtIdCliente.Text = Convert.ToString(dgvClientes.Rows[j].Cells[0].Value);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }


    }
}
