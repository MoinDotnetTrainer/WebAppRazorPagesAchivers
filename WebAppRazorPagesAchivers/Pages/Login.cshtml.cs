using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class LoginModel : PageModel
    {

        public AppDb _db;
        public LoginModel()
        {
            _db = new AppDb();
        }


        [BindProperty]
        public LoginValues _Logindata { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()  // IActionreult returns to page
        {
            // Linq Synatx ef core also uses linq syntax code first approach
            var result = (from s in _db.Users select s).Any(x => x.Email == _Logindata.Email && x.Password == _Logindata.Password); // true
            // var res = _db.Users.Where(x => x.Email == _Logindata.Email && x.Password == _Logindata.Password).FirstOrDefault(); // null or user data   
            // var res = from s in _db.Users where s.Email == _Logindata.Email && s.Password == _Logindata.Password select s;  
            if (result)
            {
                return RedirectToPage("Homepage");
            }
            else
            {
                TempData["error"] = "Invalid email or password";
                return Page();  // current page
            }


        }


        // Put UI page matched with db data
        //_logindata --> UI email & password
        //Backend Users
    }
}
