using Acme.StudentList.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentList;
public class StudentListDataSeederContributor
    : IDataSeedContributor, ITransientDependency
{
    private readonly IRepository<Student, Guid> _studentRepository;

    public StudentListDataSeederContributor(IRepository<Student, Guid> studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public async Task SeedAsync(DataSeedContext context)
    {
        if (await _studentRepository.GetCountAsync() <= 0)
        {
            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Lê Đình Thắng",
                    Class = "62HT",
                    Type = StudentSex.Male,
                    Phone = "0123456789",
                    Address = "Hà Nội"
                },
                autoSave: true
            );

            await _studentRepository.InsertAsync(
                new Student
                {
                    Name = "Lê Đình Thành",
                    Class = "64HT",
                    Type = StudentSex.Male,
                    Phone = "0123456888",
                    Address = "Hồ Chí Minh"
                },
                autoSave: true
            );
        }
    }
}
