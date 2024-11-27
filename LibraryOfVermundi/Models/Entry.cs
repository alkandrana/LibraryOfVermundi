using System.ComponentModel.DataAnnotations;

namespace LibraryOfVermundi.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string RawContent { get; set; } = "";

        public string[] Content => RawContent.Split('\n');

        [StringLength(100)]
        public string Title { get; set; } = String.Empty;

        public AppUser? Contributor { get; set; }
        
        [StringLength(2)]
        public string CategoryId { get; set; } = String.Empty;

        public Category Category { get; set; } = new Category();

        public DateTime SubmissionDate { get; set; }

        public bool Protected => RawContent.Contains("demon");

        public void FormatContent()
        {
            RawContent = RawContent.Replace("**", "\n");
        }
    }
    
}