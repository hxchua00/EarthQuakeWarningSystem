using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQuakeWarningSystem
{
    class Tsunami
    {
        public double probability;

        public double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }
        public double CalculateTsunamiProbability()
        {
            Random rand = new Random();
            double RandomOccuranceChance = NextDouble(rand, 0.0, 100.0, 2);

            probability = EarthQuake.intensity * 0.7 + 0.3 * RandomOccuranceChance;

            return probability;
        }
    }
}
