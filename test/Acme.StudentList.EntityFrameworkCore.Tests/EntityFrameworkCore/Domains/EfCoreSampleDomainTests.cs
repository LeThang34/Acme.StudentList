using Acme.StudentList.Samples;
using Xunit;

namespace Acme.StudentList.EntityFrameworkCore.Domains;

[Collection(StudentListTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<StudentListEntityFrameworkCoreTestModule>
{

}
