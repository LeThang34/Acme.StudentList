using Acme.StudentList.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.StudentList.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class StudentListController : AbpControllerBase
{
    protected StudentListController()
    {
        LocalizationResource = typeof(StudentListResource);
    }
}
