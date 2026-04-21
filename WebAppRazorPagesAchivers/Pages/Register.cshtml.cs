using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class RegisterModel : PageModel
    {

        public AppDb _db;
        public RegisterModel()
        {
            _db = new AppDb();
        }       

        [BindProperty]
        public Users _Users { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _db.Users.Add(_Users);
            _db.SaveChanges();

            // Insert Logic
            return RedirectToPage("Login");
        }
    }
}
