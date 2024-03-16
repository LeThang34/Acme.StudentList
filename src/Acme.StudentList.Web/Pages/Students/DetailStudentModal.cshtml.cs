using System;
using System.Threading.Tasks;
using Acme.StudentList.Students;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Acme.StudentList.Web.Pages.Students
{
    public class DetailStudentModalModel : StudentListPageModel
    {
        private readonly IStudentAppService _studentAppService;

        public DetailStudentModalModel(IStudentAppService studentAppService)
        {
            _studentAppService = studentAppService;
        }

        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        public StudentDto Student { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var studentDto = await _studentAppService.GetAsync(Id);
            Student = studentDto;
            return Page();
        }
    }
}
