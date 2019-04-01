using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobit_5.Clases_Modelo
{
    public class CriterioProceso
    {
        public string Criterio { get; set; }
        public Boolean seCumple { get; set; }
        public String Comentario { get; set; }
        public int noConseguido { get; set; }
        public int Parcialmente { get; set; }
        public int ParteConseguido { get; set; }
        public int Totalidad { get; set; }
        
    }
}
