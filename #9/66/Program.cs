using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное число M:");
            int numberM = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите начальное число N:");
            int numberN = int.Parse(Console.ReadLine());
            void SumOfNumbers(int firstNumber, int secondNumber, int sum)
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}");
                    return;
                }
                sum = sum + (firstNumber++);
                SumOfNumbers(firstNumber, secondNumber, sum);
            }

            SumOfNumbers(numberM, numberN, 0);
        }
    }
}