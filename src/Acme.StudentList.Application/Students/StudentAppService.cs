using Acme.StudentList.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentList.Students;

public class StudentAppService :
    CrudAppService<
        Student, 
        StudentDto, 
        Guid,  
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        //SearchFilterDto,
        CreateUpdateStudentDto>, //Used to create/update
    IStudentAppService //implement the IStudentAppService
{
    public StudentAppService(IRepository<Student, Guid> repository)
        : base(repository)
    {
        GetPolicyName = StudentListPermissions.Students.Default;
        GetListPolicyName = StudentListPermissions.Students.Default;
        CreatePolicyName = StudentListPermissions.Students.Create;
        UpdatePolicyName = StudentListPermissions.Students.Edit;
        DeletePolicyName = StudentListPermissions.Students.Delete;
    }

}
