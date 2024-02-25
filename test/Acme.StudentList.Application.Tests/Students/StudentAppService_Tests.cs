using System;
using System.Linq;
using System.Threading.Tasks;
using Shouldly;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Modularity;
using Volo.Abp.Validation;
using Xunit;

namespace Acme.StudentList.Students;

public abstract class StudentAppService_Tests<TStartupModule> :StudentListApplicationTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{
    private readonly IStudentAppService _studentAppService;
    protected StudentAppService_Tests()
    {
        _studentAppService = GetRequiredService<IStudentAppService>();
    }

    [Fact]
    public async Task Should_Get_List_Of_Students()
    {
        //Act
        var result = await _studentAppService.GetListAsync(
            new PagedAndSortedResultRequestDto()
        );

        //Assert
        result.TotalCount.ShouldBeGreaterThan(0);
        result.Items.ShouldContain(b => b.Name == "1984");
    }

    [Fact]
    public async Task Should_Create_A_Valid_Student()
    {
        //Act
        var result = await _studentAppService.CreateAsync(
            new CreateUpdateStudentDto
            {
                Name = "Nguyễn Văn A",
                Class = "62HT",
                Phone = "0123455555",
                Address = "Hà Nội",
                Type = StudentSex.Male
            }
        );

        //Assert
        result.Id.ShouldNotBe(Guid.Empty);
        result.Name.ShouldBe("Nguyễn Văn A");
    }

    [Fact]
    public async Task Should_Not_Create_A_Student_Without_Name()
    {
        var exception = await Assert.ThrowsAsync<AbpValidationException>(async () =>
        {
            await _studentAppService.CreateAsync(
                new CreateUpdateStudentDto
                {
                    Name = "",
                    Class = "01",
                    Phone = "1111111111",
                    Address = "ABC",
                    Type = StudentSex.Undefined
                }
            );
        });

        exception.ValidationErrors
            .ShouldContain(err => err.MemberNames.Any(mem => mem == "Name"));
    }
}
