using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_page.Pages;
public class AccessDenied : PageModel
{
    [HttpGet]
    [AllowAnonymous]
    public void OnGet()
    {

    }
}
