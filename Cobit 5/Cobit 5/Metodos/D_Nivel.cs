using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Cobit_5.Datos;

namespace Cobit_5.Metodos
{
    public class D_Nivel
    {
        public List<Clases_Modelo.CriterioProceso> ObtenerCriteriosXNivel(string txtProceso, string txtNivel)
        {
            using (var dbContext = new Software3Entities())
            {
                var query = (from p in dbContext.Proceso 
                    join n in dbContext.Nivel on p.Id equals n.IdProceso
                    join c in dbContext.Criterio on n.Id equals c.IdNivel
                    where p.CodigoProceso == txtProceso && n.CodigoNivel.StartsWith(txtNivel)
                    select new Clases_Modelo.CriterioProceso()
                    {
                        Criterio = c.DetalleCriterio,
                        seCumple = false,
                        Comentario = "",
                        noConseguido = 0,
                        Parcialmente = 0,
                        ParteConseguido = 0,
                        Totalidad = 0
                    }).ToList();
                return query;
            }
        }
        public string ObtenerPropositoXNivel(int NumNivel)
        {
            using (var dbContext = new Software3Entities())
            {
                string delimiter = "";
                var query = (from p in dbContext.PropositoNivel
                    where p.IdNivel == NumNivel
                    select new Clases_Modelo.Nivel()
                    {
                        Proposito = p.Proposito
                    }).ToList();
                foreach (var x in query)
                {
                    delimiter = delimiter + "\n" +x.Proposito;
                }

                return delimiter;
            }
        }
        public static int obtenerIdnivelXEmp(string txt, int idProceso)
        {
            using (Software3Entities context = new Software3Entities())
            {
                int query = (from niv in context.Nivel
                             where niv.CodigoNivel.StartsWith(txt) && niv.IdProceso == idProceso
                    select niv.Id).FirstOrDefault();
                return query;
            }
        }

        public static string obtenerUltimoNivel(string txt, int idEmpresa)
        {
            using (Software3Entities context = new Software3Entities())
            {
                string NivelTXT = "Nivel 0";
                var Proceso = (from proc in context.Proceso
                    where proc.CodigoProceso.StartsWith(txt)
                    select proc).FirstOrDefault();

                foreach (var x in Proceso.Nivel.ToList())
                {
                    foreach (var y in x.Criterio)
                    {
                        var query = (from crit in   context.CriterioEmpresa 
                            where crit.IdCriterio == y.Id &&
                                  crit.IdEmpresa == idEmpresa
                            select crit).FirstOrDefault();
                        if (query != null)
                            NivelTXT = x.CodigoNivel;
                    }
                }

                return NivelTXT;
            }
        }
    }
}
