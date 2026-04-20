using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesAchivers.Pages
{
    public class DateTimeModel : PageModel
    {
        public void OnGet()  // on load of page
        {
            TempData["currentdate"] = "On Load:"+ System.DateTime.Now.ToLongTimeString();
        }

        public void OnPost()
        {
            TempData["currentdate"] = "On click:"+ System.DateTime.Now.ToLongTimeString();
        }
    }
}
