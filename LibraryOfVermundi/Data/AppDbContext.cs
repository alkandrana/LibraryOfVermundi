using LibraryOfVermundi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LibraryOfVermundi.Data;

public class AppDbContext : IdentityDbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Article> Articles { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    public DbSet<Contribution> Contributions { get; set; }
    
    public DbSet<Conversation> Conversations { get; set; }
    
}