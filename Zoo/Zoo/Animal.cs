namespace Zoo
{
    public abstract class Animal
    {
        public Animal()
        {
            HealthPoints = 100;
        }
        public int HealthPoints { get; set; }
        // With this abstract method, we allow to use polymorphism in the parent classes, because now we don't know in which condtions
        // our animals will dying 
        public abstract bool IsDeath();
    }
}
