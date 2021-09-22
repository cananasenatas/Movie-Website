using MovieWebSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MovieWebSite.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context context = new Context();


        public List<T> TList()
        {
            return context.Set<T>().ToList();
        }

        public void TAdd(T t)
        {
            context.Set<T>().Add(t);
            context.SaveChanges();

        }
        public void TDelete(T t)
        {
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public void TUpdate(T t)
        {
            context.Set<T>().Update(t);
            context.SaveChanges();

        }


        public T TGet(int id)
        {
            return context.Set<T>().Find(id);
        }
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return context.Set<T>().Where(filter).ToList();
        }

    }
}


