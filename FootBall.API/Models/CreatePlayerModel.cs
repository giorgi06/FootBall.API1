﻿using System.ComponentModel.DataAnnotations;

namespace FootBall.API.Models
{
    public class CreatePlayerModel : BaseModel
    {
        [Required]
        [Display(Name = "NumberOnTshirt is Required field!")]
        public int NumberOnTshirt { get; set; }
        [Required]
        [Display(Name = "ScoredGoals is Required field!")]
        public int ScoredGoals { get; set; }

        public int Salary { get; set; }

        [Required]
        [Display(Name = "Position is Required field!")]
        public int Position { get; set; }
    }
}
