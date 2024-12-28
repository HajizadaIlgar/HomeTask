namespace carmodel;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int EngineCode { get; set; }

    public static bool operator <(Car a, Car b)
    {
        return a.Year < b.Year;
    }
    public static bool operator >(Car a, Car b)
    {
        return a.Year > b.Year;
    }
}
static class Helper
{
    public static void OrderByYear(this Car[] cars)
    {
        for (int j = 0; j < cars.Length; j++)
        {
            for (int i = 0; i < cars.Length-1 ; i++)
            {
                if (cars[i + 1] < cars[i])
                {
                    Car car = cars[i];
                    cars[i] = cars[i+1];
                    cars[i+1] = car;
                }
            }
        }
    }
}
