using System.ComponentModel.DataAnnotations;

namespace CurricullumVitae.ViewModels
{
    public class DocumentViewModel :IUIObject
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Employer { get; set; }
        public string Description { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTimeOffset EndDate { get; set; }
    }
}
