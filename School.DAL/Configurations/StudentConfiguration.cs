
namespace School.DAL.Configurations;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
      builder.Property(a=>a.Email)
          .HasMaxLength(250);
      builder.Property(s=>s.Name)
          .HasMaxLength(250);
      builder.Property(a=>a.Gender)
          .HasMaxLength(50);
    }
}