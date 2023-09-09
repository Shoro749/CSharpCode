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
    }
}
