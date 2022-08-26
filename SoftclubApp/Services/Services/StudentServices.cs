using Domain.Models;
namespace Services.Services;
public class StudentServices
{
    List<Student> Students = new List<Student>();
    public List<Student> GetStudents()
    {
        return Students;
    }
    public void Update(Student student, int id)
    {
        int n = 0;
        foreach (var item in Students)
        {
            n++;
            if (item.Id == id)
            {
                Students.Remove(item);
                Students.Insert(n, student);
            }
        }
    }
    public void GetStudentById(Student student, int id)
    {
        foreach (var item in Students)
        {
            if (id == student.Id)
                return;
        }
    }

    public void StudentDelete(Student student, int id)
    {
        foreach (var item in Students)
        {
            if (id == student.Id)
                Students.Remove(item);
        }
    }

    public int StudentCount(int i)
    {
        i = Students.Count();
        return i;
    }
}