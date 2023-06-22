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
            //Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
            //a = 5; b = 7->max = 7
            //a = 2 b = 10->max = 10
            //a = -9 b = -3->max = -3
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber > secondNumber)
            {
                Console.WriteLine($"число {firstNumber} больше, чем {secondNumber} \n" +
                    $"ответ = {firstNumber}");
            }
            else
            {
                Console.WriteLine($"число {firstNumber} МЕНЬШЕ, чем {secondNumber} \n" +
                    $"ответ = {secondNumber}");
            }

        }
    }
}
