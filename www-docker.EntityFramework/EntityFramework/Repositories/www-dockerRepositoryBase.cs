using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace www-docker.EntityFramework.Repositories
{
    public abstract class www-dockerRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<www-dockerDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected www-dockerRepositoryBase(IDbContextProvider<www-dockerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class www-dockerRepositoryBase<TEntity> : www-dockerRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected www-dockerRepositoryBase(IDbContextProvider<www-dockerDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
