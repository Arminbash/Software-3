//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cobit_5.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Criterio
    {
        public Criterio()
        {
            this.CriterioEmpresa = new HashSet<CriterioEmpresa>();
        }
    
        public int Id { get; set; }
        public Nullable<int> IdNivel { get; set; }
        public string DetalleCriterio { get; set; }
        public Nullable<bool> Estatus { get; set; }
    
        public virtual Nivel Nivel { get; set; }
        public virtual ICollection<CriterioEmpresa> CriterioEmpresa { get; set; }
    }
}
