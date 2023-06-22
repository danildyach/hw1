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
            //Задача 8: Напишите программу, которая на вход принимает число(N), а на выходе показывает все чётные числа от 1 до N.
            //5-> 2, 4
            //8-> 2, 4, 6, 8

            int firstNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= firstNumber; i++) 
            {
                if (i % 2 == 0) 
                {
                    
                    Console.WriteLine(i);
                }
            }
        }

    }
}
