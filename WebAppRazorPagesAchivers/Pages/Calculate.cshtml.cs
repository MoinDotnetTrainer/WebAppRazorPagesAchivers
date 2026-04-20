using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class CalculateModel : PageModel
    {
        [BindProperty]
        public MyValues _data { get; set; }  // prop
        public void OnGet()
        {
        }
        public void OnPost()
        {

            int z = _data.x + _data.y; // check for division by zero      
            TempData["res"] = "On click :" + z;
        }
    }
}
