using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace webproject.Identity
{
    public class IdentityDataContext:IdentityDbContext<ApplicationUser>
    {
        public IdentityDataContext():base("identityConnection")
        {

        }


    }
}
