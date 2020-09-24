using System.ComponentModel.DataAnnotations;

//On pouvait très bien utiliser CommandCreateDto. Mais cela est fait juste pour la forme et mieux comprendre.
namespace Commander.Dtos
{
    public class CommandUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }

        [Required]
        public string Line { get; set; }

        [Required]
        public string Platform {get; set;}
    }
}