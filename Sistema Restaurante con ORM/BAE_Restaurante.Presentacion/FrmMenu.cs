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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnEditar2_Click(object sender, EventArgs e)
        {
            try
            {
                txtIdPlato.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[0].Value);
                txtNombre2.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[1].Value);
                txtPrecio2.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[2].Value);
                txtCantidad2.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[3].Value);
                txtComentario2.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[4].Value);
                txtIdTPLATO.Text = Convert.ToString(dgvPlatos.CurrentRow.Cells[6].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione comida comida.");
            }
        }

        private void btnActualizar2_Click(object sender, EventArgs e)
        {
            this.ListarPlatos();
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.ListarPlatos();
            webBrowser1.Navigate("https://m.facebook.com/login/?ref=dbl&fl&locale2=es_ES");
        }

        private void ListarPlatos()
        {
            try
            {
                dgvPlatos.DataSource = ComidaNegocios.Listar();
                dgvTipoProducto.DataSource = Tipo_comidaNegocios.Listar();
                txtNombre2.Clear();
                txtPrecio2.Clear();
                txtCantidad2.Clear();
                txtComentario2.Clear();
                txtIdTPLATO.Clear();
                txtIdPlato.Clear();
                this.TitulosPlatos();
                dgvMenu.Rows.Clear();
                txtPublicacion.Clear();
                txtPublicacion.Text = "BAE Restaurante\r\n\r\nMENÚ DEL DÍA:\r\n\r\n\r\n";
                for (int i = 0; i < dgvPlatos.RowCount; i++)
                {
                    if(Convert.ToInt32(dgvPlatos.Rows[i].Cells[3].Value) > 0)
                    {
                        dgvMenu.Rows.Add(Convert.ToString(dgvPlatos.Rows[i].Cells[1].Value), Convert.ToString(dgvPlatos.Rows[i].Cells[2].Value), Convert.ToString(dgvPlatos.Rows[i].Cells[3].Value), Convert.ToString(dgvPlatos.Rows[i].Cells[4].Value), Convert.ToString(dgvPlatos.Rows[i].Cells[5].Value));

                        txtPublicacion.Text = txtPublicacion.Text + Convert.ToString(dgvPlatos.Rows[i].Cells[1].Value) + " -> " + Convert.ToString(dgvPlatos.Rows[i].Cells[2].Value) + "\r\n";
                    }
                }
                cboTipo.Items.Clear();
                for (int i = 0; i < dgvTipoProducto.RowCount; i++)
                {
                    cboTipo.Items.Add(dgvTipoProducto.Rows[i].Cells[1].Value);
                }
                cboTipo.SelectedIndex = 0;
                txtIdTPLATO.Text = Convert.ToString(dgvTipoProducto.Rows[0].Cells[0].Value);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void TitulosPlatos()
        {
            dgvPlatos.Columns[0].Visible = false;
            dgvPlatos.Columns[6].Visible = false;
            dgvPlatos.Columns[0].Width = 80;
            dgvPlatos.Columns[1].Width = 120;
            dgvPlatos.Columns[2].Width = 80;
            dgvPlatos.Columns[3].Width = 80;
            dgvPlatos.Columns[4].Width = 100;
            dgvPlatos.Columns[5].Width = 100;
            dgvPlatos.Columns[6].Width = 80;
            dgvPlatos.Columns[0].HeaderText = "id_comida";
            dgvPlatos.Columns[1].HeaderText = "Nombre";
            dgvPlatos.Columns[2].HeaderText = "Precio";
            dgvPlatos.Columns[3].HeaderText = "Cantidad";
            dgvPlatos.Columns[4].HeaderText = "Comentario";
            dgvPlatos.Columns[5].HeaderText = "Categoría";
            dgvPlatos.Columns[6].HeaderText = "id_tipo_comida";
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
        {
            if (txtIdPlato.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombre2.Text == string.Empty || txtIdTPLATO.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // ACTUALIZAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Comida iCliente = new Comida();
                            iCliente.id_comida = Convert.ToInt32(txtIdPlato.Text);
                            iCliente.nombre = txtNombre2.Text;
                            iCliente.precio = Convert.ToDecimal(txtPrecio2.Text);
                            iCliente.cantidad = Convert.ToInt32(txtCantidad2.Text);
                            iCliente.comentario = txtComentario2.Text;
                            iCliente.id_tipo_comida = Convert.ToInt32(txtIdTPLATO.Text);
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = ComidaNegocios.Actualizar(Convert.ToInt32(txtIdPlato.Text), txtNombre2.Text, Convert.ToDouble(txtPrecio2.Text), Convert.ToInt32(txtCantidad2.Text), txtComentario2.Text, Convert.ToInt32(txtIdTPLATO.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Comida actualizada correctamente.");
                            this.ListarPlatos();
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
                    if (txtNombre2.Text == string.Empty || txtIdTPLATO.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // INSERTAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Comida iCliente = new Comida();
                            iCliente.nombre = txtNombre2.Text;
                            iCliente.precio = Convert.ToDecimal(txtPrecio2.Text);
                            iCliente.cantidad = Convert.ToInt32(txtCantidad2.Text);
                            iCliente.comentario = txtComentario2.Text;
                            iCliente.id_tipo_comida = Convert.ToInt32(txtIdTPLATO.Text);
                            db.Comida.Add(iCliente);
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = ComidaNegocios.Insertar(txtNombre2.Text, Convert.ToDouble(txtPrecio2.Text), Convert.ToInt32(txtCantidad2.Text), txtComentario2.Text, Convert.ToInt32(txtIdTPLATO.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Comida registrada correctamente.");
                            this.ListarPlatos();
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

        private void btnLimpiar2_Click(object sender, EventArgs e)
        {
            this.ListarPlatos();
        }

        private void btnEliminar2_Click(object sender, EventArgs e)
        {
            if (txtIdPlato.Text != string.Empty)
            {
                // ELIMINAR CON LINQ - ORM
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    Comida iCliente = db.Comida.Find(Convert.ToInt32(txtIdPlato.Text));
                    db.Comida.Remove(iCliente);
                    db.SaveChanges();
                }
                this.MensajeCorrecto("Comida eliminada correctamente.");
                this.ListarPlatos();

                /*PROCEDIMIENTO SIN ORM
                string Rpta = "";
                Rpta = ComidaNegocios.Eliminar(Convert.ToInt32(txtIdPlato.Text));
                if (Rpta.Equals("OK"))
                {
                    this.MensajeCorrecto("Comida eliminada correctamente.");
                    this.ListarPlatos();
                }
                else
                {
                    this.MensajeError(Rpta);
                }*/
            }
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("m_login_email").SetAttribute("value", txtUsuario.Text);
            webBrowser1.Document.GetElementById("pass").SetAttribute("value", txtContrasena.Text);
            webBrowser1.Document.GetElementById("login").InvokeMember("click");
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("xc_message").SetAttribute("value", txtPublicacion.Text);
            webBrowser1.Document.GetElementById("view_post").InvokeMember("click");
            this.MensajeCorrecto("Menú publicado correctamente.");
        }
    }
}
