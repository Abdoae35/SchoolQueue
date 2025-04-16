namespace School.DAL.Models;

public class StudentsContext : DbContext
{
    public StudentsContext(DbContextOptions<StudentsContext> options) : base(options)
    {
        
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new StudentConfiguration());
    }

    public DbSet<Student> Students { get; set; }
}