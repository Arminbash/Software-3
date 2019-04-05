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
    public partial class frmListaProcesos : Form
    {
        List<Proceso> ListaProcesos1 = new List<Proceso>();
        List<Proceso> ListaProcesos2 = new List<Proceso>();
        List<Proceso> ListaProcesos3 = new List<Proceso>();
        List<Proceso> ListaProcesos4 = new List<Proceso>();
        List<Proceso> ListaProcesos5 = new List<Proceso>();
        public frmListaProcesos()
        {
            InitializeComponent();
        }
        private void frmListaProcesos_Load(object sender, EventArgs e)
        {
            Metodos.D_Procesos metodosProcesos = new Metodos.D_Procesos();
            grdProcesos1.DataSource = metodosProcesos.ObtenerProcesosXText("EDM");
            grdProcesos2.DataSource = metodosProcesos.ObtenerProcesosXText("APO");
            grdProcesos3.DataSource = metodosProcesos.ObtenerProcesosXText("BAI");
            grdProcesos4.DataSource = metodosProcesos.ObtenerProcesosXText("DSS");
            grdProcesos5.DataSource = metodosProcesos.ObtenerProcesosXText("MEA");
        }
        private void grdProcesos1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaProcesos1 = (List<Proceso>) grdProcesos1.DataSource;
         if   (ListaProcesos1[e.RowIndex].idProceso != null)
         {
             frmNivelesProceso nvProc = new frmNivelesProceso();
             nvProc.proceso = ListaProcesos1[e.RowIndex];
             nvProc.ShowDialog(this);
         }
        }
        private void grdProcesos2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaProcesos2 = (List<Proceso>)grdProcesos2.DataSource;
            if (ListaProcesos2[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos2[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaProcesos3 = (List<Proceso>)grdProcesos3.DataSource;
            if (ListaProcesos3[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos3[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaProcesos4 = (List<Proceso>)grdProcesos4.DataSource;
            if (ListaProcesos4[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos4[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ListaProcesos5 = (List<Proceso>)grdProcesos5.DataSource;
            if (ListaProcesos5[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos5[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
    }
}
