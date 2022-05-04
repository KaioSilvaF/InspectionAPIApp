using Microsoft.EntityFrameworkCore;

namespace InspectionAPI.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> option) : base(option) { }
        public DbSet<Inspection> Inspections { get; set; }
        public DbSet<InspectionType> InspectionTypes { get; set; } 
        public DbSet<Status> Statuses { get; set; }
        
    }
}
