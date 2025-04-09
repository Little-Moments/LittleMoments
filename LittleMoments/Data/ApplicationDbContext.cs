using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LittleMoments.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : IdentityDbContext<ApplicationUser>(options)
{
    public DbSet<Kid> Kids { get; set; } = null!;

    public DbSet<LittleMoment> LittleMoments { get; set; } = null!;
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<Kid>().HasOne(x => x.Owner).WithMany(y => y.OwnedKids);
        
        builder.Entity<Kid>().HasMany(x => x.GrantedUsers).WithMany(y => y.GrantedKids);
    }
}