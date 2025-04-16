using School.BLL.Dtos;

namespace School.BLL.Manager;

public class StudentManager : IStudentManager
{
    public IEnumerable<StudentReadDto> GetAll()
    {
        throw new NotImplementedException();        
    }

    public StudentReadDto GetById(int id)
    {
        throw new NotImplementedException();
    }

    public void insert(StudentAddDto student)
    {
        throw new NotImplementedException();
    }

    public void update(StudentModifyDto student)
    {
        throw new NotImplementedException();
    }

    public void delete(int id)
    {
        throw new NotImplementedException();
    }
}