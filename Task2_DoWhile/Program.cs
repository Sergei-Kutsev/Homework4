using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных.
            Последовательность потенциально не ограничена, окончанием последовательности служит число 0.*/
            int Number;
            int negativeNumber = 0;
            int positiveNumber = 0;
            do
            {
                Number = Convert.ToInt16(Console.ReadLine());

                int mNumber = Math.Abs(Number);
                int x = Number * mNumber;


                int v = (x < 0) ? negativeNumber++ : 0;
                int y = (x > 0) ? positiveNumber++ : 0;

            } while (Number != 0);

            if (negativeNumber > positiveNumber)
            {
                Console.WriteLine("Количество отрицательных чисел = {0} и их больше чем положительных, которых = {1}.", negativeNumber, positiveNumber);
            }
            else if (positiveNumber > negativeNumber)
            {
                Console.WriteLine("Количество положительных чисел = {1} и их больше чем отрицательных, которых = {0}.", negativeNumber, positiveNumber);
            }
            else
            {
                Console.WriteLine("Количество отрицательных чисел равно количеству положительных чисел и их общее количество = {0}.", negativeNumber + positiveNumber);
            }
            Console.ReadKey();

        }
    }
}
