using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class Notification
    {

        [Key]
        public int N_Id { get; set; }

        [Required]
        [ForeignKey("User")]
        public int U_Id { get; set; }

        [Required]
        public string? MessageType { get; set; }

        [Required]
        public string? MessageDescription { get; set; }

        [Required]
        public DateOnly SentDate { get; set; }

        //Navigation Properties
        public User? User { get; set; }
    }
}
