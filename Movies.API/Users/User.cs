using Microsoft.AspNetCore.Identity;

namespace Movies.API.Users;

public class User : IdentityUser
{
    public string? Initials{ get; set; }
}
