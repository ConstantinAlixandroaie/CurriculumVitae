﻿using Microsoft.Build.Framework;

namespace CurricullumVitae.Models
{
    public class DocumentViewModel : IUIObject
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }

        
    }
}
