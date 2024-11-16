using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dummycasestudy.Models
{
    public class Inventory
    {
        [Key]
        [Required]
        public int I_Id { get; set; }
        [Required]
        [ForeignKey(nameof(BookCatalouge.B_Id))]
        public int ?BookId { get; set; }

        [Required]
        public int AvailableQuantity { get; set; }
        [Required]
        public int TotalQuantity {  get; set; }
        //Navigation Properties for books to inventory  one to one

        public BookCatalouge? BookCatalouge { get; set; }

    }
}
