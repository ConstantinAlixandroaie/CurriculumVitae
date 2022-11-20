using CurricullumVitae.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CurricullumVitae.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public DbSet<Document> Documents { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Extra> Extras { get; set; }
        public DbSet<ProfilePicture> ProfilePictures { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}