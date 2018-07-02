using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DeployStudy.DIA.Service.Interface
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetAById(int id);
        IEnumerable<TEntity> GetPaged(Expression<Func<TEntity, bool>> predicate);
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}
