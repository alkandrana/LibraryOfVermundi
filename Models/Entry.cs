namespace LibraryOfVermundi.Models
{
    public class Entry
    {
        public int EntryId { get; set; }
        public string RawContent { get; set; } = "";

        public string[] Content => RawContent.Split('\n');

        public string Title { get; set; }

        public string Category { get; set; }

        public AppUser Contributor { get; set; }

        public DateTime SubmissionDate { get; set; }

        public bool Protected => RawContent.Contains("demon");
    }
    
}