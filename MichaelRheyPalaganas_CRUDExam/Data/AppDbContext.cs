using MichaelRheyPalaganas_CRUDExam.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace MichaelRheyPalaganas_CRUDExam.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MICHAELRHEY\\SQLEXPRESS;Database=MichaelRheyPalaganas_ExamDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
