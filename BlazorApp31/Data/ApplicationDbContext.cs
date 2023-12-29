using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlazorApp31.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        // DbSet for your custom entity
        public DbSet<TodoListModel> TodoList { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Other DbSet declarations can also be added here if needed
    }
}