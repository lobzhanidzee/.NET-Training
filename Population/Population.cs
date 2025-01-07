namespace PopulationTask
{
    public static class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if (initialPopulation <= 0 || visitors < 0 || currentPopulation <= 0 || currentPopulation < initialPopulation)
            {
                throw new ArgumentException("Error while getting information", nameof(initialPopulation));
            }
            else if (percent < 0 || percent > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(percent), "Value of percents cannot be less then 0% or more then 100%.");
            }

            int count = 0;
            double result = 0;

            while (result < currentPopulation)
            {
                result = initialPopulation + (initialPopulation * percent / 100) + visitors;
                initialPopulation = (int)result;
                count++;
            }

            return count;
        }
    }
}
