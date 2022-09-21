using DAL.Abstract;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T: class
    {
        Context context = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object = context.Set<T>();
        }

      

        public void ChangeStatu(int id)
        {
            var value = context.Buses.Find(id);
            value.Status = !value.Status;
            context.SaveChanges();
        }

        public void Delete(T item)
        {
            _object.Remove(item);
            context.SaveChanges();
        }

        public T GetByID(int id)
        {
           return _object.Find(id);
        }

        public List<T> GetList()
        {
            return _object.ToList();
        }

        public void Insert(T item)
        {
            _object.Add(item);
            context.SaveChanges();
        }

        public void Update(T item)
        {
            context.SaveChanges();
        }
    }
}
