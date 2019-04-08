using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cobit_5.Datos;

namespace Cobit_5.Metodos
{
   public class D_MetodosGenericos
    {
        public bool AddOrUpdateObj<T>(T entity, DbContext db) where T : class
        {
                try
                {
                    if (db.Entry(entity).State == EntityState.Detached)
                        db.Set<T>().AddOrUpdate(entity);
                    db.SaveChanges(); 
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                    throw e;
                }
        }
        public bool AddOrUpdateRangeObj<T>(List<T> entitys, DbContext db) where T : class
        {
            try
            {
                foreach (var x in entitys)
                {
                    if (db.Entry(x).State == EntityState.Detached)
                        db.Set<T>().AddOrUpdate(x);
                    db.SaveChanges();
                }        
               
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }
    }
}
