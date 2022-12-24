using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace FootBall.API.Models
{
    public class CreateRefereeModel : BaseModel
    {
        public int CardsGiven { get; set; }

        [Required]
        [Display(Name = "NumberOnTshirt is Required field!")]
        public int NumberOnTshirt { get; set; }
        [Required]
        [Display(Name = "Experience is Required field!")]
        public int Experience { get; set; }
        public int Salary { get; set; }
    }
}
