using LibraryOfVermundi.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryOfVermundi.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    
    public DbSet<Entry> Entries { get; set; }
    
    public DbSet<AppUser> AppUsers { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
}