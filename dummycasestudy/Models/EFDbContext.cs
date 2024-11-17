
using Microsoft.EntityFrameworkCore;

namespace dummycasestudy.Models
{
    public class EFDbContext: DbContext
    {
        public EFDbContext() { }
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Genere to BookCatalogue one to many
            modelBuilder.Entity<BookCatalouge>()
                .HasOne(g=>g.Genere)
                .WithMany(b=>b.BookCatalouges)
                .HasForeignKey(s => s.G_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //Bookcatalouge and inventory one to one relation
            modelBuilder.Entity<BookCatalouge>()
                .HasOne(s=>s.Inventory)
                .WithOne(s=>s.BookCatalouge)
                .HasForeignKey<BookCatalouge>(s=>s.I_Id)
                .OnDelete(DeleteBehavior.Cascade);

        //Bookcatalouge to Borrow table one to many

            modelBuilder.Entity<Borrow>()
                .HasOne(s=>s.BookCatalouge)
                .WithMany(s=>s.Borrows)
                .HasForeignKey(s=>s.B_Id)
                .OnDelete(DeleteBehavior.Cascade);
            // borrow to fine one to one relationship
             
            modelBuilder.Entity<Borrow>()
               .HasOne(s => s.Fine)
               .WithOne(s => s.Borrow)
               .HasForeignKey<Borrow>(s => s.F_Id)
               .OnDelete(DeleteBehavior.Cascade);

            //User to Borrow table  one to may

            modelBuilder.Entity<Borrow>()
                .HasOne(s => s.User)
                .WithMany(s => s.Borrows)
                .HasForeignKey(s => s.U_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //here Bo id defined primary key and User and book ids are unique combination

            modelBuilder.Entity<Borrow>(entity =>
            {
                // Set Bo_Id as the primary key
                entity.HasKey(b => b.Bo_Id);

                // Define a composite unique constraint on U_Id and B_Id
                entity.HasIndex(b => new { b.U_Id, b.B_Id }).IsUnique();
            });

            //Many to one Reservation to User

            modelBuilder.Entity<Reservation>()
                .HasOne(s => s.User)
                .WithMany(s => s.Reservations)
                .HasForeignKey(s => s.U_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //many to one Reservation to Book
            modelBuilder.Entity<Reservation>()
                .HasOne(s => s.BookCatalouge)
                .WithMany(s => s.Reservations)
                .HasForeignKey(s => s.B_Id)
                .OnDelete(DeleteBehavior.Cascade);

            //Many to one notification to user
            modelBuilder.Entity<Notification>()
              .HasOne(s => s.User)
              .WithMany(s => s.Notifications)
              .HasForeignKey(s => s.U_Id)
              .OnDelete(DeleteBehavior.Cascade);





















        }



    }
}
