namespace StudentStatus;
public class Student 
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public String Email { get; set; }
    public String PhoneNumber { get; set; }
    public Double GPA { get; set; } //grade point avarage
    public StudentStatus Status { get; set; }
    public string Major { get; set; } //ixtisas

}

//IStudentService Interface
//Student GetStudentById(int id); -İd ilə axtarış edəcək və geriyə həmin İd-li Student obyektini qaytaracaq
//Student[] GetAllStudents(); -Bütün Student obyektlərini qaytaracaq
//Student[] GetStudentsByName(string name); -Name ilə axtarış edəcək və geriyə həmin name-ə sahib Student obyektlərini qaytaracaq
//Void AddStudent(Student student)
//Void UpdateStudent(int id);
//Void RemoveStudent(int id, bool isSoftDelete);
//Not: RemoveStudent method-un açıqlaması - SoftDelete parametr true olduğu halda sadəcə Status Removed olacaq. Əks təqdirdə(Hard delete) bir başa olaraq Student silinəcək.
