using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class EditUsersModel : PageModel
    {
        public AppDb _db;
        public EditUsersModel()
        {
            _db = new AppDb();
        }


        [BindProperty]
        public Users _UsersData { get; set; }  // on row data
        public void OnGet(int ID)
        {
            // on load ill get the data from db based on ID 
            // passed to UI
            _UsersData = _db.Users.FirstOrDefault(x => x.ID == ID);
        }

        public IActionResult OnPost()
        {
            //ID pk modied based on PK
            _db.Users.Attach(_UsersData).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _db.SaveChanges();
            return RedirectToPage("DisplayUsers");
        }
    }
}
