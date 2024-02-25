using Microsoft.AspNetCore.Builder;
using Acme.StudentList;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<StudentListWebTestModule>();

public partial class Program
{
}
