using Coffee_MVC.Models.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Coffee_MVC.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<News> News => Set<News>();

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        

        builder
           .Entity<News>()
           .Property(e => e.Date)
           .HasDefaultValueSql("now()");

        builder
            .Entity<News>()
            .Property(e => e.CreateDate)
            .HasDefaultValueSql("now()");

        builder
            .Entity<News>()
            .Property(e => e.IsActive)
            .HasDefaultValue(true);

    }
}
