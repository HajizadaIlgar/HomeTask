namespace DelegateTask;

class Program
{
    static void Main(string[] args)
    {
        #region ..
        //Animal[] animal = [new Sparrow(), new Dog(), new Cayman()];
        //foreach (var animals in animal)
        //{
        //    if (animals is Cayman)
        //    {
        //        animals.Eat();
        //    }

        //}

        //Manat azn = new Manat();
        //Euro er = (Euro)Manat;
        #endregion
        Student student = new Student()
        {
            Id = 1,
            Name = "Ilgar",
            Surname = "Hajizade",
            Age = 19
        };
        Student student1 = new Student()
        {
            Id = 2,
            Name = "Sabuhi",
            Surname = "Sultanli",
            Age = 19
        };

        List<Exam> examList = new List<Exam>()
        {
            new Exam
            {
                student= student,
                Point=40,
                Subject="Math",
                StartDate = new DateTime(2024, 10, 9, 10, 30, 00),
                EndDate = new DateTime(2024,10,30,12,20,00),
            },
             new Exam
            {
                student= student1,
                Point=80,
                Subject="Physics",
                StartDate = new DateTime(2024, 10, 30, 16, 30, 00),
                EndDate = new DateTime(2024,10,30,16,40,00),
            }
        };
        Console.WriteLine("--------------------  ---------------------");
        examList.FindAll(x => x.Point > 50).ForEach(x => Console.WriteLine($"{x.student.Id}.{x.student.Name} {x.student.Surname}"));
        Console.WriteLine("--------------------------------------------");

        examList.FindAll(x => x.StartDate < DateTime.Now.AddDays(-7)).ForEach(x => Console.WriteLine($"Son 1 heftede imtahanda olan gencler:{x.student.Id}.{x.student.Name} {x.student.Surname}"));
        Console.WriteLine("--------------------------------------------");

        examList.FindAll(x => (x.EndDate - x.StartDate).TotalHours <= 1).ForEach(x => Console.WriteLine($"1 saatdan daha az bir muddetde imtahani bitirenler:{x.student.Id}.{x.student.Name} {x.student.Surname}"));
        Console.WriteLine("--------------------  ---------------------");

    }

}
