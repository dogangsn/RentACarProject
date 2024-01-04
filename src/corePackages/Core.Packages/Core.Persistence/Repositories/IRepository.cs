using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public interface IRepository<IEntity, TEntity> : IQuery<TEntity> where TEntity : Entity<TEntity>
    {
        TEntity GetAsync(Expression<Func<TEntity, bool>> predicate, Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default);

        Paginate<TEntity> GetListAsync(Expression<Func<TEntity,
                                    bool>> predicate, Func<IQueryable<TEntity>,
                                    IOrderedQueryable<TEntity>>? orderBey = null,
                                    Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                                    int index = 0,
                                    int size = 10,
                                    bool withDeleted = false,
                                    bool enabledTracking = true,
                                    CancellationToken cancellationToken = default);

        Paginate<TEntity> GetListByDynamicAsync(DynamicQuery dynamic, Expression<Func<TEntity, bool>> predicate,
                              Func<IQueryable<TEntity>,
                              IOrderedQueryable<TEntity>>? orderBey = null,
                              Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>? include = null,
                              int index = 0,
                              int size = 10,
                              bool withDeleted = false,
                              bool enabledTracking = true,
                              CancellationToken cancellationToken = default);

        bool AnyAsync(Expression<Func<TEntity, bool>> predicate, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default);

        TEntity AddAsync(TEntity entity);

        ICollection<TEntity> AddRangeAsync(ICollection<TEntity> entity);

        TEntity UpdateAsync(TEntity entity);

        ICollection<TEntity> UpdateRangeAsync(ICollection<TEntity> entity);

        TEntity DeleteAsync(TEntity entity, bool permanent = false);

        ICollection<TEntity> DeleteRangeAsync(ICollection<TEntity> entity, bool permanent = false);
    }
}
