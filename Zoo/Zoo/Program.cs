using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // We create our Zoo and our Animals
            Zoo zoo = new Zoo();
            List<Animal> animals = new List<Animal>()
            {
                new Monkey(), new Monkey(),new Monkey(),  new Monkey(), new Monkey(),
                new Elephant(), new Elephant(), new Elephant(), new Elephant(), new Elephant(),
                new Lion(), new Lion(), new Lion(), new Lion(),new Lion()
            };

            // We make the operations to animals which are allowed in our Zoo
            zoo.Eat(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);
            zoo.Eat(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);
            zoo.Starvation(animals);

            // We get the alived animals after the operations
            int countAlivedAnimals = zoo.GetAliveAnimals(animals);

            Console.WriteLine($"The count of alived animals is {countAlivedAnimals}");
        }
    }
}
