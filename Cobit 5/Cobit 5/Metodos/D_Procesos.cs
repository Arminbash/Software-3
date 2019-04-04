using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Cobit_5.Metodos
{
   public class D_Procesos
    {
        public List<Datos.Proceso> ObtenerProcesosXText (string Text)
        {
            List<Datos.Proceso> Lista = new List<Datos.Proceso>();
            using (var context = new Datos.Software3Entities())
            {
                Lista = context.Proceso.Where(x => x.CodigoProceso.StartsWith(Text)).ToList();
            }
            return Lista;
        }
    }
}
