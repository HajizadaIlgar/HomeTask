using System.Text.Json;
namespace TaskJsn;


public class PersonData
{
    public List<string> names;
    public string filePath = "names.json";

    public void SaveNamesToFile()
    {
        string jsonString = JsonSerializer.Serialize(names);
        File.WriteAllText(filePath, jsonString);
    }
    public void Add(string name)
    {
        names.Add(name);
        SaveNamesToFile();
    }
    public bool Exist(string name)
    {
        foreach (var item in names)
        {
            if (!item.Equals(name))
            {
                Console.WriteLine("Ad Listimizde yoxdur");
            }
        }
        return names.Contains(name);
    }

    public void Update(int index, string name)
    {
        if (index >= 0 && index < names.Count)
        {
            names[index] = name;
            SaveNamesToFile();
        }
        else
        {
            Console.WriteLine("Düzgün indeks daxil edin.");
        }
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < names.Count)
        {
            names.RemoveAt(index);
            SaveNamesToFile();
        }
        else
        {
            Console.WriteLine("Düzgün indeks daxil edin.");
        }
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