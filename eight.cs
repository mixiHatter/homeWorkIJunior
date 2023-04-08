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
            string text;
            int countRepeat;

            Console.Write("Введите сообщение: ");
            text = Console.ReadLine();
            Console.Write("Введите количество повторений сообщения: ");
            countRepeat = Convert.ToInt32(Console.ReadLine());

            while (countRepeat > 0) 
            {
                Console.WriteLine(text);
                countRepeat--;
            }
        }   
            
    }
}
