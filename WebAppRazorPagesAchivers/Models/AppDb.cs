using Microsoft.EntityFrameworkCore;

namespace WebAppRazorPagesAchivers.Models
{
    public class AppDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_WebAppAchivers;Integrated Security=true;TrustServerCertificate=true");
            // est the conn with db
            // Server name
            // db name
            // authentication
        }

        public DbSet<Users> Users { get; set; }     // table name in db and also the model class name   

        //Add to insert data in db

        public DbSet<Products> Products { get; set; }
    }
}
