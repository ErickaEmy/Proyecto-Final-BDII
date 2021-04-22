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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        private void AbrirFormulario(object formhija)
        {
            if (this.pnlFormulario.Controls.Count > 0)
                this.pnlFormulario.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlFormulario.Controls.Add(fh);
            this.pnlFormulario.Tag = fh;
            fh.Show();
           
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmStart());
            btnInicio.BackColor = Color.FromArgb(183, 115, 229);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            dgvUsers.DataSource = UsuarioNegocios.Listar();
            timer1.Enabled = true;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPedidos());
            btnPedidos.BackColor = Color.FromArgb(183, 115, 229);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlFormulario_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReservas());
            btnReservas.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpleados());
            btnReservas.BackColor = Color.FromArgb(153,0,255);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32,32,32,32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32,32,32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(128, 128, 128);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void dropPerfil_onItemSelected(object sender, EventArgs e)
        {
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmMenu());
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            btnProductos.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmProductos());
        }

        private void btnCaja_Click(object sender, EventArgs e)
        {
            btnCaja.BackColor = Color.FromArgb(128,128,128) ;
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32,32,32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmCaja());
        }

        private void btnControl_Click(object sender, EventArgs e)
        {
            btnControl.BackColor = Color.FromArgb(128,128,128);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32,32,32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            AbrirFormulario(new FrmControl());
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32,32,32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32,32,32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnReportes.BackColor = Color.FromArgb(128, 128, 128);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {

            AbrirFormulario(new FrmMantenimiento());
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32,32,32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32,32,32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(128, 128, 128);
        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEmpresa());
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32,32,32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(128, 128, 128);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmStart());
            btnInicio.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32,32,32) ;
            btnEmpresa.BackColor = Color.FromArgb(32,32,32) ;
            btnReportes.BackColor = Color.FromArgb(32,32,32) ;
            btnMantenimiento.BackColor = Color.FromArgb(32,32,32);

        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            btnClientes.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmClientes());
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            btnMesas.BackColor = Color.FromArgb(183, 115, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(32, 32, 32);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(32, 32, 32);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnContactos.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmMesas());
        }

        private void btnContactos_Click(object sender, EventArgs e)
        {
            btnContactos.BackColor = Color.FromArgb(137, 0, 229);
            btnPedidos.BackColor = Color.FromArgb(153, 0, 255);
            btnReservas.BackColor = Color.FromArgb(153, 0, 255);
            btnMenu.BackColor = Color.FromArgb(153, 0, 255);
            btnProductos.BackColor = Color.FromArgb(153, 0, 255);
            btnCaja.BackColor = Color.FromArgb(153, 0, 255);
            btnInicio.BackColor = Color.FromArgb(153, 0, 255);
            btnControl.BackColor = Color.FromArgb(153, 0, 255);
            btnClientes.BackColor = Color.FromArgb(153, 0, 255);
            btnMesas.BackColor = Color.FromArgb(153, 0, 255);
            btnEmpleados.BackColor = Color.FromArgb(32, 32, 32);
            btnEmpresa.BackColor = Color.FromArgb(32, 32, 32);
            btnReportes.BackColor = Color.FromArgb(32, 32, 32);
            btnMantenimiento.BackColor = Color.FromArgb(32, 32, 32);
            AbrirFormulario(new FrmClientes());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            //lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
