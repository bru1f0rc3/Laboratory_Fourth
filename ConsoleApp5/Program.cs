using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лабораторная Работа №4
            Console.Write("Введите X=");
            double x = double.Parse(Console.ReadLine());

            int power = 10;
            double y = 0;

            for (int k = 1; k <= 11; k++)
            {
                y += k * Pow(x, power);
                power--;
            }
            Console.WriteLine($"Ответ: y = {y}");
        }
    }
}
