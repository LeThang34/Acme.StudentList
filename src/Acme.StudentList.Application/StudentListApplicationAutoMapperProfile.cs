using Acme.StudentList.Students;
using AutoMapper;

namespace Acme.StudentList;

public class StudentListApplicationAutoMapperProfile : Profile
{
    public StudentListApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Student, StudentDto>();
        CreateMap<CreateUpdateStudentDto, Student>();
    }
}
