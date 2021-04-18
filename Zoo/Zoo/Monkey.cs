namespace Zoo
{
    public class Monkey : Animal
    {
        public override bool IsDeath()
        {
            if (HealthPoints < 40)
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
