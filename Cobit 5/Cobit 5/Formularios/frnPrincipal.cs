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
using Cobit_5.Formularios.Grids;
using Cobit_5.Formularios.Procesos;
using DevExpress.XtraBars;

namespace Cobit_5.Formularios
{
    public partial class frnPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm, Clases_Modelo.IEmpresa
    {
        public int IdEmpresa = 0;
        public string NombreEmpresa;
        public string Contraseña;
        public string NombreUsuario;
        public string ObjetivosEmpresa;
        private Form fh;

        public frnPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirFormularioHijo(object formHijo)
        {
            if (this.panelFrm.Controls.Count > 0)
            {
                this.panelFrm.Controls.RemoveAt(0);
            }

            fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelFrm.Controls.Add(fh);
            this.panelFrm.Tag = fh;
           
        }

        private void ribbonStatusBar_Click(object sender, EventArgs e)
        {

        }

        private void frnPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void btnDatosEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            AbrirFormularioHijo(new frmDatosEmpresa());
            frmDatosEmpresa data = (frmDatosEmpresa) fh;
            data.contrato = this;
            data.idEmpresa = IdEmpresa;
            fh.Show();
        }

        private void frnPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnGuardar_ItemClick(object sender, ItemClickEventArgs e)
        {
            IFactory fabrica = new IFactory();
            fabrica.GuardarFrm(fh);
        }

        private void btnEditar_ItemClick(object sender, ItemClickEventArgs e)
        {
            IFactory fabrica = new IFactory();
            fabrica.EditarFrm(fh);
        }

        private void btnSalir_ItemClick(object sender, ItemClickEventArgs e)
        {
            IFactory fabrica = new IFactory();
            fabrica.SalirFrm(fh);
        }

        public void ObtenerIdEmpresa(int id)
        {
            IdEmpresa = id;
        }private void btnProcesoEDM_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IdEmpresa > 0)
            {
                AbrirFormularioHijo(new frmProcesosEDM());
                frmProcesosEDM data = (frmProcesosEDM)fh;
                data.contrato = this;
                data.idEmpresa = IdEmpresa;
                fh.Show();
            }      
        }

        private void btnProcesosAPO_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IdEmpresa > 0)
            {
                AbrirFormularioHijo(new frmProcesosAPO());
                frmProcesosAPO data = (frmProcesosAPO)fh;
                data.contrato = this;
                data.idEmpresa = IdEmpresa;
                fh.Show();
            }
        }

        private void btnProcesosBAI_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IdEmpresa > 0)
            {
                AbrirFormularioHijo(new frmProcesosBAI());
                frmProcesosBAI data = (frmProcesosBAI)fh;
                data.contrato = this;
                data.idEmpresa = IdEmpresa;
                fh.Show();
            }
        }

        private void btnProcesosDSS_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IdEmpresa > 0)
            {AbrirFormularioHijo(new frmProcesosDSS());
                frmProcesosDSS data = (frmProcesosDSS)fh;
                data.contrato = this;
                data.idEmpresa = IdEmpresa;
                fh.Show();
            }
        }

        private void btnProcesosMEA_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IdEmpresa > 0)
            {
                AbrirFormularioHijo(new frmProcesosMEA());
                frmProcesosMEA data = (frmProcesosMEA)fh;
                data.contrato = this;
                data.idEmpresa = IdEmpresa;
                fh.Show();
            }
        }
        private void btnCargarEmpresa_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmListaEmpresas listEmp = new frmListaEmpresas();
            listEmp.contrato = this;
            listEmp.ShowDialog(this);
        }
    }
}