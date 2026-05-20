using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
        "Host=localhost;Port=5432;Database=EmployeeDB;Username=postgres;Password=Welcome@123");
    }
}