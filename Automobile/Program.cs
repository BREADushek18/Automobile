using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите расстояние (км): ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write("Введите скорость (км/ч): ");
            double speed = double.Parse(Console.ReadLine());

            Console.Write("Введите время на ремонт (часы): ");
            double repairTime = double.Parse(Console.ReadLine());

            double totalTime = distance / speed + repairTime; // общее время движения
            double avgSpeed = distance / totalTime; // средняя скорость

            Console.WriteLine($"Общее время движения: {totalTime} часов");
            Console.WriteLine($"Средняя скорость: {avgSpeed} км/ч");

            Console.ReadKey();
        }
    }
}
