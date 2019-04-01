using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cobit_5.Clases_Modelo;

namespace Cobit_5.Procesos
{
    public partial class frmNivelesProceso : Form
    {
       public Proceso  proceso = new Proceso();
        public frmNivelesProceso()
        {
            InitializeComponent();
        }
        private void frmNivelesProceso_Load(object sender, EventArgs e)
        {
            if (proceso != null)
            {
                txtIdentificador.Text = proceso.idProceso;
                txtNombre.Text = proceso.NombreProceso;
                lblN1.Text = proceso.N1;
                lblN2.Text = proceso.N2;
                lblN3.Text = proceso.N3;
                lblN4.Text = proceso.N4;
                lblN5.Text = proceso.N5;
            }
        }
    }
}
