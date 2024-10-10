using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPages.Authentication.Cookies.Model;

namespace RazorPages.Authentication.Cookies.Pages
{
    public class CreateModel : PageModel
    {
        // �������� ������ ������ Login � �����
        [BindProperty]
        public Login login { get; set; } = default!;

        public IActionResult OnGet()
        {
            // ����������� �������� ��� GET-�������
            return Page();
        }

        public IActionResult OnPost()
        {
            // ���� ������ ����� �������, ��������� cookie
            if (ModelState.IsValid)
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddDays(10); // ��������� ����� �������� ���� �� 10 ����
                Response.Cookies.Append("login", login.UserName, option); // �������� ���� � ������ ������������
                return RedirectToPage("Index"); // ��������������� �� ������� �������� ����� �������� �����������
            }

            // � ������ ������ ������������ �� �� ��������
            return Page();
        }
    }
}
