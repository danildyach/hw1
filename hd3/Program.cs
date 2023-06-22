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
            //Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным(делится ли оно на два без остатка).
            //4->да
            //- 3->нет
            //7->нет
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            if (firstNumber % 2 == 0)
            {
                Console.WriteLine($"Число {firstNumber} является четным ");
            }
            else 
            {
                Console.WriteLine($"Число {firstNumber} НЕ является четным ");
            }
        }

        }
    }
