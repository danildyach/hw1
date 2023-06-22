using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
            //2, 3, 7-> 7
            //44 5 78-> 78
            //22 3 9-> 22
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int theThirdNumber = Convert.ToInt32(Console.ReadLine());
            int max = Math.Max(firstNumber, secondNumber);
            int max_1 = Math.Max(max, theThirdNumber);
            int fullMax = Math.Max(max, max_1);
            Console.WriteLine(fullMax);

        }
    }
}
