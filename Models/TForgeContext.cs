using Microsoft.EntityFrameworkCore;

namespace Final.Models {
    public class FinalDbContext : DbContext {
        public FinalDbContext(DbContextOptions<FinalDbContext> options)
            : base(options) {}
            public DbSet<Admin> Admins { get; set; } = default!;
            public DbSet<Task> Tasks { get; set; } = default!;
            public DbSet<User> Users { get; set; } = default!;
    }
}