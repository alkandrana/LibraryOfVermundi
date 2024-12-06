using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string RawContent { get; set; } = "";

        public string[] Content => RawContent.Split('\n');  // facilitates displaying the entries on the page

        [StringLength(100)]
        public string Title { get; set; } = String.Empty;
        
        public int ContributorId { get; set; }

        public AppUser? Contributor { get; set; }
        
        [StringLength(2)]
        public string CategoryId { get; set; }

        public Category? Category { get; set; }

        public DateTime SubmissionDate { get; set; }

        public bool Protected { get; set; }
    }
    
}