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
        public Proceso proceso = new Proceso();
        Nivel nivelAct = new Nivel();
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



        private List<CriterioProceso> Nivel0()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "El proceso no se lleva a cabo, o no lograr su propósito proceso. ";

            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "En este nivel, hay poca o ninguna evidencia de cualquier logro del propósito del proceso.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);
            return ListCrit;
        }
        //se pondran todos los criterios del nivel 1 aqui
        private List<CriterioProceso> Nivel1()
        {
            // aqui se configura el nivel y su proposito
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 1.1 El proceso implementado logra su propósito proceso.";
            //esta es la lista que se le otorgara a un datasource
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            //se llena la lista con criterios
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "EDM01-O1 Estratégica modelo de toma de decisiones de TI es eficaz y alineado con los requisitos ambientales y de grupos de interés internos y externos de la empresa.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);//este es el metodo de agregar a la lista de criterios

            CriterioProceso crit2 = new CriterioProceso();
            crit2.Criterio = "EDM01-O2 El sistema de gobierno de TI es incrustado en la empresa.";
            crit2.seCumple = false;
            crit2.Comentario = "";
            crit2.noConseguido = 0;
            crit2.Parcialmente = 0;
            crit2.ParteConseguido = 0;
            crit2.Totalidad = 0;
            ListCrit.Add(crit2);

            CriterioProceso crit3 = new CriterioProceso();
            crit3.Criterio = "EDM01-O2 Aseguramiento se obtiene que el sistema de gobierno de TI está funcionando eficazmente.";
            crit3.seCumple = false;
            crit3.Comentario = "";
            crit3.noConseguido = 0;
            crit3.Parcialmente = 0;
            crit3.ParteConseguido = 0;
            crit3.Totalidad = 0;
            ListCrit.Add(crit3);

            return ListCrit;//aqui se retorna todos loscriterios del nivel 1
        }

        private List<CriterioProceso> Nivel2()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 2.1 Administración de Rendimiento - Una medida del grado en que se gestiona el rendimiento del proceso.";

            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "una)Se identifican objetivos para el rendimiento del proceso." +
                            "segundo)El rendimiento del proceso es planificado y supervisado." +
                            "El rendimiento del proceso se ajusta para satisfacer los planes."+
                            "Responsabilidades y autoridades para la realización del proceso se definen, asignados y comunicados."+
                            "mi)Resources y la información necesaria para realizar el proceso se identifican, ponen a disposición, asignados y utilizados."+
                            "F)yonterfaces entre las partes involucradas son gestionados para asegurar tanto la comunicación efectiva y clara asignación de responsabilidades.";
            crit.seCumple = false;

            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);
            return ListCrit;
        }
        private List<CriterioProceso> Nivel3()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 3.1 Definición del proceso - Una medida del grado en que un proceso estándar se mantiene para apoyar el despliegue del proceso definido.";
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "una)UNA proceso estándar, incluyendo guías de adaptación apropiadas, se define que describe los elementos fundamentales que deben ser incorporados en un proceso definido." +
                            "segundo)Tque la secuencia y la interacción del proceso estándar con otros procesos se determina." +
                            "do)competencias y funciones necesarias para la realización de un proceso se identifican como parte del proceso estándar." +
                            "Responsabilidades y autoridades para la realización del proceso se definen, asignados y comunicados." +
                           " mi)Sse determinan métodos uitable de control de eficacia e idoneidad del proceso.";
            crit.seCumple = false;

            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);
            return ListCrit;
        }
        private List<CriterioProceso> Nivel4()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 3.1 Definición del proceso - Una medida del grado en que un proceso estándar se mantiene para apoyar el despliegue del proceso definido.";
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "una)UNA proceso estándar, incluyendo guías de adaptación apropiadas, se define que describe los elementos fundamentales que deben ser incorporados en un proceso definido." +
                            "segundo)Tque la secuencia y la interacción del proceso estándar con otros procesos se determina." +
                            "do)competencias y funciones necesarias para la realización de un proceso se identifican como parte del proceso estándar." +
                            "Responsabilidades y autoridades para la realización del proceso se definen, asignados y comunicados." +
                            " mi)Sse determinan métodos uitable de control de eficacia e idoneidad del proceso.";
            crit.seCumple = false;

            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);
            return ListCrit;
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel1();//cuando se de click en el boton se cargan todo los criterios del nivel
            txtPropositoNivel.Text = nivelAct.Proposito; // aqui le decimos que carge el proposito del nivel
        }

        private void btN2_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel2();
            txtPropositoNivel.Text = nivelAct.Proposito; //
        }

        private void btnN4_Click(object sender, EventArgs e)
        {

        }

        private void lblN3_Click(object sender, EventArgs e)
        {

        }

        private void lblN1_Click(object sender, EventArgs e)
        {

        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel0();
            txtPropositoNivel.Text = nivelAct.Proposito; //
        }

        private void btN3_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel3();
            txtPropositoNivel.Text = nivelAct.Proposito; //
        }
    }
}
