using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace zadacha1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа которая выводит все натуральные числа от N до 1!");
            Console.Write("Введите число N: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Ваш ряд натуральных чисел: ");
            void NumberCounter(int num)
            {
                if (num < 0)
                {
                    Console.WriteLine("Введено не натуральное число!!!");
                    return;
                }
                if (num == 0)
                    return;
                Console.Write(num + " ");
                NumberCounter(num - 1);
            }
            NumberCounter(number);

        }
    }
}