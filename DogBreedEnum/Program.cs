using System;

namespace DogBreedEnum
{
    enum Breed
    {
        Bulldog,
        Boxer,
        Chihuahua
    }
    class Dog
    {
        public static int Count = 0;

        public string name;
        public int age;
        public Breed dogBreed;

        public Dog(string _name, int _age, Breed _breed)
        {
            name = _name;
            age = _age;
            dogBreed = _breed;
            Count++;
        }

        public void PrintDogInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Breed: {dogBreed}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog sass = new Dog("Sass", 10, Breed.Chihuahua);
            sass.PrintDogInfo();

            Dog muki = new Dog("Muki", 1, Breed.Boxer);
            muki.PrintDogInfo();

            Console.WriteLine($"You have got {Dog.Count} dog(s).");
            Console.WriteLine((int)Breed.Boxer);
        }
    }
}
