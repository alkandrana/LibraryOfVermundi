using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models;

public class Category
{
    public Category()
    {
        Entries = new HashSet<Entry>();
    }
    [StringLength(2)]
    public string CategoryId { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;
    
    public virtual ICollection<Entry> Entries { get; set; }
}