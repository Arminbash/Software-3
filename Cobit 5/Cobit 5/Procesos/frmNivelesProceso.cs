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
            crit.Criterio = "una)Se identifican objetivos para el rendimiento del proceso.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);

            CriterioProceso crit2 = new CriterioProceso();
            crit2.Criterio = "El rendimiento del proceso es planificado y supervisado.";
            crit2.seCumple = false;
            crit2.Comentario = "";
            crit2.noConseguido = 0;
            crit2.Parcialmente = 0;
            crit2.ParteConseguido = 0;
            crit2.Totalidad = 0;
            ListCrit.Add(crit2);


            CriterioProceso crit3 = new CriterioProceso();
            crit3.Criterio = "El rendimiento del proceso se ajusta para satisfacer los planes.";
            crit3.seCumple = false;
            crit3.Comentario = "";
            crit3.noConseguido = 0;
            crit3.Parcialmente = 0;
            crit3.ParteConseguido = 0;
            crit3.Totalidad = 0;
            ListCrit.Add(crit3);

            CriterioProceso crit4 = new CriterioProceso();
            crit4.Criterio = " Responsabilidades y autoridades para la realización del proceso se definen, asignados y comunicados.";
            crit4.seCumple = false;
            crit4.Comentario = "";
            crit4.noConseguido = 0;
            crit4.Parcialmente = 0;
            crit4.ParteConseguido = 0;
            crit4.Totalidad = 0;
            ListCrit.Add(crit4);

            CriterioProceso crit5 = new CriterioProceso();
            crit5.Criterio = "mi)Resources y la información necesaria para realizar el proceso se identifican, ponen a disposición, asignados y utilizados.";
            crit5.seCumple = false;
            crit5.Comentario = "";
            crit5.noConseguido = 0;
            crit5.Parcialmente = 0;
            crit5.ParteConseguido = 0;
            crit5.Totalidad = 0;
            ListCrit.Add(crit5);

            CriterioProceso crit6 = new CriterioProceso();
            crit6.Criterio = ")yonterfaces entre las partes involucradas son gestionados para asegurar tanto la comunicación efectiva y clara asignación de responsabilidades. ";
            crit6.seCumple = false;
            crit6.Comentario = "";
            crit6.noConseguido = 0;
            crit6.Parcialmente = 0;
            crit6.ParteConseguido = 0;
            crit6.Totalidad = 0;
            ListCrit.Add(crit6);

            return ListCrit;
            

        }
        private List<CriterioProceso> Nivel3()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 3.1 Definición del proceso - Una medida del grado en que un proceso estándar se mantiene para apoyar el despliegue del proceso definido.";
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "una)UNA proceso estándar, incluyendo guías de adaptación apropiadas, se define que describe los elementos fundamentales que deben ser incorporados en un proceso definido.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);

            CriterioProceso crit2 = new CriterioProceso();
            crit2.Criterio = "segundo)Tque la secuencia y la interacción del proceso estándar con otros procesos se determina.";
            crit2.seCumple = false;
            crit2.Comentario = "";
            crit2.noConseguido = 0;
            crit2.Parcialmente = 0;
            crit2.ParteConseguido = 0;
            crit2.Totalidad = 0;
            ListCrit.Add(crit2);

            CriterioProceso crit3 = new CriterioProceso();
            crit3.Criterio = " competencias y funciones necesarias para la realización de un proceso se identifican como parte del proceso estándar.";
            crit3.seCumple = false;
            crit3.Comentario = "";
            crit3.noConseguido = 0;
            crit3.Parcialmente = 0;
            crit3.ParteConseguido = 0;
            crit3.Totalidad = 0;
            ListCrit.Add(crit3);

            CriterioProceso crit4 = new CriterioProceso();
            crit4.Criterio = "re)Rinfraestructura EQUERIDO y entorno de trabajo para realizar un proceso se identifican como parte del proceso estándar.";
            crit4.seCumple = false;
            crit4.Comentario = "";
            crit4.noConseguido = 0;
            crit4.Parcialmente = 0;
            crit4.ParteConseguido = 0;
            crit4.Totalidad = 0;
            ListCrit.Add(crit4);

            CriterioProceso crit5 = new CriterioProceso();
            crit5.Criterio = "Sse determinan métodos uitable de control de eficacia e idoneidad del proceso.";
            crit5.seCumple = false;
            crit5.Comentario = "";
            crit5.noConseguido = 0;
            crit5.Parcialmente = 0;
            crit5.ParteConseguido = 0;
            crit5.Totalidad = 0;
            ListCrit.Add(crit5);
            return ListCrit;

        }
        private List<CriterioProceso> Nivel4()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 4.1 Proceso de medida - Una medida del grado en que se utilizan los resultados de medición para asegurar que el rendimiento del proceso es compatible con el logro de los objetivos de rendimiento de los procesos pertinentes en apoyo de los objetivos de negocio definidos.";
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "una)PAGinformación rocess necesita se establecen en apoyo de los objetivos de negocio definidos pertinentes.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);

            CriterioProceso crit2 = new CriterioProceso();
            crit2.Criterio = "segundo)PAGobjetivos de medición roceso se derivan de las necesidades de información de proceso.";
            crit2.seCumple = false;
            crit2.Comentario = "";
            crit2.noConseguido = 0;
            crit2.Parcialmente = 0;
            crit2.ParteConseguido = 0;
            crit2.Totalidad = 0;
            ListCrit.Add(crit2);

            CriterioProceso crit3 = new CriterioProceso();
            crit3.Criterio = "do)QSe establecen objetivos cuantitativas para el desempeño del proceso en apoyo de los objetivos de negocio relevantes.";
            crit3.seCumple = false;
            crit3.Comentario = "";
            crit3.noConseguido = 0;
            crit3.Parcialmente = 0;
            crit3.ParteConseguido = 0;
            crit3.Totalidad = 0;
            ListCrit.Add(crit3);

            CriterioProceso crit4 = new CriterioProceso();
            crit4.Criterio = "re)METROedidas y la frecuencia de medición se identifican y definen en línea con los objetivos de medición de procesos y objetivos cuantitativos para el rendimiento del proceso.";
            crit4.seCumple = false;
            crit4.Comentario = "";
            crit4.noConseguido = 0;
            crit4.Parcialmente = 0;
            crit4.ParteConseguido = 0;
            crit4.Totalidad = 0;
            ListCrit.Add(crit4);

            CriterioProceso crit5 = new CriterioProceso();
            crit5.Criterio = "mi)Resultados de medición se recogen, se analizaron e informaron el fin de controlar la medida en que se cumplan los objetivos cuantitativos para el rendimiento del proceso.";
            crit5.seCumple = false;
            crit5.Comentario = "";
            crit5.noConseguido = 0;
            crit5.Parcialmente = 0;
            crit5.ParteConseguido = 0;
            crit5.Totalidad = 0;
            ListCrit.Add(crit5);

            CriterioProceso crit6 = new CriterioProceso();
            crit6.Criterio = "f) Los resultados de medición se utilizan para caracterizar el rendimiento del proceso.";
            crit6.seCumple = false;
            crit6.Comentario = "";
            crit6.noConseguido = 0;
            crit6.Parcialmente = 0;
            crit6.ParteConseguido = 0;
            crit6.Totalidad = 0;
            ListCrit.Add(crit6);

            return ListCrit;
          
        }
        private List<CriterioProceso> Nivel5()
        {
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "PA 5.1 Proceso de innovación - Una medida del grado en que los cambios en el proceso se identifican a partir del análisis de las causas comunes de variación en el rendimiento, ya partir de las investigaciones de enfoques innovadores para la definición e implementación del proceso.  ";
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "a) los objetivos de mejora Pprocess para el proceso están definidos que apoyan los objetivos de negocio relevantes.";
            crit.seCumple = false;
            crit.Comentario = "";
            crit.noConseguido = 0;
            crit.Parcialmente = 0;
            crit.ParteConseguido = 0;
            crit.Totalidad = 0;
            ListCrit.Add(crit);

            CriterioProceso crit2 = new CriterioProceso();
            crit2.Criterio = "segundo)   UNASe analizan los datos ppropriate para identificar las causas comunes de las variaciones en el rendimiento del proceso.";
            crit2.seCumple = false;
            crit2.Comentario = "";
            crit2.noConseguido = 0;
            crit2.Parcialmente = 0;
            crit2.ParteConseguido = 0;
            crit2.Totalidad = 0;
            ListCrit.Add(crit2);

            CriterioProceso crit3 = new CriterioProceso();
            crit3.Criterio = "do)   UNASe analizan los datos ppropriate para identificar oportunidades de mejores prácticas y la innovación.";
            crit3.seCumple = false;
            crit3.Comentario = "";
            crit3.noConseguido = 0;
            crit3.Parcialmente = 0;
            crit3.ParteConseguido = 0;
            crit3.Totalidad = 0;
            ListCrit.Add(crit3);

            CriterioProceso crit4 = new CriterioProceso();
            crit4.Criterio = "re)   yoSe identifican oportunidades MEJORAMIENTO derivados de las nuevas tecnologías y conceptos de proceso.";
            crit4.seCumple = false;
            crit4.Comentario = "";
            crit4.noConseguido = 0;
            crit4.Parcialmente = 0;
            crit4.ParteConseguido = 0;
            crit4.Totalidad = 0;
            ListCrit.Add(crit4);

            CriterioProceso crit5 = new CriterioProceso();
            crit5.Criterio = "mi)   Una estrategia de ejecución se establece para alcanzar los objetivos de mejora de procesos. ";
            crit5.seCumple = false;
            crit5.Comentario = "";
            crit5.noConseguido = 0;
            crit5.Parcialmente = 0;
            crit5.ParteConseguido = 0;
            crit5.Totalidad = 0;
            ListCrit.Add(crit5);

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
            grdProcesos1.DataSource = Nivel4();
            txtPropositoNivel.Text = nivelAct.Proposito; //
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

        private void btnN5_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel5();
            txtPropositoNivel.Text = nivelAct.Proposito; //
        }
    }
}
