using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TheaterService
{
    public partial class DataModel : DbContext
    {
        public DataModel()
            : base("name=DataModel")
        {
        }

        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<Seat> Seat { get; set; }
        public virtual DbSet<Theater> Theater { get; set; }
        public virtual DbSet<Viewing> Viewing { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>()
                .HasMany(e => e.Seat)
                .WithMany(e => e.Booking)
                .Map(m => m.ToTable("BookingSeat").MapLeftKey("BookingID").MapRightKey("SeatID"));

            modelBuilder.Entity<Customer>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Theater>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}
