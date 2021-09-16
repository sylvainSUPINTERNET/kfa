using System.ComponentModel.DataAnnotations;

namespace Dto
{
    class BookDto
    {
        [Required]
        public string Title {get; set;}

        [Required]
        public string Author {get; set;}
    }
}