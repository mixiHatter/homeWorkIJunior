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
            int minutesInHours = 60;
            int waitingTimeMinutes;
            int waitingTimeHours;

            Console.Write("Сколько людей в очереди:");

            peopleCount = Convert.ToInt32(Console.ReadLine());
            waitingTimeMinutes = peopleCount * appointmentTimeMinutes;
            waitingTimeHours = waitingTimeMinutes / minutesInHours;
            waitingTimeMinutes = waitingTimeMinutes % minutesInHours;
            
            Console.WriteLine($"Ваша очередь подойдёт через {waitingTimeHours} часов и {waitingTimeMinutes} минут");
        }   
    }
}
