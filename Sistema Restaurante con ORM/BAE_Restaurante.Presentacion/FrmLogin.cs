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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "BAE Restaurante", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                dgvUsers.DataSource = UsuarioNegocios.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int llave = 0;
            for (int j = 0; j < dgvUsers.RowCount-1; j++)
            {
                if( txtUser.Text== Convert.ToString(dgvUsers.Rows[j].Cells[1].Value) && txtPas.Text== Convert.ToString(dgvUsers.Rows[j].Cells[2].Value))
                {
                    llave = 1; 
                }
            }
            if (llave == 1)
            {
                FrmPrincipal mv = new FrmPrincipal();
                mv.lblUser.Text = txtUser.Text;
                mv.Show();
                this.Hide();
            }
            else
            {
                this.MensajeError("Usuario o contraseña incorrectos.");
            }
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
