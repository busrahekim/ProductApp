using Microsoft.EntityFrameworkCore;

namespace e_commerce.Models
{
    public class AdminContext : DbContext
    {
        public AdminContext(DbContextOptions
           <AdminContext> options) : base(options)
        {
        }

        public DbSet<Admin> Admins { get; set; }
    }
}
