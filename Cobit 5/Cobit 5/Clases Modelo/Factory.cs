using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cobit_5.Formularios;

namespace Cobit_5.Clases_Modelo
{
    public class IFactory
    {
        private enum _nombreFormularios
        {
            frmDatosEmpresa
        }
        public void GuardarFrm(Form frm)
        {
            if (frm != null)
            {
                if (frm.Name == _nombreFormularios.frmDatosEmpresa.ToString())
                {
                    frmDatosEmpresa data = (frmDatosEmpresa)frm;
                    data.Guardar();
                }
            }
        }

        public void EditarFrm(Form frm)
        {
            if (frm != null)
            {
                if (frm.Name == _nombreFormularios.frmDatosEmpresa.ToString())
                {
                    frmDatosEmpresa data = (frmDatosEmpresa)frm;
                    data.Editar();
                }
            }
        }

        public void SalirFrm(Form frm)
        {
            if (frm != null)
            {
                if (frm.Name == _nombreFormularios.frmDatosEmpresa.ToString())
                {
                    frmDatosEmpresa data = (frmDatosEmpresa)frm;
                    data.Salir();
                }
            }
        }

    }
}
