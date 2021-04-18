using System;
using System.Collections.Generic;

namespace Zoo
{
   public class Zoo
    {
        private readonly List<Animal> animals;
        private readonly Random random;
        public Zoo()
        {
            animals = new List<Animal>();
            random = new Random();
        }
        public void Starvation(List<Animal> animals)
        {
            // We loop throug our collection of animals 
            foreach (var animal in animals)
            {
                // Here we check if the current animal of collection is of type Elephant, because there is some specific condition
                if (animal.GetType().Name == "Elephant")
                {
                    Elephant elephant = (Elephant)animal;
                    elephant.Moving();
                }

                // We check every time if the current animal of our collection is death to can our program work correct,
                // so if it's death, we don't make any changes on it and we are continuing
                if (animal.IsDeath())
                    continue;

                // Here we use the random object to get some random number from 0 to 20. It's 21 on the second parameter
                // because the upper limit is every time (value-1). So to work correct it's 21 in our case
                int randomNumber = random.Next(0, 21);
                animal.HealthPoints -= randomNumber;
            }
        }
        public void Eat(List<Animal> animals)
        {
            // We loop throug our collection of animals
            foreach (var animal in animals)
            {
                // Checking if animal is death again
                if (animal.IsDeath())
                    continue;

                // The same logic as in method Starvation
                int randomNumber = random.Next(5, 26);
                animal.HealthPoints += randomNumber;
            }
        }
        public int GetAliveAnimals(List<Animal> animals)
        {
            // We create new instance where we will add the alived animals
            List<Animal> aliveAnimals = new List<Animal>();

            foreach (var animal in animals)
            {
                // We get for every animal information about is it death, if not , it's added to the new collection 
                if (!animal.IsDeath()) {
                    aliveAnimals.Add(animal);
                }
            }
            // Finlly we return the count of populated collection with alive animals
            return aliveAnimals.Count;
        }
    }
}
