namespace School.DAL.Repository;

public interface IStudentRepository
{
     IEnumerable<Student> GetAll();
     Student GetById(int id);
     void Insert(Student student);
     void Update(Student student);
     void Delete(int id);

}