using School.BLL.Dtos;

namespace School.BLL.Manager;

public interface IStudentManager
{
    IEnumerable<StudentReadDto>  GetAll();
    StudentReadDto GetById(int id);
    void  insert(StudentAddDto student);
    void update(StudentModifyDto student);
    void delete(int id);
}