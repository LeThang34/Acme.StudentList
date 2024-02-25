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
        Student, //The Book entity
        StudentDto, //Used to show books
        Guid, //Primary key of the book entity  
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDto>, //Used to create/update a book
    IStudentAppService //implement the IBookAppService
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
