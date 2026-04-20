using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesAchivers.Pages
{
    public class AddTaskModel : PageModel
    {
        public void OnGet()
        {
            TempData["res"] = "On Load No res";
        }
        public void OnPost()
        {
            int x = 45, y = 45, z;
            z = x + y;
            TempData["res"] = "On click :" + z;
        }
    }
}
