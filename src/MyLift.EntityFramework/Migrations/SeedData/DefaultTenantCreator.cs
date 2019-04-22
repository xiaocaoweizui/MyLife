using System.Linq;
using MyLift.EntityFramework;
using MyLift.MultiTenancy;

namespace MyLift.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MyLiftDbContext _context;

        public DefaultTenantCreator(MyLiftDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
