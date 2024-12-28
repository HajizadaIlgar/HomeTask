namespace carmodel;

internal class Program
{
    static void Main()
    {
        Car cars = new Car()
        {
            Id = 1,
            Brand = "Mercedes",
            Model = "Cls63",
            Year = 2006,
            EngineCode = 9622342
        };
        Car cars2 = new Car()
        {
            Id = 2,
            Brand = "Nissan",
            Model = "m324",
            Year = 2002,
            EngineCode = 98722342
        };
        Car cars3 = new Car()
        {
            Id = 3,
            Brand = "Vaz",
            Model = "2107",
            Year = 2023,
            EngineCode = 9822342
        };
        Car cars4 = new Car()
        {
            Id = 4,
            Brand = "Hyundai",
            Model = "Elentra",
            Year = 1978,
            EngineCode = 33422342
        };
        Car cars5 = new Car()
        {
            Id = 5,
            Brand = "KIA",
            Model = "Sportage",
            Year = 2003,
            EngineCode = 6823535
        };
        Car[] carsarrs = { cars, cars2, cars3, cars4, cars5 };
        carsarrs.OrderByYear();
        foreach (Car car in carsarrs)
        {
            Console.WriteLine($"{car.Id}.{ car.Year}");

        }
    }
}
