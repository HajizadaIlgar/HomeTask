namespace DelegateTask;

internal class Exam
{
    public Student student { get; set; }
    public int Point { get; set; }
    public string Subject { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }


}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
}
