
namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Hippo hippo = new Hippo();
            hippo.Name = "Hippo";
            hippo.Fart();
            hippo.MakeSound();
            hippo.Eat();
            Console.WriteLine();
           

            BabyHippo babyhippo = new BabyHippo();
            babyhippo.MakeSound();
            babyhippo.FollowHippo();
            Console.WriteLine();

            PygmyHippo pygmyhippo = new PygmyHippo();
            pygmyhippo.MakeSound();
            pygmyhippo.Dwarf();
            Console.WriteLine();

            Elefant elefant = new Elefant();
            elefant.Name = "Elefant";
            elefant.Sit();
            elefant.MakeSound();
            elefant.Weight();
            Console.WriteLine();

            Lion lion = new Lion();
            lion.MakeSound();
            lion.Kills();
            Console.WriteLine();

            Animal tiger = new Animal(true,"Tiger","White",15,70);
            Console.WriteLine($"Is mammal: {tiger.Mammal}\nAnimal: {tiger.Name}\nColor: {tiger.Color}\nAge: {tiger.Age}\nSpeed: {tiger.Speed}km/h");
            tiger.Running();         
            
        }
    }
}
