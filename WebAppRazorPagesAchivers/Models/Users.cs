using System.ComponentModel.DataAnnotations;

namespace WebAppRazorPagesAchivers.Models
{
    public class Users // Model class (Table in EF core)
    {
        [Key]
        public int ID { get; set; }  // pk & auto increment 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }

        //helps validation
    }
}
