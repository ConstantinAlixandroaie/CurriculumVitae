using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurriculumVitaeAPI.Data
{
    public class MyCVDbContext:IdentityDbContext
    {
        //DBSets


        public MyCVDbContext(DbContextOptions<MyCVDbContext> options):base(options) 
        { 

        }
        
    }
}
