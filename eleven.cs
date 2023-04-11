using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTestHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Random random = new Random();
            int maxRandomValue = 101;
            number = random.Next(maxRandomValue);
            int[] fold = { 3, 5 };
            int[] arrayOfFoldNumbers = new int[0];
            int sum = 0;

            Console.WriteLine($"наше число: {number}");

            for (int i = 0; i <= number; i++)
            {
                if (i % fold[0] == 0 || i % fold[1] == 0)
                {
                    sum = sum + i;
                }
            }

            Console.WriteLine($"Сумма кратных: {sum}");
        }
    }
}
