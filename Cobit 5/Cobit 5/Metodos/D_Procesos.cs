using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cobit_5.Datos;

namespace Cobit_5.Metodos
{
   public class D_Procesos
    {
       public List<Clases_Modelo.Proceso> ObtenerProcesosXText(string Text)
        {
            using (var dbContext = new Software3Entities())
            {
                var query = (from n in dbContext.Proceso
                             select new Clases_Modelo.Proceso()
                    {
                        idProceso = n.CodigoProceso,
                        NombreProceso = n.NombreProceso,
                        N0 = "0",
                        N1 = "0",
                        N2 = "0",
                        N3 = "0",
                        N4 = "0",
                        N5 = "0"
                    }).Where(x => x.idProceso.StartsWith(Text)).ToList();
                return query;
            }
        }
       public static int obtenerIdProcesoXStr(string txt)
       {
           using (Software3Entities context = new Software3Entities())
           {
               int query = (from proc in context.Proceso
                   where proc.CodigoProceso.StartsWith(txt)
                   select proc.Id).FirstOrDefault();
               return query;
           }
       }

       public class objTemp
       {
           public string nomNivel { get; set; }
           public decimal puntaje { get; set; }
       }

       public static List<objTemp> obtenerPorcentajesXStr(string txt, int idEmpresa)
       {
           using (Software3Entities context = new Software3Entities())
           {
 var query = (from proc in context.Proceso
                   join niv in context.Nivel on proc.Id equals niv.IdProceso
                   where proc.CodigoProceso.StartsWith(txt)select new objTemp
                   {
                     nomNivel= niv.CodigoNivel,puntaje = ((from crit in context.Criterio join 
                                                  critEmp in context.CriterioEmpresa on crit.Id equals critEmp.IdCriterio
                                              where crit.IdNivel == niv.Id && critEmp.IdEmpresa == idEmpresa
                                              select critEmp).Sum(x => x.NoConseguido+x.ParteConseguido+x.Parcialmente+x.Totalidad)  /
                                          (from crit in context.Criterio join 
                                                  critEmp in context.CriterioEmpresa on crit.Id equals critEmp.IdCriterio
                                              where crit.IdNivel == niv.Id && critEmp.IdEmpresa == idEmpresa
                                           select critEmp).Count()) == null ? 0 :(decimal) ((from crit in context.Criterio
                                                                                       join
                                                                                           critEmp in context.CriterioEmpresa on crit.Id equals critEmp.IdCriterio
                                                                                       where crit.IdNivel == niv.Id && critEmp.IdEmpresa == idEmpresa
                                                                                       select critEmp).Sum(x => x.NoConseguido + x.ParteConseguido + x.Parcialmente + x.Totalidad) /
                                                                                   (from crit in context.Criterio
                                                                                       join
                                                                                           critEmp in context.CriterioEmpresa on crit.Id equals critEmp.IdCriterio
                                                                                       where crit.IdNivel == niv.Id && critEmp.IdEmpresa == idEmpresa
                                                                                       select critEmp).Count()) 
                   }).ToList();
               return query;
             }
       }
    }
}
