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
    public partial class FrmMantenimiento : Form
    {
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void TitulosTipo_comida()
        {
            dgvTipo_comida.Columns[0].Visible = false;
            dgvTipo_comida.Columns[1].Width = 200;
            dgvTipo_comida.Columns[0].HeaderText = "ID";
            dgvTipo_comida.Columns[1].HeaderText = "Nombre";
        }

        private void ListarTipo_comida()
        {
            // LISTAR TIPO DE COMIDA CON LINQ - ORM
            using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
            {
                var lst = from d in db.Tipo_comida
                          select new { d.id_tipo_comida, d.nombre };

                dgvTipo_comida.DataSource = lst.ToList();
            }
            txtNombreTComida.Clear();
            txtIdTComida.Clear();
            this.TitulosTipo_comida();
            lblTipoComida.Text = "Agregar tipo de comida";
            /* PROCEDIMIENTO SIN ORM
            try
            {
                dgvTipo_comida.DataSource = Tipo_comidaNegocios.Listar();
                txtNombreTComida.Clear();
                txtIdTComida.Clear();
                this.TitulosTipo_comida();
                lblTipoComida.Text = "Agregar tipo de comida";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }*/
        }
        private void TitulosTipo_producto()
        {
            dgvTipo_producto.Columns[0].Visible = false;
            dgvTipo_producto.Columns[1].Width = 200;
            dgvTipo_producto.Columns[0].HeaderText = "ID";
            dgvTipo_producto.Columns[1].HeaderText = "Nombre";
        }

        private void ListarTipo_producto()
        {

            // LISTAR TIPO DE PRODUCTO CON LINQ - ORM
            using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
            {
                var lst = from d in db.Tipo_producto
                          select new { d.id_tipo_producto, d.nombre };

                dgvTipo_producto.DataSource = lst.ToList();
            }
            txtIdTProducto.Clear();
            txtNombreTProducto.Clear();
            lblTipoProducto.Text = "Agregar tipo de producto";
            this.TitulosTipo_producto();

            /* PROCEDIMIENTO SIN ORM
            try
            {
                dgvTipo_producto.DataSource = Tipo_productoNegocios.Listar();
                txtIdTProducto.Clear();
                txtNombreTProducto.Clear();
                lblTipoProducto.Text = "Agregar tipo de producto";
                this.TitulosTipo_producto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }*/
        }
        private void TitulosTipo_medida()
        {
            dgvTipo_medida.Columns[0].Visible = false;
            dgvTipo_medida.Columns[1].Width = 200;
            dgvTipo_medida.Columns[0].HeaderText = "ID";
            dgvTipo_medida.Columns[1].HeaderText = "Nombre";
        }

        private void ListarTipo_medida()
        {

            // LISTAR TIPO DE MEDIDA CON LINQ - ORM
            using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
            {
                var lst = from d in db.Tipo_medida
                          select new { d.id_tipo_medida, d.nombre };

                dgvTipo_medida.DataSource = lst.ToList();
            }
            txtIdTMedida.Clear();
            txtNombreTMedida.Clear();
            lblTipoMedida.Text = "Agregar tipo de medida";
            this.TitulosTipo_medida();
            /* PROCEDIMIENTO SIN ORM
            try
            {
                dgvTipo_medida.DataSource = Tipo_medidaNegocios.Listar();
                txtIdTMedida.Clear();
                txtNombreTMedida.Clear();
                lblTipoMedida.Text = "Agregar tipo de medida";
                this.TitulosTipo_medida();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }*/
        }
        private void TitulosCargo()
        {
            dgvCargo.Columns[0].Visible = false;
            dgvCargo.Columns[1].Width = 130;
            dgvCargo.Columns[2].Width = 90;
            dgvCargo.Columns[0].HeaderText = "ID";
            dgvCargo.Columns[1].HeaderText = "Nombre";
            dgvCargo.Columns[2].HeaderText = "Sueldo";
        }

        private void ListarCargo()
        {
            // LISTAR CARGO CON LINQ - ORM
            using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
            {
                var lst = from d in db.Cargo
                          select new { d.id_cargo, d.nombre, d.sueldo };

                dgvCargo.DataSource = lst.ToList();
            }
            txtIdCargo.Clear();
            txtCargo.Clear();
            txtSueldo.Clear();
            lblTipoMedida.Text = "Agregar tipo de medida";
            this.TitulosCargo();

            /* PROCEDIMIENTO SIN ORM
            try
            {
                dgvCargo.DataSource = CargoNegocios.Listar();
                txtIdCargo.Clear();
                txtCargo.Clear();
                txtSueldo.Clear();
                lblTipoMedida.Text = "Agregar tipo de medida";
                this.TitulosCargo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }*/
        }

        public FrmMantenimiento()
        {
            InitializeComponent();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                lblTipoComida.Text = "  Editar tipo de comida";
                
                txtIdTComida.Text = Convert.ToString(dgvTipo_comida.CurrentRow.Cells[0].Value);
                txtNombreTComida.Text = Convert.ToString(dgvTipo_comida.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de comida");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.ListarTipo_comida();
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {
            if (txtIdTComida.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombreTComida.Text == string.Empty )
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // ACTUALIZAR TIPO DE COMIDA CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Tipo_comida iCliente = new Tipo_comida();
                            iCliente.id_tipo_comida = Convert.ToInt32(txtIdTComida.Text);
                            iCliente.nombre = txtNombreTComida.Text;
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        this.ListarTipo_comida();
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = Tipo_comidaNegocios.Actualizar(Convert.ToInt32(txtIdTComida.Text), txtNombreTComida.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de comida actualizado correctamente.");
                            this.ListarTipo_comida();
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
                    if (txtNombreTComida.Text == string.Empty )
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // INSERTAR TIPO DE COMIDA CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Tipo_comida iCliente = new Tipo_comida();
                            iCliente.nombre = txtNombreTComida.Text;
                            db.Tipo_comida.Add(iCliente);
                            db.SaveChanges();

                        }
                        this.ListarTipo_comida();
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = Tipo_comidaNegocios.Insertar(txtNombreTComida.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de comida agregado correctamente.");
                            this.ListarTipo_comida();
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

        private void FrmMantenimiento_Load(object sender, EventArgs e)
        {
            this.ListarTipo_comida();
            this.ListarTipo_producto();
            this.ListarTipo_medida();
            this.ListarCargo();
        }

        private void btnActualizarTProducto_Click(object sender, EventArgs e)
        {
            this.ListarTipo_producto();
        }

        private void btnActualizarTMedida_Click(object sender, EventArgs e)
        {
            this.ListarTipo_medida();

        }

        private void btnActualizarCargo_Click(object sender, EventArgs e)
        {
            this.ListarCargo();

        }

        private void btnLimpiarTComida_Click(object sender, EventArgs e)
        {
            this.ListarTipo_comida();
        }

        private void dgvTipo_comida_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTipo_comida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblTipoComida.Text = "  Editar tipo de comida";

                txtIdTComida.Text = Convert.ToString(dgvTipo_comida.CurrentRow.Cells[0].Value);
                txtNombreTComida.Text = Convert.ToString(dgvTipo_comida.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de comida");
            }
        }

        private void btnEliminarTComida_Click(object sender, EventArgs e)
        {
            if (txtIdTComida.Text != string.Empty)
            {
                try
                {
                    //ELIMINAR TIPO DE COMIDA CON LINQ - ORN
                    using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                    {
                        Tipo_comida iCliente = db.Tipo_comida.Find(Convert.ToInt32(txtIdTComida.Text));
                        db.Tipo_comida.Remove(iCliente);
                        db.SaveChanges();
                    }
                    this.MensajeCorrecto("Tipo de comida eliminado correctamente.");
                    this.ListarTipo_comida();
                    /* PROCEDIMIENTO SIN ORM
                    string Rpta = "OK";
                    Rpta = Tipo_comidaNegocios.Eliminar(Convert.ToInt32(txtIdTComida.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Tipo de comida eliminado correctamente.");
                        this.ListarTipo_comida();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnDetalleTProducto_Click(object sender, EventArgs e)
        {
            try
            {
                lblTipoProducto.Text = "  Editar tipo de producto";

                txtIdTProducto.Text = Convert.ToString(dgvTipo_producto.CurrentRow.Cells[0].Value);
                txtNombreTProducto.Text = Convert.ToString(dgvTipo_producto.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de producto");
            }
        }

        private void dgvTipo_producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblTipoProducto.Text = "  Editar tipo de producto";

                txtIdTProducto.Text = Convert.ToString(dgvTipo_producto.CurrentRow.Cells[0].Value);
                txtNombreTProducto.Text = Convert.ToString(dgvTipo_producto.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de producto");
            }
        }

        private void btnAgregarTProducto_Click(object sender, EventArgs e)
        {
            if (txtIdTProducto.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombreTProducto.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // ACTUALIZAR TIPO DE PRODUCTO CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Tipo_producto iCliente = new Tipo_producto();
                            iCliente.id_tipo_producto = Convert.ToInt32(txtIdTProducto.Text);
                            iCliente.nombre = txtNombreTProducto.Text;
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        this.ListarTipo_producto();
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = Tipo_productoNegocios.Actualizar(Convert.ToInt32(txtIdTProducto.Text), txtNombreTProducto.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de producto actualizado correctamente.");
                            this.ListarTipo_producto();
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
                    if (txtNombreTProducto.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        // INSERTAR TIPO DE PRODUCTO CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Tipo_producto iCliente = new Tipo_producto();
                            iCliente.nombre = txtNombreTProducto.Text;
                            db.Tipo_producto.Add(iCliente);
                            db.SaveChanges();

                        }
                        this.ListarTipo_producto();
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = Tipo_productoNegocios.Insertar(txtNombreTProducto.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de producto agregado correctamente.");
                            this.ListarTipo_producto();
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

        private void btnLimpiarTProducto_Click(object sender, EventArgs e)
        {
            this.ListarTipo_producto();
        }

        private void btnEliminarTProducto_Click(object sender, EventArgs e)
        {
            if (txtIdTProducto.Text != string.Empty)
            {
                //ELIMINAR TIPO DE PRODUCTO CON LINQ - ORN
                using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                {
                    Tipo_producto iCliente = db.Tipo_producto.Find(Convert.ToInt32(txtIdTProducto.Text));
                    db.Tipo_producto.Remove(iCliente);
                    db.SaveChanges();
                }
                this.MensajeCorrecto("Tipo de producto eliminado correctamente.");
                this.ListarTipo_producto();

                /* PROCEDIMIENTO SIN ORM
                try
                {

                    string Rpta = "";
                    Rpta = Tipo_productoNegocios.Eliminar(Convert.ToInt32(txtIdTProducto.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Tipo de producto eliminado correctamente.");
                        this.ListarTipo_producto();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }*/
            }
        }

        private void btnDetalleTMedida_Click(object sender, EventArgs e)
        {
            try
            {
                lblTipoMedida.Text = "  Editar tipo de medida";

                txtIdTMedida.Text = Convert.ToString(dgvTipo_medida.CurrentRow.Cells[0].Value);
                txtNombreTMedida.Text = Convert.ToString(dgvTipo_medida.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de producto");
            }
        }

        private void dgvTipo_medida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblTipoMedida.Text = "  Editar tipo de medida";

                txtIdTMedida.Text = Convert.ToString(dgvTipo_medida.CurrentRow.Cells[0].Value);
                txtNombreTMedida.Text = Convert.ToString(dgvTipo_medida.CurrentRow.Cells[1].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el tipo de producto");
            }
        }

        private void btnAgregarTMedida_Click(object sender, EventArgs e)
        {
            if (txtIdTMedida.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtNombreTMedida.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        Rpta = Tipo_medidaNegocios.Actualizar(Convert.ToInt32(txtIdTMedida.Text), txtNombreTMedida.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de medida actualizado correctamente.");
                            this.ListarTipo_medida();
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
                    if (txtNombreTMedida.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {

                        Rpta = Tipo_medidaNegocios.Insertar(txtNombreTMedida.Text.Trim());
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Tipo de medida agregado correctamente.");
                            this.ListarTipo_medida();
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

        private void btnEliminarTMedida_Click(object sender, EventArgs e)
        {
            if (txtIdTMedida.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    Rpta = Tipo_medidaNegocios.Eliminar(Convert.ToInt32(txtIdTMedida.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Tipo de medida eliminada correctamente.");
                        this.ListarTipo_medida();
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

        private void btnLimpiarTMedida_Click(object sender, EventArgs e)
        {
            this.ListarTipo_medida();
        }

        private void btnDetalleCargo_Click(object sender, EventArgs e)
        {
            try
            {
                lblCargo.Text = "  Editar cargo";

                txtIdCargo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[0].Value);
                txtCargo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[1].Value);
                txtSueldo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[2].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el cargo");
            }
        }

        private void dgvCargo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblCargo.Text = "  Editar cargo";

                txtIdCargo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[0].Value);
                txtCargo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[1].Value);
                txtSueldo.Text = Convert.ToString(dgvCargo.CurrentRow.Cells[2].Value);

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione el cargo");
            }
        }

        private void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            if (txtIdCargo.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtCargo.Text == string.Empty|| txtSueldo.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {
                        Rpta = CargoNegocios.Actualizar(Convert.ToInt32(txtIdCargo.Text), txtCargo.Text.Trim(),Convert.ToInt32(txtSueldo.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Cargo actualizado correctamente.");
                            this.ListarCargo();
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
                    if (txtCargo.Text == string.Empty || txtSueldo.Text == string.Empty)
                    {
                        this.MensajeError("Ingrese los datos requeridos.");
                    }
                    else
                    {

                        Rpta = CargoNegocios.Insertar(txtCargo.Text.Trim(),Convert.ToInt32(txtSueldo.Text));
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Cargo agregado correctamente.");
                            this.ListarCargo();
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

        private void btnLimpiarCargo_Click(object sender, EventArgs e)
        {
            this.ListarCargo();

        }

        private void btnEliminarCargo_Click(object sender, EventArgs e)
        {
            if (txtIdCargo.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    Rpta = CargoNegocios.Eliminar(Convert.ToInt32(txtIdCargo.Text));
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Cargo eliminado correctamente.");
                        this.ListarCargo();
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
