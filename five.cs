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
            string name = "Ваковски";
            string secondName = "Валерий";

            Console.WriteLine($"{name} {secondName}");

            (name,secondName) = (secondName,name); 

            Console.WriteLine($"{name} {secondName}");
        }
    }
}
