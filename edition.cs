using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class edition
    {
        private string title;
        private string author;
        private int year;

        public string Title
        {
            get { return string.IsNullOrEmpty(title) ? "неизвестный" : title; }
            set { title = value; }
        }

        public string Author
        {
            get { return string.IsNullOrEmpty(author) ? "неизвестный" : author; }
            set { author = value; }
        }

        public int Year
        {
            get { return (year >= 1990 && year <= 2024) ? year : 0; }
            set { year = (value >= 1990 && value <= 2024) ? value : 0; }
        }

        public edition() { }

        public edition(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год издания: {Year}");
        }

        public void ChangeYear(int years)
        {
            year += years;
            if (year < 1990) year = 1990;
            if (year > 2024) year = 2024;
        }

        public bool IsYearInRange(int startYear, int endYear)
        {
            return year >= startYear && year <= endYear;
        }
    }
}
