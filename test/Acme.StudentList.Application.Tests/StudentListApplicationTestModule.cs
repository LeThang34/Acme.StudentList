using Volo.Abp.Modularity;

namespace Acme.StudentList;

[DependsOn(
    typeof(StudentListApplicationModule),
    typeof(StudentListDomainTestModule)
)]
public class StudentListApplicationTestModule : AbpModule
{

}
