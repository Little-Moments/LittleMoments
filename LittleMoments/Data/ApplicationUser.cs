using Microsoft.AspNetCore.Identity;

namespace LittleMoments.Data;

public class ApplicationUser : IdentityUser
{
    public ICollection<Child> OwnedChildren { get; set; } = new List<Child>();

    public ICollection<Child> GrantedChildren { get; set; } = new List<Child>();
}