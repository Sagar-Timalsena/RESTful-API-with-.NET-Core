﻿using System.ComponentModel.DataAnnotations;

namespace MagicView.Models.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
