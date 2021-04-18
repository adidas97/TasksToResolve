using Zoo.Interfaces;

namespace Zoo
{
    public class Elephant : Animal, IElephant
    {
        public bool IsDying { get; set; }
        public override bool IsDeath()
        {
            if (IsDying == true)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
        public void Moving()
        {
            if (HealthPoints < 70)
            {
                IsDying = true;
            }
        }
    }
}
