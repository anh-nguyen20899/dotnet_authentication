using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_page.Pages.Account;
public class LoginModel : PageModel
{
    [BindProperty]
    public string? Username {get; set;}
    [BindProperty]
    public string? Password {get; set;}

    public async Task<IActionResult> OnPost()
    {
        if(!ModelState.IsValid) return Page();
        // Verify the Credential
            if(Username == "admin" && Password == "password")
            {
                // Create Security Context
                var claims = new List<Claim> 
                { 
                    new Claim(ClaimTypes.Name,"admin"),
                    new Claim(ClaimTypes.Email,"admin@mywebsite.com"),
                };
                var identity = new ClaimsIdentity(claims,"MyCookieAuth");
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync("MyCookieAuth", principal);
                return RedirectToPage("/Index");
            }
            
        return RedirectToPage("/Index");
    }
}
public class Credential 
{
    [Required]
    [Display(Name = "User Name")]
    public string? Username;
    [Required]
    [DataType(DataType.Password)]
    public string? Password;
}
