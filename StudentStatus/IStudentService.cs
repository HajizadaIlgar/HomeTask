namespace StudentStatus;

public interface IStudentService
{
    Student GetStudentById(int id);
    Student GetAllStudent(Student[] student);
}
public class StudentService : IStudentService
{
    private readonly Student[] _students;
    public Student[] Students { get { return _students; } }
    public StudentService(Student[] students)
    {
        _students = students;
    }

    public Student GetStudentById(int id)
    {
        foreach (Student item in Students)
        {
            if (item.Id == id)
            {
            return item;
            }
        }
        return null;
    }
    public Student GetAllStudent(Student[] student)
    {
        foreach (Student item in student)
        {
            Console.WriteLine($"Siyahi:{student}");
            Console.WriteLine(item);
        }
        return null;
    }
    public Student[] GetStudentByName(string name)
    {
        foreach (Student item in Students)
        {
            if (item.Id==)
            {
                return item;
            }
        }
        return _students;
    }
}


