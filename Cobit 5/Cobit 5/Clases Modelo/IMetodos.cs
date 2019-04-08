using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cobit_5.Clases_Modelo
{
    public interface IMetodos
    {
        void Guardar();
        void Editar();
        void Salir();
    }

    public interface IEmpresa
    {
        void ObtenerIdEmpresa(int id); 
    }

    public interface IProceso
    {
        void ObtenerProceso(Proceso proc);
    }

}
