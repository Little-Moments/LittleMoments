using Microsoft.AspNetCore.Identity;

namespace LittleMoments.Data;

public class ApplicationUser : IdentityUser
{
    public ICollection<Kid> OwnedKids { get; set; } = new List<Kid>();

    public ICollection<Kid> GrantedKids { get; set; } = new List<Kid>();
}