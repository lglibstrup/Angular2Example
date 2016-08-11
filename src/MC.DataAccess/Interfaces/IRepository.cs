using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MC.DataAccess.Interfaces
{
    public interface IRepository<T, in TK>
    {
        IMCContext MCContext { get; set; }
        IQueryable<T> GetAll();
        T GetSingle(TK entityKey);
        IQueryable<T> FindBy(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
    }
}
