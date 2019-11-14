using System;

namespace DogConstructor
{
    class Animal
    {
        public static int Count = 0;

        public string name;
        public string color;

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Color: {color}");
        }
    }

    class Dog: Animal
    {
        public string breed;

        public Dog(string _name, string _color, string _breed)
        {
            name = _name;
            color = _color;
            breed = _breed;

            Count++;
        }

        public void PrintInfoAboutDog()
        {
            Console.WriteLine($"Dog's Name: {name}");
            Console.WriteLine($"Dog's color: {color}");
            Console.WriteLine($"Dog's breed: {breed}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{Animal.Count} has/have been created.");
            Dog rex = new Dog("Rex", "black and white", "bulldog");
            rex.PrintInfoAboutDog();

            Console.WriteLine($"{Animal.Count} has/have been created.");

            Console.ReadLine();
            
        }

        
    }
}
