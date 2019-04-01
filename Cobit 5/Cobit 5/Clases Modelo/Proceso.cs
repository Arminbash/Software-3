using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobit_5.Clases_Modelo
{
    public class Proceso
    {
        public string idProceso { get; set; }
        public string NombreProceso { get; set; }
        public string N1 { get; set; }
        public string N2 { get; set; }
        public string N3 { get; set; }
        public string N4 { get; set; }
        public string N5 { get; set; }
        public virtual ICollection<Nivel> Niveles { get; set; }
    }
}
