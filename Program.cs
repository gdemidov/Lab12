using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите координаты  точкиотносительно центра окружности (х, y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            double r1, l, s;

            if (r >= 0)
            {
                Circ.LenghtCircle(r, out l);
                Circ.AreaCircle(r, out s);
                Circ.FindPoint(x, y, r, out r1);
            }
            else
            {
                Console.WriteLine("Радиус не может < 0");
            }

            Console.ReadKey();
        }
        // статический класс
        static class Circ
        {
            public static void LenghtCircle(double r, out double l)
            {
                l = 2 * Math.PI * r;
                Console.WriteLine("Длина окружности равна L= {0:F3}", l);
            }

            public static void AreaCircle(double r, out double s)
            {
                s = Math.PI * r * r;
                Console.WriteLine("Площадь круга равна S= {0:F3}", s);
            }

            public static void FindPoint(double x, double y, double r, out double r1)
            {
                r1 = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
                if (r1 <= r)
                {
                    Console.WriteLine("Точка с координатами x = {0}, y = {1} принадлежит кругу", x, y);
                }
                else
                {
                    Console.WriteLine("Точка с координатами x = {0}, y = {1} не принадлежит кругу", x, y);
                }
            }


        }


    }
}
