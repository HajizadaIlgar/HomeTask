namespace StudentStatus;
internal class Program
{
    static void Main(string[] args)
    {
        Student student = new Student()
        {
            Id = 1,
            FirstName = "resad",
            Status = StudentStatus.Active
        };
        Student student2 = new Student()
        {
            Id = 2,
            FirstName = "ilqar",
            Status = StudentStatus.Active
        };
        Student student3 = new Student()
        {
            Id = 3,
            FirstName = "musa",
            Status = StudentStatus.Active
        };
        Student student4 = new Student()
        {
            Id = 4,
            FirstName = "revan",
            Status = StudentStatus.Active
        };
        Student[] studentss = { student, student2, student3, student4 };
        foreach (Student item in studentss)
        {
            StudentService studentservice = new StudentService(studentss);
            Student studentname = studentservice.GetAllStudent(studentss);
            Console.WriteLine("----------------------------------------------");
            Student searchstudent = studentservice.GetStudentById(1);
            Console.WriteLine(searchstudent);
        }

    }
}

/*
 *Lab task:

StudentStatus Enum
 Active, Graduate, Pending, Removed

Student class
int Id 
string FirstName
string LastName
string Email 
string PhoneNumber
double GPA 
StudentStatus  Status // 
string Major // Ixtisas



IStudentService Interface
Student GetStudentById(int id); - İd ilə axtarış edəcək və geriyə həmin İd-li Student obyektini qaytaracaq
Student[] GetAllStudents(); - Bütün Student obyektlərini qaytaracaq
Student[] GetStudentsByName(string name); -  Name ilə axtarış edəcək və geriyə həmin name-ə sahib Student obyektlərini qaytaracaq
Void AddStudent(Student student)
Void UpdateStudent(int id);
Void RemoveStudent(int id, bool isSoftDelete);
Not: RemoveStudent method-un açıqlaması - SoftDelete parametr true olduğu halda sadəcə Status Removed olacaq. Əks təqdirdə(Hard delete) bir başa olaraq Student silinəcək.

StudentService Class
IStudentService interface-dən implement edəcək və Method-ların daxili düzgün şəkildə doldurulacaq.
 */