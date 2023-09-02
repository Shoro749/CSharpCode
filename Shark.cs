using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCode
{
    public class Shark : Oceanarium
    {
        private int _size;
        private int _mass;
        private string _location;
        private string _desc;

        public Shark(int size, int mass, string location, string desc) : base()
        {
            _size = size;
            _mass = mass;
            _location = location;
            _desc = desc;
        }

        public void ToString()
        {
            Console.WriteLine($"Назва: Акула\nРозмір: {_size}\nМаса: {_mass} тон\nМожна знайти: {_location}\nОпис: {_desc}\n");
        }
    }
}
