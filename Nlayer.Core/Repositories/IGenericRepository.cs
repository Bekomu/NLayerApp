using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetByIdAsync(int id);

        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);

        // productRepo.Where(x => x.id > 5).ToListAsync();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task<T> AddAsync(T entity);

        Task<T> AddRangeAsync(IEnumerable<T> entities);

        // update async değil çünkü bu entity, efcore tarafından memory de takip edilen state i değiştiriyoruz.
        void Update(T entity);

        void Remove(T entity);

        void RemoveRage(IEnumerable<T> entities);
    }
}
