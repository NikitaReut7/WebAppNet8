using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Context
{
    public interface IDataContext
    {
        public EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
