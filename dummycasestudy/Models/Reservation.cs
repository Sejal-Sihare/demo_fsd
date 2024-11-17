using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class Reservation
    {
        [Key]
        public int R_Id { get; set; }

        [Required]
        [ForeignKey("Book")]
        public int B_Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int U_Id { get; set; }

        [Required]
        public string? ReservationStatus { get; set; }
        //Navigation properties

        public User? User { get; set; }

        public BookCatalouge? BookCatalouge { get; set; }




    }
}
