namespace Zoo
{
    public class Lion : Animal
    {
        public override bool IsDeath()
        {
            if (HealthPoints < 50)
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
