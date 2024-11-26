using Microsoft.AspNetCore.Mvc;

namespace LibraryOfVermundi.Models
{
    public class AppUser
    {
        public int AppUserId { get; set; }
        public string UserName { get; set; }

        public DateTime SignUpDate { get; set; }
    }
}