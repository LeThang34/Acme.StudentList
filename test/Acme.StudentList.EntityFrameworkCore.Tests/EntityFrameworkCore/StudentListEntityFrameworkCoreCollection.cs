using Xunit;

namespace Acme.StudentList.EntityFrameworkCore;

[CollectionDefinition(StudentListTestConsts.CollectionDefinitionName)]
public class StudentListEntityFrameworkCoreCollection : ICollectionFixture<StudentListEntityFrameworkCoreFixture>
{

}
