using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPages.Authentication.Cookies.Pages
{
    public class IndexModel : PageModel
    {      

        public IActionResult OnGet()
        {
            // �������� ������� ���� "login"; ���� � ���, ��������������� �� �������� �����������
            if (Request.Cookies["login"] == null)
            {
                return RedirectToPage("Create");
            }

            // ���� ���� �������, ������������ ������� ��������
            return Page();
        }

        public IActionResult OnPost()
        {
            // ��� �������� ����� ��������������� �� �������� ������ �� �������
            return RedirectToPage("Logout");
        }
    }
}
