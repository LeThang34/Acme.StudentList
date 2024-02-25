using Volo.Abp.Modularity;

namespace Acme.StudentList;

[DependsOn(
    typeof(StudentListDomainModule),
    typeof(StudentListTestBaseModule)
)]
public class StudentListDomainTestModule : AbpModule
{

}
