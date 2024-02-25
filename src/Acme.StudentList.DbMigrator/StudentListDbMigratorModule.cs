using Acme.StudentList.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Acme.StudentList.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(StudentListEntityFrameworkCoreModule),
    typeof(StudentListApplicationContractsModule)
    )]
public class StudentListDbMigratorModule : AbpModule
{
}
