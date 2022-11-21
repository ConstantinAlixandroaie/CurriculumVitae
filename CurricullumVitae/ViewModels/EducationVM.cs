namespace CurricullumVitae.Models
{
    public class EducationVM : IUIObject
    {
        public int Id { get;set; }
        public string Title { get; set; }
        public string University { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IUIObject MakeNew()
        {
            return new EducationVM { Id = Id, Title = Title, University = University, Description = Description, StartDate = StartDate, EndDate = EndDate };
        }

        public void UpdateFrom(IUIObject obj)
        {
            throw new NotImplementedException();
        }
    }
}
