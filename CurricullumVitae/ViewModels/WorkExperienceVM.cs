﻿namespace CurricullumVitae.Models
{
    public class WorkExperienceVM :IUIObject
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public string Description { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public DateTimeOffset EndDate { get; set; }
    }
}
