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
    public partial class FrmMesas : Form
    {
        public FrmMesas()
        {
            InitializeComponent();
        }

        private void FrmMesas_Load(object sender, EventArgs e)
        {
            this.ListarMesas();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "RESTOADMIN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarMesas()
        {
            try
            {
                dgvMesas.DataSource = MesaNegocios.Listar();
                txtIdMesa.Clear();
                txtCodigoMesa.Clear();
                checkBox1.Checked = false;
                txtAsientos.Clear();
                this.TitulosMesa();
                this.ListarImagenes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarImagenes()
        {
            try
            {
                dgvFotos.Rows.Clear();
                dgvFotos.RowTemplate.Height = 50;
                dgvFotos.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                dgvFotos.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dgvFotos2.Rows.Clear();
                dgvFotos2.RowTemplate.Height = 50;
                dgvFotos2.DefaultCellStyle.SelectionForeColor = Color.Transparent;
                dgvFotos2.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                for (int i = 0; i < dgvMesas.RowCount; i++)
                {
                    if (i >= 10)
                    {
                        if (Convert.ToBoolean(dgvMesas.Rows[i].Cells[2].Value) == false)
                        {
                            dgvFotos2.Rows.Add(Image.FromFile("D:/Universidad/Laboratorios Programación II/MesasBAE/Verde.png"), Convert.ToString(dgvMesas.Rows[i].Cells[1].Value));
                        }
                        else
                        {
                            dgvFotos2.Rows.Add(Image.FromFile("D:/Universidad/Laboratorios Programación II/MesasBAE/Rojo.png"), Convert.ToString(dgvMesas.Rows[i].Cells[1].Value));
                        }
                    }
                    else
                    {
                        if (Convert.ToBoolean(dgvMesas.Rows[i].Cells[2].Value) == false)
                        {
                            dgvFotos.Rows.Add(Image.FromFile("D:/Universidad/Laboratorios Programación II/MesasBAE/Verde.png"), Convert.ToString(dgvMesas.Rows[i].Cells[1].Value));
                        }
                        else
                        {
                            dgvFotos.Rows.Add(Image.FromFile("D:/Universidad/Laboratorios Programación II/MesasBAE/Rojo.png"), Convert.ToString(dgvMesas.Rows[i].Cells[1].Value));
                        }
                    }
                    
                }
                    dgvMesas.DataSource = MesaNegocios.Listar();
                txtIdMesa.Clear();
                txtCodigoMesa.Clear();
                checkBox1.Checked = false;
                txtAsientos.Clear();
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
            dgvMesas.Columns[3].Width = 90;
            dgvMesas.Columns[0].HeaderText = "ID";
            dgvMesas.Columns[1].HeaderText = "Código";
            dgvMesas.Columns[2].HeaderText = "En uso";
            dgvMesas.Columns[3].HeaderText = "Asientos";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizarMesas_Click(object sender, EventArgs e)
        {
            this.ListarMesas();
        }

        private void btnLimpiarMesa_Click(object sender, EventArgs e)
        {
            this.ListarMesas();
        }

        private void btnAgregarMesa_Click(object sender, EventArgs e)
        {

            if (txtIdMesa.Text != string.Empty)
            {
                try
                {
                    string Rpta = "";
                    if (txtCodigoMesa.Text == string.Empty || txtAsientos.Text == string.Empty)
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

                        //ACTUALIZAR CON LINQ - ORM
                        using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                        {
                            Mesa iCliente = new Mesa();
                            iCliente.id_mesa = Convert.ToInt32(txtIdMesa.Text);
                            iCliente.codigo = txtCodigoMesa.Text;
                            iCliente.estado = es;
                            iCliente.asientos = Convert.ToInt32(txtAsientos.Text);
                            db.Entry(iCliente).State = System.Data.Entity.EntityState.Modified;
                            db.SaveChanges();

                        }
                        Rpta = "OK";

                        /* PROCEDIMIENTO SIN ORM
                        Rpta = MesaNegocios.Actualizar(Convert.ToInt32(txtIdMesa.Text), txtCodigoMesa.Text.Trim(), estado, Convert.ToInt32(txtAsientos.Text)); */
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Mesa actualizada correctamente.");
                            this.ListarMesas();
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
                    if (txtCodigoMesa.Text == string.Empty || txtAsientos.Text == string.Empty)
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
                            Mesa iCliente = new Mesa();
                            iCliente.codigo = txtCodigoMesa.Text;
                            iCliente.estado = es;
                            iCliente.asientos = Convert.ToInt32(txtAsientos.Text);
                            db.Mesa.Add(iCliente);
                            db.SaveChanges();

                        }
                        Rpta = "OK";


                        /* PROCEDIMIENTO SIN ORM
                        Rpta = MesaNegocios.Insertar(txtCodigoMesa.Text.Trim(), estado, Convert.ToInt32(txtAsientos.Text));*/
                        if (Rpta.Equals("OK"))
                        {
                            this.MensajeCorrecto("Mesa agregada correctamente.");
                            this.ListarMesas();
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtIdMesa.Text != string.Empty)
            {
                try
                {
                    // ELIMINAR CON LINQ - ORM
                    using (BAE_RestauranteEntities db = new BAE_RestauranteEntities())
                    {
                        Mesa iCliente = db.Mesa.Find(Convert.ToInt32(txtIdMesa.Text));
                        db.Mesa.Remove(iCliente);
                        db.SaveChanges();
                    }
                    this.MensajeCorrecto("Mesa eliminada correctamente.");
                    this.ListarMesas();

                    /* PROCEDIMIENTO SIN ORM
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
                    }*/
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
        }

        private void btnDetalleMesa_Click(object sender, EventArgs e)
        {
            try
            {
                string Estado = "";
                txtIdMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[0].Value);
                txtCodigoMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[1].Value);
                txtAsientos.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[3].Value).Trim();

                if (Convert.ToBoolean(dgvMesas.CurrentRow.Cells[2].Value) == true)
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

        private void dgvMesas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Estado = "";
                txtIdMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[0].Value);
                txtCodigoMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[1].Value);
                txtAsientos.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[3].Value).Trim();

                if (Convert.ToBoolean(dgvMesas.CurrentRow.Cells[2].Value) == true)
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

        private void dgvMesas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string Estado = "";
                txtIdMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[0].Value);
                txtCodigoMesa.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[1].Value);
                txtAsientos.Text = Convert.ToString(dgvMesas.CurrentRow.Cells[3].Value).Trim();

                if (Convert.ToBoolean(dgvMesas.CurrentRow.Cells[2].Value) == true)
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

        private void dgvFotos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
