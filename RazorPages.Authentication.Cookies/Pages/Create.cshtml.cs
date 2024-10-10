using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Authentication.Cookies.Model;

namespace RazorPages.Authentication.Cookies.Pages
{
    public class CreateModel : PageModel
    {
        // Привязка модели данных Login к форме
        [BindProperty]
        public Login login { get; set; } = default!;

        public IActionResult OnGet()
        {
            // Отображение страницы при GET-запросе
            return Page();
        }

        public IActionResult OnPost()
        {
            // Если данные формы валидны, создается cookie
            if (ModelState.IsValid)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(10); // Установка срока действия куки на 10 дней
                Response.Cookies.Append("login", login.UserName, option); // Создание куки с именем пользователя
                return RedirectToPage("Index"); // Перенаправление на главную страницу после успешной авторизации
            }

            // В случае ошибки отображается та же страница
            return Page();
        }
    }
}
