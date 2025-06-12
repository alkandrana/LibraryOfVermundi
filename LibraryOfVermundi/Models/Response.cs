using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models;

public class Response
{
    public int ResponseId { get; set; }
    [Required] public string Content { get; set; } = "";
    public DateTime Date { get; set; }
    
    public Conversation Conversation { get; set; }
    public AppUser? Author { get; set; }
}