using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Car
    {
        public string Name { get; set; }      
        public string Manufacturer { get; set; } 
        public int Year { get; set; }           

        public Car(string name, string manufacturer, int year)
        {
            Name = name;
            Manufacturer = manufacturer;
            Year = year;
        }

        public override bool Equals(object obj)
        {
            return obj is Car car &&
                   Name == car.Name &&
                   Manufacturer == car.Manufacturer &&
                   Year == car.Year; ;
        }


        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Manufacturer, Year);
        }
    }
}
