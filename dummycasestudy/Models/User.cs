using System.ComponentModel.DataAnnotations;

namespace dummycasestudy.Models
{
    public class User
    {
        [Required]
        [Key]
        public int?  U_Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]

        public string? Phone {  get; set; }
        [Required]
        public string? Address {  get; set; }
        [Required]

        public string? Role { get; set; }
        [Required]
        public DateTime Created_at { get; set; }
        [Required]
        public DateTime Updated_at { get;set; }

        //Navigation Property
        public ICollection<Borrow>? Borrows { get; set; }
    }
}
