using Acme.StudentList.Students;
using AutoMapper;

namespace Acme.StudentList.Web;

public class StudentListWebAutoMapperProfile : Profile
{
    public StudentListWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
        CreateMap<StudentDto, CreateUpdateStudentDto>();
    }
}
