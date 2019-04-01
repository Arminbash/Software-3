using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cobit_5.Procesos;

namespace Cobit_5
{
    public partial class frmRellenarEmpresa : Form
    {
        public frmRellenarEmpresa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSig_Click(object sender, EventArgs e)
        {
            frmListaProcesos frmProcesos = new frmListaProcesos();
            frmProcesos.ShowDialog(this);
            this.Visible = false;
        }
    }
}
