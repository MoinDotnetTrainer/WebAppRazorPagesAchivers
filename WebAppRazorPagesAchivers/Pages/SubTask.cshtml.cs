using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppRazorPagesAchivers.Pages
{
    public class SubTaskModel : PageModel
    {
        public void OnGet()
        {
                TempData["res"] = "On Load No res"; 
        }

        public void OnPost()
        {
            int x = Convert.ToInt32(Request.Form["x"].ToString());
            int y = Convert.ToInt32(Request.Form["y"].ToString());
            int z = x - y;
            TempData["res"] = "On click Subtask :" + z;
        }
    }
}
