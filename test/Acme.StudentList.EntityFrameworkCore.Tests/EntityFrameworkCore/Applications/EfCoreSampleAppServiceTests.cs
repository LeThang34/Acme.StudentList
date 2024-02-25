using Acme.StudentList.Samples;
using Xunit;

namespace Acme.StudentList.EntityFrameworkCore.Applications;

[Collection(StudentListTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<StudentListEntityFrameworkCoreTestModule>
{

}
