﻿using System;
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
        //se pondran todos los criterios del nivel 1 aqui
        private List<CriterioProceso> Nivel1()
        {
            // aqui se configura el nivel y su proposito
            nivelAct.idProceso = "EDM01";
            nivelAct.Proposito = "Proporcionar un enfoque coherente integrado y alineado " +
                                 "con el enfoque de gobierno de la empresa. Para asegurar que los relacionados " +
                                 "con las TI las decisiones se toman de acuerdo con las estrategias y objetivos de " +
                                 "la empresa, aseguran que los procesos relacionados con las TI son supervisados ​​con " +
                                 "eficacia y transparencia, el cumplimiento de los requisitos legales y reglamentarios " +
                                 "se confirma, y ​​se cumplen los requisitos de gobierno de los miembros del consejo.";
            //esta es la lista que se le otorgara a un datasource
            List<CriterioProceso> ListCrit = new List<CriterioProceso>();
            //se llena la lista con criterios
            CriterioProceso crit = new CriterioProceso();
            crit.Criterio = "EDM01-O1 Estratégica modelo de toma de decisiones de TI " +
                            "es eficaz y alineado con los requisitos ambientales y de grupos de interés internos y " +
                            "externos de la empresa.";
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

        private void btnN1_Click(object sender, EventArgs e)
        {
            grdProcesos1.DataSource = Nivel1();//cuando se de click en el boton se cargan todo los criterios del nivel
            txtPropositoNivel.Text = nivelAct.Proposito; // aqui le decimos que carge el proposito del nivel
        }
}
}
