using System.Linq.Expressions;

namespace BookingApp.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null);
        TEntity Get(Expression<Func<TEntity, bool>> predicate);
        TEntity GetById(int  id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void DeleteAll(int id);
        void Delete(TEntity entity);
    }
}
