using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dummycasestudy.Models
{
    public class BookCatalouge
    {
        [Key]
        [Required]
        public int B_Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        
        public int G_Id { get; set;}
        [Required]
        public string? Author{ get; set; }

        [Required] 
        public int? I_Id {  get; set; }
        [Required]
        public int Isbn { get; set; }
        [Required]
        public string? Publisher { get; set; }
        [Required]
        public DateTime Publication_Date { get; set; }
        [Required]
        public int Cost { get; set; }
        //Navigation properties
        //book to genere many to one
         public Genere? Genere {  get; set; }
        //book to inventory one to one
        public Inventory? Inventory { get; set; }

        //book to Borrow many to one
        public ICollection<Borrow>? Borrows { get; set; }

        public ICollection<Reservation>? Reservations { get; set; }

       

    }
}
