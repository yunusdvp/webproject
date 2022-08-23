using Microsoft.AspNetCore.Identity;

namespace webproject.Identity
{
    public class ApplicationRole:IdentityRole
    {
        public String Description { get; set; }
    }
}
