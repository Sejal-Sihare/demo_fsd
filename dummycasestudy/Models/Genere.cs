using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class Genere
    {

        [Key]
        [Required]
        public int G_ID {  get; set; }

        [Required]
        public string? G_Name { get; set; }

        //Navigation properties
        public ICollection<BookCatalouge>? BookCatalouges { get; set; }

    }
}
