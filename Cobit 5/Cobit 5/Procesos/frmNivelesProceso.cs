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
using Cobit_5.Datos;
using Cobit_5.Metodos;
using Proceso = Cobit_5.Clases_Modelo.Proceso;

namespace Cobit_5.Procesos
{
    public partial class frmNivelesProceso : Form, Clases_Modelo.IEmpresa, Clases_Modelo.IProceso
    {
        public Proceso proceso = new Proceso();
        public int IdEmpresa = 0;public int idProceso = 0;
        List<Clases_Modelo.CriterioProceso> listCrit = new List<CriterioProceso>();
        public string nivelActual = "Nivel 0";
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
        private void btnN1_Click(object sender, EventArgs e){
            if ( nivelActual.StartsWith("Nivel 1") || nivelActual.StartsWith("Nivel 2") ||
                nivelActual.StartsWith("Nivel 3") || nivelActual.StartsWith("Nivel 4") || nivelActual.StartsWith("Nivel 5"))
            { }
            else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 1", idProceso);
            listCrit.Clear();
            foreach (var x in dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 1"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }

            try
            {
                foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
                {
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(1);
        }
        private void btN2_Click(object sender, EventArgs e)
        {
            if ( nivelActual.StartsWith("Nivel 2") ||nivelActual.StartsWith("Nivel 3") || nivelActual.StartsWith("Nivel 4") || nivelActual.StartsWith("Nivel 5"))
            { }
            else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 2", idProceso);
            listCrit.Clear();
            foreach (var x in  dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 2"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }

            try
            {
                foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
                {
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(2);
        }
        private void btnN4_Click(object sender, EventArgs e){
            if ( nivelActual.StartsWith("Nivel 4") || nivelActual.StartsWith("Nivel 5"))
            { }
            else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 4", idProceso);
            listCrit.Clear();
            foreach (var x in dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 4"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }

            try
            {
                foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
                {
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(4);
        }
        private void btnN0_Click(object sender, EventArgs e)
        {
            if (nivelActual.StartsWith("Nivel 0") || nivelActual.StartsWith("Nivel 1") || nivelActual.StartsWith("Nivel 2") ||
            nivelActual.StartsWith("Nivel 3") || nivelActual.StartsWith("Nivel 4") || nivelActual.StartsWith("Nivel 5"))
            { }
                else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 0", idProceso);
            listCrit.Clear();
            foreach (var x in dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 0"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }

            try
            {
                foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
                {
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(0);
        }
        private void btN3_Click(object sender, EventArgs e)
        {
            if (nivelActual.StartsWith("Nivel 3") || nivelActual.StartsWith("Nivel 4") || nivelActual.StartsWith("Nivel 5"))
            { }
            else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 3", idProceso);
            listCrit.Clear();
            foreach (var x in dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 3"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }
            try
            {
                foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
                {
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                    listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(3);
        }
        private void btnN5_Click(object sender, EventArgs e){
            if ( nivelActual.StartsWith("Nivel 5"))
            { }
            else
            {
                MessageBox.Show("Debe rellenar los niveles anteriores", "Accion Incorrecta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            D_Nivel dNivel = new D_Nivel();
            int IdNivel = D_Nivel.obtenerIdnivelXEmp("Nivel 5", idProceso);
            listCrit.Clear();
            foreach (var x in dNivel.ObtenerCriteriosXNivel(proceso.idProceso, "Nivel 5"))
            {
                Clases_Modelo.CriterioProceso crit = new CriterioProceso();
                crit.Criterio = x.Criterio;
                crit.Comentario = x.Comentario;
                crit.seCumple = x.seCumple;
                crit.noConseguido = x.noConseguido;
                crit.Parcialmente = x.Parcialmente;
                crit.ParteConseguido = x.ParteConseguido;
                crit.Totalidad = x.Totalidad;
                listCrit.Add(crit);
            }

            try
            {
            foreach (var y in D_Criterios.obtenerListaCriterioEmp(IdNivel, IdEmpresa))
            {
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Comentario = y.Comentario;
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).seCumple = (bool)y.SeCumple;
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).noConseguido = (int)y.NoConseguido;
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).ParteConseguido = (int)y.ParteConseguido;
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Parcialmente = (int)y.Parcialmente;
                listCrit.Find(x => x.Criterio == y.Criterio.DetalleCriterio).Totalidad = (int)y.Totalidad;
            }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }

            grdcProcesos1.DataSource = null;
            grdcProcesos1.DataSource = listCrit;
            txtPropositoNivel.Text = dNivel.ObtenerPropositoXNivel(5);
        }
        private void grdProcesos1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.Name == "colnoConseguido")
            {
                int value = 0;
                if (listCrit[e.RowHandle].seCumple == true)
                    value = (int) e.Value;
                listCrit[e.RowHandle].noConseguido = value;
                listCrit[e.RowHandle].ParteConseguido = 0;
                listCrit[e.RowHandle].Parcialmente = 0;
                listCrit[e.RowHandle].Totalidad = 0;
            }
            if (e.Column.Name == "colParcialmente")
            {
                int value = 0;
                if (listCrit[e.RowHandle].seCumple == true)value = (int)e.Value;
                if (value < 15 && value>0)
                    value = 16;
                listCrit[e.RowHandle].noConseguido = 0;
                listCrit[e.RowHandle].ParteConseguido = 0;
                listCrit[e.RowHandle].Parcialmente = value;
                listCrit[e.RowHandle].Totalidad = 0;
            }
            if (e.Column.Name == "colParteConseguido")
            {
                int value = 0;
                if (listCrit[e.RowHandle].seCumple == true)
                    value = (int)e.Value;
                if (value < 50 && value > 0)
                    value = 51;
                listCrit[e.RowHandle].noConseguido = 0;
                listCrit[e.RowHandle].ParteConseguido = value;
                listCrit[e.RowHandle].Parcialmente = 0;
                listCrit[e.RowHandle].Totalidad = 0;
            }
            if (e.Column.Name == "colTotalidad")
            {
                int value = 0;
                if (listCrit[e.RowHandle].seCumple == true)
                    value = (int)e.Value;
                if (value < 85 && value > 0)
                    value = 86;
                listCrit[e.RowHandle].noConseguido = 0;
                listCrit[e.RowHandle].ParteConseguido = 0;
                listCrit[e.RowHandle].Parcialmente = 0;
                listCrit[e.RowHandle].Totalidad = value;
            }
            if (e.Column.Name == "colseCumple")
            {
                if ((bool) e.Value == false)
                {
                listCrit[e.RowHandle].noConseguido = 0;
                listCrit[e.RowHandle].ParteConseguido = 0;
                listCrit[e.RowHandle].Parcialmente = 0;
                listCrit[e.RowHandle].Totalidad = 0;
                }
                
            }
        }

        public void ObtenerIdEmpresa(int id)
        {
            IdEmpresa = id;
            spIdEmpresa.Value = id;
        }

        public void ObtenerProceso(Proceso proc)
        {
            proceso = proc;
        }

        private void spIdEmpresa_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void rellenarLista(ref List<CriterioEmpresa> critsEmp)
        {
            foreach (var x in listCrit)
            {
                int idCrit = D_Criterios.obtenerIdCriterioXStr(x.Criterio);
                CriterioEmpresa crit = new CriterioEmpresa
                {
                    IdCriterio = idCrit,
                    IdEmpresa = IdEmpresa,
                    Id = D_Criterios.obtenerIdCriterioEmp(idCrit, IdEmpresa),
                    SeCumple = x.seCumple,
                    Comentario = x.Comentario,
                    NoConseguido = x.noConseguido,ParteConseguido = x.ParteConseguido,
                    Parcialmente = x.Parcialmente,
                    Totalidad = x.Totalidad,
                    Estatus = true
                };
                critsEmp.Add(crit);
            }
        }
        public void Guardar()
        {
            try
            {
           List<CriterioEmpresa> critsEmp = new List<CriterioEmpresa>();
           rellenarLista(ref critsEmp);
           D_MetodosGenericos met = new D_MetodosGenericos();
           if (met.AddOrUpdateRangeObj(critsEmp,new Software3Entities()))
           {
               MessageBox.Show("Se guardo correctamente", "Accion Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }}
