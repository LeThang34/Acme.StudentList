using System.Threading.Tasks;

namespace Acme.StudentList.Data;

public interface IStudentListDbSchemaMigrator
{
    Task MigrateAsync();
}
