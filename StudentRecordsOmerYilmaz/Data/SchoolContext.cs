using Microsoft.EntityFrameworkCore;
using StudentRecordsOmerYilmaz.Models;

namespace StudentRecordsOmerYilmaz.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<ProgramModel> Programs { get; set; } 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<ProgramModel>().HasData(
                new ProgramModel { ProgramCode = "VCM", Name = "Very Cool Math" },
                new ProgramModel { ProgramCode = "BCS", Name = "Bachelor of Computer Science" }
            );

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    Id = 1,
                    FirstName = "Omer",
                    LastName = "Yilmaz",
                    DateOfBirth = new DateTime(2004, 6, 13),
                    GPA = 2.7,
                    ProgramCode = "VCM"
                },
                new Student
                {
                    Id = 2,
                    FirstName = "Hi",
                    LastName = "Mola",
                    DateOfBirth = new DateTime(1973, 8, 5),
                    GPA = 4.0,
                    ProgramCode = "BCS"
                }
            );
        }
    }
}
