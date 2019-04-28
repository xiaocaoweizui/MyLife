using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyLife.Authorization.Roles;
using MyLife.Authorization.Users;
using MyLife.MultiTenancy;

namespace MyLife.EntityFrameworkCore
{
    public class MyLifeDbContext : AbpZeroDbContext<Tenant, Role, User, MyLifeDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyLifeDbContext(DbContextOptions<MyLifeDbContext> options)
            : base(options)
        {
        }
    }
}
