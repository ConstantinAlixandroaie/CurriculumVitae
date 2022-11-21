using Microsoft.Build.Framework;

namespace CurricullumVitae.Models
{
    public class DocumentVM : IUIObject
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        public List<EducationVM> Education { get; set; }
        public List<ExtraVM> Extra { get; set; }
        public ProfilePicture ProfilePicture { get; set; }
        public List<WorkExperience> WorkExperience { get; set; }



        public IUIObject MakeNew()
        {
            return new Document { Id = Id, Description = Description, Education = Education, Extra = Extra, ProfilePicture = ProfilePicture, WorkExperience = WorkExperience };
        }

        public void UpdateFrom(IUIObject obj)
        {
            var q=obj as Document;
            Description= q.Description;
            Education= q.Education;
            Extra= q.Extra;
            ProfilePicture= q.ProfilePicture;
            WorkExperience= q.WorkExperience;
        }
    }
}
