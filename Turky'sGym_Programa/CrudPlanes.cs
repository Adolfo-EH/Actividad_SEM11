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
    public partial class CrudPlanes : Form
    {

        public CrudPlanes()
        {
            InitializeComponent();

        }


        private void CrudPlanes_Load(object sender, EventArgs e)
        {
            cbb.Items.Add("DIARIO");
            cbb.Items.Add("MENSUAL");
            cbb.Items.Add("TRIMESTRAL");
            cbb.Items.Add("SEMESTRAL");
            cbb.Items.Add("ANUAL");




        }

        private void cbb_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
