using Entities.Abstract;
using Repository.Context;
using System.Linq.Expressions;

namespace Repository.Abstract.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {

        public void Create(T entity)
        {
            using (KaloriTakipDbContext context = new KaloriTakipDbContext())
            {
                context.Add(entity);
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (KaloriTakipDbContext context = new KaloriTakipDbContext())
            {
                context.Remove(entity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            using (KaloriTakipDbContext context = new KaloriTakipDbContext())
            {
                return context.Set<T>().Where(filter).ToList();
            }
        }

        public T GetById(int id)
        {
            using (KaloriTakipDbContext context = new KaloriTakipDbContext())
            {
                return context.Set<T>().Find(id);

            }
        }

        public void Update(T entity)
        {
            using (KaloriTakipDbContext context = new KaloriTakipDbContext())
            {
                context.Update(entity);
                context.SaveChanges();
            }
        }
    }
}
