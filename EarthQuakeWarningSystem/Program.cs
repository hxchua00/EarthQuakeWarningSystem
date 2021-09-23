using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EarthQuakeWarningSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            EarthQuake quake = new EarthQuake();
            quake.Alert += AlertMessage;
            quake.DetectEarthQuake();

            Console.ReadLine();
        }

        public static void AlertMessage(object sender, EventArgs e)
        {
            Console.WriteLine("EARTHQUAKE WARNING!!!");
            Console.WriteLine("==============================================");
            Console.WriteLine();
            Console.Write("Place of Occurance: " + EarthQuake.PlaceOfOccurance);
            Console.WriteLine();
            Console.Write("Intensity of EarthQuake: " + EarthQuake.intensity);
            Console.WriteLine();
            Console.Write("Chance of Tsunami: " + EarthQuake.TsunamiChance + "%");
            Console.WriteLine();
        }
    }
}
