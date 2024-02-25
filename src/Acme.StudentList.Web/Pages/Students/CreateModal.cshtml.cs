using Acme.StudentList.Students;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace Acme.StudentList.Web.Pages.Students
{
    public class CreateModalModel : StudentListPageModel
                                    //PageModel
    {
        [BindProperty]
        public CreateUpdateStudentDto Student { get; set; }

        private readonly IStudentAppService _studentAppService;

        public CreateModalModel(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }
        public void OnGet()
        {
            Student = new CreateUpdateStudentDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _studentAppService.CreateAsync(Student);
            return NoContent();
        }
    }
}
