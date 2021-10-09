using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Ввести число N. Найти квадраты всех чисел от 1 до числа N по формуле N^2=1 + 3 + 5 + ... + (2*N – 1). 
             После добавления к сумме каждого слагаемого выводить текущее значение суммы */


            Console.WriteLine("Введите значение N");
            int N = Convert.ToInt32(Console.ReadLine());

            for ( int N4 = 1; N4 < N ; N4++)
            {
                int N2 = N4 * N4;
                int N3 = N4 * N4 - (2 * N4 - 1);
                int N5 = (2 * N4 - 1);
                Console.WriteLine("Квадрат числа {0} = {1} + 2 * {2} - 1 = {3}", N4, N3, N4, N2 = N3 + (2 * N4 - 1));
            }

            //for (int N6 = 0; N6 <= N3 ; N3 +=2)


                Console.ReadKey();


        }
    }
}
