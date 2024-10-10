using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages.Authentication.Cookies.Model;

namespace RazorPages.Authentication.Cookies.Pages
{
    public class IndexModel : PageModel
    {      
        private readonly ApplicationContext _context;

        public IndexModel(ApplicationContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            // ѕроверка наличи€ куки "login"; если еЄ нет, перенаправление на страницу авторизации
            if (Request.Cookies["login"] == null)
            {
                return RedirectToPage("Create");
            }

            
            Students = await _context.Students.ToListAsync();            
            return Page();
        }

        public IActionResult OnPost()
        {
            // ѕри отправке формы перенаправление на страницу выхода из системы
            return RedirectToPage("Logout");
        }
    }
}
