namespace MicroProject;

public class Book
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string AuthorName { get; set; }
    public double Price { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"book id:{Id}" +
                          $"\nbook name:{Name}" +
                          $"\nbook author:{AuthorName}" +
                          $"\nbook price:{Price}"
                         );
    }
}

/*
Library class
- Id
- Name
- Books list
- AddBook() - book obyekti qəbul edəcək və books listinə əlavə edəcək
- GetBookById() - id qebul edəcek və həmin id-li book obyektini tapıb geriyə qaytaracaq
- RemoveBook() - id qebul edəcək və həmin id-li book

obyektini tapıb siləcək
*/