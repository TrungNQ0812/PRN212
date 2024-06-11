using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FUHotelManageLibrary.Model;
using Microsoft.EntityFrameworkCore;

namespace FUHotelManageLibrary.dal
{
    public class DBContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }
        public DbSet<RoomInformation> RoomInformation { get; set; }
        public DbSet<RoomType> RoomType { get; set; }
        public DbSet<BookingDetail> BookingDetail { get; set; }
        public DbSet<BookingReservation> BookingReservation { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string ServerName = "MSI\\TRUNGNQ";
            string Database = "FUMiniHotelManagement";
            string user = "sa";
            string password = "123121";
            optionsBuilder.UseSqlServer($"Server={ServerName};Database={Database};User Id={user};Password={password};Encrypt=true;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BookingDetail>()
                .HasKey(b => new { b.BookingReservationID, b.RoomID });
        }
    }
}
