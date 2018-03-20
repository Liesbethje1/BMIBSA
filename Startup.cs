using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace bmibsaberekene
{
    public class Startup
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef je lengte in meter in");
            double lengte = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Geef je gewicht in");
            double gewicht = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Je Bmi is " + berekenBMI(lengte, gewicht) + " Je BSA is " + berekenBSA(lengte, gewicht));
            Console.ReadKey();
        }
        public static double berekenBMI(double lengte, double gewicht)
        {
            return (gewicht / (lengte * lengte));

        }
        public static double berekenBSA(double lengte, double gewicht)
        {
            return 0.024265 * Math.Pow((lengte * 100), 0.3964) * Math.Pow(gewicht, 0.5378);
        }
    }
}
