using Microsoft.EntityFrameworkCore;

namespace Final.Models {
    public class FinalDbContext : DbContext {
        public FinalDbContext(DbContextOptions<FinalDbContext> options)
            : base(options) {}
            public DbSet<Admin> Admins { get; set; } = default!;
            public DbSet<WorkerTask> WorkerTasks { get; set; } = default!;
            public DbSet<Worker> Workers { get; set; } = default!;
    }
}