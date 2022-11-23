using System.ComponentModel.DataAnnotations;

namespace CurricullumVitae.ViewModels
{
    public class EducationViewModel : IUIObject
    {
        public int Id { get;set; }
        public string Title { get; set; }
        public string University { get; set; }
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset EndDate { get; set; }
        
    }
}
