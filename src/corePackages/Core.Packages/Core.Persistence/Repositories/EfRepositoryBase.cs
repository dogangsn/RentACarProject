using Core.Persistence.Dynamic;
using Core.Persistence.Paging;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Persistence.Repositories
{
    public class EfRepositoryBase<TEntity, TEntityId, TContext> : IAsyncRepository<TEntity, TEntityId>, IRepository<TEntity, TEntityId> where TEntity : Entity<TEntityId> where TContext : DbContext
    {
        protected readonly TContext Context;

        public EfRepositoryBase(TContext context)
        {
            Context = context;
        }

        public async Task<TEntity> AddAsync(TEntity entity)
        {
            entity.CreatedDate = DateTime.UtcNow;
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        public Task<ICollection<TEntity>> AddRangeAsync(ICollection<TEntity> entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> AnyAsync(Expression<Func<TEntityId, bool>> predicate, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityId> DeleteAsync(TEntityId entity, bool permanent = false)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntityId>> DeleteRangeAsync(ICollection<TEntityId> entity, bool permanent = false)
        {
            throw new NotImplementedException();
        }

        public Task<TEntityId> GetAsync(Expression<Func<TEntityId, bool>> predicate, Func<IQueryable<TEntityId>, IIncludableQueryable<TEntityId, object>>? include = null, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<TEntityId>> GetListAsync(Expression<Func<TEntityId, bool>> predicate, Func<IQueryable<TEntityId>, IOrderedQueryable<TEntityId>>? orderBey = null, Func<IQueryable<TEntityId>, IIncludableQueryable<TEntityId, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<Paginate<TEntityId>> GetListByDynamicAsync(DynamicQuery dynamic, Expression<Func<TEntityId, bool>> predicate, Func<IQueryable<TEntityId>, IOrderedQueryable<TEntityId>>? orderBey = null, Func<IQueryable<TEntityId>, IIncludableQueryable<TEntityId, object>>? include = null, int index = 0, int size = 10, bool withDeleted = false, bool enabledTracking = true, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntityId> Query()
        {
            throw new NotImplementedException();
        }

        public Task<TEntityId> UpdateAsync(TEntityId entity)
        {
            throw new NotImplementedException();
        }

        public Task<ICollection<TEntityId>> UpdateRangeAsync(ICollection<TEntityId> entity)
        {
            throw new NotImplementedException();
        }
    }
}
