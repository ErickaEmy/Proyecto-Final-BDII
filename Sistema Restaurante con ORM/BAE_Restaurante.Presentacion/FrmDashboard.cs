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
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

            dgvEmpleados.DataSource = EmpleadoNegocios.Listar();
            dgvUsers.DataSource = UsuarioNegocios.Listar();
            string idempleado = "0";
            for (int j = 0; j < dgvUsers.RowCount; j++)
            {
                if (lblUsuario.Text == Convert.ToString(dgvUsers.Rows[j].Cells[1].Value))
                {
                    idempleado = Convert.ToString(dgvUsers.Rows[j].Cells[7].Value);
                }
            }

            for (int j = 0; j < dgvEmpleados.RowCount; j++)
            {
                if (idempleado == Convert.ToString(dgvEmpleados.Rows[j].Cells[0].Value))
                {
                    lblNombres.Text = Convert.ToString(dgvEmpleados.Rows[j].Cells[2].Value);
                    lblApellidos.Text = Convert.ToString(dgvEmpleados.Rows[j].Cells[3].Value);
                    lblCelular.Text = Convert.ToString(dgvEmpleados.Rows[j].Cells[6].Value);
                    lblEmail.Text = Convert.ToString(dgvEmpleados.Rows[j].Cells[7].Value);
                }
            }
            
        }
    }
}
