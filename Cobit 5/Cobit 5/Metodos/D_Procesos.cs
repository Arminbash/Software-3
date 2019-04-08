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
    }
}
