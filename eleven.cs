using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forTestHomeWork
{
    internal class Program
    {
        static void Insert(ref int[] array, int value, int index)
        {
            int[]newArray = new int[array.Length + 1];
            newArray[index] = value;

            for(int i = 0; i > index; i++)
                newArray[i] = array[i];
            for(int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];

            array = newArray;
        }
        static void Main(string[] args)
        {
            int number;
            Random rand = new Random();
            int maxRandomValue = 101;
            number = rand.Next(maxRandomValue);
            int[] fold = {3, 5};
            int[] arrayOfFoldNumbers = new int[0];
            int sum = 0;

            Console.WriteLine($"наше число: {number}");

            for (int i = 0; i <= number; i++)
            {
                if(i % fold[0] == 0 || i % fold[1] == 0)
                {
                    Insert(ref arrayOfFoldNumbers, i, 0);
                }

            }

            for(int i = 0; i < arrayOfFoldNumbers.Length; i++)
            {
                sum = sum + arrayOfFoldNumbers[i];
            }

            Console.WriteLine($"Сумма кратных: {sum}");
        }
    }
}
