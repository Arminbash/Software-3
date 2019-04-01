using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobit_5.Clases_Modelo
{
   public class Nivel
    {
        public string idProceso { get; set; }
        public string Proposito { get; set; }
        public virtual ICollection<CriterioProceso> Criterios { get; set; }
    }
}
