using System.Collections.Generic;

namespace Zoo.Interfaces
{
    interface IZoo
    {
        void Starvation(List<Animal> animals);
        void Eat(List<Animal> animals);
        int GetAliveAnimals(List<Animal> animals);

    }
}
