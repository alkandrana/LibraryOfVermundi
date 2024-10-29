using Microsoft.AspNetCore.Mvc;

namespace LibraryOfVermundi.Models
{
    public class AppUser
    {
        public string UserName { get; set; }

        public DateTime SignUpDate { get; set; }
    }
}