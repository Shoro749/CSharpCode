using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Fish : Oceanarium
    {
        private string _type;
        private int _size;
        private int _mass;
        private string _location;
        private string _desc;

        public Fish(string type, int size, int mass, string location, string desc)
        {
            _type = type;
            _size = size;
            _mass = mass;
            _location = location;
            _desc = desc;
        }

        public void ToString()
        {
            Console.WriteLine($"Тип риби: {_type}\nРозмір: {_size}\nМаса: {_mass} г\nМожна знайти: {_location}\nОпис: {_desc}\n");
        }
    }
}
