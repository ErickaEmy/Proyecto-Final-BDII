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
    public partial class FrmPedidos : Form
    {
        public FrmPedidos()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarMesas()
        {
            try
            {
                cboMesa.Items.Clear();
                dgvMesas.DataSource = MesaNegocios.ListarDisponibles();
                dgvTodasLasMesas.DataSource = MesaNegocios.Listar();
                this.TitulosMesa();
                for (int j = 0; j < dgvMesas.RowCount; j++)
                {
                    cboMesa.Items.Add(Convert.ToString(dgvMesas.Rows[j].Cells[1].Value));
                }
                cboMesa.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarPedidos()
        {
            try
            {
                dgvPedidos.DataSource = PedidoNegocios.ListarActivos();
                dgvClientes.DataSource = ClienteNegocios.Listar();
                this.TitulosPedido();
                this.ListarEmpleados();
                this.Listar();
                dteFecha.Value = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
                cboTipoPedido.SelectedIndex = 0;
                cboTipoPago.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;
                cboMesa.SelectedIndex = 0;
                cboEmpleado.SelectedIndex = 0;
                txtDireccion.Clear();
                txtComentario.Clear();
                txtDocCliente.Clear();
                txtNomCliente.Clear();
                btnVenta.Text = "Generar Boleta";
                if (txtNomCliente.Text == "")
                {
                    btnVenta.Visible = false;
                }
                else
                {
                    btnVenta.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarPedidos2()
        {
            try
            {
                dgvPedidos.DataSource = PedidoNegocios.Listar();
                dgvClientes.DataSource = ClienteNegocios.Listar();
                this.TitulosPedido();
                this.ListarEmpleados();
                this.Listar();
                dteFecha.Value = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
                cboTipoPedido.SelectedIndex = 0;
                cboTipoPago.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;
                cboMesa.SelectedIndex = 0;
                cboEmpleado.SelectedIndex = 0;
                txtDireccion.Clear();
                txtComentario.Clear();
                txtDocCliente.Clear();
                txtNomCliente.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void ListarEmpleados()
        {
            try
            {
                dgvEmpleados.DataSource = EmpleadoNegocios.Listar();
                this.Listar();
                cboTipoPedido.SelectedIndex = 0;
                cboEmpleado.Items.Clear();
                for (int i = 0; i < dgvEmpleados.RowCount; i++)
                {
                    cboEmpleado.Items.Add(Convert.ToString(dgvEmpleados.Rows[i].Cells[2].Value) + " " + Convert.ToString(dgvEmpleados.Rows[i].Cells[3].Value));
                }
                cboEmpleado.SelectedIndex = 0;
                cboTipoPago.SelectedIndex = 0;
                cboEstado.SelectedIndex = 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Listar()
        {
            dgvPedido_Comida.DataSource = Pedido_ComidaNegocios.Listar();
            dgvPedido_Producto.DataSource = Pedido_ProductoNegocios.Listar();
            dgvComida.DataSource = ComidaNegocios.Listar();
            dgvProducto.DataSource = ProductoNegocios.Listar();
            cboComida.Items.Clear();
            for (int i = 0; i < dgvComida.RowCount; i++)
            {
                cboComida.Items.Add(Convert.ToString(dgvComida.Rows[i].Cells[1].Value));
            }
            cboProducto.Items.Clear();
            for (int i = 0; i < dgvProducto.RowCount; i++)
            {
                cboProducto.Items.Add(Convert.ToString(dgvProducto.Rows[i].Cells[0].Value)+" "+ Convert.ToString(dgvProducto.Rows[i].Cells[4].Value)+ Convert.ToString(dgvProducto.Rows[i].Cells[5].Value));
            }
            cboComida.SelectedIndex = 0;
            cboProducto.SelectedIndex = 0;
        }

        private void ListarComidaProducto()
        {
            try
            {
                dgvComida_Producto.Rows.Clear();
                string comida = "", cantidad = "";
                for (int i = 0; i < dgvPedido_Comida.RowCount; i++)
                {
                    if (Convert.ToString(dgvPedido_Comida.Rows[i].Cells[0].Value) == txtIdPedido.Text)
                    {
                        for (int j = 0; j < dgvComida.RowCount; j++)
                        {
                            if (Convert.ToString(dgvComida.Rows[j].Cells[0].Value) == Convert.ToString(dgvPedido_Comida.Rows[i].Cells[1].Value))
                            {
                                comida = Convert.ToString(dgvComida.Rows[j].Cells[1].Value);
                                cantidad = Convert.ToString(dgvPedido_Comida.Rows[i].Cells[2].Value);
                            }
                        }

                        dgvComida_Producto.Rows.Add(comida, "Comida",cantidad);
                    }
                }

                for (int i = 0; i < dgvPedido_Producto.RowCount; i++)
                {
                    if (Convert.ToString(dgvPedido_Producto.Rows[i].Cells[0].Value) == txtIdPedido.Text)
                    {
                        for (int j = 0; j < dgvProducto.RowCount; j++)
                        {
                            if (Convert.ToString(dgvProducto.Rows[j].Cells[10].Value) == Convert.ToString(dgvPedido_Producto.Rows[i].Cells[1].Value))
                            {
                                comida = Convert.ToString(dgvProducto.Rows[j].Cells[0].Value + " " + Convert.ToString(dgvProducto.Rows[j].Cells[4].Value) + Convert.ToString(dgvProducto.Rows[j].Cells[5].Value));
                                cantidad = Convert.ToString(dgvPedido_Producto.Rows[i].Cells[2].Value);
                            }
                        }
                        dgvComida_Producto.Rows.Add(comida, "Producto",cantidad);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosMesa()
        {
            dgvMesas.Columns[0].Visible = false;
            dgvMesas.Columns[2].Visible = false;
            dgvMesas.Columns[1].Width = 100;
            dgvMesas.Columns[2].Width = 90;
            dgvMesas.Columns[3].Width = 73;
            dgvMesas.Columns[0].HeaderText = "ID";
            dgvMesas.Columns[1].HeaderText = "Código";
            dgvMesas.Columns[2].HeaderText = "En uso";
            dgvMesas.Columns[3].HeaderText = "Asientos";
        }

        private void TitulosPedido()
        {
            dgvPedidos.Columns[0].Visible = false;
            dgvPedidos.Columns[4].Visible = false;
            dgvPedidos.Columns[6].Visible = false;
            dgvPedidos.Columns[7].Visible = true;
            dgvPedidos.Columns[8].Visible = false;
            dgvPedidos.Columns[9].Visible = false;
            dgvPedidos.Columns[10].Visible = false;
            dgvPedidos.Columns[11].Visible = false;
            dgvPedidos.Columns[12].Visible = false;
            dgvPedidos.Columns[14].Visible = false;
            dgvPedidos.Columns[15].Visible = false;
            dgvPedidos.Columns[16].Visible = false;
            dgvPedidos.Columns[1].Width = 80;
            dgvPedidos.Columns[2].Width = 80;
            dgvPedidos.Columns[3].Width = 110;
            dgvPedidos.Columns[5].Width = 60;
            dgvPedidos.Columns[7].Width = 133;
            dgvPedidos.Columns[13].Width = 58;
            dgvPedidos.Columns[0].HeaderText = "id_pedido";
            dgvPedidos.Columns[1].HeaderText = "Fecha";
            dgvPedidos.Columns[2].HeaderText = "Tipo";
            dgvPedidos.Columns[3].HeaderText = "Pago";
            dgvPedidos.Columns[4].HeaderText = "Imagen";
            dgvPedidos.Columns[5].HeaderText = "Estado";
            dgvPedidos.Columns[6].HeaderText = "Direccion";
            dgvPedidos.Columns[7].HeaderText = "Comentario";
            dgvPedidos.Columns[8].HeaderText = "Nombre Empleado";
            dgvPedidos.Columns[9].HeaderText = "Apellido Empleado";
            dgvPedidos.Columns[10].HeaderText = "Doc. Cliente";
            dgvPedidos.Columns[11].HeaderText = "Nombre Cliente";
            dgvPedidos.Columns[12].HeaderText = "Apellido Cliente";
            dgvPedidos.Columns[13].HeaderText = "Mesa";
            dgvPedidos.Columns[14].HeaderText = "id_cliente";
            dgvPedidos.Columns[15].HeaderText = "id_empleado";
            dgvPedidos.Columns[16].HeaderText = "id_mesa";
        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            ListarMesas();
            this.ListarPedidos();
            
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {

           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizarMesas_Click(object sender, EventArgs e)
        {
            this.ListarMesas();
        }

        private void btnDetalleMesa_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLimpiarMesa_Click(object sender, EventArgs e)
        {
            this.ListarMesas();
        }

        private void dgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtAsientos_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAsientos_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtIdMesa.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    Rpta = MesaNegocios.Eliminar(Convert.ToInt32(txtIdMesa.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Mesa eliminada correctamente.");
                        this.ListarMesas();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarPedidos();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ListarPedidos();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int encontrar = 0;
            for (int i = 0; i < dgvMesas.RowCount; i++)
            {
                if(Convert.ToString(dgvPedidos.CurrentRow.Cells[13].Value)== Convert.ToString(dgvMesas.Rows[i].Cells[1].Value))
                {
                    encontrar = 1;
                }
            }
            if (encontrar == 0)
            {
                this.ListarMesas();
                cboMesa.Items.Add(Convert.ToString(dgvPedidos.CurrentRow.Cells[13].Value));
            }
            else
            {
                this.ListarMesas();
            }
            txtIdPedido.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[0].Value);
            dteFecha.Value = Convert.ToDateTime(dgvPedidos.CurrentRow.Cells[1].Value);
            txtDireccion.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[6].Value);
            cboTipoPedido.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[2].Value);
            cboTipoPago.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[3].Value);
            txtComentario.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[7].Value);

            if (Convert.ToString(dgvPedidos.CurrentRow.Cells[5].Value) == "A")
            {
                cboEstado.Text = "Activo";
                btnVenta.Text = "Generar Boleta";
                btnGuardar.Enabled = true;
            }
            else
            {
                cboEstado.Text = "Finalizado";
                btnVenta.Text = "Ver Boleta";
                btnGuardar.Enabled = false;
            }
            btnVenta.Visible = true;
            txtIdEmpleado.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[15].Value);
            txtIdCliente.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[14].Value);
            txtIdPMesa.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[16].Value);
            txtDocCliente.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[10].Value);
            cboMesa.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[13].Value);
            cboEmpleado.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[8].Value) + " " + Convert.ToString(dgvPedidos.CurrentRow.Cells[9].Value);
            txtNomCliente.Text = Convert.ToString(dgvPedidos.CurrentRow.Cells[11].Value) + " " + Convert.ToString(dgvPedidos.CurrentRow.Cells[12].Value);
            if (cboTipoPedido.Text == "Mesa")
            {
                lblDireccion.Visible = false;
                txtDireccion.Visible = false;
            }
            else
            {
                lblDireccion.Visible = true;
                txtDireccion.Visible = true;
            }
            if (cboEstado.Text == "Finalizado")
            {
                btnAgregarComida.Enabled = false;
                btnQuitarComida.Enabled = false;
                btnAgregarProducto.Enabled = false;
                btnQuitarProducto.Enabled = false;
            }
            else
            {
                btnAgregarComida.Enabled = true;
                btnQuitarComida.Enabled = true;
                btnAgregarProducto.Enabled = true;
                btnQuitarProducto.Enabled = true;
            }
            this.ListarComidaProducto();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdPedido.Text == string.Empty || txtiProducto.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                }
                else
                {

                    Rpta = Pedido_ProductoNegocios.Insertar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiProducto.Text),1);

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Producto agregado correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtIdPedido.Text == string.Empty || txtiComida.Text == string.Empty)
                {
                    this.MensajeError("Ingrese los datos requeridos.");
                }
                else
                {

                    Rpta = Pedido_ComidaNegocios.Insertar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiComida.Text), 1);

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Comida agregada correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
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

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            if (txtIdPedido.Text != string.Empty)
            {
                if (cboEstado.Text == "Finalizado")
                {
                    //VOLVER A ACTIVAR MESA
                    try
                    {
                        string idmesa = "";
                        string codmesa = "";
                        string asientos = "";

                        for (int i = 0; i < dgvPedidos.RowCount; i++)
                        {
                            if (txtIdPedido.Text == Convert.ToString(dgvPedidos.Rows[i].Cells[0].Value))
                            {
                                idmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[16].Value);
                                codmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[13].Value);
                            }
                        }
                        for (int i = 0; i < dgvTodasLasMesas.RowCount; i++)
                        {
                            if (idmesa == Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[0].Value))
                            {
                                asientos = Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[3].Value);
                            }
                        }

                        string Rpta = "";
                        string estado = "false";
                        Rpta = MesaNegocios.Actualizar(Convert.ToInt32(idmesa), codmesa, estado, Convert.ToInt32(asientos));
                        if (Rpta.Equals("OK"))
                        {
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
                    //FIN VOLVER A ACTIVAR MESA
                }

                try
                {
                    string Rpta = "";
                    if (txtNomCliente.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "";
                        if (cboEstado.Text == "Activo")
                        {
                            estado = "A";
                        }
                        else
                        {
                            estado = "F";
                        }
                        if (txtDireccion.Text == "")
                        {
                            txtDireccion.Text = "-";
                        }
                        Rpta = PedidoNegocios.Actualizar(Convert.ToInt32(txtIdPedido.Text), dteFecha.Value, cboTipoPedido.Text, cboTipoPago.Text, 1, estado, txtComentario.Text, Convert.ToInt32(txtIdEmpleado.Text), Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdMesa.Text), txtDireccion.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Pedido actualizado correctamente.");
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

                if (cboEstado.Text == "Activo")
                {

                    try
                    {
                        string idmesa = "";
                        string codmesa = "";
                        string asientos = "";

                        for (int i = 0; i < dgvPedidos.RowCount; i++)
                        {
                            if (txtIdPedido.Text == Convert.ToString(dgvPedidos.Rows[i].Cells[0].Value))
                            {
                                idmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[16].Value);
                                codmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[13].Value);
                            }
                        }
                        for (int i = 0; i < dgvTodasLasMesas.RowCount; i++)
                        {
                            if (idmesa == Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[0].Value))
                            {
                                asientos = Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[3].Value);
                            }
                        }

                        string Rpta = "";
                        string estado = "false";
                        Rpta = MesaNegocios.Actualizar(Convert.ToInt32(idmesa), codmesa, estado, Convert.ToInt32(asientos));
                        if (Rpta.Equals("OK"))
                        {
                            //this.ListarMesas();
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
                    try
                    {
                        string Rpta = "";
                        string estado = "true";
                        Rpta = MesaNegocios.Actualizar(Convert.ToInt32(txtIdMesa.Text), cboMesa.Text, estado, Convert.ToInt32(txtAsientos.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.ListarMesas();
                            this.ListarPedidos();
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
                else
                {
                    
                }
                this.ListarMesas();
                this.ListarPedidos();
                dgvComida_Producto.Rows.Clear();
            }
            else
            {
                try
                {
                    string Rpta = "";
                    if (txtNomCliente.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        string estado = "";
                        if (cboEstado.Text == "Activo")
                        {
                            estado = "A";
                        }
                        else
                        {
                            estado = "F";
                        }
                        Rpta = PedidoNegocios.Insertar(dteFecha.Value, cboTipoPedido.Text, cboTipoPago.Text, 1, estado, txtComentario.Text, Convert.ToInt32(txtIdEmpleado.Text), Convert.ToInt32(txtIdCliente.Text), Convert.ToInt32(txtIdMesa.Text), txtDireccion.Text);
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Pedido registrado correctamente.");
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

                try
                {
                    string Rpta = "";
                    string estado = "true";
                    Rpta = MesaNegocios.Actualizar(Convert.ToInt32(txtIdMesa.Text), cboMesa.Text, estado, Convert.ToInt32(txtAsientos.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.ListarMesas();
                        this.ListarPedidos();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarPedidos();
            dgvComida_Producto.Rows.Clear();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            int llave = 0;
            for (int i = 0; i < dgvComida_Producto.RowCount; i++)
            {
                if (cboComida.Text == Convert.ToString(dgvComida_Producto.Rows[i].Cells[0].Value))
                {
                    llave = 1;
                    try
                    {
                        int cantidad = Convert.ToInt32(dgvComida_Producto.Rows[i].Cells[2].Value) + 1;
                        string Rpta = "";
                        int stock = 0;

                        for(int j=0; j < dgvComida.RowCount; j++)
                        {
                            if (txtiComida.Text == Convert.ToString(dgvComida.Rows[j].Cells[0].Value))
                            {
                                int hola = Convert.ToInt32(dgvComida.Rows[j].Cells[3].Value);
                                if (hola >= 1)
                                {
                                    stock = 1;
                                    Rpta = Pedido_ComidaNegocios.Actualizar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiComida.Text), Convert.ToInt32(cantidad));
                                    Rpta = ComidaNegocios.Actualizar(Convert.ToInt32(dgvComida.Rows[j].Cells[0].Value), Convert.ToString(dgvComida.Rows[j].Cells[1].Value), Convert.ToDouble(dgvComida.Rows[j].Cells[2].Value), Convert.ToInt32(dgvComida.Rows[j].Cells[3].Value) - 1, Convert.ToString(dgvComida.Rows[j].Cells[4].Value), Convert.ToInt32(dgvComida.Rows[j].Cells[6].Value));
                                }
                            }
                        }

                        if (Rpta.Equals("OK"))
                        {
                            this.ListarMesas();
                            this.Listar();
                            this.ListarComidaProducto();
                        }
                        else
                        {
                            if (stock == 0)
                            {
                                this.MensajeError("Stock mínimo alcanzado.");
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

            if (llave == 0)
            {
                try
                {
                    int cantidad = 1;
                    string Rpta = "";
                    int stock = 0;
                    for (int j = 0; j < dgvComida.RowCount; j++)
                    {
                        if (txtiComida.Text == Convert.ToString(dgvComida.Rows[j].Cells[0].Value))
                        {
                            int hola = Convert.ToInt32(dgvComida.Rows[j].Cells[3].Value);
                            if (hola >= 1)
                            {
                                stock = 1;
                                Rpta = Pedido_ComidaNegocios.Insertar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiComida.Text), Convert.ToInt32(cantidad));
                                Rpta = ComidaNegocios.Actualizar(Convert.ToInt32(dgvComida.Rows[j].Cells[0].Value), Convert.ToString(dgvComida.Rows[j].Cells[1].Value), Convert.ToDouble(dgvComida.Rows[j].Cells[2].Value), Convert.ToInt32(dgvComida.Rows[j].Cells[3].Value) - 1, Convert.ToString(dgvComida.Rows[j].Cells[4].Value), Convert.ToInt32(dgvComida.Rows[j].Cells[6].Value));
                            }
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Comida agregada correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
                    }
                    else
                    {
                        if (stock == 0)
                        {
                            this.MensajeError("No se pudo agregar la comida, stock mínimo alcanzado.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text != string.Empty)
            {
                try
                {

                    string Rpta = "";
                    Rpta = Pedido_ComidaNegocios.Eliminar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiComida.Text));

                    if (Rpta.Equals("OK"))
                    {
                        //============================ACTUALIZAR TABLA DE COMIDAS================
                        for (int j = 0; j < dgvComida.RowCount; j++)
                        {
                            if (txtiComida.Text == Convert.ToString(dgvComida.Rows[j].Cells[0].Value))
                            {
                                int hola = Convert.ToInt32(dgvComida.Rows[j].Cells[3].Value);
                                int ncantidad = 0;
                                for (int z = 0; z < dgvComida_Producto.RowCount; z++)
                                {
                                    if (Convert.ToString(dgvComida_Producto.Rows[z].Cells[0].Value) == cboComida.Text)
                                    {
                                        ncantidad = Convert.ToInt32(dgvComida_Producto.Rows[z].Cells[2].Value);
                                    }
                                }
                                Rpta = ComidaNegocios.Actualizar(Convert.ToInt32(dgvComida.Rows[j].Cells[0].Value), Convert.ToString(dgvComida.Rows[j].Cells[1].Value), Convert.ToDouble(dgvComida.Rows[j].Cells[2].Value), hola+ncantidad, Convert.ToString(dgvComida.Rows[j].Cells[4].Value), Convert.ToInt32(dgvComida.Rows[j].Cells[6].Value));
                            }
                        }
                        this.MensajeCorrecto("Comida eliminada correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
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

        private void button4_Click_1(object sender, EventArgs e)
        {
            int llave = 0;
            for (int i = 0; i < dgvComida_Producto.RowCount; i++)
            {
                if (cboProducto.Text == Convert.ToString(dgvComida_Producto.Rows[i].Cells[0].Value))
                {
                    llave = 1;
                    try
                    {
                        int cantidad = Convert.ToInt32(dgvComida_Producto.Rows[i].Cells[2].Value) + 1;
                        string Rpta = "";
                        int stock = 0;

                        for (int j = 0; j < dgvProducto.RowCount; j++)
                        {
                            if (txtiProducto.Text == Convert.ToString(dgvProducto.Rows[j].Cells[10].Value))
                            {
                                int hola = Convert.ToInt32(dgvProducto.Rows[j].Cells[2].Value);
                                if (hola >= 1)
                                {
                                    stock = 1;
                                    Rpta = Pedido_ProductoNegocios.Actualizar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiProducto.Text), Convert.ToInt32(cantidad));

                                    Rpta = ProductoNegocios.Actualizar(Convert.ToInt32(dgvProducto.Rows[j].Cells[10].Value), Convert.ToString(dgvProducto.Rows[j].Cells[0].Value), Convert.ToDouble(dgvProducto.Rows[j].Cells[1].Value), hola - 1, Convert.ToDateTime(dgvProducto.Rows[j].Cells[3].Value), Convert.ToDouble(dgvProducto.Rows[j].Cells[4].Value), Convert.ToString(7), Convert.ToInt32(dgvProducto.Rows[j].Cells[9].Value), Convert.ToInt32(dgvProducto.Rows[j].Cells[8].Value));
                                }
                            }
                        }


                        
                        if (Rpta.Equals("OK"))
                        {
                            this.ListarMesas();
                            this.Listar();
                            this.ListarComidaProducto();
                        }
                        else
                        {
                            if (stock == 0)
                            {
                                this.MensajeError("Stock mínimo alcanzado.");
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

            if (llave == 0)
            {
                try
                {
                    int cantidad = 1;
                    string Rpta = "";
                    int stock = 0;

                    for (int j = 0; j < dgvProducto.RowCount; j++)
                    {
                        if (txtiProducto.Text == Convert.ToString(dgvProducto.Rows[j].Cells[10].Value))
                        {
                            int hola = Convert.ToInt32(dgvProducto.Rows[j].Cells[2].Value);
                            if (hola >= 1)
                            {
                                stock = 1;
                                Rpta = Pedido_ProductoNegocios.Insertar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiProducto.Text), Convert.ToInt32(cantidad));

                                Rpta = ProductoNegocios.Actualizar(Convert.ToInt32(dgvProducto.Rows[j].Cells[10].Value), Convert.ToString(dgvProducto.Rows[j].Cells[0].Value), Convert.ToDouble(dgvProducto.Rows[j].Cells[1].Value), hola - 1, Convert.ToDateTime(dgvProducto.Rows[j].Cells[3].Value), Convert.ToDouble(dgvProducto.Rows[j].Cells[4].Value), Convert.ToString(7), Convert.ToInt32(dgvProducto.Rows[j].Cells[9].Value), Convert.ToInt32(dgvProducto.Rows[j].Cells[8].Value));
                            }
                        }
                    }

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Producto agregado correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
                    }
                    else
                    {
                        if (stock == 0)
                        {
                            this.MensajeError("No se pudo agregar el producto, stock mínimo alcanzado.");
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

        private void button5_Click(object sender, EventArgs e)
        {
            //==========================================================
            if (txtIdMesa.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    Rpta = Pedido_ProductoNegocios.Eliminar(Convert.ToInt32(txtIdPedido.Text), Convert.ToInt32(txtiProducto.Text));
                    if (Rpta.Equals("OK"))
                    {
                        //============================ACTUALIZAR TABLA DE PRODUCTOS================
                        for (int j = 0; j < dgvProducto.RowCount; j++)
                        {
                            if (txtiProducto.Text == Convert.ToString(dgvProducto.Rows[j].Cells[10].Value))
                            {
                                int hola = Convert.ToInt32(dgvProducto.Rows[j].Cells[2].Value);
                                int ncantidad = 0;
                                for (int z = 0; z < dgvComida_Producto.RowCount; z++)
                                {
                                    if (Convert.ToString(dgvComida_Producto.Rows[z].Cells[0].Value) == cboProducto.Text)
                                    {
                                        ncantidad = Convert.ToInt32(dgvComida_Producto.Rows[z].Cells[2].Value);
                                    }
                                }
                                Rpta = ProductoNegocios.Actualizar(Convert.ToInt32(dgvProducto.Rows[j].Cells[10].Value),Convert.ToString(dgvProducto.Rows[j].Cells[0].Value),Convert.ToDouble(dgvProducto.Rows[j].Cells[1].Value),hola+ncantidad,Convert.ToDateTime(dgvProducto.Rows[j].Cells[3].Value),Convert.ToDouble(dgvProducto.Rows[j].Cells[4].Value), Convert.ToString(7),Convert.ToInt32(dgvProducto.Rows[j].Cells[9].Value),Convert.ToInt32(dgvProducto.Rows[j].Cells[8].Value));
                            }
                        }
                        this.MensajeCorrecto("Comida eliminada correctamente.");
                        this.ListarMesas();
                        this.Listar();
                        this.ListarComidaProducto();
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtNomCliente.Clear();
                txtIdCliente.Clear();
                for (int i = 0; i < dgvClientes.RowCount; i++)
                {
                    if(txtDocCliente.Text == Convert.ToString(dgvClientes.Rows[i].Cells[1].Value))
                    {
                        txtNomCliente.Text = Convert.ToString(dgvClientes.Rows[i].Cells[3].Value) + " " + Convert.ToString(dgvClientes.Rows[i].Cells[4].Value);
                        txtIdCliente.Text = Convert.ToString(dgvClientes.Rows[i].Cells[0].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void cboTipoPedido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoPedido.Text == "Mesa")
            {
                lblDireccion.Visible = false;
                txtDireccion.Visible = false;
            }
            else
            {
                lblDireccion.Visible = true;
                txtDireccion.Visible = true;
            }
        }

        private void cboMesa_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTodasLasMesas.RowCount; i++)
            {
                if (cboMesa.Text == Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[1].Value))
                {
                    txtIdMesa.Text = Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[0].Value);
                    txtAsientos.Text = Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[3].Value);
                }
            }
        }

        private void txtDocCliente_TextChanged(object sender, EventArgs e)
        {
            txtNomCliente.Clear();
            //txtIdCliente.Clear();
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

        private void txtNomCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (txtIdPedido.Text == "")
            {
                MensajeError("Escoja un pedido.");
            }
            else
            {
                FrmDocVenta mv = new FrmDocVenta();
                mv.lblPedidoID.Text = txtIdPedido.Text;
                if (txtDocCliente.Text.Length == 8)
                {
                    mv.lblTipo.Text = "BOLETA";
                    mv.lblMi.Text = "D.N.I";
                    mv.txtNombref.Text = txtNomCliente.Text;
                    mv.txtRUC.Text = txtDocCliente.Text;
                    mv.txtDireccionf.Text = txtDireccion.Text;
                }
                else
                {
                    mv.lblTipo.Text = "FACTURA";
                    mv.lblMi.Text = "R.U.C";
                    mv.txtNombref.Text = txtNomCliente.Text;
                    mv.txtRUC.Text = txtDocCliente.Text;
                    mv.txtDireccionf.Text = txtDireccion.Text;
                }
                if (cboEstado.Text == "Finalizado")
                {
                    mv.btnGuardar.Visible = false;
                }
                else
                {
                    mv.btnGuardar.Visible = true;
                }
                mv.lblFechaf.Text = Convert.ToString(dteFecha.Value.ToShortDateString());
                mv.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            //VOLVER A ACTIVAR MESA
            //try
            //{
            //    string idmesa = "";
            //    string codmesa = "";
            //    string asientos = "";

            //    for (int i = 0; i < dgvPedidos.RowCount; i++)
            //    {
            //        if (txtIdPedido.Text == Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[0].Value))
            //        {
            //            idmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[16].Value);
            //            codmesa = Convert.ToString(dgvPedidos.Rows[i].Cells[13].Value);
            //        }
            //    }
            //    for (int i = 0; i < dgvTodasLasMesas.RowCount; i++)
            //    {
            //        if (idmesa == Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[0].Value))
            //        {
            //            asientos = Convert.ToString(dgvTodasLasMesas.Rows[i].Cells[3].Value);
            //        }
            //    }

            //    string Rpta = "";
            //    string estado = "false";
            //    Rpta = MesaNegocios.Actualizar(Convert.ToInt32(idmesa), codmesa, estado, Convert.ToInt32(asientos));
            //    if (Rpta.Equals("OK"))
            //    {
            //        //this.ListarMesas();
            //    }
            //    else
            //    {
            //        this.MensajeError(Rpta);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
            //FIN VOLVER A ACTIVAR MESA


            try
            {
                string Rpta = "";
                Rpta = PedidoNegocios.Eliminar(Convert.ToInt32(txtIdPedido.Text));

                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Pedido eliminado correctamente.");
                    this.ListarMesas();
                    this.ListarPedidos();
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

        private void button6_Click(object sender, EventArgs e)
        {
            this.ListarPedidos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.ListarPedidos2();
        }

        private void cboComida_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvComida.RowCount; i++)
            {
                if(cboComida.Text== Convert.ToString(dgvComida.Rows[i].Cells[1].Value))
                {
                    txtiComida.Text = Convert.ToString(dgvComida.Rows[i].Cells[0].Value);
                }
            }
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvProducto.RowCount; i++)
            {
                if (cboProducto.Text == Convert.ToString(dgvProducto.Rows[i].Cells[0].Value)+" "+ Convert.ToString(dgvProducto.Rows[i].Cells[4].Value)+ Convert.ToString(dgvProducto.Rows[i].Cells[5].Value))
                {
                    txtiProducto.Text = Convert.ToString(dgvProducto.Rows[i].Cells[10].Value);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
