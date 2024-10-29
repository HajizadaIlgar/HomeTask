namespace GenericClass;

abstract class Animal
{
    public int AvgLifeTime { get; set; }

    public enum Gender
    {
        Mammals,
        Birds,
        Fish
    }
    public string Breed { get; set; }
    public int HP { get; set; } //Healty point
}
class Wolf<T> where T : Animal
{

    public bool IsPrideLeader;
    public int AttackDamage { get; set; }


    public void Hunt(T animal)
    {
        Console.WriteLine($"Animals Breed:{animal.Breed}");
        Console.WriteLine($"Current Healthy Point:{animal.HP}");
        Console.WriteLine($"Life span:{animal.AvgLifeTime} year");

        animal.HP -= AttackDamage;
        Console.WriteLine($"Vurulan Ziyan:{animal.HP}");
    }

}
class Elephant : Animal
{
    public Gender AnimalGender { get; set; }
    public double Weight { get; set; }
    public bool IsTrained;


}

abstract class Food
{
    public int Calorie { get; set; }

}
class Meat : Food
{
    public enum Type
    {
        Red_Meat = 1,
        White_Meat = 2,
        SeaFood = 3
    }
    public Type MeatType { get; set; }
}
class Grass : Food
{
    public string Name { get; set; }

}

class ZooCage<T, U> where T : Animal, new() where U : Food, new()
{
    public T Animal { get; set; }
    public U Food { get; set; }

}


/*
Food abstract class:
int Calorie

Meat class:Food
enum Type

Grass class:Food
string Name

ZooCage<T, U> class:
T Animal
U Food

T ancaq Animal-dan miras alan ve instance alina bilen class olmalidir
U ancaq Food-dan miras alan ve instance alina bilen class olmalidir.



*/