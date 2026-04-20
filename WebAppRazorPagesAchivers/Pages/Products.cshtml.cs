using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppRazorPagesAchivers.Models;

namespace WebAppRazorPagesAchivers.Pages
{
    public class ProductsModel : PageModel
    {
        public AppDb _db;
        public ProductsModel()
        {
            _db = new AppDb();
        }   
        [BindProperty]
        public Products _products { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() {

            // add

            _db.Products.Add(_products);
            _db.SaveChanges();
            return RedirectToPage("getProducts");
        }
    }
}
