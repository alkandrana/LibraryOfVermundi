using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models.ViewModels;

public class ResponseVM
{
    public int ConversationId { get; set; }
    [Required, RegularExpression(@"^[a-zA-Z0-9_\-\.?! ]+$")]
    public string Content { get; set; }
    
    public AppUser? Commenter { get; set; }
}

