using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cobit_5.Clases_Modelo;
using Cobit_5.Metodos;
using Cobit_5.Procesos;
using DevExpress.XtraEditors;

namespace Cobit_5.Formularios.Procesos
{
    public partial class frmProcesosBAI : DevExpress.XtraEditors.XtraForm
    {
        public int idEmpresa = 0;
        public IEmpresa contrato { get; set; }
        List<Proceso> ListaProcesos3 = new List<Proceso>();
        public frmProcesosBAI()
        {
            InitializeComponent();
        }

        private void frmProcesosBAI_Load(object sender, EventArgs e)
        {
            Metodos.D_Procesos metodosProcesos = new Metodos.D_Procesos();
            grdcProcesos.DataSource = metodosProcesos.ObtenerProcesosXText("BAI");
        }
        private void grdProcesos_DoubleClick(object sender, EventArgs e)
        {
            ListaProcesos3 = (List<Proceso>)grdProcesos.DataSource;
            if (ListaProcesos3.FirstOrDefault(x => x.idProceso == (string)grdProcesos.GetFocusedRowCellValue(colidProceso)).idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos3.FirstOrDefault(x => x.idProceso == (string)grdProcesos.GetFocusedRowCellValue(colidProceso));
                nvProc.ObtenerIdEmpresa(idEmpresa);
                nvProc.idProceso =
                    Metodos.D_Procesos.obtenerIdProcesoXStr((string)grdProcesos.GetFocusedRowCellValue(colidProceso));
                nvProc.nivelActual =
                    D_Nivel.obtenerUltimoNivel((string)grdProcesos.GetFocusedRowCellValue(colidProceso), idEmpresa);
                nvProc.ShowDialog(this);
            }
        }
    }
}