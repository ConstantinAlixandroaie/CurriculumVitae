using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurricullumVitae.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        //to add DbSets
        //To add migrations and inspect foreign keys.
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}