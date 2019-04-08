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
using Cobit_5.Datos;
using Cobit_5.Metodos;
using DevExpress.XtraEditors;
namespace Cobit_5.Formularios{
    public partial class frmDatosEmpresa : DevExpress.XtraEditors.XtraForm,Clases_Modelo.IMetodos
    {
        public int idEmpresa = 0;
        public IEmpresa contrato { get; set; }
        public frmDatosEmpresa()
        {
            InitializeComponent();
        }

        private void frmDatosEmpresa_Load(object sender, EventArgs e)
        {
            spIdEmpresa.Value = idEmpresa;
        }

        private void rellenarEmpresa(ref DatosEmpresa emp)
        {
            emp.Id = idEmpresa;
            emp.Nombre = txtNombreEmpresa.Text;
            emp.Proposito = txtPropositoEmpresa.Text;
            emp.Estatus = true;
        }
        public void Guardar()
        {
            if (spIdEmpresa.Value==0)
            try
            {
                DatosEmpresa emp = new DatosEmpresa();
                rellenarEmpresa(ref emp);
                D_MetodosGenericos met =new D_MetodosGenericos();
                if (met.AddOrUpdateObj(emp, new Software3Entities()))
                {
                    MessageBox.Show("Se guardo correctamente", "Accion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    spIdEmpresa.Value = D_Empresa.obtenerIdUltimaEmpresa();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al guardar", "Error en el metodo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrio un error al guardar", "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Salir()
        {
            this.Close();
        }
        public void Editar()
        {
            if (spIdEmpresa.Value > 0)
                try
                {
                    DatosEmpresa emp = new DatosEmpresa();
                    rellenarEmpresa(ref emp);
                    D_MetodosGenericos met = new D_MetodosGenericos();
                    if (met.AddOrUpdateObj(emp, new Software3Entities()))
                    {
                        MessageBox.Show("Se edito correctamente", "Accion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error al editar", "Error en el metodo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocurrio un error al editar", "Mensaje Error", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
        private void frmDatosEmpresa_FormClosed(object sender, FormClosedEventArgs e)
        {
           contrato.ObtenerIdEmpresa(idEmpresa);
        }
        private void spIdEmpresa_EditValueChanged(object sender, EventArgs e)
        {
            idEmpresa = (int) spIdEmpresa.Value;
            DatosEmpresa emp = new DatosEmpresa();
            emp = D_Empresa.obtenerEmpresaXId(idEmpresa);
            if (emp != null)
            {
                txtNombreEmpresa.Text = emp.Nombre;
                txtPropositoEmpresa.Text = emp.Proposito;}
        }
    }
}