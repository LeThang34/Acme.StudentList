using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StudentList.Students;

public interface IStudentAppService:
ICrudAppService< //Defines CRUD methods
        StudentDto, //Used to show studens
        Guid, //Primary key of the studens entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        //SearchFilterDto,
        CreateUpdateStudentDto> //Used to create/update a studens
{

}