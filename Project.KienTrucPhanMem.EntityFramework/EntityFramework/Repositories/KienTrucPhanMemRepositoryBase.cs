using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Project.KienTrucPhanMem.EntityFramework.Repositories
{
    public abstract class KienTrucPhanMemRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<KienTrucPhanMemDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected KienTrucPhanMemRepositoryBase(IDbContextProvider<KienTrucPhanMemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class KienTrucPhanMemRepositoryBase<TEntity> : KienTrucPhanMemRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected KienTrucPhanMemRepositoryBase(IDbContextProvider<KienTrucPhanMemDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
