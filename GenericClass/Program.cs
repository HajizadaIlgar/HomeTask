namespace GenericClass;

internal class Program
{
    static void Main(string[] args)
    {

        Wolf<Elephant> wolf = new Wolf<Elephant>();
        Elephant elephant = new Elephant();
        wolf.AttackDamage = 200;
        elephant.Weight = 769;
        elephant.IsTrained = true;
        elephant.HP = 300;
        elephant.Breed = "Chamel";
        elephant.AvgLifeTime = 80;
        wolf.Hunt(elephant);
        Console.WriteLine($"Canlinin Genderi:{elephant.AnimalGender = Animal.Gender.Mammals}");

        if (elephant.IsTrained)
        {
            Console.WriteLine("Canli ehlilesdirilib");
        }
        else
        {
            Console.WriteLine("Canli vehsidir");
        }


    }
}
/*
Animal abstract class:+
int AvgLifeTime
enum Gender 
string Breed
int HP - Health point 

Wolf class:Animal
bool IsPrideLeader
int AttackDamage
Hunt(T animal ) - generic metdhodur ancaq animal abstract classdan miras alan classin objectini qebul ede bilmelidir. Gonderilen objectin HP deyereini AttackDamage qeder azaldir.

Elephant class:Animal
double Weight
bool IsTrained

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


Optional task:
Custom LinkedList yazmaq



*/