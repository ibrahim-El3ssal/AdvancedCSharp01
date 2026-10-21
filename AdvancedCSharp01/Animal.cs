using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedCSharp01
{
    public class Animal
    {
        public string Name { get; set; } = "Unknown Animal";
        public void Eat()
        {
            Console.WriteLine($"{Name} is eating.");
        }
    }

    public class AnimalShelter<T> where T : Animal
    {
        public void ProcessAnimal(T animal)
        {
            Console.WriteLine($"Processing shelter animal: {animal.Name}");
            animal.Eat();
        }
    }

    public class Dog : Animal
    {
        public void Bark() => Console.WriteLine("Woof! Woof!");
    }

    public class Cat : Animal
    {
        public void Meow() => Console.WriteLine("Meow...");
    }


}
