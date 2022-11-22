namespace CurricullumVitae.Models
{
    public class Education : IDbObject
    {
        public int Id { get;set; }
        public string Title { get; set; }
        public string University { get; set; }
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IDbObject MakeNew()
        {
            return new Education { Id = Id, Title = Title, University = University, Description = Description, StartDate = StartDate, EndDate = EndDate };
        }

        public void UpdateFrom(IDbObject obj)
        {
          var q = obj as Education;
            Title=q.Title;
            University= q.University;
            Description=q.Description;
            StartDate=q.StartDate;
            EndDate=q.EndDate;
        }
    }
}
