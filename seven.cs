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
            int peopleCount;
            int appointmentTimeMinutes = 10;
            int WaitingTimeMinutes;
            int WaitingTimeHours;

            Console.Write("Сколько людей в очереди:");
            peopleCount = Convert.ToInt32(Console.ReadLine());
            WaitingTimeMinutes = peopleCount * appointmentTimeMinutes;
            WaitingTimeHours = WaitingTimeMinutes / 60;
            WaitingTimeMinutes = WaitingTimeMinutes % 60;
            Console.WriteLine($"Ваша очередь подойдёт через {WaitingTimeHours} часов и {WaitingTimeMinutes} минут");

        }   
            
    }
}
