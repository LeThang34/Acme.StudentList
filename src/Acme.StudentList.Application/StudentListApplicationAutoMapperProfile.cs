using Acme.StudentList.Students;
using AutoMapper;

namespace Acme.StudentList;

public class StudentListApplicationAutoMapperProfile : Profile
{
    public StudentListApplicationAutoMapperProfile()
    {
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
