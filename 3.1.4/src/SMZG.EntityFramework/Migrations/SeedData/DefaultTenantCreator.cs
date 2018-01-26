using System.Linq;
using SMZG.EntityFramework;
using SMZG.MultiTenancy;

namespace SMZG.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly SMZGDbContext _context;

        public DefaultTenantCreator(SMZGDbContext context)
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
