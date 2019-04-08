using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Cobit_5.Datos;

namespace Cobit_5.Metodos
{
    public class D_Empresa
    {
        public static int obtenerIdUltimaEmpresa()
        {
            try
            {
                using (Software3Entities context = new Software3Entities())
                {
                    var query = (from emp in context.DatosEmpresa orderby emp.Id descending select emp.Id).FirstOrDefault();
                    return query;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 0;
            }
        }

        public static DatosEmpresa obtenerEmpresaXId(int idEmpresa)
        {
            try
            {
                using (Software3Entities context = new Software3Entities())
                {
                    var query = (from emp in context.DatosEmpresa where emp.Id==idEmpresa select emp).FirstOrDefault();
                    return query;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

        public static List<DatosEmpresa> obtenerEmpresas()
        {
            try
            {
                using (Software3Entities context = new Software3Entities())
                {
                    var query = (from emp in context.DatosEmpresa where emp.Estatus==true select emp).ToList();
                    return query;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }

    }
}
