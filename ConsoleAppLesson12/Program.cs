using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleAppLesson12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x0, y0;
            double r;
            double x, y;

            Console.WriteLine("Введите центр окружности : ");
            Console.Write(" X0 = ");
            x0 = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Y0 = ");
            y0 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите радиус окружности : ");
            Console.Write(" R = ");
            r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Длина окружности составляет : {0}", RoundCalc.L_from_R(r));
            Console.WriteLine("Площадь окружности составляет : {0}", RoundCalc.S_from_R(r));
            Console.WriteLine(" ");

            Console.WriteLine("Введите точку на плоскости : ");
            Console.Write(" X = ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Y = ");
            y = Convert.ToDouble(Console.ReadLine());
            if (RoundCalc.Point_on_Round(x0, y0, r, x, y))
            {
                Console.WriteLine("Точка лежит на окружности");
            }
            else
            {
                Console.WriteLine("Точка НЕ лежит на окружности");
            }

            Console.ReadKey();
        }
    }
    public static class RoundCalc
    {

        public static double L_from_R(double r)
        {
            return r * 2 * Math.PI;
        }
        public static double S_from_R(double r)
        {
            return r * r * Math.PI;
        }
        public static bool Point_on_Round(double x, double y, double r, double x0, double y0)
        {
            if ( ((x - x0) * (x - x0) + (y - y0) * (y - y0)) == (r * r) )
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
