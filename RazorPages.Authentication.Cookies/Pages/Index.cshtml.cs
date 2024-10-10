using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Authentication.Cookies.Pages
{
    public class IndexModel : PageModel
    {      

        public IActionResult OnGet()
        {
            // ѕроверка наличи€ куки "login"; если еЄ нет, перенаправление на страницу авторизации
            if (Request.Cookies["login"] == null)
            {
                return RedirectToPage("Create");
            }

            // ≈сли куки найдены, отображаетс€ текуща€ страница
            return Page();
        }

        public IActionResult OnPost()
        {
            // ѕри отправке формы перенаправление на страницу выхода из системы
            return RedirectToPage("Logout");
        }
    }
}
