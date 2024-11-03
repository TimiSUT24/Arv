
namespace Arv
{
    public class Animal
    {   //Properties 
        public int Speed { get; set; } = 10;
        public int Age { get; set; } = 25;
        public string Name { get; set; } = "Animal";
        public string Color { get; set; } = "Unkown";
        public bool Mammal { get; set; } = true;

        public Animal()
        {


        }
        //Constructor in animal class if u want to create a new animal 
        public Animal(bool mammal, string name, string color, int age, int speed)
        {
            Speed = speed;
            Age = age;
            Name = name;
            Color = color;
            Mammal = mammal;
        }

        //Methods in Animal class
        public void Fart()
        {

            Console.WriteLine($"{Name} farts");
        }

        public void Running()
        {

            Console.WriteLine($"{Name} is running");
        }

        public void Sit()
        {
            Console.WriteLine($"{Name} is sitting");
        }
    }
    //Hippo class derived from Animal 
    public class Hippo : Animal
    {
        public string eating = "Hippo is eating";

        public void Eat()
        {

            Console.WriteLine(eating);
        }

        public void MakeSound()
        {
            Console.WriteLine("Huff Huff!!");
        }
    }
    //BabyHippo class derived from Hippo
    public class BabyHippo : Hippo
    {
        public string followHippo = "Baby hippo is following hippo";

        public void FollowHippo()
        {
            Console.WriteLine($"{followHippo}");
        }

        public new void MakeSound()
        {
            Console.WriteLine("SQUEE SQUEE!!");
        }
    }

    //PygmyHippo class derived from Hippo
    public class PygmyHippo : Hippo
    {
        public string dwarfHippo = "This is a dwarf hippo";

        public void Dwarf()
        {
            Console.WriteLine($"{dwarfHippo}");
        }

    }
    //Elefant class derived from Animal
    public class Elefant : Animal
    {
        public int weightTons = 5;

        public void Weight()
        {
            Console.WriteLine($"Elefant weight is: {weightTons} tons");
        }

        public void MakeSound()
        {
            Console.WriteLine("PAWOO PAWOO!!");
        }

    }
    //Lion class derived from Animal 
    public class Lion : Animal
    {
        public int killedAnimals = 30;

        public void Kills()
        {
            Console.WriteLine($"Lion has killed: {killedAnimals} Zebras");
        }

        public void MakeSound()
        {
            Console.WriteLine("ROAR!!");
        }
    }


}
