using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentList.Data;

/* This is used if database provider does't define
 * IStudentListDbSchemaMigrator implementation.
 */
public class NullStudentListDbSchemaMigrator : IStudentListDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
