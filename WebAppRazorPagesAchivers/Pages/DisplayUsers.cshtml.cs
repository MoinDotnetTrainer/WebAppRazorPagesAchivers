using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class DisplayUsersModel : PageModel
    {
        public AppDb _db;
        public DisplayUsersModel()
        {
            _db = new AppDb();
        }


        [BindProperty]
        public List<Users> _usersdata { get; set; }  // all data from db
        // iteration
        public void OnGet()
        {
            _usersdata = (from s in _db.Users select s).ToList();  // linq query to get all data from db and store in list
        }
    }
}
