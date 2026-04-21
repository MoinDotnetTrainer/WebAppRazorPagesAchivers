using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class DeleteUsersModel : PageModel
    {
        private readonly AppDb _db;

        public DeleteUsersModel()
        {
            _db = new AppDb();
        }

        [BindProperty]
        public Users _User { get; set; }

        // Load record before delete (GET)
        public IActionResult OnGet(int ID)
        {
            _User = _db.Users.FirstOrDefault(u => u.ID == ID);

            if (User == null)
            {
                return NotFound();
            }

            return Page();
        }

        // Delete record (POST)
        public IActionResult OnPost(int ID)
        {
            var user = _db.Users.Find(ID);

            if (user == null)
            {
                return NotFound();
            }

            _db.Users.Remove(user);
            _db.SaveChanges();

            return RedirectToPage("DisplayUsers"); // redirect after delete
        }
    }
}

