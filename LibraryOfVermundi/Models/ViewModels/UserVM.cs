using Microsoft.AspNetCore.Identity;

namespace LibraryOfVermundi.Models.ViewModels;

public class UserVM
{
    public IEnumerable<AppUser> Users { get; set; }
    public IEnumerable<IdentityRole> Roles { get; set; }
}