using Microsoft.EntityFrameworkCore;
using SecondExamSimulation.Areas.Admin.Models;

namespace SecondExamSimulation.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Trainer> Trainers { get; set; }

    public DbSet<Category> Categories { get; set; }


}
