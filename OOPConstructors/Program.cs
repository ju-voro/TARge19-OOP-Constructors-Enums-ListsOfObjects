using System;

namespace OOPConstructors
{
    class Animal
    {
        public string name;
        public int age;
        public int levelOfHappiness;

        public void PrintBasicInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Level of happiness: {levelOfHappiness}");
        }
    }

    class Dog : Animal
    {
        public int numberOfBarks = 0;
        public void WaveTail()
        {
            levelOfHappiness++;
        }

        public void Bark()
        {
            Console.WriteLine("Woof!");
            numberOfBarks++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog rex = new Dog();
            rex.name = "Rex";
            rex.age = 5;
            rex.levelOfHappiness = 0;

            for(int i = 0; i < 12; i++)
            {
                rex.WaveTail();

                if(rex.levelOfHappiness % 3 == 0)
                {
                    rex.Bark();
                }
            }

            rex.PrintBasicInfo();
            Console.WriteLine($"{rex.name} has barked {rex.numberOfBarks} times");

        }
    }
}
