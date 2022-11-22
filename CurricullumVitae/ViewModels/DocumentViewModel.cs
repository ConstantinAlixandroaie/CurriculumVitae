﻿using Microsoft.Build.Framework;

namespace CurricullumVitae.ViewModels
{
    public class DocumentViewModel : IUIObject
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public string Author { get; set; }
        public string AuhtorId { get; set; }

    }
}
