using Newtonsoft.Json;

namespace TaskJsn;

class Program
{
    static void Main()
    {
        PersonData manager = new PersonData();


        manager.Add("Ilqar");

        Console.WriteLine(manager.Exist("veli"));

        manager.Update(1, "Kenan");

        manager.Delete(1);

        string path = Path.Combine(@"C:\\Users\\Ilqar\\Desktop\\HomeTask\\TaskJsn\\names.json");
        string convrtsjson = JsonSerializer.Serialize(path);
        File.WriteAllText(convrtsjson, convrtsjson);

    }
}
/*
List<string> yaradırsınız. Bunu names.json adlı jsona yazırsınız.
void Add(string name)
bool Exist(stiring name)
void Update(int index, string name)
void Delete(int index)
Metodlarını adlarına uyğun olaraq yazın
*/