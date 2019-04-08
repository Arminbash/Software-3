using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cobit_5.Datos;
using DevExpress.Data.Helpers;

namespace Cobit_5.Metodos
{
   public class D_Criterios
    {
        public static int obtenerIdCriterioXStr(string txt)
        {
            using (Software3Entities context = new Software3Entities())
            {
                int query = (from crit in context.Criterio where crit.DetalleCriterio.StartsWith(txt) select crit.Id).FirstOrDefault();
                return query;
            }
        }
        public static int obtenerIdCriterioEmp(int IdCriterio, int idEmpresa)
        {
            using (Software3Entities context = new Software3Entities())
            {
                int query = (from crit in context.CriterioEmpresa
                             where crit.IdCriterio == IdCriterio &&
                                   crit.IdEmpresa==idEmpresa
                    select crit.Id).FirstOrDefault();
                return query;
            }
        }
        public static List<CriterioEmpresa> obtenerListaCriterioEmp(int idNivel, int idEmpresa)
        {
            Software3Entities context = new Software3Entities();

                var query = (from crit in context.Criterio join
                      critEmp in  context.CriterioEmpresa on crit.Id equals critEmp.IdCriterio
                             where crit.IdNivel == idNivel &&
                                   critEmp.IdEmpresa == idEmpresa
                             select critEmp).ToList();
                return query;

        }
    }
}
