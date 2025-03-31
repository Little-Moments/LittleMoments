using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LittleMoments.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Child> Children { get; set; } = null!;

    public DbSet<LittleMoment> LittleMoments { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Child>().HasOne(x => x.Owner).WithMany(y => y.OwnedChildren);
        
        builder.Entity<Child>().HasMany(x => x.GrantedUsers).WithMany(y => y.GrantedChildren);
    }
}