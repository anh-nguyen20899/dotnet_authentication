using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_page.Pages;
[Authorize(Policy="HRDepartment")]
public class HumanResource : PageModel
{

    public void OnGet()
    {

    }
}
