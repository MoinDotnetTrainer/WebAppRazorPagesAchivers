using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesAchivers.Pages
{
    public class MultiplyTaskModel : PageModel
    {
        [BindProperty]
        public int x { get; set; }

        [BindProperty]
        public int y { get; set; }

        // code 
        // no reusability
        public void OnGet()
        {
            TempData["res"] = "On Load No res";
        }
        public void OnPost()
        {
            int z = x * y;
            TempData["res"] = "On click :" + z;
        }
    }
}
