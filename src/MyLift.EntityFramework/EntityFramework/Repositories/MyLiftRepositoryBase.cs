using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace MyLift.EntityFramework.Repositories
{
    public abstract class MyLiftRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<MyLiftDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected MyLiftRepositoryBase(IDbContextProvider<MyLiftDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class MyLiftRepositoryBase<TEntity> : MyLiftRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected MyLiftRepositoryBase(IDbContextProvider<MyLiftDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
