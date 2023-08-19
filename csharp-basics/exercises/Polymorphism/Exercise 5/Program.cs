namespace Exercise_5
{
    class Program
    {
        protected double baseCost;

        public Program(double baseCost)
        {
            this.baseCost = baseCost;
        }

        public virtual double CalculateCost()
        {
            return baseCost;
        }
    }
}