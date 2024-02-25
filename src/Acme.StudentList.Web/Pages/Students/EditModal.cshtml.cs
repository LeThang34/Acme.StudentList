using System;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Acme.StudentList.Students;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.StudentList.Web.Pages.Students;

public class EditModalModel : StudentListPageModel
                                //PageModel
{
    [HiddenInput]
    [BindProperty(SupportsGet = true)]
    public Guid Id { get; set; }

    [BindProperty]
    public CreateUpdateStudentDto Student { get; set; }

    private readonly IStudentAppService _studentAppService;

    public EditModalModel(IStudentAppService studentAppService)
    {
        _studentAppService = studentAppService;
    }

    public async Task OnGetAsync()
    {
        var studentDto = await _studentAppService.GetAsync(Id);
        Student = ObjectMapper.Map<StudentDto, CreateUpdateStudentDto>(studentDto);
    }

    public async Task<IActionResult> OnPostAsync()
    {
        await _studentAppService.UpdateAsync(Id, Student);
        return NoContent();
    }

    /*public void OnGet()
    {
    }*/
}
