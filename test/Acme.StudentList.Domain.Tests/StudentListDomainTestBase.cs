using Volo.Abp.Modularity;

namespace Acme.StudentList;

/* Inherit from this class for your domain layer tests. */
public abstract class StudentListDomainTestBase<TStartupModule> : StudentListTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
