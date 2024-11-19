using EFCore.Context;
using EFCore.Exceptions;
using EFCore.Tables;

namespace EFCore;

public static class Program
{
    static List<Users> users = new();
    static List<Products> products = new();
    static List<Baskets> basket = new();
    static void Main(string[] args)
    {
        SeedProducts();

        bool IsTrue = true;
        do
        {
            PrintInfo();
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Register();
                    break;
                case 2:
                    Login();
                    UserMenu();
                    break;
                default:
                    IsTrue = false;
                    break;
            }
        }
        while (IsTrue);


    }
    static void PrintInfo()
    {
        Console.WriteLine("""
                1.Register

                2.Login
                """);
    }

    public static void Register()
    {
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Surname: ");
        string surname = Console.ReadLine();
        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Users newUser = new()
        {
            Name = name,
            Surname = surname,
            Username = username,
            Password = password
        };

        using (AppDB contex = new AppDB())
        {
            contex.Users.Add(newUser);
            contex.SaveChanges();
        }
        Console.WriteLine("İstifadeçi uğurla qeydiyyatdan keçdi.");

    }
    static void Login()
    {
        Console.WriteLine("İstifadeçi adını daxil edin:");
        string username = Console.ReadLine();

        Console.WriteLine("Şifreni daxil edin:");
        string password = Console.ReadLine();

        Users newUser = new()
        {
            Username = username,
            Password = password
        };
        using (AppDB sql = new AppDB())
        {

            var user = sql.Users.Where(u => u.Username == username && u.Password == password).FirstOrDefault();

            if (user == null)
            {
                throw new UserNotFoundException();
            }

            else
            {
                PrintInfo();
            }
        }

    }

    static void UserMenu()
    {
        Console.WriteLine("""
            1. Mehsullara bax.
            2. Sebete bax.
            3. Hesabdan çıx.
            
            """);

        do
        {
            int choicee = int.Parse(Console.ReadLine());

            switch (choicee)
            {
                case 1:
                    ViewProducts();
                    break;
                case 2:
                    ViewBasket();
                    break;
                case 3:
                    Console.WriteLine("Hesabdan uğurla çıxıldı.");
                    return;
                default:
                    Console.WriteLine("Yanlış seçim, yenidən cəhd edin.");
                    break;
            }
        } while (true);

    }

    static void ViewProducts()
    {
        using (AppDB context = new AppDB())
        {
            products = context.Products.ToList();
        }

        if (products.Count == 0)
        {
            Console.WriteLine("Depoda heç bir məhsul yoxdur.");
            return;
        }
        Console.WriteLine("Mehsullar:");
        foreach (Products product in products)
        {
            Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} AZN");
        }

        Console.WriteLine($"NOT: Magazada umumi olaraq {products.Count} eded mehsul var");

        Console.WriteLine($"Menuya qayitmaq ucun 0 daxil edin:");
        if (int.TryParse(Console.ReadLine(), out int productId))
        {
            if (productId == 0)
            {
                UserMenu();
            }

            Products? selectedProduct = products.FirstOrDefault(p => p.Id == productId);
            if (selectedProduct == null)
            {
                Console.WriteLine($"Magazada {selectedProduct.Id}-li mehsul mövcud deyil.");
            }
            else
            {
                Console.WriteLine($"Mehsul Movcuddur: {selectedProduct.Name} - {selectedProduct.Price} AZN");
                basket.Add(new Baskets { UserId = selectedProduct.Id, ProductId = productId });
            }
        }
        else
        {
            Console.WriteLine("Duzgun deyer daxil edin !");
        }
    }
    static void ViewBasket()
    {
        using (AppDB sql = new AppDB())
        {
            Console.WriteLine("Sebet:");
            foreach (var basket in sql.Baskets)
            {
                Console.WriteLine($"Mehsulun Id-si-{basket.Id},Mehsulun Adi-{basket.UserId},Mehsulun Qiymeti-{basket.ProductId}");
            }
        }
        using (AppDB sqll = new AppDB())
        {
            Console.WriteLine("Mehsullar:");
            foreach (var product in sqll.Products)
            {
                Console.WriteLine($"Mehsulun Id-si-{product.Id},Mehsulun Adi-{product.Name},Mehsulun Qiymeti-{product.Price}");
            }
        }
        using (AppDB sqll = new AppDB())
        {
            int num = int.Parse(Console.ReadLine());
            var data = sqll.Baskets.Find(num);
            if (data != null)
            {
                sqll.Baskets.Remove(data);
                sqll.SaveChanges();
            }
            else
            {
                throw new ProductNotFoundException();
            }
        }


    }




    static void SeedProducts()
    {
        List<Products> products = new List<Products>

        {
        new Products {  Name = "Telefon", Price = 800 },
        new Products {  Name = "Noutbuk", Price = 1500 },
        new Products {  Name = "Qulaqlıq", Price = 150 },
        new Products {  Name = "PowerBank", Price = 200 },
        new Products {  Name = "IPhone 13", Price = 1500 }
        };

        using (AppDB context = new AppDB())
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(products);
                context.SaveChanges();
                Console.WriteLine("Mehsullar uğurla əlavə edildi.");
            }
            else
            {
                Console.WriteLine("Melumatlar artıq mövcuddur.");
            }
        }
    }
}


//Users:
//Id, Name, Surname, Username, Password

//Products:
//Id, Name, Price

//Baskets:
//Id, UserId, ProductId
