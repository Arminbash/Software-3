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
        //Los procesos para la Gobernabilidad de TI de las empresas - Evaluar, directa y el monitor
        private List<Proceso> RellenarLista1()
        {
            Proceso pro1 = new Proceso();
            pro1.idProceso = "EDM01";
            pro1.NombreProceso = "Asegurar la gobernabilidad Ajuste Marco y Mantenimiento";
            pro1.N1 = "0";
            pro1.N2 = "0";
            pro1.N3 = "0";
            pro1.N4 = "0";
            pro1.N5 = "0";
            ListaProcesos1.Add(pro1);

            Proceso pro2 = new Proceso();
            pro2.idProceso = "EDM02";
            pro2.NombreProceso = "Beneficios garantizar la entrega";
            pro2.N1 = "0";
            pro2.N2 = "0";
            pro2.N3 = "0";
            pro2.N4 = "0";
            pro2.N5 = "0";
            ListaProcesos1.Add(pro2);

            Proceso pro3 = new Proceso();
            pro3.idProceso = "EDM03";
            pro3.NombreProceso = "Garantizar la optimización del Riesgo";
            pro3.N1 = "0";
            pro3.N2 = "0";
            pro3.N3 = "0";
            pro3.N4 = "0";
            pro3.N5 = "0";
            ListaProcesos1.Add(pro3);

            Proceso pro4 = new Proceso();
            pro4.idProceso = "EDM04";
            pro4.NombreProceso = "Asegurar la optimización de recursos";
            pro4.N1 = "0";
            pro4.N2 = "0";
            pro4.N3 = "0";
            pro4.N4 = "0";
            pro4.N5 = "0";
            ListaProcesos1.Add(pro4);

            Proceso pro5 = new Proceso();
            pro5.idProceso = "EDM05";
            pro5.NombreProceso = "Garantizar la transparencia de las partes interesadas";
            pro5.N1 = "0";
            pro5.N2 = "0";
            pro5.N3 = "0";
            pro5.N4 = "0";
            pro5.N5 = "0";
            ListaProcesos1.Add(pro5);

            return ListaProcesos1;
        }
        //Alinear, Planificar y Organizar
        private List<Proceso> RellenarLista2()
        {
            Proceso pro1 = new Proceso();
            pro1.idProceso = "APO01";
            pro1.NombreProceso = "Gestionar el Marco de gestión de TI";
            pro1.N1 = "0";
            pro1.N2 = "0";
            pro1.N3 = "0";
            pro1.N4 = "0";
            pro1.N5 = "0";
            ListaProcesos2.Add(pro1);

            Proceso pro2 = new Proceso();
            pro2.idProceso = "APO02";
            pro2.NombreProceso = "Manejo de Estrategia";
            pro2.N1 = "0";
            pro2.N2 = "0";
            pro2.N3 = "0";
            pro2.N4 = "0";
            pro2.N5 = "0";
            ListaProcesos2.Add(pro2);

            Proceso pro3 = new Proceso();
            pro3.idProceso = "APO03";
            pro3.NombreProceso = "Manejo de Arquitectura Empresarial";
            pro3.N1 = "0";
            pro3.N2 = "0";
            pro3.N3 = "0";
            pro3.N4 = "0";
            pro3.N5 = "0";
            ListaProcesos2.Add(pro3);

            Proceso pro4 = new Proceso();
            pro4.idProceso = "APO04";
            pro4.NombreProceso = "gestionar la innovación";
            pro4.N1 = "0";
            pro4.N2 = "0";
            pro4.N3 = "0";
            pro4.N4 = "0";
            pro4.N5 = "0";
            ListaProcesos2.Add(pro4);

            Proceso pro5 = new Proceso();
            pro5.idProceso = "APO05";
            pro5.NombreProceso = "Manejo de Cartera";
            pro5.N1 = "0";
            pro5.N2 = "0";
            pro5.N3 = "0";
            pro5.N4 = "0";
            pro5.N5 = "0";
            ListaProcesos2.Add(pro5);

            Proceso pro6 = new Proceso();
            pro6.idProceso = "APO06";
            pro6.NombreProceso = "Manejo de Presupuesto y Costos";
            pro6.N1 = "0";
            pro6.N2 = "0";
            pro6.N3 = "0";
            pro6.N4 = "0";
            pro6.N5 = "0";
            ListaProcesos2.Add(pro6);

            Proceso pro7 = new Proceso();
            pro7.idProceso = "APO07";
            pro7.NombreProceso = "Manejo de Recursos Humanos";
            pro7.N1 = "0";
            pro7.N2 = "0";
            pro7.N3 = "0";
            pro7.N4 = "0";
            pro7.N5 = "0";
            ListaProcesos2.Add(pro7);

            Proceso pro8 = new Proceso();
            pro8.idProceso = "APO08";
            pro8.NombreProceso = "administrar relaciones";
            pro8.N1 = "0";
            pro8.N2 = "0";
            pro8.N3 = "0";
            pro8.N4 = "0";
            pro8.N5 = "0";
            ListaProcesos2.Add(pro8);

            Proceso pro9 = new Proceso();
            pro9.idProceso = "APO09";
            pro9.NombreProceso = "Manejo de acuerdos de servicios";
            pro9.N1 = "0";
            pro9.N2 = "0";
            pro9.N3 = "0";
            pro9.N4 = "0";
            pro9.N5 = "0";
            ListaProcesos2.Add(pro9);

            Proceso pro10 = new Proceso();
            pro10.idProceso = "APO10";
            pro10.NombreProceso = "Manejo de Proveedores";
            pro10.N1 = "0";
            pro10.N2 = "0";
            pro10.N3 = "0";
            pro10.N4 = "0";
            pro10.N5 = "0";
            ListaProcesos2.Add(pro10);

            Proceso pro11 = new Proceso();
            pro11.idProceso = "APO11";
            pro11.NombreProceso = "Manejo de la Calidad";
            pro11.N1 = "0";
            pro11.N2 = "0";
            pro11.N3 = "0";
            pro11.N4 = "0";
            pro11.N5 = "0";
            ListaProcesos2.Add(pro11);

            Proceso pro12 = new Proceso();
            pro12.idProceso = "APO12";
            pro12.NombreProceso = "Manejo de Riesgo";
            pro12.N1 = "0";
            pro12.N2 = "0";
            pro12.N3 = "0";
            pro12.N4 = "0";
            pro12.N5 = "0";
            ListaProcesos2.Add(pro12);

            Proceso pro13 = new Proceso();
            pro13.idProceso = "APO13";
            pro13.NombreProceso = "administrar seguridad";
            pro13.N1 = "0";
            pro13.N2 = "0";
            pro13.N3 = "0";
            pro13.N4 = "0";
            pro13.N5 = "0";
            ListaProcesos2.Add(pro13);

            return ListaProcesos2;
        }
        //Construir, adquirir e implementar
        private List<Proceso> RellenarLista3()
        {
            Proceso pro1 = new Proceso();
            pro1.idProceso = "BAI01";
            pro1.NombreProceso = "Manejo de Programas y Proyectos";
            pro1.N1 = "0";
            pro1.N2 = "0";
            pro1.N3 = "0";
            pro1.N4 = "0";
            pro1.N5 = "0";
            ListaProcesos3.Add(pro1);

            Proceso pro2 = new Proceso();
            pro2.idProceso = "BAI02";
            pro2.NombreProceso = "Gestionar la definición de requerimientos";
            pro2.N1 = "0";
            pro2.N2 = "0";
            pro2.N3 = "0";
            pro2.N4 = "0";
            pro2.N5 = "0";
            ListaProcesos3.Add(pro2);

            Proceso pro3 = new Proceso();
            pro3.idProceso = "BAI03";
            pro3.NombreProceso = "Manejo de soluciones de identificación y Construir";
            pro3.N1 = "0";
            pro3.N2 = "0";
            pro3.N3 = "0";
            pro3.N4 = "0";
            pro3.N5 = "0";
            ListaProcesos3.Add(pro3);

            Proceso pro4 = new Proceso();
            pro4.idProceso = "BAI04";
            pro4.NombreProceso = "Gestionar la disponibilidad y capacidad";
            pro4.N1 = "0";
            pro4.N2 = "0";
            pro4.N3 = "0";
            pro4.N4 = "0";
            pro4.N5 = "0";
            ListaProcesos3.Add(pro4);

            Proceso pro5 = new Proceso();
            pro5.idProceso = "BAI05";
            pro5.NombreProceso = "Manejo del Cambio Organizacional habilitación";
            pro5.N1 = "0";
            pro5.N2 = "0";
            pro5.N3 = "0";
            pro5.N4 = "0";
            pro5.N5 = "0";
            ListaProcesos3.Add(pro5);

            Proceso pro6 = new Proceso();
            pro6.idProceso = "BAI06";
            pro6.NombreProceso = "gestionar los cambios";
            pro6.N1 = "0";
            pro6.N2 = "0";
            pro6.N3 = "0";
            pro6.N4 = "0";
            pro6.N5 = "0";
            ListaProcesos3.Add(pro6);

            Proceso pro7 = new Proceso();
            pro7.idProceso = "BAI07";
            pro7.NombreProceso = "La aceptación gestionar el cambio y la transición";
            pro7.N1 = "0";
            pro7.N2 = "0";
            pro7.N3 = "0";
            pro7.N4 = "0";
            pro7.N5 = "0";
            ListaProcesos3.Add(pro7);

            Proceso pro8 = new Proceso();
            pro8.idProceso = "BAI08";
            pro8.NombreProceso = "gestionar el conocimiento";
            pro8.N1 = "0";
            pro8.N2 = "0";
            pro8.N3 = "0";
            pro8.N4 = "0";
            pro8.N5 = "0";
            ListaProcesos3.Add(pro8);

            Proceso pro9 = new Proceso();
            pro9.idProceso = "BAI09";
            pro9.NombreProceso = "Manejo de Activos";
            pro9.N1 = "0";
            pro9.N2 = "0";
            pro9.N3 = "0";
            pro9.N4 = "0";
            pro9.N5 = "0";
            ListaProcesos3.Add(pro9);

            Proceso pro10 = new Proceso();
            pro10.idProceso = "BAI10";
            pro10.NombreProceso = "gestionar configuración";
            pro10.N1 = "0";
            pro10.N2 = "0";
            pro10.N3 = "0";
            pro10.N4 = "0";
            pro10.N5 = "0";
            ListaProcesos3.Add(pro10);
            return ListaProcesos3;
        }
        //Entregar, servicio y soporte
        private List<Proceso> RellenarLista4()
        {
            Proceso pro1 = new Proceso();
            pro1.idProceso = "DSS01";
            pro1.NombreProceso = "gestión de las operaciones";
            pro1.N1 = "0";
            pro1.N2 = "0";
            pro1.N3 = "0";
            pro1.N4 = "0";
            pro1.N5 = "0";
            ListaProcesos4.Add(pro1);

            Proceso pro2 = new Proceso();
            pro2.idProceso = "DSS02";
            pro2.NombreProceso = "Gestionar las solicitudes de servicio e incidentes";
            pro2.N1 = "0";
            pro2.N2 = "0";
            pro2.N3 = "0";
            pro2.N4 = "0";
            pro2.N5 = "0";
            ListaProcesos4.Add(pro2);

            Proceso pro3 = new Proceso();
            pro3.idProceso = "DSS03";
            pro3.NombreProceso = "Manejo de Problemas";
            pro3.N1 = "0";
            pro3.N2 = "0";
            pro3.N3 = "0";
            pro3.N4 = "0";
            pro3.N5 = "0";
            ListaProcesos4.Add(pro3);

            Proceso pro4 = new Proceso();
            pro4.idProceso = "DSS04";
            pro4.NombreProceso = "Manejo de Continuidad";
            pro4.N1 = "0";
            pro4.N2 = "0";
            pro4.N3 = "0";
            pro4.N4 = "0";
            pro4.N5 = "0";
            ListaProcesos4.Add(pro4);

            Proceso pro5 = new Proceso();
            pro5.idProceso = "DSS05";
            pro5.NombreProceso = "Manejo de Servicios de Seguridad";
            pro5.N1 = "0";
            pro5.N2 = "0";
            pro5.N3 = "0";
            pro5.N4 = "0";
            pro5.N5 = "0";
            ListaProcesos4.Add(pro5);

            Proceso pro6 = new Proceso();
            pro6.idProceso = "DSS06";
            pro6.NombreProceso = "Manejo Controles de Procesos de Negocios";
            pro6.N1 = "0";
            pro6.N2 = "0";
            pro6.N3 = "0";
            pro6.N4 = "0";
            pro6.N5 = "0";
            ListaProcesos4.Add(pro6);

            return ListaProcesos4;
        }
        //Monitorear, evaluar y valorar
        private List<Proceso> RellenarLista5()
        {
            Proceso pro1 = new Proceso();
            pro1.idProceso = "MEA01";
            pro1.NombreProceso = "Monitorear, evaluar y evaluar el desempeño y Conformidad";
            pro1.N1 = "0";
            pro1.N2 = "0";
            pro1.N3 = "0";
            pro1.N4 = "0";
            pro1.N5 = "0";
            ListaProcesos5.Add(pro1);

            Proceso pro2 = new Proceso();
            pro2.idProceso = "MEA02";
            pro2.NombreProceso = "Monitorear, evaluar y evaluar el sistema de control interno";
            pro2.N1 = "0";
            pro2.N2 = "0";
            pro2.N3 = "0";
            pro2.N4 = "0";
            pro2.N5 = "0";
            ListaProcesos5.Add(pro2);

            Proceso pro3 = new Proceso();
            pro3.idProceso = "MEA03";
            pro3.NombreProceso = "Monitorear, evaluar y evaluar el cumplimiento de los requisitos externos";
            pro3.N1 = "0";
            pro3.N2 = "0";
            pro3.N3 = "0";
            pro3.N4 = "0";
            pro3.N5 = "0";
            ListaProcesos5.Add(pro3);

            return ListaProcesos5;
        }
        private void frmListaProcesos_Load(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = RellenarLista1();
            grdProcesos2.DataSource = RellenarLista2();
            grdProcesos3.DataSource = RellenarLista3();
            grdProcesos4.DataSource = RellenarLista4();
            grdProcesos5.DataSource = RellenarLista5();
        }
        private void grdProcesos1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
         if   (ListaProcesos1[e.RowIndex].idProceso != null)
         {
             frmNivelesProceso nvProc = new frmNivelesProceso();
             nvProc.proceso = ListaProcesos1[e.RowIndex];
             nvProc.ShowDialog(this);
         }
        }
        private void grdProcesos2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProcesos2[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos2[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProcesos3[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos3[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProcesos4[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos4[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
        private void grdProcesos5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ListaProcesos5[e.RowIndex].idProceso != null)
            {
                frmNivelesProceso nvProc = new frmNivelesProceso();
                nvProc.proceso = ListaProcesos5[e.RowIndex];
                nvProc.ShowDialog(this);
            }
        }
    }
}
