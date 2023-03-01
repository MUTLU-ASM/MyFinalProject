using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DateAccess
{
    //generic constrait
    //class : referans tip olabilir.
    //Entity : IEntity olabilir veya IEntity impelemente eden bir nesne olabilir.
    //new() : new lenebilir.
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
