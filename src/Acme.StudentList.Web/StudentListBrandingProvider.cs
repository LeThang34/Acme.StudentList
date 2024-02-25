using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Acme.StudentList.Web;

[Dependency(ReplaceServices = true)]
public class StudentListBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "StudentList";
}
