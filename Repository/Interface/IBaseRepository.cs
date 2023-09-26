using Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Interface
{
    public interface IBaseRepository<T> where T : BaseEntity, IEntity, new()
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);

        T GetById(int id);
        List<T> GetAll(Expression<Func<T,bool>> expression);

    }
}
