using Microsoft.EntityFrameworkCore.Design;

namespace School.DAL.Models;

public class PanelContextFactory : IDesignTimeDbContextFactory<StudentsContext>
{
    public StudentsContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<StudentsContext>();
        optionsBuilder.UseSqlServer("Server=localhost; DataBase=StudentQueue; User Id = SA; Password= ABleniux12;TrustServerCertificate= True;");

        return new StudentsContext(optionsBuilder.Options);
    }
}