using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models;

public class Category
{
    [StringLength(2)]
    public string CategoryId { get; set; } = string.Empty;
    
    [StringLength(50)]
    public string Name { get; set; } = string.Empty;
    
    [StringLength(1000)]
    public string Description { get; set; } = string.Empty;
}