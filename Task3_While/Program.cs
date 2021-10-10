using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_While
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C (без наложений). 
            Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
            */


            Console.WriteLine("Введите величину стороны А прямоугольника");
            double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите величину стороны B прямоугольника");
            double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите величину С квадрата");
            double C = Convert.ToDouble(Console.ReadLine());


            int count = 0;

            while (A > 0 && B > 0)
            {

                A -= C;
                B -= C;

                count++;
            }

            Console.WriteLine("Количество квадратов, размещенных в прямоугольнике равняется {0}", count);
            Console.ReadKey();

        }
    }
}
