using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using SMZG.EntityFramework;

namespace SMZG.Migrator
{
    [DependsOn(typeof(SMZGDataModule))]
    public class SMZGMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<SMZGDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}