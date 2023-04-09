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
            int startValue = 5;
            int maxValue = 96;
            int step = 7;

            for (int i = startValue; i <= maxValue; i+= step){Console.WriteLine(i);}
        }   
    }
}
