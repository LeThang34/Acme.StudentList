using Volo.Abp.Modularity;

namespace Acme.StudentList;

public abstract class StudentListApplicationTestBase<TStartupModule> : StudentListTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
