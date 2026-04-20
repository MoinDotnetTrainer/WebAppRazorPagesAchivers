using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesAchivers.Models
{
    public class Products
    {
        [Key] // pk & auto increment 
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Cost { get; set; }
        public int Qty { get; set; }
    }
}
