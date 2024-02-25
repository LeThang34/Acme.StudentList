using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Acme.StudentList.Pages;

public class Index_Tests : StudentListWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
