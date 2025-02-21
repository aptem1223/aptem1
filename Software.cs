using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Software
    {
        public Software(string v1, string v2, bool v3)
        {
        }

        public Software()
        {
        }

        class ProgramSoftware
        {
            private string name;
            private string manufacturer;
            private bool isPaid;

            public string Name
            {
                get { return string.IsNullOrEmpty(name) ? "неизвестное ПО" : name; }
                set { name = value; }
            }

            public string Manufacturer
            {
                get { return string.IsNullOrEmpty(manufacturer) ? "неизвестный производитель" : manufacturer; }
                set { manufacturer = value; }
            }

            public bool IsPaid
            {
                get { return isPaid; }
                set { isPaid = value; }
            }

            public ProgramSoftware() { }

            public ProgramSoftware(string name, string manufacturer, bool isPaid)
            {
                Name = name;
                Manufacturer = manufacturer;
                IsPaid = isPaid;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Название: {Name}, Производитель: {Manufacturer}, {(IsPaid ? "Платное" : "Бесплатное")}");
            }

            public void TogglePaidStatus()
            {
                isPaid = !isPaid;
            }

            public bool IsSoftwareFreeFromManufacturer(string manufacturer)
            {
                return !isPaid && this.manufacturer.Equals(manufacturer, StringComparison.OrdinalIgnoreCase);
            }
        }

        internal bool IsSoftwareFreeFromManufacturer(string v)
        {
            throw new NotImplementedException();
        }

        internal void TogglePaidStatus()
        {
            throw new NotImplementedException();
        }

        internal void DisplayInfo()
        {
            throw new NotImplementedException();
        }
    }
}
