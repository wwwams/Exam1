using Domain.Models;
namespace Services.Services;
public class TeacherServices
{
    List<Teacher> Teachers = new List<Teacher>();
    public List<Teacher> GetTeachers()
    {
        return Teachers;
    }
    public void Update(Teacher teacher, int id)
    {
        int n = 0;
        foreach (var item in Teachers)
        {
            n++;
            if (item.Id == id)
            {
                Teachers.Remove(item);
                Teachers.Insert(n, teacher);
            }
        }
    }
    public void GetTeacherById(Teacher teacher, int id)
    {
        foreach (var item in Teachers)
        {
            if (id == teacher.Id)
                return;
        }
    }

    public void TeacerDelete(Teacher teacher, int id)
    {
        foreach (var item in Teachers)
        {
            if (id == teacher.Id)
                Teachers.Remove(item);
        }
    }

    public int TeachersCount(int i)
    {
        i = Teachers.Count();
        return i;
    }
}