using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class Fine
    {

        [Key]
        [Required]
        public int F_Id { get; set; }

        [Required]
        public float FineAmount { get; set; }

        [Required]
        public string PaidStatus { get; set; } = string.Empty;

        public DateOnly PaidDate { get; set; }
        //Navigation property
        public Borrow? Borrow { get; set; }
    }
}
