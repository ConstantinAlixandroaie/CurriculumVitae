namespace CurricullumVitae.Models
{
    public class WorkExperienceVM :IUIObject
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }

        public Document Document { get; set; }
        public int DocumentId { get; set; }

        public IUIObject MakeNew()
        {
            return new WorkExperienceVM { Id = Id, Title = Title, Description = Description, StartDate = StartDate, EndDate = EndDate, Document = Document, DocumentId = DocumentId };
        }

        public void UpdateFrom(IUIObject obj)
        {
            var q=obj as WorkExperienceVM;
            Title= q.Title; 
            Description= q.Description; 
            StartDate= q.StartDate; 
            EndDate= q.EndDate;
            Document = q.Document;  
            DocumentId= q.DocumentId;   
        }
    }
}
