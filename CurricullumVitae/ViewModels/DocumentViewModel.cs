using Microsoft.Build.Framework;

namespace CurricullumVitae.ViewModels
{
    public class DocumentViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuhtorId { get; set; }
        public WorkExperienceViewModel WorkExperienceViewModel { get; set; }    
        public EducationViewModel EducationViewModel { get; set; }
        public ExtraViewModel ExtraViewModel { get; set; }
        public ProfilePictureViewModel ProfilePictureViewModel { get; set; }

    }
}
