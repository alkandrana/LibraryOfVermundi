namespace LibraryOfVermundi.Models
{
    public class Entry
    {
        public string Content { get; set; }

        public string Title { get; set; }

        public string Category { get; set; }

        public AppUser Contributor { get; set; }

        public DateTime SubmissionDate { get; set; }

        public bool Protected { get; set; }
    }
}