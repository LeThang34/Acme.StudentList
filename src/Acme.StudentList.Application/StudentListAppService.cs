using System;
using System.Collections.Generic;
using System.Text;
using Acme.StudentList.Localization;
using Volo.Abp.Application.Services;

namespace Acme.StudentList;

/* Inherit your application services from this class.
 */
public abstract class StudentListAppService : ApplicationService
{
    protected StudentListAppService()
    {
        LocalizationResource = typeof(StudentListResource);
    }
}
