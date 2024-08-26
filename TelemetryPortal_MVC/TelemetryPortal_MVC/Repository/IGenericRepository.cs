using System.Linq.Expressions;

namespace TelemetryPortal_MVC.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        T GetByID(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void AddAll(IEnumerable<T> entities);
        void Remove(T entity);
        void RemoveAll(IEnumerable<T> entitied);
        void Update(T entity);
        void UpdateAll(IEnumerable<T> entities);
    }
}
