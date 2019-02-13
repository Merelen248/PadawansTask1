using System;

namespace PadawansTask1
{
    public class Population
    {
        public static int GetYears(int initialPopulation, double percent, int visitors, int currentPopulation)
        {
            if ((initialPopulation >=0) && (percent >= 0) && (visitors >= 0))
            { int i = 0;
                double population = initialPopulation;
                while (population <= currentPopulation)
                {
                    i += 1;
                    population += population * percent / 100 + visitors;
                }
                return i;
            }
             else throw new Exception("0");
        }
    }
}