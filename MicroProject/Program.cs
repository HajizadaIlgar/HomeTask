namespace MicroProject;
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        PrintInfo();
        do
        {
            int choice = int.Parse(Console.ReadLine());
            try
            {
                switch (choice)
                {
                    case 1:
                        AddLibrary(library);
                        AddBook(library);
                        break;
                    case 2:
                        GetBookById(library);
                        break;
                    case 3:
                        RemoveBook(library);
                        break;
                    case 0:
                        Console.WriteLine("Quit");
                        break;
                    default:
                        Console.WriteLine("Daxil Ettiyin Command Menu da yoxdu," + "Bunlardan birini daxil et !" +
                            "\nMenu\r\n1. Add book\r\n2. Get book by id\r\n3. Remove book\r\n0. Quit");
                        break;
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Daxil Ettiyin Id de kitabxanada kitab yoxdur");
                PrintInfo();
            }
            catch (FormatException)
            {
                Console.WriteLine("Bos Enter basma");
            }
        } while (true);
    }
    public static void AddLibrary(Library library)
    {
        Console.Write("Enter Book Library:");
        library.Name = Console.ReadLine();
        Console.WriteLine("-------------------");
    }
    public static void AddBook(Library library)
    {
        Console.Write("Enter book ID: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("-------------------");
        Console.Write("Enter book name: ");
        string name = Console.ReadLine();
        Console.WriteLine("-------------------");
        Console.Write("Enter author name: ");
        string authorName = Console.ReadLine();
        Console.WriteLine("-------------------");
        Console.Write("Enter book price: ");
        double price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("-------------------");
        Book newBook = new Book
        {
            Id = id,
            Name = name,
            AuthorName = authorName,
            Price = price
        };
        library.AddBook(newBook);
        string path = Newtonsoft.Json.JsonConvert.SerializeObject(library);
        File.WriteAllText(@"C:\Users\Ilqar\source\repos\MicroProject\Database.json", path);
        Console.WriteLine("Book added successfully!");
    }

    private static void GetBookById(Library library)
    {
        Console.Write("Enter book ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Book book = library.GetBookById(id);
        if (library.Id != null)
        {
            book.ShowInfo();
            Console.Write(" Json Data :");
            string data = File.ReadAllText(@"C:\Users\Ilqar\source\repos\MicroProject\Database.json");
            Console.WriteLine(data);
        }
        else
        {
            Console.WriteLine("Book not found.");
        }

    }
    private static void RemoveBook(Library library)
    {
        Console.WriteLine("Enter Book Id:");
        int id = int.Parse(Console.ReadLine());
        if (library.Id != id)
        {
            library.RemoveBook(id);

        }
        string filepath = @"C:\Users\Ilqar\source\repos\MicroProject\Database.json";
        string jsonData = File.ReadAllText(filepath);
        //Book lib = JsonConverter.DeserializeObject<Book>(jsonData);
        //Console.WriteLine($"{lib.Id}{lib.AuthorName}{lib.Price}");
    }
    static void PrintInfo()
    {
        Console.WriteLine("""
                    Menu
                    1. Add book
                    2. Get book by id
                    3. Remove book
                    0. Quit
                    """);
    }

}



/*
Book class
- Id
- Name
- AuthorName
- Price
- ShowInfo()

Library class
- Id
- Name
- Books list
- AddBook() - book obyekti qəbul edəcək və books listinə əlavə edəcək
- GetBookById() - id qebul edəcek və həmin id-li book obyektini tapıb geriyə qaytaracaq
- RemoveBook() - id qebul edəcək və həmin id-li book

obyektini tapıb siləcək
*/