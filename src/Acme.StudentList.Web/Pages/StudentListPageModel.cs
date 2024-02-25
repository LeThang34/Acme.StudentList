using Acme.StudentList.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.StudentList.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class StudentListPageModel : AbpPageModel
{
    protected StudentListPageModel()
    {
        LocalizationResourceType = typeof(StudentListResource);
    }
}
