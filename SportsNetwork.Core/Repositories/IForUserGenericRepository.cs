using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SportsNetwork.Core.Repositories
{
    /**************************************************************** 
    * Date: 20.05.2022
    * Signed-off-by: Ömer TÜRKGELDİ < turkgeldiomer@gmail.com>
    * GitHub : https://github.com/omerturkgeldi
    ****************************************************************/
    public interface IForUserGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id);

        Task<IEnumerable<TEntity>> GetAllAsync();

        IQueryable<TEntity> Where(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);

        void Remove(TEntity entity);

        TEntity Update(TEntity entity);
    }
}
