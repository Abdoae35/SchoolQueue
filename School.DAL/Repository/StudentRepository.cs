namespace School.DAL.Repository;

public class StudentRepository : IStudentRepository
{
    private readonly StudentsContext _context;
    public StudentRepository(StudentsContext context)
    {
        _context = context;
    }
    public IEnumerable<Student> GetAll()
    {
      return _context.Students;
    }

    public Student GetById(int id)
    {
      return _context.Students.Find(id);
    }

    public void Insert(Student student)
    {
      _context.Students.Add(student);
      _context.SaveChanges();
    }

    public void Update(Student student)
    {
      
       _context.SaveChanges();
    }

    public void Delete(int id)
    {
        _context.Students.Remove(GetById(id));
        _context.SaveChanges();
        
    }
}