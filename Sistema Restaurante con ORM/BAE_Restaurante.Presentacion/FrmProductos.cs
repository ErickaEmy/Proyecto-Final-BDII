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
using BAE_Restaurante.Entidad.Modelos;

namespace BAE_Restaurante.Presentacion
{
    public partial class FrmProductos : Form
    {
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            this.ListarProductos();
        }

        private void ListarProductos()
        {
            try
            {

                dgvProductos.DataSource = ProductoNegocios.Listar();

                //LISTAR TIPO DE PRODUCTO CON LINQ - ORM
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    var lst = from d in db.Tipo_producto
                              select new {d.id_tipo_producto, d.nombre};

                    dgvTipoProducto.DataSource = lst.ToList();
                }
                //dgvTipoProducto.DataSource = Tipo_productoNegocios.Listar();


                //LISTAR TIPO DE MEDIDA CON LINQ - ORM
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    var lst = from d in db.Tipo_medida
                              select new { d.id_tipo_medida, d.nombre };

                    dgvTipoMedida.DataSource = lst.ToList();
                }
                //dgvTipoMedida.DataSource = Tipo_medidaNegocios.Listar();
                txtNombre.Clear();
                txtPrecio.Clear();
                txtCantidad.Clear();
                txtComentario.Clear();
                txtNumMed.Clear();
                txtIdTMED.Clear();
                txtIdTPLATO.Clear();
                txtIdProducto.Clear();
                this.TitulosProductos();
                cboTipo.Items.Clear();
                for (int i = 0; i < dgvTipoProducto.RowCount; i++)
                {
                    cboTipo.Items.Add(dgvTipoProducto.Rows[i].Cells[1].Value);
                }
                cboTipo.SelectedIndex = 0;
                txtIdTPLATO.Text = Convert.ToString(dgvTipoProducto.Rows[0].Cells[0].Value);

                cboMedida.Items.Clear();
                for (int i = 0; i < dgvTipoMedida.RowCount; i++)
                {
                    cboMedida.Items.Add(dgvTipoMedida.Rows[i].Cells[1].Value);
                }
                cboMedida.SelectedIndex = 0;
                txtIdTMED.Text = Convert.ToString(dgvTipoMedida.Rows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosProductos()
        {
            dgvProductos.Columns[8].Visible = false;
            dgvProductos.Columns[9].Visible = false;
            dgvProductos.Columns[10].Visible = false;
            dgvProductos.Columns[0].Width = 120;
            dgvProductos.Columns[1].Width = 80;
            dgvProductos.Columns[2].Width = 80;
            dgvProductos.Columns[3].Width = 80;
            dgvProductos.Columns[4].Width = 100;
            dgvProductos.Columns[5].Width = 100;
            dgvProductos.Columns[6].Width = 100;
            dgvProductos.Columns[7].Width = 100;
            dgvProductos.Columns[8].Width = 80;
            dgvProductos.Columns[9].Width = 80;
            dgvProductos.Columns[10].Width = 80;
            dgvProductos.Columns[0].HeaderText = "Nombre";
            dgvProductos.Columns[1].HeaderText = "Precio";
            dgvProductos.Columns[2].HeaderText = "Cantidad";
            dgvProductos.Columns[3].HeaderText = "Fecha de Vencimiento";
            dgvProductos.Columns[4].HeaderText = "Num. Medida";
            dgvProductos.Columns[5].HeaderText = "Tipo Medida";
            dgvProductos.Columns[6].HeaderText = "Tipo Producto";
            dgvProductos.Columns[7].HeaderText = "Comentario";
            dgvProductos.Columns[8].HeaderText = "id_tipo_medida";
            dgvProductos.Columns[9].HeaderText = "id_tipo_producto";
            dgvProductos.Columns[10].HeaderText = "id_producto";
        }

        

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {

            try
            {
                txtNombre.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[0].Value);
                txtPrecio.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[1].Value);
                txtCantidad.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[2].Value);
                dteFecha.Value = Convert.ToDateTime(dgvProductos.CurrentRow.Cells[3].Value);
                txtNumMed.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[4].Value);
                txtComentario.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[7].Value);
                txtIdTMED.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[8].Value);
                txtIdTPLATO.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[9].Value);
                txtIdProducto.Text = Convert.ToString(dgvProductos.CurrentRow.Cells[10].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el producto.");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre.Text == string.Empty || txtIdTPLATO.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // ACTUALIZAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Producto iCliente = new Producto();
                            iCliente.id_producto = Convert.ToInt32(txtIdProducto.Text);
                            iCliente.nombre = txtNombre.Text;
                            iCliente.precio = Convert.ToDecimal(txtPrecio.Text);
                            iCliente.cantidad = Convert.ToInt32(txtCantidad.Text);
                            iCliente.fecha_vencimiento = dteFecha.Value;
                            iCliente.num_medida = Convert.ToDecimal(txtNumMed.Text);
                            iCliente.comentario = txtComentario.Text;
                            iCliente.id_tipo_producto = Convert.ToInt32(txtIdTPLATO.Text);
                            iCliente.id_tipo_medida = Convert.ToInt32(txtIdTMED.Text);
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /*PROCEDIMIENTO SIN ORM
                        this.ListarProductos();
                        Rpta = ProductoNegocios.Actualizar(Convert.ToInt32(txtIdProducto.Text), txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text),dteFecha.Value, Convert.ToDouble(txtNumMed.Text), txtComentario.Text, Convert.ToInt32(txtIdTPLATO.Text), Convert.ToInt32(txtIdTMED.Text));
                        */
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Producto actualizado correctamente.");
                            this.ListarProductos();
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
                    if (txtNombre.Text == string.Empty || txtIdTPLATO.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // INSERTAR PRODUCTO CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Producto iCliente = new Producto();
                            iCliente.nombre = txtNombre.Text;
                            iCliente.precio = Convert.ToDecimal(txtPrecio.Text);
                            iCliente.cantidad = Convert.ToInt32(txtCantidad.Text);
                            iCliente.fecha_vencimiento = dteFecha.Value;
                            iCliente.num_medida = Convert.ToDecimal(txtNumMed.Text);
                            iCliente.comentario = txtComentario.Text;
                            iCliente.id_tipo_producto = Convert.ToInt32(txtIdTPLATO.Text);
                            iCliente.id_tipo_medida = Convert.ToInt32(txtIdTMED.Text);
                            db.Producto.Add(iCliente);
                            db.SaveChanges();

                        }
                        Rpta = "OK";


                        /*PROCEDIMIENTO SIN ORM
                        Rpta = ProductoNegocios.Insertar(txtNombre.Text, Convert.ToDouble(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), dteFecha.Value, Convert.ToDouble(txtNumMed.Text), txtComentario.Text, Convert.ToInt32(txtIdTPLATO.Text), Convert.ToInt32(txtIdTMED.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Producto registrado correctamente.");
                            this.ListarProductos();
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
            this.ListarProductos();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text != string.Empty)
            {
                // ELIMINAR CON LINQ - ORM
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    Producto iCliente = db.Producto.Find(Convert.ToInt32(txtIdProducto.Text));
                    db.Producto.Remove(iCliente);
                    db.SaveChanges();
                }
                this.MensajeCorrecto("Producto eliminado correctamente.");
                this.ListarProductos();

                /* PROCEDIMIENTO SIN ORM
                string Rpta = "";
                Rpta = ProductoNegocios.Eliminar(Convert.ToInt32(txtIdProducto.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Producto eliminado correctamente.");
                    this.ListarProductos();
                }
                else
                {
                    this.MensajeError(Rpta);
                }*/
            }
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
        }

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione comida comida.");
            }
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTipoProducto.RowCount; i++)
            {
                if (Convert.ToString(dgvTipoProducto.Rows[i].Cells[1].Value) == cboTipo.Text)
                {
                    txtIdTPLATO.Text = Convert.ToString(dgvTipoProducto.Rows[i].Cells[0].Value);
                }
            }
        }

        private void cboMedida_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvTipoMedida.RowCount; i++)
            {
                if (Convert.ToString(dgvTipoMedida.Rows[i].Cells[1].Value) == cboMedida.Text)
                {
                    txtIdTMED.Text = Convert.ToString(dgvTipoMedida.Rows[i].Cells[0].Value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                Rpta = Doc_compraNegocios.Insertar(cboDocumento.Text, Convert.ToInt32(txtNumDocumento.Text),Convert.ToDouble(txtMontoCompra.Text), dteCompra.Value, txtComentario.Text + ".");
                if (Rpta.Equals("OK"))
                {
                    
                    DateTime today = DateTime.Today;
                    string auxfecha = Convert.ToString(today.ToShortDateString());
                    this.MensajeCorrecto("Documento registrado correctamente.");
                    Rpta = CajaNegocios.Actualizar3(Convert.ToDateTime(auxfecha).Date, Convert.ToDouble(txtMontoCompra.Text));
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
