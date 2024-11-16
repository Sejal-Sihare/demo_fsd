using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dummycasestudy.Models
{
    public class UserLog
    {
        [Key]
        [Required]
        public int L_Id { get; set; }
        [Required]
        [ForeignKey(nameof(User.U_Id))]
        public int U_Id { get; set; }
        [Required]
        public string? Action {  get; set; }

        [Required]
        public DateTime Performed_At {  get; set; }

    }
}
