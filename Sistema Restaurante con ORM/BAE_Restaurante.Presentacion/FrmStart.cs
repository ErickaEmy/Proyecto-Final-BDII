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
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmStart_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Listar();
        }

        public void Listar()
        {
            dgvProductos.DataSource = ProductoNegocios.Listar();
            dgvPedidos.DataSource = PedidoNegocios.ListarActivos();
            int contadorproductos = 0;
            int productoscero = 0;
            for (int i = 0; i < dgvProductos.RowCount; i++)
            {
                if (Convert.ToInt32(dgvProductos.Rows[i].Cells[2].Value) <= 3 && Convert.ToInt32(dgvProductos.Rows[i].Cells[2].Value) > 0)
                {
                    contadorproductos = contadorproductos + 1;
                }

                if (Convert.ToInt32(dgvProductos.Rows[i].Cells[2].Value) == 0)
                {
                    productoscero = productoscero + 1;
                }
            }

            if (dgvPedidos.RowCount > 0)
            {
                if (dgvPedidos.RowCount > 1)
                {
                    dgvAvisos.Rows.Add(dgvPedidos.RowCount, " pedidos están activos.");
                }
                else
                {
                    dgvAvisos.Rows.Add(dgvPedidos.RowCount, " pedido está activo.");
                }

            }

            if (contadorproductos > 0)
            {
                if (contadorproductos > 1)
                {
                    dgvAvisos.Rows.Add(contadorproductos, " productos están por agotarse.");
                }
                else
                {
                    dgvAvisos.Rows.Add(contadorproductos, " producto está por agotarse.");
                }
                    
            }
            if (productoscero > 0)
            {
                if (productoscero > 1)
                {
                    dgvAvisos.Rows.Add(productoscero, " productos se han agotado.");
                }
                else
                {
                    dgvAvisos.Rows.Add(productoscero, " producto se ha agotado.");
                }
  
            }
            
            dgvAvisos.DefaultCellStyle.SelectionForeColor = Color.Transparent;
            dgvAvisos.DefaultCellStyle.SelectionBackColor = Color.Transparent;
        }
    }
}
