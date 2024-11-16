using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class Borrow
    {

        [Key]
        [Required]
        public int Bo_Id { get; set; }

        [Required]
        public int B_Id { get; set; }
       

        [Required]
        [ForeignKey("U_Id")]
        public int  U_Id { get; set; }

        [Required]
        public DateOnly BorrowDate { get; set; }

        [Required]
        public DateOnly ReturnDeadline { get; set; }

        [Required]
        public DateOnly ReturnDate { get; set; }

        [ForeignKey("F_Id")]
        public int F_Id { get; set; }

        [Required]
        public string BorrowStatus { get; set; } = string.Empty;

        //Navigation properties
        public BookCatalouge? BookCatalouge {  get; set; }

        public Fine? Fine { get; set; }

        public User? User { get; set; }



    }
}
