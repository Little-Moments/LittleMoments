
namespace LittleMoments.Data;

public class Child
{
    public int Id { get; set; }

    public required string Name { get; set; }

    public int OwnerId { get; set; }
    
    public ApplicationUser? Owner { get; set; }

    public ICollection<ApplicationUser> GrantedUsers { get; set; } = new List<ApplicationUser>();

    public ICollection<LittleMoment> LittleMoments { get; set; } = new List<LittleMoment>();
}