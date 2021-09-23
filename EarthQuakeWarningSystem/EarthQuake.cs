using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQuakeWarningSystem
{
    public delegate void EQWarningEventHandler(object sender, EventArgs e);
    class EarthQuake
    {
        public event EQWarningEventHandler Alert;

        public static double intensity;
        public static string PlaceOfOccurance;
        public static double TsunamiChance;
        public string[] PlacesArr = new string[] { "Indonesia", "Sri Lanka", "India", "Thailand", "Japan" };

        public double NextDouble(Random rand, double minValue, double maxValue, int decimalPlaces)
        {
            double randNumber = rand.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNumber.ToString("f" + decimalPlaces));
        }

        public void DetectEarthQuake()
        {
            Random rand = new Random();
            int i = rand.Next(PlacesArr.Length - 1 );
            PlaceOfOccurance = PlacesArr[i];

            intensity = NextDouble(rand, 0.0, 10.0, 2);

            Tsunami wave = new Tsunami();
            TsunamiChance = wave.CalculateTsunamiProbability();

            AlertSubs(EventArgs.Empty);
        }

        protected virtual void AlertSubs(EventArgs e)
        {
            Alert?.Invoke(this,e);
        }
    }
}
