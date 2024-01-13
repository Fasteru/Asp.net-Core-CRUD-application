using Microsoft.EntityFrameworkCore;
using SRPS.Entities.DomainModels;

namespace SRPS.Entities
{
    public class SRPSDbContext : DbContext
    {
        public SRPSDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<StudentsDomainModel>? SRPS_TBL_Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<StudentsDomainModel>().ToTable("SRPS_TBL_Students");

            string studentsData = File.ReadAllText("StudentsData.json");
            List<StudentsDomainModel>? studentsDomainModelsData = System.Text.Json.JsonSerializer.Deserialize<List<StudentsDomainModel>>(studentsData);
            if (studentsDomainModelsData != null )
            {
                foreach (StudentsDomainModel Student in studentsDomainModelsData)
                {
                    modelBuilder.Entity<StudentsDomainModel>().HasData(Student);
                }
            }
        }
    }
}
