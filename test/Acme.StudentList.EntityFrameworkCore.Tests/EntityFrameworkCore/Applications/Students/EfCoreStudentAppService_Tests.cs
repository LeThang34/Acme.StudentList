using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.StudentList.Students;
using Xunit;

namespace Acme.StudentList.EntityFrameworkCore.Applications.Students;
[Collection(StudentListTestConsts.CollectionDefinitionName)]
public class EfCoreStudentAppService_Tests : StudentAppService_Tests<StudentListEntityFrameworkCoreTestModule>
{
}
