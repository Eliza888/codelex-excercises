namespace Exercise_5
{
    class Advert
    {
        protected double baseCost;

        public Advert(double baseCost)
        {
            this.baseCost = baseCost;
        }

        public virtual double CalculateCost()
        {
            return baseCost;
        }
    }
}