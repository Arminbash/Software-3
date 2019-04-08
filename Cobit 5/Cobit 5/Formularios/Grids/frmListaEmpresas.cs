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
using DevExpress.XtraEditors;

namespace Cobit_5.Formularios.Grids
{
    public partial class frmListaEmpresas : DevExpress.XtraEditors.XtraForm
    {
        public int idEmpresa = 0;
        public IEmpresa contrato { get; set; }
        public frmListaEmpresas()
        {
            InitializeComponent();
        }

        private void frmListaEmpresas_Load(object sender, EventArgs e)
        {
            grdcEmpresas.DataSource = D_Empresa.obtenerEmpresas();
        }private void grdEmpresas_DoubleClick(object sender, EventArgs e)
        {
            if (grdEmpresas.GetFocusedRowCellValue(colId) != null)
            {
                idEmpresa = (int) grdEmpresas.GetFocusedRowCellValue(colId);
                contrato.ObtenerIdEmpresa(idEmpresa);
                this.Close();
            }
        }
    }
}