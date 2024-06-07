using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Turky_sGym_Programa
{
    public partial class CORE_VENTA_PRODUCTOS : Form
    {
        public CORE_VENTA_PRODUCTOS()
        {
            InitializeComponent();
        }

        private void CORE_VENTA_PRODUCTOS_Load(object sender, EventArgs e)
        {

        }

        private void cbxTipoPlan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblFechaRegistro_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoPlan_Click(object sender, EventArgs e)
        {

        }

        private void btnAnularVentaProducto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultarVentasProducto_Click_1(object sender, EventArgs e)
        {
            formConsultaProducto form2 = new formConsultaProducto();
            form2.StartPosition = FormStartPosition.Manual; // Especifica que se usará una posición manual
            form2.Location = new Point(100, 100);
            form2.Show();
        }
    }
}