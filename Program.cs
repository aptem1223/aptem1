using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Software software1 = new Software("ПО 1", "Производитель 1", true);
            Software software2 = new Software("ПО 2", "Производитель 2", false);
            Software software3 = new Software();

            software1.DisplayInfo();
            software2.DisplayInfo();
            software3.DisplayInfo();

            // Пример смены статуса платности
            software1.TogglePaidStatus();
            software1.DisplayInfo();

            // Проверка бесплатности ПО от заданного производителя
            Console.WriteLine(software2.IsSoftwareFreeFromManufacturer("Производитель 2"));
        }
    }
}
