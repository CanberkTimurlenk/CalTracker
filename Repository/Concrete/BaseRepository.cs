using Entities.Abstract;
using Repository.Context;
using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    internal class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {
        public void Create(T entity)
        {
            using (KaloriTakipDbContext db = new KaloriTakipDbContext())
            {
                db.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (KaloriTakipDbContext db = new KaloriTakipDbContext())
            {
               db.Remove(entity);
               db.SaveChanges();
            }
        }


        public List<T> GetAll(Expression<Func<T, bool>> filter=null)
        {
            using (KaloriTakipDbContext db = new KaloriTakipDbContext())
            {
                return db.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (KaloriTakipDbContext db = new KaloriTakipDbContext())
            {
               return db.Set<T>().Find(id);

            }
        }

        public void Update(T entity)
        {
            using (KaloriTakipDbContext db = new KaloriTakipDbContext())
            {
                db.Update(entity);
                db.SaveChanges();
            }
        }
    }
}
