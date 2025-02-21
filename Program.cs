using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            edition book1 = new edition("Книга 1", "Автор 1", 2005);
            edition book2 = new edition("Книга 2", "", 2015);
            edition book3 = new edition();

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();

            book1.ChangeYear(5);
            book1.DisplayInfo();

            Console.WriteLine(book2.IsYearInRange(2000, 2020));
        }
    }
}
