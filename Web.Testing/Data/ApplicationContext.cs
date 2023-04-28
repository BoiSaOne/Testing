using Microsoft.EntityFrameworkCore;
using Web.Testing.Models;

namespace Web.Testing.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<User> Users { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        public ApplicationContext() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Question>().Property(q => q.QuestionType)
                .HasConversion<string>().HasMaxLength(100);
        }

    }
}
